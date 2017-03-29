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
            this.grProduction = new System.Windows.Forms.GroupBox();
            this.cb_production_path = new System.Windows.Forms.ComboBox();
            this.btnBrowserProduction = new System.Windows.Forms.Label();
            this.grBackup = new System.Windows.Forms.GroupBox();
            this.dtpk_cur_time = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpk_cur_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_backup_path = new System.Windows.Forms.ComboBox();
            this.btnBrowserBackup = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_sub_deploy_folder = new System.Windows.Forms.TextBox();
            this.lb_tb_sub_deploy_folder = new System.Windows.Forms.Label();
            this.tb_sub_backup_folder = new System.Windows.Forms.TextBox();
            this.lb_tb_sub_backup_folder = new System.Windows.Forms.Label();
            this.rtb_list_files = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtb_unused_files = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkUnicode = new System.Windows.Forms.CheckBox();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btnReadFolder = new System.Windows.Forms.Button();
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
            this.btnMerge = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeploymentFlow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.rtb_release_note = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grResource = new System.Windows.Forms.GroupBox();
            this.cb_deployment_path = new System.Windows.Forms.ComboBox();
            this.btnBrowserDeployment = new System.Windows.Forms.Label();
            this.btn_run_pre_deploy = new System.Windows.Forms.Button();
            this.btn_collapse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grProduction.SuspendLayout();
            this.grBackup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grResource.SuspendLayout();
            this.SuspendLayout();
            // 
            // grProduction
            // 
            this.grProduction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grProduction.Controls.Add(this.cb_production_path);
            this.grProduction.Controls.Add(this.btnBrowserProduction);
            this.grProduction.ForeColor = System.Drawing.Color.Tomato;
            this.grProduction.Location = new System.Drawing.Point(12, 32);
            this.grProduction.Name = "grProduction";
            this.grProduction.Size = new System.Drawing.Size(351, 55);
            this.grProduction.TabIndex = 0;
            this.grProduction.TabStop = false;
            this.grProduction.Text = "Production Section";
            // 
            // cb_production_path
            // 
            this.cb_production_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_production_path.FormattingEnabled = true;
            this.cb_production_path.Location = new System.Drawing.Point(95, 23);
            this.cb_production_path.Name = "cb_production_path";
            this.cb_production_path.Size = new System.Drawing.Size(246, 21);
            this.cb_production_path.TabIndex = 1;
            this.cb_production_path.Leave += new System.EventHandler(this.cb_production_path_Leave);
            this.cb_production_path.MouseHover += new System.EventHandler(this.cb_production_path_MouseHover);
            // 
            // btnBrowserProduction
            // 
            this.btnBrowserProduction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowserProduction.AutoSize = true;
            this.btnBrowserProduction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBrowserProduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowserProduction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBrowserProduction.Location = new System.Drawing.Point(6, 27);
            this.btnBrowserProduction.Name = "btnBrowserProduction";
            this.btnBrowserProduction.Size = new System.Drawing.Size(85, 15);
            this.btnBrowserProduction.TabIndex = 0;
            this.btnBrowserProduction.Text = "Production Path";
            this.btnBrowserProduction.Click += new System.EventHandler(this.btnBrowserProduction_Click);
            // 
            // grBackup
            // 
            this.grBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBackup.Controls.Add(this.dtpk_cur_time);
            this.grBackup.Controls.Add(this.label5);
            this.grBackup.Controls.Add(this.dtpk_cur_date);
            this.grBackup.Controls.Add(this.label4);
            this.grBackup.Controls.Add(this.cb_backup_path);
            this.grBackup.Controls.Add(this.btnBrowserBackup);
            this.grBackup.ForeColor = System.Drawing.Color.Tomato;
            this.grBackup.Location = new System.Drawing.Point(12, 154);
            this.grBackup.Name = "grBackup";
            this.grBackup.Size = new System.Drawing.Size(351, 86);
            this.grBackup.TabIndex = 2;
            this.grBackup.TabStop = false;
            this.grBackup.Text = "Backup Section";
            // 
            // dtpk_cur_time
            // 
            this.dtpk_cur_time.CustomFormat = "HH:mm tt";
            this.dtpk_cur_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_cur_time.Location = new System.Drawing.Point(188, 52);
            this.dtpk_cur_time.Name = "dtpk_cur_time";
            this.dtpk_cur_time.ShowUpDown = true;
            this.dtpk_cur_time.Size = new System.Drawing.Size(70, 20);
            this.dtpk_cur_time.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(152, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Time";
            // 
            // dtpk_cur_date
            // 
            this.dtpk_cur_date.CustomFormat = "yyyy-MM-dd";
            this.dtpk_cur_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_cur_date.Location = new System.Drawing.Point(42, 52);
            this.dtpk_cur_date.Name = "dtpk_cur_date";
            this.dtpk_cur_date.Size = new System.Drawing.Size(75, 20);
            this.dtpk_cur_date.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date";
            // 
            // cb_backup_path
            // 
            this.cb_backup_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_backup_path.FormattingEnabled = true;
            this.cb_backup_path.Location = new System.Drawing.Point(95, 23);
            this.cb_backup_path.Name = "cb_backup_path";
            this.cb_backup_path.Size = new System.Drawing.Size(247, 21);
            this.cb_backup_path.TabIndex = 3;
            this.cb_backup_path.Leave += new System.EventHandler(this.cb_backup_path_Leave);
            this.cb_backup_path.MouseHover += new System.EventHandler(this.cb_backup_path_MouseHover);
            // 
            // btnBrowserBackup
            // 
            this.btnBrowserBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowserBackup.AutoSize = true;
            this.btnBrowserBackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBrowserBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowserBackup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBrowserBackup.Location = new System.Drawing.Point(6, 27);
            this.btnBrowserBackup.Name = "btnBrowserBackup";
            this.btnBrowserBackup.Size = new System.Drawing.Size(71, 15);
            this.btnBrowserBackup.TabIndex = 0;
            this.btnBrowserBackup.Text = "Backup Path";
            this.btnBrowserBackup.Click += new System.EventHandler(this.btnBrowserBackup_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tb_sub_deploy_folder);
            this.groupBox3.Controls.Add(this.lb_tb_sub_deploy_folder);
            this.groupBox3.Controls.Add(this.tb_sub_backup_folder);
            this.groupBox3.Controls.Add(this.lb_tb_sub_backup_folder);
            this.groupBox3.Location = new System.Drawing.Point(12, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 86);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other";
            // 
            // tb_sub_deploy_folder
            // 
            this.tb_sub_deploy_folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_sub_deploy_folder.Location = new System.Drawing.Point(142, 49);
            this.tb_sub_deploy_folder.Name = "tb_sub_deploy_folder";
            this.tb_sub_deploy_folder.Size = new System.Drawing.Size(200, 20);
            this.tb_sub_deploy_folder.TabIndex = 7;
            this.tb_sub_deploy_folder.Text = "deploy";
            // 
            // lb_tb_sub_deploy_folder
            // 
            this.lb_tb_sub_deploy_folder.AutoSize = true;
            this.lb_tb_sub_deploy_folder.Location = new System.Drawing.Point(6, 53);
            this.lb_tb_sub_deploy_folder.Name = "lb_tb_sub_deploy_folder";
            this.lb_tb_sub_deploy_folder.Size = new System.Drawing.Size(125, 13);
            this.lb_tb_sub_deploy_folder.TabIndex = 2;
            this.lb_tb_sub_deploy_folder.Text = "Deploy Sub Folder Name";
            // 
            // tb_sub_backup_folder
            // 
            this.tb_sub_backup_folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_sub_backup_folder.Location = new System.Drawing.Point(142, 23);
            this.tb_sub_backup_folder.Name = "tb_sub_backup_folder";
            this.tb_sub_backup_folder.Size = new System.Drawing.Size(200, 20);
            this.tb_sub_backup_folder.TabIndex = 6;
            this.tb_sub_backup_folder.Text = "bk";
            // 
            // lb_tb_sub_backup_folder
            // 
            this.lb_tb_sub_backup_folder.AutoSize = true;
            this.lb_tb_sub_backup_folder.Location = new System.Drawing.Point(6, 27);
            this.lb_tb_sub_backup_folder.Name = "lb_tb_sub_backup_folder";
            this.lb_tb_sub_backup_folder.Size = new System.Drawing.Size(129, 13);
            this.lb_tb_sub_backup_folder.TabIndex = 0;
            this.lb_tb_sub_backup_folder.Text = "Backup Sub Folder Name";
            // 
            // rtb_list_files
            // 
            this.rtb_list_files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_list_files.BackColor = System.Drawing.SystemColors.Window;
            this.rtb_list_files.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_list_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rtb_list_files.Location = new System.Drawing.Point(6, 69);
            this.rtb_list_files.Name = "rtb_list_files";
            this.rtb_list_files.Size = new System.Drawing.Size(452, 94);
            this.rtb_list_files.TabIndex = 15;
            this.rtb_list_files.Text = "";
            this.rtb_list_files.WordWrap = false;
            this.rtb_list_files.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtb_list_files_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.rtb_unused_files);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.chkUnicode);
            this.groupBox4.Controls.Add(this.btn_clean);
            this.groupBox4.Controls.Add(this.btnReadFolder);
            this.groupBox4.Controls.Add(this.btn_replace);
            this.groupBox4.Controls.Add(this.tb_text2);
            this.groupBox4.Controls.Add(this.tb_text1);
            this.groupBox4.Controls.Add(this.btnLoadFile);
            this.groupBox4.Controls.Add(this.rtb_list_files);
            this.groupBox4.Location = new System.Drawing.Point(369, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(464, 241);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "List Files For Deployment";
            // 
            // rtb_unused_files
            // 
            this.rtb_unused_files.Location = new System.Drawing.Point(6, 186);
            this.rtb_unused_files.Name = "rtb_unused_files";
            this.rtb_unused_files.Size = new System.Drawing.Size(452, 47);
            this.rtb_unused_files.TabIndex = 18;
            this.rtb_unused_files.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Unused Files";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Deployment Files";
            // 
            // chkUnicode
            // 
            this.chkUnicode.AutoSize = true;
            this.chkUnicode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkUnicode.Location = new System.Drawing.Point(68, 23);
            this.chkUnicode.Name = "chkUnicode";
            this.chkUnicode.Size = new System.Drawing.Size(85, 17);
            this.chkUnicode.TabIndex = 10;
            this.chkUnicode.Text = "Use Unicode";
            this.chkUnicode.UseVisualStyleBackColor = true;
            // 
            // btn_clean
            // 
            this.btn_clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clean.Image = ((System.Drawing.Image)(resources.GetObject("btn_clean.Image")));
            this.btn_clean.Location = new System.Drawing.Point(433, 19);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(25, 25);
            this.btn_clean.TabIndex = 14;
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btnReadFolder
            // 
            this.btnReadFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnReadFolder.Image")));
            this.btnReadFolder.Location = new System.Drawing.Point(37, 19);
            this.btnReadFolder.Name = "btnReadFolder";
            this.btnReadFolder.Size = new System.Drawing.Size(25, 25);
            this.btnReadFolder.TabIndex = 9;
            this.btnReadFolder.UseVisualStyleBackColor = true;
            this.btnReadFolder.Click += new System.EventHandler(this.btnReadFolder_Click);
            // 
            // btn_replace
            // 
            this.btn_replace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_replace.Image = ((System.Drawing.Image)(resources.GetObject("btn_replace.Image")));
            this.btn_replace.Location = new System.Drawing.Point(402, 19);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(25, 25);
            this.btn_replace.TabIndex = 13;
            this.btn_replace.UseVisualStyleBackColor = true;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // tb_text2
            // 
            this.tb_text2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_text2.Location = new System.Drawing.Point(278, 21);
            this.tb_text2.Name = "tb_text2";
            this.tb_text2.Size = new System.Drawing.Size(119, 20);
            this.tb_text2.TabIndex = 12;
            // 
            // tb_text1
            // 
            this.tb_text1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_text1.Location = new System.Drawing.Point(153, 21);
            this.tb_text1.Name = "tb_text1";
            this.tb_text1.Size = new System.Drawing.Size(119, 20);
            this.tb_text1.TabIndex = 11;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFile.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadFile.Image")));
            this.btnLoadFile.Location = new System.Drawing.Point(6, 19);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(25, 25);
            this.btnLoadFile.TabIndex = 8;
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Generate.Image = ((System.Drawing.Image)(resources.GetObject("btn_Generate.Image")));
            this.btn_Generate.Location = new System.Drawing.Point(369, 280);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(140, 52);
            this.btn_Generate.TabIndex = 16;
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // btn_run_backup
            // 
            this.btn_run_backup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run_backup.Location = new System.Drawing.Point(516, 280);
            this.btn_run_backup.Name = "btn_run_backup";
            this.btn_run_backup.Size = new System.Drawing.Size(152, 23);
            this.btn_run_backup.TabIndex = 17;
            this.btn_run_backup.Text = "1. Run Backup";
            this.btn_run_backup.UseVisualStyleBackColor = true;
            this.btn_run_backup.Click += new System.EventHandler(this.btn_run_backup_Click);
            // 
            // btn_run_deploy
            // 
            this.btn_run_deploy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run_deploy.Location = new System.Drawing.Point(517, 309);
            this.btn_run_deploy.Name = "btn_run_deploy";
            this.btn_run_deploy.Size = new System.Drawing.Size(152, 23);
            this.btn_run_deploy.TabIndex = 19;
            this.btn_run_deploy.Text = "3. Run Deploy";
            this.btn_run_deploy.UseVisualStyleBackColor = true;
            this.btn_run_deploy.Click += new System.EventHandler(this.btn_run_deploy_Click);
            // 
            // btn_run_rollback
            // 
            this.btn_run_rollback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run_rollback.Location = new System.Drawing.Point(675, 309);
            this.btn_run_rollback.Name = "btn_run_rollback";
            this.btn_run_rollback.Size = new System.Drawing.Size(152, 23);
            this.btn_run_rollback.TabIndex = 20;
            this.btn_run_rollback.Text = "4. Run Rollback";
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
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMerge,
            this.toolStripSeparator1,
            this.btnExitMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // btnMerge
            // 
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(117, 22);
            this.btnMerge.Text = "&Merge...";
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // btnExitMenu
            // 
            this.btnExitMenu.Name = "btnExitMenu";
            this.btnExitMenu.Size = new System.Drawing.Size(117, 22);
            this.btnExitMenu.Text = "E&xit";
            this.btnExitMenu.Click += new System.EventHandler(this.btnExitMenu_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDeploymentFlow,
            this.menuAbout});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "&Help";
            // 
            // menuDeploymentFlow
            // 
            this.menuDeploymentFlow.Name = "menuDeploymentFlow";
            this.menuDeploymentFlow.Size = new System.Drawing.Size(165, 22);
            this.menuDeploymentFlow.Text = "&Deployment Rule";
            this.menuDeploymentFlow.Click += new System.EventHandler(this.menuDeploymentFlow_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(165, 22);
            this.menuAbout.Text = "&About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Location = new System.Drawing.Point(0, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 220);
            this.panel1.TabIndex = 11;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnOpen);
            this.groupBox5.Controls.Add(this.rtb_release_note);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Location = new System.Drawing.Point(12, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(821, 208);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Create Release Note";
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.Location = new System.Drawing.Point(740, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 25);
            this.btnOpen.TabIndex = 22;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // rtb_release_note
            // 
            this.rtb_release_note.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_release_note.BackColor = System.Drawing.SystemColors.Window;
            this.rtb_release_note.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_release_note.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_release_note.Location = new System.Drawing.Point(6, 19);
            this.rtb_release_note.Name = "rtb_release_note";
            this.rtb_release_note.Size = new System.Drawing.Size(728, 183);
            this.rtb_release_note.TabIndex = 21;
            this.rtb_release_note.Text = "";
            this.rtb_release_note.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtb_release_note_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(740, 48);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 23;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grResource
            // 
            this.grResource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grResource.Controls.Add(this.cb_deployment_path);
            this.grResource.Controls.Add(this.btnBrowserDeployment);
            this.grResource.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grResource.Location = new System.Drawing.Point(12, 93);
            this.grResource.Name = "grResource";
            this.grResource.Size = new System.Drawing.Size(351, 55);
            this.grResource.TabIndex = 2;
            this.grResource.TabStop = false;
            this.grResource.Text = "Deployment Resource Section";
            // 
            // cb_deployment_path
            // 
            this.cb_deployment_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_deployment_path.FormattingEnabled = true;
            this.cb_deployment_path.Location = new System.Drawing.Point(95, 23);
            this.cb_deployment_path.Name = "cb_deployment_path";
            this.cb_deployment_path.Size = new System.Drawing.Size(246, 21);
            this.cb_deployment_path.TabIndex = 2;
            this.cb_deployment_path.Leave += new System.EventHandler(this.cb_deployment_path_Leave);
            this.cb_deployment_path.MouseHover += new System.EventHandler(this.cb_deployment_path_MouseHover);
            // 
            // btnBrowserDeployment
            // 
            this.btnBrowserDeployment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowserDeployment.AutoSize = true;
            this.btnBrowserDeployment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBrowserDeployment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowserDeployment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBrowserDeployment.Location = new System.Drawing.Point(6, 27);
            this.btnBrowserDeployment.Name = "btnBrowserDeployment";
            this.btnBrowserDeployment.Size = new System.Drawing.Size(80, 15);
            this.btnBrowserDeployment.TabIndex = 0;
            this.btnBrowserDeployment.Text = "Resource Path";
            this.btnBrowserDeployment.Click += new System.EventHandler(this.btnBrowserDeployment_Click);
            // 
            // btn_run_pre_deploy
            // 
            this.btn_run_pre_deploy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run_pre_deploy.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_run_pre_deploy.Location = new System.Drawing.Point(675, 280);
            this.btn_run_pre_deploy.Name = "btn_run_pre_deploy";
            this.btn_run_pre_deploy.Size = new System.Drawing.Size(152, 23);
            this.btn_run_pre_deploy.TabIndex = 18;
            this.btn_run_pre_deploy.Text = "2. Pre-Deployment";
            this.btn_run_pre_deploy.UseVisualStyleBackColor = true;
            this.btn_run_pre_deploy.Click += new System.EventHandler(this.btn_run_pre_deploy_Click);
            // 
            // btn_collapse
            // 
            this.btn_collapse.AutoSize = true;
            this.btn_collapse.BackColor = System.Drawing.Color.Transparent;
            this.btn_collapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_collapse.Location = new System.Drawing.Point(9, 335);
            this.btn_collapse.Name = "btn_collapse";
            this.btn_collapse.Size = new System.Drawing.Size(19, 13);
            this.btn_collapse.TabIndex = 13;
            this.btn_collapse.Text = "▼";
            this.btn_collapse.Click += new System.EventHandler(this.btn_collapse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(814, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(850, 580);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_collapse);
            this.Controls.Add(this.btn_run_pre_deploy);
            this.Controls.Add(this.grResource);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_run_rollback);
            this.Controls.Add(this.btn_run_deploy);
            this.Controls.Add(this.btn_run_backup);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grBackup);
            this.Controls.Add(this.grProduction);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prepare For Deployment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grProduction.ResumeLayout(false);
            this.grProduction.PerformLayout();
            this.grBackup.ResumeLayout(false);
            this.grBackup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.grResource.ResumeLayout(false);
            this.grResource.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grProduction;
        private System.Windows.Forms.Label btnBrowserProduction;
        private System.Windows.Forms.GroupBox grBackup;
        private System.Windows.Forms.DateTimePicker dtpk_cur_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_backup_path;
        private System.Windows.Forms.Label btnBrowserBackup;
        private System.Windows.Forms.DateTimePicker dtpk_cur_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_sub_deploy_folder;
        private System.Windows.Forms.Label lb_tb_sub_deploy_folder;
        private System.Windows.Forms.TextBox tb_sub_backup_folder;
        private System.Windows.Forms.Label lb_tb_sub_backup_folder;
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
        private System.Windows.Forms.ToolStripMenuItem btnExitMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDeploymentFlow;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtb_release_note;
        private System.Windows.Forms.Button btnReadFolder;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox grResource;
        private System.Windows.Forms.ComboBox cb_deployment_path;
        private System.Windows.Forms.Label btnBrowserDeployment;
        private System.Windows.Forms.Button btn_run_pre_deploy;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Label btn_collapse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkUnicode;
        private System.Windows.Forms.ToolStripMenuItem btnMerge;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RichTextBox rtb_unused_files;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

