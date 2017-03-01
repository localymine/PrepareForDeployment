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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpk_cur_time = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpk_cur_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_backup_path = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_sub_deploy_folder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_sub_backup_folder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rtb_list_files = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_load_file = new System.Windows.Forms.Button();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_production_path);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
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
            this.cb_production_path.Text = "C:\\GTL\\WEB_APP\\GMAWEB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Production Path";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpk_cur_time);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpk_cur_date);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cb_backup_path);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 86);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backup Section";
            // 
            // dtpk_cur_time
            // 
            this.dtpk_cur_time.CustomFormat = "HH:mm";
            this.dtpk_cur_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
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
            this.cb_backup_path.Text = "F:\\Backup_Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Backup Path";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_sub_deploy_folder);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tb_sub_backup_folder);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 165);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rtb_list_files
            // 
            this.rtb_list_files.Location = new System.Drawing.Point(6, 51);
            this.rtb_list_files.Name = "rtb_list_files";
            this.rtb_list_files.ShortcutsEnabled = false;
            this.rtb_list_files.Size = new System.Drawing.Size(452, 142);
            this.rtb_list_files.TabIndex = 4;
            this.rtb_list_files.Text = resources.GetString("rtb_list_files.Text");
            this.rtb_list_files.WordWrap = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_load_file);
            this.groupBox4.Controls.Add(this.rtb_list_files);
            this.groupBox4.Location = new System.Drawing.Point(285, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(464, 199);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "List Files For Deployment";
            // 
            // btn_load_file
            // 
            this.btn_load_file.Location = new System.Drawing.Point(6, 22);
            this.btn_load_file.Name = "btn_load_file";
            this.btn_load_file.Size = new System.Drawing.Size(120, 23);
            this.btn_load_file.TabIndex = 5;
            this.btn_load_file.Text = "Load List From File";
            this.btn_load_file.UseVisualStyleBackColor = true;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(291, 218);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(140, 33);
            this.btn_Generate.TabIndex = 6;
            this.btn_Generate.Text = "Generate Executable Files";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "1. Run Backup";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(546, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "2. Run Deploy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(653, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "3. Run Rollback";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 260);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prepare For Deployment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpk_cur_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_backup_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpk_cur_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_sub_deploy_folder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_sub_backup_folder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox rtb_list_files;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_load_file;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.ComboBox cb_production_path;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

