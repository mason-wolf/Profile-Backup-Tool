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
            this.ExclusionField = new System.Windows.Forms.TextBox();
            this.CopyAllOption = new System.Windows.Forms.CheckBox();
            this.RemoveExclusionButton = new System.Windows.Forms.Button();
            this.AddExclusionButton = new System.Windows.Forms.Button();
            this.ExclusionsLabel = new System.Windows.Forms.Label();
            this.ExclusionsList = new System.Windows.Forms.ListBox();
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
            this.year = new System.Windows.Forms.TextBox();
            this.dd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mm = new System.Windows.Forms.TextBox();
            this.ApplyTransferSettingsButton = new System.Windows.Forms.Button();
            this.CalculateProfileSizesOption = new System.Windows.Forms.CheckBox();
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
            this.tabControl1.Size = new System.Drawing.Size(436, 367);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ExclusionField);
            this.tabPage1.Controls.Add(this.CopyAllOption);
            this.tabPage1.Controls.Add(this.RemoveExclusionButton);
            this.tabPage1.Controls.Add(this.AddExclusionButton);
            this.tabPage1.Controls.Add(this.ExclusionsLabel);
            this.tabPage1.Controls.Add(this.ExclusionsList);
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
            // ExclusionField
            // 
            this.ExclusionField.Location = new System.Drawing.Point(226, 205);
            this.ExclusionField.Name = "ExclusionField";
            this.ExclusionField.Size = new System.Drawing.Size(175, 20);
            this.ExclusionField.TabIndex = 13;
            // 
            // CopyAllOption
            // 
            this.CopyAllOption.AutoSize = true;
            this.CopyAllOption.Location = new System.Drawing.Point(238, 139);
            this.CopyAllOption.Name = "CopyAllOption";
            this.CopyAllOption.Size = new System.Drawing.Size(64, 17);
            this.CopyAllOption.TabIndex = 12;
            this.CopyAllOption.Text = "Copy All";
            this.CopyAllOption.UseVisualStyleBackColor = true;
            this.CopyAllOption.CheckedChanged += new System.EventHandler(this.CopyAllOption_CheckedChanged);
            // 
            // RemoveExclusionButton
            // 
            this.RemoveExclusionButton.Location = new System.Drawing.Point(275, 231);
            this.RemoveExclusionButton.Name = "RemoveExclusionButton";
            this.RemoveExclusionButton.Size = new System.Drawing.Size(59, 23);
            this.RemoveExclusionButton.TabIndex = 11;
            this.RemoveExclusionButton.Text = "Remove";
            this.RemoveExclusionButton.UseVisualStyleBackColor = true;
            this.RemoveExclusionButton.Click += new System.EventHandler(this.RemoveExclusionButton_Click);
            // 
            // AddExclusionButton
            // 
            this.AddExclusionButton.Location = new System.Drawing.Point(226, 231);
            this.AddExclusionButton.Name = "AddExclusionButton";
            this.AddExclusionButton.Size = new System.Drawing.Size(43, 23);
            this.AddExclusionButton.TabIndex = 10;
            this.AddExclusionButton.Text = "Add";
            this.AddExclusionButton.UseVisualStyleBackColor = true;
            this.AddExclusionButton.Click += new System.EventHandler(this.AddExclusionButton_Click);
            // 
            // ExclusionsLabel
            // 
            this.ExclusionsLabel.AutoSize = true;
            this.ExclusionsLabel.Location = new System.Drawing.Point(226, 189);
            this.ExclusionsLabel.Name = "ExclusionsLabel";
            this.ExclusionsLabel.Size = new System.Drawing.Size(60, 13);
            this.ExclusionsLabel.TabIndex = 9;
            this.ExclusionsLabel.Text = "Exclusions:";
            // 
            // ExclusionsList
            // 
            this.ExclusionsList.FormattingEnabled = true;
            this.ExclusionsList.Location = new System.Drawing.Point(13, 113);
            this.ExclusionsList.Name = "ExclusionsList";
            this.ExclusionsList.Size = new System.Drawing.Size(196, 212);
            this.ExclusionsList.TabIndex = 8;
            // 
            // CustomDirectoryOption
            // 
            this.CustomDirectoryOption.AutoSize = true;
            this.CustomDirectoryOption.Checked = true;
            this.CustomDirectoryOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CustomDirectoryOption.Location = new System.Drawing.Point(238, 113);
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
            this.tabPage2.Controls.Add(this.year);
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
            // year
            // 
            this.year.Location = new System.Drawing.Point(214, 177);
            this.year.MaxLength = 4;
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(38, 20);
            this.year.TabIndex = 6;
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
            this.Name = "Preferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Preferences";
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
        private System.Windows.Forms.TextBox DestinationDirectoryField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ApplyDirectoriesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BackupDirectoryField;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ApplyTransferSettingsButton;
        private System.Windows.Forms.CheckBox CalculateProfileSizesOption;
        private System.Windows.Forms.CheckBox CustomDirectoryOption;
        private System.Windows.Forms.Label ExclusionsLabel;
        private System.Windows.Forms.ListBox ExclusionsList;
        private System.Windows.Forms.CheckBox CopyAllOption;
        private System.Windows.Forms.Button RemoveExclusionButton;
        private System.Windows.Forms.Button AddExclusionButton;
        private System.Windows.Forms.TextBox ExclusionField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox dd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mm;
        private System.Windows.Forms.CheckBox ShowErrorsOption;
        private System.Windows.Forms.CheckBox ForceUserLogoffOption;
    }
}