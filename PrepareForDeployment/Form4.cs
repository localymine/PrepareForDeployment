﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PrepareForDeployment
{
    public partial class Form4 : Form
    {
        private string _selectedPath = string.Empty;
        private string _subDeployPath = string.Empty;
        private string _bkFolder = string.Empty;
        private string _deployFolder = string.Empty;
        private string _productionFolder = string.Empty;
        public List<string> _listFiles = new List<string>();

        public Form4(List<KeyValuePair<string, string>> data)
        {
            InitializeComponent();
            //
            _subDeployPath = data.First(kvp => kvp.Key == "SUB_DEPLOY_PATH").Value;
            _bkFolder = data.First(kvp => kvp.Key == "BK_FOLDER").Value;
            _deployFolder = data.First(kvp => kvp.Key == "DEPLOY_FOLDER").Value;
            _productionFolder = data.First(kvp => kvp.Key == "PRODUCTION_FOLDER").Value;
            lbDeployPath.Text = _subDeployPath;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Please choose the folder\nWhere you want to deploy the source code";
                folderDialog.RootFolder = Environment.SpecialFolder.DesktopDirectory;
                if (Directory.Exists(Properties.Settings.Default.RecentFolder))
                {
                    folderDialog.SelectedPath = Properties.Settings.Default.RecentFolder;
                    SendKeys.Send("{TAB}{TAB}{RIGHT}");
                }
                //
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    _selectedPath = folderDialog.SelectedPath;
                    txtPath.Text = _selectedPath;
                    Properties.Settings.Default.RecentFolder = _selectedPath;
                    Properties.Settings.Default.Save();
                }
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

        private void btnMerge_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory(_subDeployPath);
                //
                rtbListFolder.Clear();
                AllFiles.Clear();
                string[] SubDirs = Directory.GetDirectories(_selectedPath);
                Array.Sort(SubDirs, StringComparer.InvariantCulture);
                foreach (string subFolder in SubDirs)
                {
                    ParsePath(subFolder);
                    //
                    foreach (string filePath in AllFiles)
                    {
                        // get the file attributes for file or directory
                        FileAttributes attr = File.GetAttributes(filePath);
                        //detect whether its a directory or file
                        if (!attr.HasFlag(FileAttributes.Directory))
                        {
                            string[] k = filePath.Split(new string[] { "\\" }, StringSplitOptions.None).Reverse().Skip(1).Reverse().ToArray();
                            if (Array.Exists(k, element => element == _deployFolder))
                            {
                                string fileName = filePath.Substring(filePath.IndexOf(_deployFolder), filePath.Length - filePath.IndexOf(_deployFolder));
                                fileName = fileName.Replace(_deployFolder + "\\", "");
                                fileName = fileName.Replace(_productionFolder + "\\", "");
                                string preDeployFolder = Path.GetDirectoryName(fileName);
                                //
                                Directory.CreateDirectory(Path.Combine(_subDeployPath, preDeployFolder));
                                //
                                // To copy a file to another location and
                                // overwrite the destination file if it already exists.
                                System.IO.File.Copy(filePath, Path.Combine(_subDeployPath, fileName), true);
                                //
                                _listFiles.Add(fileName);
                            }
                        }
                    }
                }
                _listFiles = _listFiles.Distinct().ToList();
                foreach (string item in _listFiles)
                {
                    rtbListFolder.AppendText(item);
                    rtbListFolder.AppendText(Environment.NewLine);
                }
                //
                rtbListFolder.Focus();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            _selectedPath = txtPath.Text.Trim();
        }
    }
}
