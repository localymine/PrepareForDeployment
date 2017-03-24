using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.Text;

namespace PrepareForDeployment
{
    public partial class frmMain : Form
    {
        private string[] _arrListFiles = { };
        private string _strProductionPath;
        private string _strProductionFolder;
        private string _strBackupPath;
        private string _strPreDeployPath;
        private string _strSubBackupPath;
        private string _strSubDeployPath;
        private string _strCurDate;
        private string _strCurTime;
        private string _strBackupFolder;
        private string _strDeployFolder;
        private string _strBackupPathCur;
        private string _strBackupBat;
        private string _strDeployBat;
        private string _strRollbackBat;
        private string _strPreDeployBat;

        public frmMain()
        {
            InitializeComponent();

            AddContextMenu(rtb_list_files);
            AddContextMenu(rtb_release_note);

            DisableEnableControl(false);

            string appPlacingPath = Directory.GetCurrentDirectory();

            // load history production deployment backup path
            LoadDataToCombobox();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            try
            {
                GetInfoFromForm();

                // make folder
                MkdirFolder(_strSubBackupPath);
                MkdirFolder(_strSubDeployPath);

                // prepare list files, convert to array and make folder
                MkdirProjectFolder();

                // generate backup
                Generate_Backup_File();

                // generate deploy
                Generate_Deploy_File();

                // generate rollback
                Generate_Rollback_File();

                // active button control
                DisableEnableControl(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisableEnableControl(bool flag)
        {
            btn_run_backup.Enabled = flag;
            btn_run_deploy.Enabled = flag;
            btn_run_rollback.Enabled = flag;
            btn_run_pre_deploy.Enabled = flag;
            // btnOpen.Enabled = flag;
            // btnSave.Enabled = flag;
        }

        private void GetInfoFromForm()
        {
            _strCurDate = dtpk_cur_date.Text.Replace("-", "");
            _strCurTime = dtpk_cur_time.Text.Replace(":", "").Replace(" ", "");
            _strBackupFolder = tb_sub_backup_folder.Text;
            _strDeployFolder = tb_sub_deploy_folder.Text;

            // get the name of production folder
            _strProductionPath = cb_production_path.Text.TrimStart().TrimEnd();
            _strProductionFolder = _strProductionPath.Split(new string[] { "\\" }, StringSplitOptions.None).Last();
            // get the backup path
            _strBackupPath = cb_backup_path.Text.TrimStart().TrimEnd();
            // get the resource path (prepare for deployment)
            _strPreDeployPath = cb_deployment_path.Text.TrimStart().TrimEnd();
            // make a path for backup and deploy
            _strSubBackupPath = Path.Combine(new string[] { _strBackupPath, _strCurDate, _strCurTime, _strBackupFolder, _strProductionFolder });
            _strSubDeployPath = Path.Combine(new string[] { _strBackupPath, _strCurDate, _strCurTime, _strDeployFolder, _strProductionFolder });
            // make a path for current time of backup
            _strBackupPathCur = Path.Combine(new string[] { _strBackupPath, _strCurDate, _strCurTime });

            _strBackupBat = @Path.Combine(_strBackupPathCur, "1_Backup.bat");
            _strPreDeployBat = @Path.Combine(_strBackupPathCur, "2_PreDeploy.bat");
            _strDeployBat = @Path.Combine(_strBackupPathCur, "3_Deploy.bat");
            _strRollbackBat = @Path.Combine(_strBackupPathCur, "4_Rollback.bat");

            if (string.IsNullOrEmpty(cb_production_path.Text) || string.IsNullOrWhiteSpace(cb_production_path.Text))
            {
                throw new System.ArgumentException(btnBrowserProduction.Text + " is not empty");
            }
            //
            if (string.IsNullOrEmpty(cb_backup_path.Text) || string.IsNullOrWhiteSpace(cb_backup_path.Text))
            {
                throw new System.ArgumentException(btnBrowserBackup.Text + " is not empty");
            }
            //
            if (string.IsNullOrEmpty(tb_sub_backup_folder.Text) || string.IsNullOrWhiteSpace(tb_sub_backup_folder.Text))
            {
                throw new System.ArgumentException(lb_tb_sub_backup_folder.Text + " is not empty");
            }
            //
            if (string.IsNullOrEmpty(tb_sub_deploy_folder.Text) || string.IsNullOrWhiteSpace(tb_sub_deploy_folder.Text))
            {
                throw new System.ArgumentException(lb_tb_sub_deploy_folder.Text + " is not empty");
            }
        }

        private string[] Lines(string source)
        {
            // remove empty, duplicate item
            return source.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();
        }

        private string RemoveDriveOrNetworkShare(string source)
        {
            string MyPathWithoutDriveOrNetworkShare = "";
            if ((source.IndexOf(":") == 1) || (source.IndexOf("\\\\") == 0))
            {
                MyPathWithoutDriveOrNetworkShare = source.Substring(3);
                return MyPathWithoutDriveOrNetworkShare;
            }
            return source;
        }

        private void MkdirFolder(string pathString)
        {
            Directory.CreateDirectory(pathString);
        }

        public string[] StripSlash(string[] lines)
        {
            List<string> lineList = new List<string>();
            foreach (string line in lines)
            {
                string filePath = RemoveDriveOrNetworkShare(line).Replace("/", "\\");
                if (filePath.TrimStart(' ').StartsWith("\\"))
                {
                    lineList.Add(filePath.TrimStart(' ', '\\'));
                }
                else
                {
                    lineList.Add(filePath.TrimStart(' '));
                }
            }
            return lineList.ToArray();
        }

        private void MkdirProjectFolder()
        {
            // prepare list file path
            _arrListFiles = StripSlash(Lines(rtb_list_files.Text));
            //
            List<string> tPaths = new List<string>();
            foreach(string filePath in _arrListFiles)
            {
                // remove the file at the end of each path
                string[] k = filePath.Split(new string[] { "\\" }, StringSplitOptions.None).Reverse().Skip(1).Reverse().ToArray();
                string tPath = Path.Combine(k);
                tPaths.Add(tPath);
            }
            // make folder following path (bk and deploy)
            string[] tempPaths = tPaths.Distinct().ToArray();
            foreach (string tFolder in tempPaths)
            {
                MkdirFolder(Path.Combine(_strSubBackupPath, tFolder));
                MkdirFolder(Path.Combine(_strSubDeployPath, tFolder));
            }
        }

        private void Generate_Backup_File()
        {
            try
            {
                if (File.Exists(_strBackupBat))
                {
                    File.Delete(_strBackupBat);
                }
                // create file
                using (StreamWriter sw = File.AppendText(_strBackupBat))
                {
                    sw.WriteLine("@echo off");
                    if (chkUnicode.Checked)
                    {
                        sw.WriteLine("chcp 65001");
                    }
                    sw.WriteLine(":Syntax");
                    sw.WriteLine("echo ------------------------------------");
                    sw.WriteLine("echo Backup Sourcecode From The Production");
                    sw.WriteLine("echo Base on The Files List in Release Note");
                    sw.WriteLine("echo ------------------------------------");
                    sw.WriteLine(":End");
                    sw.WriteLine(Environment.NewLine);
                    foreach (string file in _arrListFiles)
                    {
                        string productionFilePath = Path.Combine(_strProductionPath, file);
                        if (File.Exists(productionFilePath))
                        {
                            sw.WriteLine("copy \"" + productionFilePath + "\" \"" + Path.Combine(_strSubBackupPath, file) + "\"");
                        }
                    }
                    sw.WriteLine(Environment.NewLine);
                    // log
                    sw.WriteLine("@echo off");
                    sw.WriteLine("(");
                    sw.WriteLine("@echo Execute Backup at %date% %time%");
                    sw.WriteLine("@echo ++--------------------------------------------------------------------------------++");
                    sw.WriteLine(") >> log.txt");
                    sw.WriteLine(Environment.NewLine);
                    //
                    sw.WriteLine("echo DONE");
                    sw.WriteLine("timeout /t 3");
                }
                //
                // https://msdn.microsoft.com/en-us/library/system.diagnostics.process.exitcode.aspx
                //
                if (File.Exists(_strBackupBat))
                {
                    System.Diagnostics.Process myProcess = null;
                    //
                    try
                    {
                        // Start the process.
                        myProcess = Process.Start(_strBackupBat);
                        // Display the process statistics until
                        // the user closes the program.
                        do
                        {
                            if (!myProcess.HasExited)
                            {
                                // Refresh the current process property values.
                                myProcess.Refresh();
                            }
                        }
                        while (!myProcess.WaitForExit(5000));
                    }
                    finally
                    {
                        if (myProcess != null)
                        {
                            myProcess.Close();
                        }
                    }
                    //
                    DeleteEmptyDirs(_strSubBackupPath);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Generate_Deploy_File()
        {
            try
            {
                if (File.Exists(_strDeployBat))
                {
                    File.Delete(_strDeployBat);
                }
                // create file
                using (StreamWriter sw = File.AppendText(_strDeployBat))
                {
                    sw.WriteLine("@echo off");
                    if (chkUnicode.Checked)
                    {
                        sw.WriteLine("chcp 65001");
                    }
                    sw.WriteLine(":Syntax");
                    sw.WriteLine("echo ------------------------------------");
                    sw.WriteLine("echo Deploy Source Code");
                    sw.WriteLine("echo Base on The Files List in Release Note");
                    sw.WriteLine("echo ------------------------------------");
                    sw.WriteLine(":End");
                    sw.WriteLine(Environment.NewLine);
                    foreach (string file in _arrListFiles)
                    {
                        sw.WriteLine("copy \"" + Path.Combine(_strSubDeployPath, file) + "\" \"" + Path.Combine(_strProductionPath, file) + "\"");
                    }
                    sw.WriteLine(Environment.NewLine);
                    // log
                    sw.WriteLine("@echo off");
                    sw.WriteLine("(");
                    sw.WriteLine("@echo Execute Deploy at %date% %time%");
                    sw.WriteLine("@echo ++--------------------------------------------------------------------------------++");
                    sw.WriteLine(") >> log.txt");
                    sw.WriteLine(Environment.NewLine);
                    //
                    sw.WriteLine("echo DONE");
                    sw.WriteLine("timeout /t 3");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Generate_Rollback_File()
        {
            try
            {
                if (File.Exists(_strRollbackBat))
                {
                    File.Delete(_strRollbackBat);
                }
                // create file
                using (StreamWriter sw = File.AppendText(_strRollbackBat))
                {
                    sw.WriteLine("@echo off");
                    if (chkUnicode.Checked)
                    {
                        sw.WriteLine("chcp 65001");
                    }
                    sw.WriteLine(":Syntax");
                    sw.WriteLine("echo ------------------------------------");
                    sw.WriteLine("echo Delete The Files From The Production");
                    sw.WriteLine("echo Restore The Backup Files");
                    sw.WriteLine("echo ------------------------------------");
                    sw.WriteLine(":End");
                    sw.WriteLine(Environment.NewLine);
                    foreach (string file in _arrListFiles)
                    {
                        string subBackupFilePath = Path.Combine(_strSubBackupPath, file);
                        // there's no file in backup folder
                        if (!File.Exists(subBackupFilePath))
                        {
                            sw.WriteLine("del \"" + Path.Combine(_strProductionPath, file) + "\"");
                        }
                        else
                        {
                            sw.WriteLine("del \"" + Path.Combine(_strProductionPath, file) + "\"");
                            sw.WriteLine("copy \"" + subBackupFilePath + "\" \"" + Path.Combine(_strProductionPath, file) + "\"");
                        }
                        sw.WriteLine(Environment.NewLine);
                    }
                    // log
                    sw.WriteLine("@echo off");
                    sw.WriteLine("(");
                    sw.WriteLine("@echo Execute Rollback at %date% %time%");
                    sw.WriteLine("@echo ++--------------------------------------------------------------------------------++");
                    sw.WriteLine(") >> log.txt");
                    sw.WriteLine(Environment.NewLine);
                    //
                    sw.WriteLine("echo DONE");
                    sw.WriteLine("timeout /t 3");
                }
                //
                WriteLogExeBat("BACKUP");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Generate_PreDeploy_File()
        {
            try
            {
                if (File.Exists(_strPreDeployBat))
                {
                    File.Delete(_strPreDeployBat);
                }
                // create file
                using (StreamWriter sw = File.AppendText(_strPreDeployBat))
                {
                    sw.WriteLine("@echo off");
                    if (chkUnicode.Checked)
                    {
                        sw.WriteLine("chcp 65001");
                    }
                    sw.WriteLine(":Syntax");
                    sw.WriteLine("echo ------------------------------------");
                    sw.WriteLine("echo Copy Files From The Resource (Current Changed)");
                    sw.WriteLine("echo To Deploy Folder");
                    sw.WriteLine("echo In Order To Prepare For Run Deployment");
                    sw.WriteLine("echo ------------------------------------");
                    sw.WriteLine(":End");
                    sw.WriteLine(Environment.NewLine);
                    foreach (string file in _arrListFiles)
                    {
                        string subResourceFilePath = Path.Combine(_strPreDeployPath, file);
                        // copy resour -> deploy folder
                        if (File.Exists(subResourceFilePath))
                        {
                            sw.WriteLine("copy \"" + subResourceFilePath + "\" \"" + Path.Combine(_strSubDeployPath, file) + "\"");
                        }
                    }
                    sw.WriteLine(Environment.NewLine);
                    // log
                    sw.WriteLine("@echo off");
                    sw.WriteLine("(");
                    sw.WriteLine("@echo Prepare Resource at %date% %time%");
                    sw.WriteLine("@echo ++--------------------------------------------------------------------------------++");
                    sw.WriteLine(") >> log.txt");
                    sw.WriteLine(Environment.NewLine);
                    //
                    sw.WriteLine("echo DONE");
                    sw.WriteLine("timeout /t 3");
                }
                //
                WriteLogExeBat("PRE-DEPLOY");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowserProduction_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Please choose the folder\nWhere you want to deploy the source code";
                folderDialog.SelectedPath = Properties.Settings.Default.RecentFolder;
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    Properties.Settings.Default.RecentFolder = selectedPath;
                    //
                    cb_production_path.Text = selectedPath;
                    cb_production_path.Items.AddRange(new object[] { selectedPath });
                }
            }
        }

        private void btnBrowserBackup_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Please choose the folder\nWhere you want to backup the source code";
                folderDialog.SelectedPath = Properties.Settings.Default.RecentFolder;
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    Properties.Settings.Default.RecentFolder = selectedPath;
                    //
                    cb_backup_path.Text = selectedPath;
                    cb_backup_path.Items.AddRange(new object[] { selectedPath });
                }
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Please Choose File";
            dialog.Filter = "Support Files | *.txt; *.bat; *.log; *.dat; *.rm;";
            dialog.InitialDirectory = Properties.Settings.Default.RecentFileFolder;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.RecentFileFolder = dialog.FileName;
                //
                rtb_list_files.Clear();
                using (StreamReader sr = new StreamReader(dialog.FileName, Encoding.Default))
                {
                    string s = "";
                    while((s = sr.ReadLine()) != null)
                    {
                        rtb_list_files.AppendText(s);
                        rtb_list_files.AppendText(Environment.NewLine);
                    }
                }
            }
        }

        private void btn_replace_Click(object sender, EventArgs e)
        {
            string text1 = tb_text1.Text.Trim();
            string text2 = tb_text2.Text.Trim();
            if (text1 != "")
            {
                rtb_list_files.Text = rtb_list_files.Text.Replace(text1, text2);
            }
        }

        public void AddContextMenu(RichTextBox rtb)
        {
            if (rtb.ContextMenuStrip == null)
            {
                ContextMenuStrip cms = new ContextMenuStrip { ShowImageMargin = false };
                ToolStripMenuItem tsmiCut = new ToolStripMenuItem("Cut");
                tsmiCut.Click += (sender, e) => rtb.Cut();
                cms.Items.Add(tsmiCut);
                ToolStripMenuItem tsmiCopy = new ToolStripMenuItem("Copy");
                tsmiCopy.Click += (sender, e) => rtb.Copy();
                cms.Items.Add(tsmiCopy);
                ToolStripMenuItem tsmiPaste = new ToolStripMenuItem("Paste");
                tsmiPaste.Click += (sender, e) => rtb.Paste();
                cms.Items.Add(tsmiPaste);
                ToolStripMenuItem tsmiSelectAll = new ToolStripMenuItem("Select All");
                tsmiSelectAll.Click += (sender, e) => rtb.SelectAll();
                cms.Items.Add(tsmiSelectAll);
                rtb.ContextMenuStrip = cms;
            }
        }

        private void WriteLogExeBat(string type)
        {
            string logFile = Path.Combine(_strBackupPathCur, "log.txt");
            switch (type)
            {
                case "BACKUP":
                    using (StreamWriter sw = File.AppendText(logFile))
                    {
                        sw.WriteLine("Execute Backup at " + DateTime.Now.ToString("ddd dd/MM/yyyy HH:mm:ss.ff"));
                        sw.WriteLine("++--------------------------------------------------------------------------------++");
                    }
                    break;
                case "DEPLOY":
                    using (StreamWriter sw = File.AppendText(logFile))
                    {
                        sw.WriteLine("Execute Deploy at " + DateTime.Now.ToString("ddd dd/MM/yyyy HH:mm:ss.ff"));
                        sw.WriteLine("++--------------------------------------------------------------------------------++");
                    }
                    break;
                case "ROLLBACK":
                    using (StreamWriter sw = File.AppendText(logFile))
                    {
                        sw.WriteLine("Execute Rollback at " + DateTime.Now.ToString("ddd dd/MM/yyyy HH:mm:ss.ff"));
                        sw.WriteLine("++--------------------------------------------------------------------------------++");
                    }
                    break;
                case "PRE-DEPLOY":
                    using (StreamWriter sw = File.AppendText(logFile))
                    {
                        sw.WriteLine("Prepare Resource at " + DateTime.Now.ToString("ddd dd/MM/yyyy HH:mm:ss.ff"));
                        sw.WriteLine("++--------------------------------------------------------------------------------++");
                    }
                    break;
            }
        }

        private void RunProcessAsAdmin(string exePath, string parameters)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.UseShellExecute = true;
                startInfo.WorkingDirectory = Environment.ExpandEnvironmentVariables("%SystemRoot%") + @"\System32\cmd.exe";
                startInfo.FileName = exePath;
                startInfo.Verb = "runas";
                //MLHIDE
                startInfo.Arguments = parameters;
                startInfo.ErrorDialog = true;

                Process proc = System.Diagnostics.Process.Start(startInfo);
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_run_backup_Click(object sender, EventArgs e)
        {
            try
            {
                GetInfoFromForm();
                //
                if (File.Exists(_strBackupBat))
                {
                    System.Diagnostics.Process myProcess = null;
                    //
                    try
                    {
                        // Start the process.
                        myProcess = Process.Start(_strBackupBat);
                        // Display the process statistics until
                        // the user closes the program.
                        do
                        {
                            if (!myProcess.HasExited)
                            {
                                // Refresh the current process property values.
                                myProcess.Refresh();
                            }
                        }
                        while (!myProcess.WaitForExit(5000));
                    }
                    finally
                    {
                        if (myProcess != null)
                        {
                            myProcess.Close();
                        }
                    }
                    //
                    DeleteEmptyDirs(_strSubBackupPath);
                    //
                    WriteLogExeBat("BACKUP");
                }
                else
                {
                    MessageBox.Show("File Not Found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_run_deploy_Click(object sender, EventArgs e)
        {
            try
            {
                GetInfoFromForm();
                //
                if (!File.Exists(_strPreDeployBat))
                {
                    throw new System.ArgumentException("Please Copy Resource Files to deploy Folder");
                }
                //
                if (File.Exists(_strDeployBat))
                {
                    if (MessageBox.Show("Do you really want to deploy The Source Code?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        RunProcessAsAdmin(_strPreDeployBat, "");
                        // System.Diagnostics.Process.Start(_strDeployBat);
                        //
                        WriteLogExeBat("DEPLOY");
                    }
                }
                else
                {
                    MessageBox.Show("File Not Found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_run_rollback_Click(object sender, EventArgs e)
        {
            try
            {
                GetInfoFromForm();
                //
                if (File.Exists(_strRollbackBat))
                { 
                    if (MessageBox.Show("Do you really want to restore The Source Code?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        RunProcessAsAdmin(_strRollbackBat, "");
                        // System.Diagnostics.Process.Start(_strRollbackBat);
                        //
                        WriteLogExeBat("ROLLBACK");
                    }
                }
                else
                {
                    MessageBox.Show("File Not Found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDataToCombobox()
        {
            try
            {
                ComboBox[] cmbs = new ComboBox[] { cb_production_path, cb_backup_path, cb_deployment_path };
                string[] attributeNames = new String[] { "production", "backup", "deployment" };
                //
                string appPlacingPath = Directory.GetCurrentDirectory();
                string fileName = Path.Combine(appPlacingPath, "setting.xml");
                if (!File.Exists(fileName))
                {
                    return;
                }
                //
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(fileName);
                for (int i = 0; i < attributeNames.Length; i++)
                {
                    XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/setting/location[@name='" + attributeNames[i] + "']");
                    foreach (XmlNode node in nodeList)
                    {
                        XmlNodeList items = node.SelectNodes("item");
                        foreach (XmlNode item in items)
                        {
                            cmbs[i].Items.Add(item.Attributes["path"].Value);
                        }
                        cmbs[i].SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex) {
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GetInfoFromForm();

                // make folder
                MkdirFolder(_strBackupPathCur);
                //
                string noteFile = @Path.Combine(_strBackupPathCur, "ReleaseNote.txt");
                using (StreamWriter sw = File.CreateText(noteFile))
                {
                    sw.WriteLine(rtb_release_note.Text);
                }
                //
                MessageBox.Show("The Realse Note has been created!");
            }
            catch (Exception ex)
            {

            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Please Choose File";
                dialog.Filter = "Support Files | *.txt; *.bat; *.log; *.dat; *.rm;";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.RecentFileFolder = dialog.FileName;
                    //
                    rtb_release_note.Clear();
                    using (StreamReader sr = new StreamReader(dialog.FileName, Encoding.Default))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            rtb_release_note.AppendText(s);
                            rtb_release_note.AppendText(Environment.NewLine);
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        private List<string> AllFiles = new List<string>();
        private void ParsePath(string path)
        {
            string[] SubDirs = Directory.GetDirectories(path);
            AllFiles.AddRange(SubDirs);
            AllFiles.AddRange(Directory.GetFiles(path));
            foreach (string subdir in SubDirs)
                ParsePath(subdir);
        }

        private void DeleteEmptyDirs(string startPath)
        {
            if (String.IsNullOrEmpty(startPath))
                throw new ArgumentException(
                    "Starting directory is a null reference or an empty string",
                    "dir");

            try
            {
                foreach (var d in Directory.EnumerateDirectories(startPath))
                {
                    DeleteEmptyDirs(d);
                }

                var entries = Directory.EnumerateFileSystemEntries(startPath);

                if (!entries.Any())
                {
                    try
                    {
                        Directory.Delete(startPath);
                    }
                    catch (UnauthorizedAccessException) { }
                    catch (DirectoryNotFoundException) { }
                }
            }
            catch (UnauthorizedAccessException) { }
        }

        private void btnReadFolder_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Please choose the folder\nWhere is keeping the source code that have been stored before";
                    folderDialog.SelectedPath = Properties.Settings.Default.RecentFolder;
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedPath = folderDialog.SelectedPath;
                        Properties.Settings.Default.RecentFolder = selectedPath;
                        //
                        AllFiles.Clear();
                        ParsePath(selectedPath);
                        //
                        foreach (string item in AllFiles)
                        {
                            // get the file attributes for file or directory
                            FileAttributes attr = File.GetAttributes(item);
                            //detect whether its a directory or file
                            if (!attr.HasFlag(FileAttributes.Directory))
                            {
                                rtb_list_files.AppendText(item);
                                rtb_list_files.AppendText(Environment.NewLine);
                            }
                            
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }

        }

        private void btnExitMenu_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            Form2 frmAbout = new Form2();
            frmAbout.ShowDialog();
            frmAbout.Dispose();
        }

        private void menuDeploymentFlow_Click(object sender, EventArgs e)
        {
            Form3 frmDeployment = new Form3();
            frmDeployment.ShowDialog();
            frmDeployment.Dispose();
        }

        private void btnBrowserDeployment_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Please choose the folder\nThe resource from this folder will be copied to [" + tb_sub_deploy_folder.Text + "] folder\nIn order to prepare for deployment";
                folderDialog.SelectedPath = Properties.Settings.Default.RecentFolder;
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    Properties.Settings.Default.RecentFolder = selectedPath;
                    //
                    cb_deployment_path.Text = selectedPath;
                    cb_deployment_path.Items.AddRange(new object[] { selectedPath });
                }
            }
        }

        private void btn_run_pre_deploy_Click(object sender, EventArgs e)
        {
            try
            {
                GetInfoFromForm();
                //
                if (string.IsNullOrEmpty(cb_deployment_path.Text) || string.IsNullOrWhiteSpace(cb_deployment_path.Text))
                {
                    throw new System.ArgumentException(btnBrowserDeployment.Text + " is not empty");
                }
                //
                // generate pre-deploy
                Generate_PreDeploy_File();
                //
                if (File.Exists(_strPreDeployBat))
                {
                    if (MessageBox.Show("Do you want to prepare Source Code for Deployment?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process myProcess = null;
                        //
                        try
                        {
                            // Start the process.
                            myProcess = Process.Start(_strPreDeployBat);
                            // Display the process statistics until
                            // the user closes the program.
                            do
                            {
                                if (!myProcess.HasExited)
                                {
                                    // Refresh the current process property values.
                                    myProcess.Refresh();
                                }
                            }
                            while (!myProcess.WaitForExit(5000));
                        }
                        finally
                        {
                            if (myProcess != null)
                            {
                                myProcess.Close();
                            }
                        }
                        //
                        DeleteEmptyDirs(_strSubDeployPath);
                        //
                        WriteLogExeBat("PRE-DEPLOY");
                    }
                }
                else
                {
                    MessageBox.Show("File Not Found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CleanRichTextBox(RichTextBox rtb)
        {
            string[] lstFilePath = Lines(rtb.Text);
            Array.Sort(lstFilePath, StringComparer.InvariantCulture);
            //
            rtb.Clear();
            //
            List<string> lineLst = new List<string>();
            foreach (string filePath in lstFilePath)
            {
                lineLst.Add(filePath.TrimStart(' ', '\\'));
            }
            rtb.Text = string.Join(Environment.NewLine, lineLst.ToArray()).TrimStart(' ', '\\');
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            CleanRichTextBox(rtb_list_files);
        }

        private void grResource_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.DodgerBlue, 1);
            gfx.DrawLine(p, 0, 6, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 6, 5, 6);
            gfx.DrawLine(p, 155, 6, e.ClipRectangle.Width - 2, 6);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 6, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }

        private string[] ConvertCmb2Arr(ComboBox cb)
        {
            string[] strArr = new string[cb.Items.Count];
            for(int i=0; i<cb.Items.Count; i++)
            {
                strArr[i] = cb.Items[i].ToString();
            }
            return strArr.Distinct().ToArray();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.ApplicationExitCall)
            {
                ComboBox[] cmbs = new ComboBox[] { cb_production_path, cb_backup_path, cb_deployment_path };
                string[] attributeNames = new String[] { "production", "backup", "deployment" };
                string[] comboboxLst;
                string appPlacingPath = Directory.GetCurrentDirectory();
                XmlWriter xmlWriter = XmlWriter.Create(Path.Combine(appPlacingPath, "setting.xml"));

                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("setting");

                for (int i=0; i< attributeNames.Length; i++)
                {
                    // prodcution path // backup path // deployment path
                    xmlWriter.WriteStartElement("location");
                    xmlWriter.WriteAttributeString("name", attributeNames[i]);
                    comboboxLst = ConvertCmb2Arr(cmbs[i]);
                    foreach (string path in comboboxLst)
                    {
                        xmlWriter.WriteStartElement("item");
                        xmlWriter.WriteAttributeString("path", path);
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }
        }

        private void btn_collapse_Click(object sender, EventArgs e)
        {
            string value = btn_collapse.Text;
            switch (value)
            {
                case "▼":
                    btn_collapse.Text = "▲";
                    break;
                case "▲":
                    btn_collapse.Text = "▼";
                    break;
            }
            //
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void cb_production_path_Leave(object sender, EventArgs e)
        {
            string item = cb_production_path.Text;
            if (item.Trim() != "" && !cb_production_path.Items.Contains(item))
            {
                cb_production_path.Items.Add(item);
            }
        }

        private void cb_deployment_path_Leave(object sender, EventArgs e)
        {
            string item = cb_deployment_path.Text;
            if (item.Trim() != "" && !cb_deployment_path.Items.Contains(item))
            {
                cb_deployment_path.Items.Add(item);
            }
        }

        private void cb_backup_path_Leave(object sender, EventArgs e)
        {
            string item = cb_backup_path.Text;
            if (item.Trim() != "" && !cb_backup_path.Items.Contains(item))
            {
                cb_backup_path.Items.Add(item);
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (string.IsNullOrEmpty(cb_production_path.Text) || string.IsNullOrWhiteSpace(cb_production_path.Text))
            {
                MessageBox.Show(btnBrowserProduction.Text + " is not empty");
                flag = false;
            }
            //
            if (string.IsNullOrEmpty(cb_backup_path.Text) || string.IsNullOrWhiteSpace(cb_backup_path.Text))
            {
                MessageBox.Show(btnBrowserBackup.Text + " is not empty");
                flag = false;
            }
            //
            if (string.IsNullOrEmpty(tb_sub_backup_folder.Text) || string.IsNullOrWhiteSpace(tb_sub_backup_folder.Text))
            {
                MessageBox.Show(lb_tb_sub_backup_folder.Text + " is not empty");
                flag = false;
            }
            //
            if (string.IsNullOrEmpty(tb_sub_deploy_folder.Text) || string.IsNullOrWhiteSpace(tb_sub_deploy_folder.Text))
            {
                MessageBox.Show(lb_tb_sub_deploy_folder.Text + " is not empty");
                flag = false;
            }
            //
            if (flag)
            {
                Form4 frmMerge = new Form4(SetDataMainForm());
                frmMerge.ShowDialog();

                rtb_list_files.Clear();
                foreach (string item in frmMerge._listFiles.Distinct())
                {
                    rtb_list_files.AppendText(item);
                    rtb_list_files.AppendText(Environment.NewLine);
                }
                CleanRichTextBox(rtb_list_files);

                frmMerge.Dispose();
            }
        }

        public List<KeyValuePair<string, string>> SetDataMainForm()
        {
            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
            try
            {
                //
                GetInfoFromForm();
                //
                frmMain form = new frmMain();
                data.Add(new KeyValuePair<string, string>("CUR_BK_PATH", _strBackupPathCur));
                data.Add(new KeyValuePair<string, string>("PRE_DEPLOY_PATH", _strPreDeployPath));
                data.Add(new KeyValuePair<string, string>("SUB_BK_PATH", _strSubBackupPath));
                data.Add(new KeyValuePair<string, string>("SUB_DEPLOY_PATH", _strSubDeployPath));
                data.Add(new KeyValuePair<string, string>("BK_FOLDER", _strBackupFolder));
                data.Add(new KeyValuePair<string, string>("DEPLOY_FOLDER", _strDeployFolder));
                data.Add(new KeyValuePair<string, string>("PRODUCTION_FOLDER", _strProductionFolder));
                //
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return data;
        }
    }
}
