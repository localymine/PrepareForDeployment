using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepareForDeployment
{
    public partial class frmMain : Form
    {
        private string[] _arrListFiles = { };
        private string _strProductionPath;
        private string _strProductionFolder;
        private string _strBackupPath;
        private string _strSubBackupPath;
        private string _strSubDeployPath;
        private string _strCurDate;
        private string _strCurTime;
        private string _strBackupFolder;
        private string _strDeployFolder;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            this._strCurDate = dtpk_cur_date.Text.Replace("-", "");
            this._strCurTime = dtpk_cur_time.Text.Replace(":", "").Replace(" ", "");
            this._strBackupFolder = tb_sub_backup_folder.Text;
            this._strDeployFolder = tb_sub_deploy_folder.Text;

            this._strProductionPath = cb_production_path.Text.TrimStart().TrimEnd();
            this._strProductionFolder = this._strProductionPath.Split(new string[] { "\\" }, StringSplitOptions.None).Last();
            this._strBackupPath = cb_backup_path.Text.TrimStart().TrimEnd();
            this._strSubBackupPath = System.IO.Path.Combine(new string[] { this._strBackupPath, this._strCurDate, this._strCurTime, this._strBackupFolder, this._strProductionFolder });
            this._strSubDeployPath = System.IO.Path.Combine(new string[] { this._strBackupPath, this._strCurDate, this._strCurTime, this._strDeployFolder, this._strProductionFolder });

            // make folder
            MkdirFolder(this._strSubBackupPath);
            MkdirFolder(this._strSubDeployPath);

            // prepare list files, convert to array and make folder
            MkdirProjectFolder();

            // generate backup
            // Generate_Backup_File();



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
            }
            return MyPathWithoutDriveOrNetworkShare;
        }

        private void MkdirFolder(string pathString)
        {
            System.IO.Directory.CreateDirectory(pathString);
        }

        private void MkdirProjectFolder()
        {
            string[] listFiles = Lines(rtb_list_files.Text);
            List<string> tempList = new List<string>();
            //
            foreach (string item in listFiles)
            {
                string t = RemoveDriveOrNetworkShare(item).Replace("/", "\\");
                tempList.Add(t);
            }
            //
            this._arrListFiles = tempList.ToArray();
            //
            foreach(string file in this._arrListFiles)
            {
                string[] k = file.Split(new string[] { "\\" }, StringSplitOptions.None).Reverse().Skip(1).Reverse().ToArray();
                k = k.Distinct().ToArray();
                string t = System.IO.Path.Combine(k);
                Console.WriteLine(t);
            }
        }

        private void Generate_Backup_File()
        {
            string strBackupPath = RemoveDriveOrNetworkShare(this._strBackupPath);

            string[] arrBackupPath = this._strBackupPath.Split(new string[] { "\\", "/" }, StringSplitOptions.None);

            System.Diagnostics.Debug.WriteLine(this._strProductionFolder);
            System.Diagnostics.Debug.WriteLine(this._strSubBackupPath);
            System.Diagnostics.Debug.WriteLine(this._strSubDeployPath);

        }

    }
}
