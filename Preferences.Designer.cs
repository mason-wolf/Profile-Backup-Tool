namespace ProfileBackupTool
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FolderContainer = new System.Windows.Forms.GroupBox();
            this.MusicOption = new System.Windows.Forms.CheckBox();
            this.PicturesOption = new System.Windows.Forms.CheckBox();
            this.FavoritesOption = new System.Windows.Forms.CheckBox();
            this.DownloadsOption = new System.Windows.Forms.CheckBox();
            this.DocumentsOption = new System.Windows.Forms.CheckBox();
            this.DesktopOption = new System.Windows.Forms.CheckBox();
            this.CopyAllOption = new System.Windows.Forms.CheckBox();
            this.CustomDirectoryOption = new System.Windows.Forms.CheckBox();
            this.SetDefaultDirectoriesButton = new System.Windows.Forms.Button();
            this.DestinationDirectoryField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ApplyDirectoriesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BackupDirectoryField = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ForceUserLogoffOption = new System.Windows.Forms.CheckBox();
            this.ShowErrorsOption = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yyyy = new System.Windows.Forms.TextBox();
            this.dd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mm = new System.Windows.Forms.TextBox();
            this.ApplyTransferSettingsButton = new System.Windows.Forms.Button();
            this.CalculateProfileSizesOption = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.FolderContainer.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(436, 367);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FolderContainer);
            this.tabPage1.Controls.Add(this.CopyAllOption);
            this.tabPage1.Controls.Add(this.CustomDirectoryOption);
            this.tabPage1.Controls.Add(this.SetDefaultDirectoriesButton);
            this.tabPage1.Controls.Add(this.DestinationDirectoryField);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ApplyDirectoriesButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.BackupDirectoryField);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(428, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Directories";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FolderContainer
            // 
            this.FolderContainer.Controls.Add(this.MusicOption);
            this.FolderContainer.Controls.Add(this.PicturesOption);
            this.FolderContainer.Controls.Add(this.FavoritesOption);
            this.FolderContainer.Controls.Add(this.DownloadsOption);
            this.FolderContainer.Controls.Add(this.DocumentsOption);
            this.FolderContainer.Controls.Add(this.DesktopOption);
            this.FolderContainer.Location = new System.Drawing.Point(13, 113);
            this.FolderContainer.Name = "FolderContainer";
            this.FolderContainer.Size = new System.Drawing.Size(155, 169);
            this.FolderContainer.TabIndex = 13;
            this.FolderContainer.TabStop = false;
            this.FolderContainer.Text = "Folders";
            // 
            // MusicOption
            // 
            this.MusicOption.AutoSize = true;
            this.MusicOption.Checked = true;
            this.MusicOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MusicOption.Location = new System.Drawing.Point(35, 134);
            this.MusicOption.Name = "MusicOption";
            this.MusicOption.Size = new System.Drawing.Size(54, 17);
            this.MusicOption.TabIndex = 17;
            this.MusicOption.Text = "Music";
            this.MusicOption.UseVisualStyleBackColor = true;
            this.MusicOption.CheckedChanged += new System.EventHandler(this.MusicOption_CheckedChanged);
            // 
            // PicturesOption
            // 
            this.PicturesOption.AutoSize = true;
            this.PicturesOption.Checked = true;
            this.PicturesOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PicturesOption.Location = new System.Drawing.Point(35, 111);
            this.PicturesOption.Name = "PicturesOption";
            this.PicturesOption.Size = new System.Drawing.Size(64, 17);
            this.PicturesOption.TabIndex = 13;
            this.PicturesOption.Text = "Pictures";
            this.PicturesOption.UseVisualStyleBackColor = true;
            this.PicturesOption.CheckedChanged += new System.EventHandler(this.PicturesOption_CheckedChanged);
            // 
            // FavoritesOption
            // 
            this.FavoritesOption.AutoSize = true;
            this.FavoritesOption.Checked = true;
            this.FavoritesOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FavoritesOption.Location = new System.Drawing.Point(35, 88);
            this.FavoritesOption.Name = "FavoritesOption";
            this.FavoritesOption.Size = new System.Drawing.Size(69, 17);
            this.FavoritesOption.TabIndex = 16;
            this.FavoritesOption.Text = "Favorites";
            this.FavoritesOption.UseVisualStyleBackColor = true;
            this.FavoritesOption.CheckedChanged += new System.EventHandler(this.FavoritesOption_CheckedChanged);
            // 
            // DownloadsOption
            // 
            this.DownloadsOption.AutoSize = true;
            this.DownloadsOption.Checked = true;
            this.DownloadsOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DownloadsOption.Location = new System.Drawing.Point(35, 65);
            this.DownloadsOption.Name = "DownloadsOption";
            this.DownloadsOption.Size = new System.Drawing.Size(79, 17);
            this.DownloadsOption.TabIndex = 15;
            this.DownloadsOption.Text = "Downloads";
            this.DownloadsOption.UseVisualStyleBackColor = true;
            this.DownloadsOption.CheckedChanged += new System.EventHandler(this.DownloadsOption_CheckedChanged);
            // 
            // DocumentsOption
            // 
            this.DocumentsOption.AutoSize = true;
            this.DocumentsOption.Checked = true;
            this.DocumentsOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DocumentsOption.Location = new System.Drawing.Point(35, 42);
            this.DocumentsOption.Name = "DocumentsOption";
            this.DocumentsOption.Size = new System.Drawing.Size(80, 17);
            this.DocumentsOption.TabIndex = 14;
            this.DocumentsOption.Text = "Documents";
            this.DocumentsOption.UseVisualStyleBackColor = true;
            this.DocumentsOption.CheckedChanged += new System.EventHandler(this.DocumentsOption_CheckedChanged);
            // 
            // DesktopOption
            // 
            this.DesktopOption.AutoSize = true;
            this.DesktopOption.Checked = true;
            this.DesktopOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DesktopOption.Location = new System.Drawing.Point(35, 19);
            this.DesktopOption.Name = "DesktopOption";
            this.DesktopOption.Size = new System.Drawing.Size(66, 17);
            this.DesktopOption.TabIndex = 13;
            this.DesktopOption.Text = "Desktop";
            this.DesktopOption.UseVisualStyleBackColor = true;
            this.DesktopOption.CheckedChanged += new System.EventHandler(this.DesktopOption_CheckedChanged);
            // 
            // CopyAllOption
            // 
            this.CopyAllOption.AutoSize = true;
            this.CopyAllOption.Location = new System.Drawing.Point(229, 155);
            this.CopyAllOption.Name = "CopyAllOption";
            this.CopyAllOption.Size = new System.Drawing.Size(64, 17);
            this.CopyAllOption.TabIndex = 12;
            this.CopyAllOption.Text = "Copy All";
            this.CopyAllOption.UseVisualStyleBackColor = true;
            this.CopyAllOption.CheckedChanged += new System.EventHandler(this.CopyAllOption_CheckedChanged);
            // 
            // CustomDirectoryOption
            // 
            this.CustomDirectoryOption.AutoSize = true;
            this.CustomDirectoryOption.Checked = true;
            this.CustomDirectoryOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CustomDirectoryOption.Location = new System.Drawing.Point(229, 113);
            this.CustomDirectoryOption.Name = "CustomDirectoryOption";
            this.CustomDirectoryOption.Size = new System.Drawing.Size(172, 17);
            this.CustomDirectoryOption.TabIndex = 7;
            this.CustomDirectoryOption.Text = "Create directory for each target";
            this.CustomDirectoryOption.UseVisualStyleBackColor = true;
            this.CustomDirectoryOption.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SetDefaultDirectoriesButton
            // 
            this.SetDefaultDirectoriesButton.Location = new System.Drawing.Point(229, 302);
            this.SetDefaultDirectoriesButton.Name = "SetDefaultDirectoriesButton";
            this.SetDefaultDirectoriesButton.Size = new System.Drawing.Size(75, 23);
            this.SetDefaultDirectoriesButton.TabIndex = 6;
            this.SetDefaultDirectoriesButton.Text = "Default";
            this.SetDefaultDirectoriesButton.UseVisualStyleBackColor = true;
            this.SetDefaultDirectoriesButton.Click += new System.EventHandler(this.SetDefaultDirectoriesButton_Click);
            // 
            // DestinationDirectoryField
            // 
            this.DestinationDirectoryField.Enabled = false;
            this.DestinationDirectoryField.Location = new System.Drawing.Point(174, 68);
            this.DestinationDirectoryField.Name = "DestinationDirectoryField";
            this.DestinationDirectoryField.Size = new System.Drawing.Size(227, 20);
            this.DestinationDirectoryField.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Backup Source Directory:";
            // 
            // ApplyDirectoriesButton
            // 
            this.ApplyDirectoriesButton.Location = new System.Drawing.Point(326, 302);
            this.ApplyDirectoriesButton.Name = "ApplyDirectoriesButton";
            this.ApplyDirectoriesButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyDirectoriesButton.TabIndex = 2;
            this.ApplyDirectoriesButton.Text = "Apply";
            this.ApplyDirectoriesButton.UseVisualStyleBackColor = true;
            this.ApplyDirectoriesButton.Click += new System.EventHandler(this.ApplyDirectoriesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Custom Destination Directory:";
            // 
            // BackupDirectoryField
            // 
            this.BackupDirectoryField.Location = new System.Drawing.Point(174, 27);
            this.BackupDirectoryField.Name = "BackupDirectoryField";
            this.BackupDirectoryField.Size = new System.Drawing.Size(227, 20);
            this.BackupDirectoryField.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ForceUserLogoffOption);
            this.tabPage2.Controls.Add(this.ShowErrorsOption);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.yyyy);
            this.tabPage2.Controls.Add(this.dd);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.mm);
            this.tabPage2.Controls.Add(this.ApplyTransferSettingsButton);
            this.tabPage2.Controls.Add(this.CalculateProfileSizesOption);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(428, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transfers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ForceUserLogoffOption
            // 
            this.ForceUserLogoffOption.AutoSize = true;
            this.ForceUserLogoffOption.Location = new System.Drawing.Point(22, 126);
            this.ForceUserLogoffOption.Name = "ForceUserLogoffOption";
            this.ForceUserLogoffOption.Size = new System.Drawing.Size(105, 17);
            this.ForceUserLogoffOption.TabIndex = 9;
            this.ForceUserLogoffOption.Text = "Force user logoff";
            this.ForceUserLogoffOption.UseVisualStyleBackColor = true;
            this.ForceUserLogoffOption.CheckedChanged += new System.EventHandler(this.ForceUserLogoffOption_CheckedChanged);
            // 
            // ShowErrorsOption
            // 
            this.ShowErrorsOption.AutoSize = true;
            this.ShowErrorsOption.Location = new System.Drawing.Point(22, 75);
            this.ShowErrorsOption.Name = "ShowErrorsOption";
            this.ShowErrorsOption.Size = new System.Drawing.Size(82, 17);
            this.ShowErrorsOption.TabIndex = 8;
            this.ShowErrorsOption.Text = "Show errors";
            this.ShowErrorsOption.UseVisualStyleBackColor = true;
            this.ShowErrorsOption.CheckedChanged += new System.EventHandler(this.ShowErrorsOption_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "mm-dd-yyyy";
            // 
            // yyyy
            // 
            this.yyyy.Location = new System.Drawing.Point(214, 177);
            this.yyyy.MaxLength = 4;
            this.yyyy.Name = "yyyy";
            this.yyyy.Size = new System.Drawing.Size(38, 20);
            this.yyyy.TabIndex = 6;
            // 
            // dd
            // 
            this.dd.Location = new System.Drawing.Point(187, 177);
            this.dd.MaxLength = 2;
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(21, 20);
            this.dd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Transfer files no older than:";
            // 
            // mm
            // 
            this.mm.Location = new System.Drawing.Point(160, 177);
            this.mm.MaxLength = 2;
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(21, 20);
            this.mm.TabIndex = 3;
            // 
            // ApplyTransferSettingsButton
            // 
            this.ApplyTransferSettingsButton.Location = new System.Drawing.Point(332, 301);
            this.ApplyTransferSettingsButton.Name = "ApplyTransferSettingsButton";
            this.ApplyTransferSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyTransferSettingsButton.TabIndex = 2;
            this.ApplyTransferSettingsButton.Text = "Apply";
            this.ApplyTransferSettingsButton.UseVisualStyleBackColor = true;
            this.ApplyTransferSettingsButton.Click += new System.EventHandler(this.ApplyTransferSettingsButton_Click);
            // 
            // CalculateProfileSizesOption
            // 
            this.CalculateProfileSizesOption.AutoSize = true;
            this.CalculateProfileSizesOption.Checked = true;
            this.CalculateProfileSizesOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CalculateProfileSizesOption.Location = new System.Drawing.Point(22, 24);
            this.CalculateProfileSizesOption.Name = "CalculateProfileSizesOption";
            this.CalculateProfileSizesOption.Size = new System.Drawing.Size(127, 17);
            this.CalculateProfileSizesOption.TabIndex = 0;
            this.CalculateProfileSizesOption.Text = "Calculate profile sizes";
            this.CalculateProfileSizesOption.UseVisualStyleBackColor = true;
            this.CalculateProfileSizesOption.CheckedChanged += new System.EventHandler(this.CalculateProfileSizesOption_CheckedChanged);
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 392);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Preferences";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.FolderContainer.ResumeLayout(false);
            this.FolderContainer.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button SetDefaultDirectoriesButton;
        private System.Windows.Forms.TextBox DestinationDirectoryField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ApplyDirectoriesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BackupDirectoryField;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ApplyTransferSettingsButton;
        private System.Windows.Forms.CheckBox CalculateProfileSizesOption;
        private System.Windows.Forms.CheckBox CustomDirectoryOption;
        private System.Windows.Forms.CheckBox CopyAllOption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yyyy;
        private System.Windows.Forms.TextBox dd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mm;
        private System.Windows.Forms.CheckBox ShowErrorsOption;
        private System.Windows.Forms.CheckBox ForceUserLogoffOption;
        private System.Windows.Forms.GroupBox FolderContainer;
        private System.Windows.Forms.CheckBox PicturesOption;
        private System.Windows.Forms.CheckBox FavoritesOption;
        private System.Windows.Forms.CheckBox DownloadsOption;
        private System.Windows.Forms.CheckBox DocumentsOption;
        private System.Windows.Forms.CheckBox DesktopOption;
        private System.Windows.Forms.CheckBox MusicOption;
    }
}