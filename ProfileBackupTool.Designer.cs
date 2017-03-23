namespace ProfileBackupTool
{
    partial class ProfileBackupTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileBackupTool));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.backupModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restorationModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restorationHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileTransferContainer = new System.Windows.Forms.RichTextBox();
            this.DeviceList = new System.Windows.Forms.ListBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.StartTransferButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.ProfileCountContainer = new System.Windows.Forms.Label();
            this.TotalSizeLabel = new System.Windows.Forms.Label();
            this.TotalSizeContainer = new System.Windows.Forms.Label();
            this.FileTransfersLabel = new System.Windows.Forms.Label();
            this.TargetMachinesLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.ProcessedFilesLabel = new System.Windows.Forms.Label();
            this.ProcessedFilesContainer = new System.Windows.Forms.Label();
            this.ElapsedTimeLabel = new System.Windows.Forms.Label();
            this.ElapsedTimeContainer = new System.Windows.Forms.Label();
            this.AddMachineButton = new System.Windows.Forms.Button();
            this.RemoveDeviceButton = new System.Windows.Forms.Button();
            this.ConnectionButton = new System.Windows.Forms.Button();
            this.PreferencesButton = new System.Windows.Forms.Button();
            this.removeDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripMenuItem1,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSessionToolStripMenuItem,
            this.saveReportToolStripMenuItem,
            this.toolStripSeparator1,
            this.backupModeToolStripMenuItem,
            this.restorationModeToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newSessionToolStripMenuItem
            // 
            this.newSessionToolStripMenuItem.Name = "newSessionToolStripMenuItem";
            this.newSessionToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.newSessionToolStripMenuItem.Text = "New Session";
            this.newSessionToolStripMenuItem.Click += new System.EventHandler(this.newSessionToolStripMenuItem_Click);
            // 
            // saveReportToolStripMenuItem
            // 
            this.saveReportToolStripMenuItem.Enabled = false;
            this.saveReportToolStripMenuItem.Name = "saveReportToolStripMenuItem";
            this.saveReportToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.saveReportToolStripMenuItem.Text = "Save Report";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // backupModeToolStripMenuItem
            // 
            this.backupModeToolStripMenuItem.Checked = true;
            this.backupModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backupModeToolStripMenuItem.Name = "backupModeToolStripMenuItem";
            this.backupModeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.backupModeToolStripMenuItem.Text = "Backup Mode";
            // 
            // restorationModeToolStripMenuItem
            // 
            this.restorationModeToolStripMenuItem.Enabled = false;
            this.restorationModeToolStripMenuItem.Name = "restorationModeToolStripMenuItem";
            this.restorationModeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.restorationModeToolStripMenuItem.Text = "Restoration Mode";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionsToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // connectionsToolStripMenuItem
            // 
            this.connectionsToolStripMenuItem.Name = "connectionsToolStripMenuItem";
            this.connectionsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.connectionsToolStripMenuItem.Text = "Connections";
            this.connectionsToolStripMenuItem.Click += new System.EventHandler(this.connectionsToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDeviceToolStripMenuItem,
            this.removeDeviceToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem1.Text = "Tools";
            // 
            // addDeviceToolStripMenuItem
            // 
            this.addDeviceToolStripMenuItem.Name = "addDeviceToolStripMenuItem";
            this.addDeviceToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addDeviceToolStripMenuItem.Text = "Add Device";
            this.addDeviceToolStripMenuItem.Click += new System.EventHandler(this.addDeviceToolStripMenuItem_Click_1);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupHistoryToolStripMenuItem,
            this.restorationHistoryToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // backupHistoryToolStripMenuItem
            // 
            this.backupHistoryToolStripMenuItem.Enabled = false;
            this.backupHistoryToolStripMenuItem.Name = "backupHistoryToolStripMenuItem";
            this.backupHistoryToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.backupHistoryToolStripMenuItem.Text = "Backup History";
            // 
            // restorationHistoryToolStripMenuItem
            // 
            this.restorationHistoryToolStripMenuItem.Enabled = false;
            this.restorationHistoryToolStripMenuItem.Name = "restorationHistoryToolStripMenuItem";
            this.restorationHistoryToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.restorationHistoryToolStripMenuItem.Text = "Restoration History";
            // 
            // FileTransferContainer
            // 
            this.FileTransferContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileTransferContainer.Location = new System.Drawing.Point(12, 55);
            this.FileTransferContainer.Name = "FileTransferContainer";
            this.FileTransferContainer.ReadOnly = true;
            this.FileTransferContainer.Size = new System.Drawing.Size(399, 377);
            this.FileTransferContainer.TabIndex = 1;
            this.FileTransferContainer.Text = "1. Ensure backup server connection is specified. Navigate to Edit-->Connections.\n" +
    "2. Add target computer(s) in the right pane by selecting Tools-->Add Device. \n3." +
    " Click Start";
            // 
            // DeviceList
            // 
            this.DeviceList.FormattingEnabled = true;
            this.DeviceList.Location = new System.Drawing.Point(420, 54);
            this.DeviceList.Name = "DeviceList";
            this.DeviceList.Size = new System.Drawing.Size(305, 251);
            this.DeviceList.TabIndex = 2;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 438);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(713, 23);
            this.ProgressBar.TabIndex = 3;
            this.ProgressBar.Visible = false;
            // 
            // StartTransferButton
            // 
            this.StartTransferButton.Enabled = false;
            this.StartTransferButton.Location = new System.Drawing.Point(650, 409);
            this.StartTransferButton.Name = "StartTransferButton";
            this.StartTransferButton.Size = new System.Drawing.Size(75, 23);
            this.StartTransferButton.TabIndex = 4;
            this.StartTransferButton.Text = "Start";
            this.StartTransferButton.UseVisualStyleBackColor = true;
            this.StartTransferButton.Click += new System.EventHandler(this.StartTransferButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 470);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(737, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusBar
            // 
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(39, 17);
            this.StatusBar.Text = "Status";
            this.StatusBar.Visible = false;
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Location = new System.Drawing.Point(417, 318);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(44, 13);
            this.ProfileLabel.TabIndex = 6;
            this.ProfileLabel.Text = "Profiles:";
            this.ProfileLabel.Visible = false;
            // 
            // ProfileCountContainer
            // 
            this.ProfileCountContainer.AutoSize = true;
            this.ProfileCountContainer.Location = new System.Drawing.Point(507, 318);
            this.ProfileCountContainer.Name = "ProfileCountContainer";
            this.ProfileCountContainer.Size = new System.Drawing.Size(63, 13);
            this.ProfileCountContainer.TabIndex = 7;
            this.ProfileCountContainer.Text = "profileCount";
            this.ProfileCountContainer.Visible = false;
            // 
            // TotalSizeLabel
            // 
            this.TotalSizeLabel.AutoSize = true;
            this.TotalSizeLabel.Location = new System.Drawing.Point(417, 345);
            this.TotalSizeLabel.Name = "TotalSizeLabel";
            this.TotalSizeLabel.Size = new System.Drawing.Size(57, 13);
            this.TotalSizeLabel.TabIndex = 8;
            this.TotalSizeLabel.Text = "Total Size:";
            this.TotalSizeLabel.Visible = false;
            // 
            // TotalSizeContainer
            // 
            this.TotalSizeContainer.AutoSize = true;
            this.TotalSizeContainer.Location = new System.Drawing.Point(507, 345);
            this.TotalSizeContainer.Name = "TotalSizeContainer";
            this.TotalSizeContainer.Size = new System.Drawing.Size(13, 13);
            this.TotalSizeContainer.TabIndex = 9;
            this.TotalSizeContainer.Text = "0";
            this.TotalSizeContainer.Visible = false;
            // 
            // FileTransfersLabel
            // 
            this.FileTransfersLabel.AutoSize = true;
            this.FileTransfersLabel.Location = new System.Drawing.Point(12, 39);
            this.FileTransfersLabel.Name = "FileTransfersLabel";
            this.FileTransfersLabel.Size = new System.Drawing.Size(79, 13);
            this.FileTransfersLabel.TabIndex = 10;
            this.FileTransfersLabel.Text = "File Transfer(s):";
            // 
            // TargetMachinesLabel
            // 
            this.TargetMachinesLabel.AutoSize = true;
            this.TargetMachinesLabel.Location = new System.Drawing.Point(417, 38);
            this.TargetMachinesLabel.Name = "TargetMachinesLabel";
            this.TargetMachinesLabel.Size = new System.Drawing.Size(96, 13);
            this.TargetMachinesLabel.TabIndex = 11;
            this.TargetMachinesLabel.Text = "Target Machine(s):";
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(569, 409);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 12;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ProcessedFilesLabel
            // 
            this.ProcessedFilesLabel.AutoSize = true;
            this.ProcessedFilesLabel.Location = new System.Drawing.Point(417, 371);
            this.ProcessedFilesLabel.Name = "ProcessedFilesLabel";
            this.ProcessedFilesLabel.Size = new System.Drawing.Size(84, 13);
            this.ProcessedFilesLabel.TabIndex = 13;
            this.ProcessedFilesLabel.Text = "Processed Files:";
            this.ProcessedFilesLabel.Visible = false;
            // 
            // ProcessedFilesContainer
            // 
            this.ProcessedFilesContainer.AutoSize = true;
            this.ProcessedFilesContainer.Location = new System.Drawing.Point(507, 371);
            this.ProcessedFilesContainer.Name = "ProcessedFilesContainer";
            this.ProcessedFilesContainer.Size = new System.Drawing.Size(77, 13);
            this.ProcessedFilesContainer.TabIndex = 14;
            this.ProcessedFilesContainer.Text = "processedFiles";
            this.ProcessedFilesContainer.Visible = false;
            // 
            // ElapsedTimeLabel
            // 
            this.ElapsedTimeLabel.AutoSize = true;
            this.ElapsedTimeLabel.Location = new System.Drawing.Point(587, 318);
            this.ElapsedTimeLabel.Name = "ElapsedTimeLabel";
            this.ElapsedTimeLabel.Size = new System.Drawing.Size(74, 13);
            this.ElapsedTimeLabel.TabIndex = 15;
            this.ElapsedTimeLabel.Text = "Elapsed Time:";
            this.ElapsedTimeLabel.Visible = false;
            // 
            // ElapsedTimeContainer
            // 
            this.ElapsedTimeContainer.AutoSize = true;
            this.ElapsedTimeContainer.Location = new System.Drawing.Point(676, 318);
            this.ElapsedTimeContainer.Name = "ElapsedTimeContainer";
            this.ElapsedTimeContainer.Size = new System.Drawing.Size(49, 13);
            this.ElapsedTimeContainer.TabIndex = 16;
            this.ElapsedTimeContainer.Text = "00:00:00";
            this.ElapsedTimeContainer.Visible = false;
            // 
            // AddMachineButton
            // 
            this.AddMachineButton.FlatAppearance.BorderSize = 0;
            this.AddMachineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMachineButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddMachineButton.Image = ((System.Drawing.Image)(resources.GetObject("AddMachineButton.Image")));
            this.AddMachineButton.Location = new System.Drawing.Point(519, 27);
            this.AddMachineButton.Name = "AddMachineButton";
            this.AddMachineButton.Size = new System.Drawing.Size(27, 23);
            this.AddMachineButton.TabIndex = 17;
            this.AddMachineButton.TabStop = false;
            this.AddMachineButton.Tag = "";
            this.AddMachineButton.UseVisualStyleBackColor = true;
            this.AddMachineButton.Click += new System.EventHandler(this.AddMachineButton_Click);
            // 
            // RemoveDeviceButton
            // 
            this.RemoveDeviceButton.FlatAppearance.BorderSize = 0;
            this.RemoveDeviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveDeviceButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RemoveDeviceButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveDeviceButton.Image")));
            this.RemoveDeviceButton.Location = new System.Drawing.Point(552, 29);
            this.RemoveDeviceButton.Name = "RemoveDeviceButton";
            this.RemoveDeviceButton.Size = new System.Drawing.Size(27, 23);
            this.RemoveDeviceButton.TabIndex = 18;
            this.RemoveDeviceButton.TabStop = false;
            this.RemoveDeviceButton.Tag = "";
            this.RemoveDeviceButton.UseVisualStyleBackColor = true;
            this.RemoveDeviceButton.Click += new System.EventHandler(this.RemoveDeviceButton_Click_1);
            // 
            // ConnectionButton
            // 
            this.ConnectionButton.FlatAppearance.BorderSize = 0;
            this.ConnectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectionButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConnectionButton.Image = ((System.Drawing.Image)(resources.GetObject("ConnectionButton.Image")));
            this.ConnectionButton.Location = new System.Drawing.Point(585, 27);
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Size = new System.Drawing.Size(27, 23);
            this.ConnectionButton.TabIndex = 19;
            this.ConnectionButton.TabStop = false;
            this.ConnectionButton.Tag = "";
            this.ConnectionButton.UseVisualStyleBackColor = true;
            this.ConnectionButton.Click += new System.EventHandler(this.ConnectionButton_Click);
            // 
            // PreferencesButton
            // 
            this.PreferencesButton.FlatAppearance.BorderSize = 0;
            this.PreferencesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreferencesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PreferencesButton.Image = ((System.Drawing.Image)(resources.GetObject("PreferencesButton.Image")));
            this.PreferencesButton.Location = new System.Drawing.Point(617, 27);
            this.PreferencesButton.Name = "PreferencesButton";
            this.PreferencesButton.Size = new System.Drawing.Size(27, 23);
            this.PreferencesButton.TabIndex = 20;
            this.PreferencesButton.TabStop = false;
            this.PreferencesButton.Tag = "";
            this.PreferencesButton.UseVisualStyleBackColor = true;
            this.PreferencesButton.Click += new System.EventHandler(this.PreferencesButton_Click);
            // 
            // removeDeviceToolStripMenuItem
            // 
            this.removeDeviceToolStripMenuItem.Name = "removeDeviceToolStripMenuItem";
            this.removeDeviceToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.removeDeviceToolStripMenuItem.Text = "Remove Device";
            this.removeDeviceToolStripMenuItem.Click += new System.EventHandler(this.removeDeviceToolStripMenuItem_Click);
            // 
            // ProfileBackupTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 492);
            this.Controls.Add(this.PreferencesButton);
            this.Controls.Add(this.ConnectionButton);
            this.Controls.Add(this.RemoveDeviceButton);
            this.Controls.Add(this.AddMachineButton);
            this.Controls.Add(this.ElapsedTimeContainer);
            this.Controls.Add(this.ElapsedTimeLabel);
            this.Controls.Add(this.ProcessedFilesContainer);
            this.Controls.Add(this.ProcessedFilesLabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.TargetMachinesLabel);
            this.Controls.Add(this.FileTransfersLabel);
            this.Controls.Add(this.TotalSizeContainer);
            this.Controls.Add(this.TotalSizeLabel);
            this.Controls.Add(this.ProfileCountContainer);
            this.Controls.Add(this.ProfileLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.StartTransferButton);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.DeviceList);
            this.Controls.Add(this.FileTransferContainer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ProfileBackupTool";
            this.Text = "Profile Backup Tool";
            this.Load += new System.EventHandler(this.ProfileBackupTool_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem backupModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restorationModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restorationHistoryToolStripMenuItem;
        private System.Windows.Forms.RichTextBox FileTransferContainer;
        private System.Windows.Forms.ProgressBar ProgressBar;
        public System.Windows.Forms.ListBox DeviceList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar;
        public System.Windows.Forms.Button StartTransferButton;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.Label ProfileCountContainer;
        private System.Windows.Forms.Label TotalSizeLabel;
        public System.Windows.Forms.Label TotalSizeContainer;
        private System.Windows.Forms.Label FileTransfersLabel;
        private System.Windows.Forms.Label TargetMachinesLabel;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label ProcessedFilesLabel;
        private System.Windows.Forms.Label ProcessedFilesContainer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addDeviceToolStripMenuItem;
        private System.Windows.Forms.Label ElapsedTimeLabel;
        private System.Windows.Forms.Label ElapsedTimeContainer;
        private System.Windows.Forms.Button AddMachineButton;
        private System.Windows.Forms.Button RemoveDeviceButton;
        private System.Windows.Forms.Button ConnectionButton;
        private System.Windows.Forms.Button PreferencesButton;
        private System.Windows.Forms.ToolStripMenuItem removeDeviceToolStripMenuItem;
    }
}

