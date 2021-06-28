namespace AESxWin
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.gbPaths = new System.Windows.Forms.GroupBox();
            this.btnRemovePath = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.lstPaths = new System.Windows.Forms.ListBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstExts = new System.Windows.Forms.ComboBox();
            this.chkSubFolders = new System.Windows.Forms.CheckBox();
            this.chkDeleteOrg = new System.Windows.Forms.CheckBox();
            this.gbPassword = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gbPaths.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbPassword.SuspendLayout();
            this.gbLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPaths
            // 
            this.gbPaths.Controls.Add(this.btnRemovePath);
            this.gbPaths.Controls.Add(this.btnAddFolder);
            this.gbPaths.Controls.Add(this.btnAddFile);
            this.gbPaths.Controls.Add(this.lstPaths);
            this.gbPaths.Location = new System.Drawing.Point(12, 11);
            this.gbPaths.Name = "gbPaths";
            this.gbPaths.Size = new System.Drawing.Size(648, 227);
            this.gbPaths.TabIndex = 0;
            this.gbPaths.TabStop = false;
            this.gbPaths.Text = "列表";
            // 
            // btnRemovePath
            // 
            this.btnRemovePath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemovePath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRemovePath.Location = new System.Drawing.Point(541, 188);
            this.btnRemovePath.Name = "btnRemovePath";
            this.btnRemovePath.Size = new System.Drawing.Size(91, 33);
            this.btnRemovePath.TabIndex = 3;
            this.btnRemovePath.Text = "移除";
            this.btnRemovePath.UseVisualStyleBackColor = false;
            this.btnRemovePath.Click += new System.EventHandler(this.btnRemovePath_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddFolder.Location = new System.Drawing.Point(144, 188);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(125, 33);
            this.btnAddFolder.TabIndex = 2;
            this.btnAddFolder.Text = "添加文件夹";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddFile.Location = new System.Drawing.Point(0, 188);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(125, 33);
            this.btnAddFile.TabIndex = 1;
            this.btnAddFile.Text = "添加文件";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // lstPaths
            // 
            this.lstPaths.AllowDrop = true;
            this.lstPaths.FormattingEnabled = true;
            this.lstPaths.HorizontalScrollbar = true;
            this.lstPaths.ItemHeight = 12;
            this.lstPaths.Location = new System.Drawing.Point(6, 18);
            this.lstPaths.Name = "lstPaths";
            this.lstPaths.Size = new System.Drawing.Size(636, 160);
            this.lstPaths.TabIndex = 0;
            this.lstPaths.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstPaths_DragDrop);
            this.lstPaths.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstPaths_DragEnter);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.label1);
            this.gbOptions.Controls.Add(this.lstExts);
            this.gbOptions.Controls.Add(this.chkSubFolders);
            this.gbOptions.Controls.Add(this.chkDeleteOrg);
            this.gbOptions.Location = new System.Drawing.Point(12, 244);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(652, 64);
            this.gbOptions.TabIndex = 1;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "设置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "文件类型:";
            // 
            // lstExts
            // 
            this.lstExts.FormattingEnabled = true;
            this.lstExts.Items.AddRange(new object[] {
            "(Images) jpg jpeg png gif bmp",
            "(Videos) avi flv mov mp4 mpg rm rmvb mkv swf vob wmv 3g2 3gp asf ogv",
            "(Audio) mp3 wav acc ogg amr wma",
            "(Documents) pdf txt rtf doc docx ppt pptx xls xlsx",
            "(Compresed) zip rar 7z tar gzip",
            "(Code) cs vb java py rb cpp html css js",
            "(All Files)"});
            this.lstExts.Location = new System.Drawing.Point(351, 14);
            this.lstExts.Name = "lstExts";
            this.lstExts.Size = new System.Drawing.Size(295, 20);
            this.lstExts.TabIndex = 2;
            this.lstExts.SelectedIndexChanged += new System.EventHandler(this.lstExts_SelectedIndexChanged);
            // 
            // chkSubFolders
            // 
            this.chkSubFolders.AutoSize = true;
            this.chkSubFolders.Location = new System.Drawing.Point(6, 39);
            this.chkSubFolders.Name = "chkSubFolders";
            this.chkSubFolders.Size = new System.Drawing.Size(132, 16);
            this.chkSubFolders.TabIndex = 1;
            this.chkSubFolders.Text = "包含路径下的文件夹";
            this.chkSubFolders.UseVisualStyleBackColor = true;
            // 
            // chkDeleteOrg
            // 
            this.chkDeleteOrg.AutoSize = true;
            this.chkDeleteOrg.Location = new System.Drawing.Point(7, 18);
            this.chkDeleteOrg.Name = "chkDeleteOrg";
            this.chkDeleteOrg.Size = new System.Drawing.Size(84, 16);
            this.chkDeleteOrg.TabIndex = 0;
            this.chkDeleteOrg.Text = "删除源文件";
            this.chkDeleteOrg.UseVisualStyleBackColor = true;
            // 
            // gbPassword
            // 
            this.gbPassword.Controls.Add(this.button2);
            this.gbPassword.Controls.Add(this.txtPassword);
            this.gbPassword.Controls.Add(this.btnDecrypt);
            this.gbPassword.Controls.Add(this.btnEncrypt);
            this.gbPassword.Location = new System.Drawing.Point(17, 323);
            this.gbPassword.Name = "gbPassword";
            this.gbPassword.Size = new System.Drawing.Size(649, 98);
            this.gbPassword.TabIndex = 2;
            this.gbPassword.TabStop = false;
            this.gbPassword.Text = "密码";
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(3, 17);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(643, 27);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEncrypt.Location = new System.Drawing.Point(366, 67);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(123, 31);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "加密";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDecrypt.Location = new System.Drawing.Point(524, 67);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(125, 31);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "解密";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // gbLog
            // 
            this.gbLog.Controls.Add(this.txtLog);
            this.gbLog.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbLog.Location = new System.Drawing.Point(12, 427);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(652, 217);
            this.gbLog.TabIndex = 6;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "日志";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 22);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(646, 192);
            this.txtLog.TabIndex = 0;
            this.txtLog.WordWrap = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(6, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "生成随机密码";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 658);
            this.Controls.Add(this.gbLog);
            this.Controls.Add(this.gbPassword);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbPaths);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文档加密";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.gbPaths.ResumeLayout(false);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.gbPassword.ResumeLayout(false);
            this.gbPassword.PerformLayout();
            this.gbLog.ResumeLayout(false);
            this.gbLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPaths;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.ListBox lstPaths;
        private System.Windows.Forms.Button btnRemovePath;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.CheckBox chkSubFolders;
        private System.Windows.Forms.CheckBox chkDeleteOrg;
        private System.Windows.Forms.GroupBox gbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.ComboBox lstExts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button button2;
    }
}

