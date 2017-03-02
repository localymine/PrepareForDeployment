namespace PrepareForDeployment
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_production_path = new System.Windows.Forms.ComboBox();
            this.btnBrowserProduction = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpk_cur_time = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpk_cur_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_backup_path = new System.Windows.Forms.ComboBox();
            this.btnBrowserBackup = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_sub_deploy_folder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_sub_backup_folder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtb_list_files = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_replace = new System.Windows.Forms.Button();
            this.tb_text2 = new System.Windows.Forms.TextBox();
            this.tb_text1 = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.btn_run_backup = new System.Windows.Forms.Button();
            this.btn_run_deploy = new System.Windows.Forms.Button();
            this.btn_run_rollback = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateReleaseNote = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deploymentFlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_release_note = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_production_path);
            this.groupBox1.Controls.Add(this.btnBrowserProduction);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Production Section";
            // 
            // cb_production_path
            // 
            this.cb_production_path.FormattingEnabled = true;
            this.cb_production_path.Location = new System.Drawing.Point(95, 23);
            this.cb_production_path.Name = "cb_production_path";
            this.cb_production_path.Size = new System.Drawing.Size(162, 21);
            this.cb_production_path.TabIndex = 1;
            // 
            // btnBrowserProduction
            // 
            this.btnBrowserProduction.AutoSize = true;
            this.btnBrowserProduction.Location = new System.Drawing.Point(6, 27);
            this.btnBrowserProduction.Name = "btnBrowserProduction";
            this.btnBrowserProduction.Size = new System.Drawing.Size(83, 13);
            this.btnBrowserProduction.TabIndex = 0;
            this.btnBrowserProduction.Text = "Production Path";
            this.btnBrowserProduction.Click += new System.EventHandler(this.btnBrowserProduction_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpk_cur_time);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpk_cur_date);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cb_backup_path);
            this.groupBox2.Controls.Add(this.btnBrowserBackup);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 86);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backup Section";
            // 
            // dtpk_cur_time
            // 
            this.dtpk_cur_time.CustomFormat = "HH:mm tt";
            this.dtpk_cur_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_cur_time.Location = new System.Drawing.Point(175, 52);
            this.dtpk_cur_time.Name = "dtpk_cur_time";
            this.dtpk_cur_time.ShowUpDown = true;
            this.dtpk_cur_time.Size = new System.Drawing.Size(83, 20);
            this.dtpk_cur_time.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Time";
            // 
            // dtpk_cur_date
            // 
            this.dtpk_cur_date.CustomFormat = "yyyy-MM-dd";
            this.dtpk_cur_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_cur_date.Location = new System.Drawing.Point(47, 52);
            this.dtpk_cur_date.Name = "dtpk_cur_date";
            this.dtpk_cur_date.Size = new System.Drawing.Size(91, 20);
            this.dtpk_cur_date.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date";
            // 
            // cb_backup_path
            // 
            this.cb_backup_path.FormattingEnabled = true;
            this.cb_backup_path.Location = new System.Drawing.Point(95, 23);
            this.cb_backup_path.Name = "cb_backup_path";
            this.cb_backup_path.Size = new System.Drawing.Size(163, 21);
            this.cb_backup_path.TabIndex = 1;
            // 
            // btnBrowserBackup
            // 
            this.btnBrowserBackup.AutoSize = true;
            this.btnBrowserBackup.Location = new System.Drawing.Point(6, 27);
            this.btnBrowserBackup.Name = "btnBrowserBackup";
            this.btnBrowserBackup.Size = new System.Drawing.Size(69, 13);
            this.btnBrowserBackup.TabIndex = 0;
            this.btnBrowserBackup.Text = "Backup Path";
            this.btnBrowserBackup.Click += new System.EventHandler(this.btnBrowserBackup_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_sub_deploy_folder);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tb_sub_backup_folder);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 86);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other";
            // 
            // tb_sub_deploy_folder
            // 
            this.tb_sub_deploy_folder.Location = new System.Drawing.Point(142, 49);
            this.tb_sub_deploy_folder.Name = "tb_sub_deploy_folder";
            this.tb_sub_deploy_folder.Size = new System.Drawing.Size(116, 20);
            this.tb_sub_deploy_folder.TabIndex = 3;
            this.tb_sub_deploy_folder.Text = "deploy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Deploy Sub Folder Name";
            // 
            // tb_sub_backup_folder
            // 
            this.tb_sub_backup_folder.Location = new System.Drawing.Point(142, 23);
            this.tb_sub_backup_folder.Name = "tb_sub_backup_folder";
            this.tb_sub_backup_folder.Size = new System.Drawing.Size(116, 20);
            this.tb_sub_backup_folder.TabIndex = 1;
            this.tb_sub_backup_folder.Text = "bk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Backup Sub Folder Name";
            // 
            // rtb_list_files
            // 
            this.rtb_list_files.Location = new System.Drawing.Point(6, 51);
            this.rtb_list_files.Name = "rtb_list_files";
            this.rtb_list_files.ShortcutsEnabled = false;
            this.rtb_list_files.Size = new System.Drawing.Size(452, 142);
            this.rtb_list_files.TabIndex = 4;
            this.rtb_list_files.Text = "";
            this.rtb_list_files.WordWrap = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_replace);
            this.groupBox4.Controls.Add(this.tb_text2);
            this.groupBox4.Controls.Add(this.tb_text1);
            this.groupBox4.Controls.Add(this.btnLoadFile);
            this.groupBox4.Controls.Add(this.rtb_list_files);
            this.groupBox4.Location = new System.Drawing.Point(285, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(464, 199);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "List Files For Deployment";
            // 
            // btn_replace
            // 
            this.btn_replace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_replace.Image = ((System.Drawing.Image)(resources.GetObject("btn_replace.Image")));
            this.btn_replace.Location = new System.Drawing.Point(428, 21);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(30, 23);
            this.btn_replace.TabIndex = 8;
            this.btn_replace.UseVisualStyleBackColor = true;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // tb_text2
            // 
            this.tb_text2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_text2.Location = new System.Drawing.Point(322, 22);
            this.tb_text2.Name = "tb_text2";
            this.tb_text2.Size = new System.Drawing.Size(100, 20);
            this.tb_text2.TabIndex = 7;
            // 
            // tb_text1
            // 
            this.tb_text1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_text1.Location = new System.Drawing.Point(216, 22);
            this.tb_text1.Name = "tb_text1";
            this.tb_text1.Size = new System.Drawing.Size(100, 20);
            this.tb_text1.TabIndex = 6;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(6, 22);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(120, 23);
            this.btnLoadFile.TabIndex = 5;
            this.btnLoadFile.Text = "Load List From File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(291, 238);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(140, 33);
            this.btn_Generate.TabIndex = 6;
            this.btn_Generate.Text = "Generate Executable Files";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // btn_run_backup
            // 
            this.btn_run_backup.Location = new System.Drawing.Point(439, 243);
            this.btn_run_backup.Name = "btn_run_backup";
            this.btn_run_backup.Size = new System.Drawing.Size(95, 23);
            this.btn_run_backup.TabIndex = 8;
            this.btn_run_backup.Text = "1. Run Backup";
            this.btn_run_backup.UseVisualStyleBackColor = true;
            this.btn_run_backup.Click += new System.EventHandler(this.btn_run_backup_Click);
            // 
            // btn_run_deploy
            // 
            this.btn_run_deploy.Location = new System.Drawing.Point(546, 243);
            this.btn_run_deploy.Name = "btn_run_deploy";
            this.btn_run_deploy.Size = new System.Drawing.Size(95, 23);
            this.btn_run_deploy.TabIndex = 4;
            this.btn_run_deploy.Text = "2. Run Deploy";
            this.btn_run_deploy.UseVisualStyleBackColor = true;
            this.btn_run_deploy.Click += new System.EventHandler(this.btn_run_deploy_Click);
            // 
            // btn_run_rollback
            // 
            this.btn_run_rollback.Location = new System.Drawing.Point(653, 243);
            this.btn_run_rollback.Name = "btn_run_rollback";
            this.btn_run_rollback.Size = new System.Drawing.Size(95, 23);
            this.btn_run_rollback.TabIndex = 9;
            this.btn_run_rollback.Text = "3. Run Rollback";
            this.btn_run_rollback.UseVisualStyleBackColor = true;
            this.btn_run_rollback.Click += new System.EventHandler(this.btn_run_rollback_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateReleaseNote,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnCreateReleaseNote
            // 
            this.btnCreateReleaseNote.Name = "btnCreateReleaseNote";
            this.btnCreateReleaseNote.Size = new System.Drawing.Size(157, 22);
            this.btnCreateReleaseNote.Text = "Release Note ▼";
            this.btnCreateReleaseNote.Click += new System.EventHandler(this.btnCreateReleaseNote_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deploymentFlowToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // deploymentFlowToolStripMenuItem
            // 
            this.deploymentFlowToolStripMenuItem.Name = "deploymentFlowToolStripMenuItem";
            this.deploymentFlowToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deploymentFlowToolStripMenuItem.Text = "Deployment Flow";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.rtb_release_note);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 213);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Release Note";
            // 
            // rtb_release_note
            // 
            this.rtb_release_note.Location = new System.Drawing.Point(9, 21);
            this.rtb_release_note.Name = "rtb_release_note";
            this.rtb_release_note.Size = new System.Drawing.Size(740, 160);
            this.rtb_release_note.TabIndex = 1;
            this.rtb_release_note.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(674, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(760, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_run_rollback);
            this.Controls.Add(this.btn_run_deploy);
            this.Controls.Add(this.btn_run_backup);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prepare For Deployment";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label btnBrowserProduction;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpk_cur_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_backup_path;
        private System.Windows.Forms.Label btnBrowserBackup;
        private System.Windows.Forms.DateTimePicker dtpk_cur_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_sub_deploy_folder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_sub_backup_folder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtb_list_files;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.ComboBox cb_production_path;
        private System.Windows.Forms.Button btn_run_backup;
        private System.Windows.Forms.Button btn_run_deploy;
        private System.Windows.Forms.Button btn_run_rollback;
        private System.Windows.Forms.Button btn_replace;
        private System.Windows.Forms.TextBox tb_text2;
        private System.Windows.Forms.TextBox tb_text1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCreateReleaseNote;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deploymentFlowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtb_release_note;
        private System.Windows.Forms.Label label1;
    }
}

