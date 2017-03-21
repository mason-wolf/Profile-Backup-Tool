﻿namespace ProfileBackupTool
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
            this.SetDefaultDirectoriesButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DestinationDirectoryField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ApplyDirectoriesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BackupDirectoryField = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ApplyTransferSettingsButton = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.CalculateProfileSizesOption = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(436, 208);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SetDefaultDirectoriesButton);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.DestinationDirectoryField);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ApplyDirectoriesButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.BackupDirectoryField);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(428, 182);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Directories";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SetDefaultDirectoriesButton
            // 
            this.SetDefaultDirectoriesButton.Location = new System.Drawing.Point(234, 138);
            this.SetDefaultDirectoriesButton.Name = "SetDefaultDirectoriesButton";
            this.SetDefaultDirectoriesButton.Size = new System.Drawing.Size(75, 23);
            this.SetDefaultDirectoriesButton.TabIndex = 6;
            this.SetDefaultDirectoriesButton.Text = "Default";
            this.SetDefaultDirectoriesButton.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(277, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Use Computer Name";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // DestinationDirectoryField
            // 
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
            this.ApplyDirectoriesButton.Location = new System.Drawing.Point(326, 138);
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
            this.label1.Location = new System.Drawing.Point(48, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destination Directory:";
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
            this.tabPage2.Controls.Add(this.ApplyTransferSettingsButton);
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.CalculateProfileSizesOption);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(428, 182);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transfer Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ApplyTransferSettingsButton
            // 
            this.ApplyTransferSettingsButton.Location = new System.Drawing.Point(347, 141);
            this.ApplyTransferSettingsButton.Name = "ApplyTransferSettingsButton";
            this.ApplyTransferSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyTransferSettingsButton.TabIndex = 2;
            this.ApplyTransferSettingsButton.Text = "Apply";
            this.ApplyTransferSettingsButton.UseVisualStyleBackColor = true;
            this.ApplyTransferSettingsButton.Click += new System.EventHandler(this.ApplyTransferSettingsButton_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(22, 60);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(105, 17);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Force user logoff";
            this.checkBox3.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(470, 234);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Preferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button SetDefaultDirectoriesButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox DestinationDirectoryField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ApplyDirectoriesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BackupDirectoryField;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button ApplyTransferSettingsButton;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox CalculateProfileSizesOption;
    }
}