namespace ProfileBackupTool.DeviceManagement
{
    partial class RestorationQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestorationQuery));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemoveOriginal = new System.Windows.Forms.Button();
            this.OriginalDeviceList = new System.Windows.Forms.ListBox();
            this.AddOriginalDevice = new System.Windows.Forms.Button();
            this.OriginalDevice = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RemoveNew = new System.Windows.Forms.Button();
            this.AddNewDevice = new System.Windows.Forms.Button();
            this.NewDevice = new System.Windows.Forms.TextBox();
            this.NewDevices = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResoreButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ViewLogs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoveOriginal);
            this.groupBox1.Controls.Add(this.OriginalDeviceList);
            this.groupBox1.Controls.Add(this.AddOriginalDevice);
            this.groupBox1.Controls.Add(this.OriginalDevice);
            this.groupBox1.Location = new System.Drawing.Point(28, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original Device(s)";
            // 
            // RemoveOriginal
            // 
            this.RemoveOriginal.Location = new System.Drawing.Point(198, 344);
            this.RemoveOriginal.Name = "RemoveOriginal";
            this.RemoveOriginal.Size = new System.Drawing.Size(64, 23);
            this.RemoveOriginal.TabIndex = 5;
            this.RemoveOriginal.Text = "Remove";
            this.RemoveOriginal.UseVisualStyleBackColor = true;
            this.RemoveOriginal.Click += new System.EventHandler(this.RemoveOriginal_Click);
            // 
            // OriginalDeviceList
            // 
            this.OriginalDeviceList.FormattingEnabled = true;
            this.OriginalDeviceList.Location = new System.Drawing.Point(7, 20);
            this.OriginalDeviceList.Name = "OriginalDeviceList";
            this.OriginalDeviceList.Size = new System.Drawing.Size(255, 316);
            this.OriginalDeviceList.TabIndex = 0;
            // 
            // AddOriginalDevice
            // 
            this.AddOriginalDevice.Location = new System.Drawing.Point(146, 344);
            this.AddOriginalDevice.Name = "AddOriginalDevice";
            this.AddOriginalDevice.Size = new System.Drawing.Size(46, 23);
            this.AddOriginalDevice.TabIndex = 4;
            this.AddOriginalDevice.Text = "Add";
            this.AddOriginalDevice.UseVisualStyleBackColor = true;
            this.AddOriginalDevice.Click += new System.EventHandler(this.AddOriginalDevice_Click);
            // 
            // OriginalDevice
            // 
            this.OriginalDevice.Location = new System.Drawing.Point(7, 347);
            this.OriginalDevice.Name = "OriginalDevice";
            this.OriginalDevice.Size = new System.Drawing.Size(133, 20);
            this.OriginalDevice.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RemoveNew);
            this.groupBox2.Controls.Add(this.AddNewDevice);
            this.groupBox2.Controls.Add(this.NewDevice);
            this.groupBox2.Controls.Add(this.NewDevices);
            this.groupBox2.Location = new System.Drawing.Point(302, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 373);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Device(s)";
            // 
            // RemoveNew
            // 
            this.RemoveNew.Location = new System.Drawing.Point(198, 342);
            this.RemoveNew.Name = "RemoveNew";
            this.RemoveNew.Size = new System.Drawing.Size(64, 23);
            this.RemoveNew.TabIndex = 7;
            this.RemoveNew.Text = "Remove";
            this.RemoveNew.UseVisualStyleBackColor = true;
            this.RemoveNew.Click += new System.EventHandler(this.RemoveNew_Click);
            // 
            // AddNewDevice
            // 
            this.AddNewDevice.Location = new System.Drawing.Point(145, 341);
            this.AddNewDevice.Name = "AddNewDevice";
            this.AddNewDevice.Size = new System.Drawing.Size(46, 23);
            this.AddNewDevice.TabIndex = 6;
            this.AddNewDevice.Text = "Add";
            this.AddNewDevice.UseVisualStyleBackColor = true;
            this.AddNewDevice.Click += new System.EventHandler(this.AddNewDevice_Click);
            // 
            // NewDevice
            // 
            this.NewDevice.Location = new System.Drawing.Point(6, 344);
            this.NewDevice.Name = "NewDevice";
            this.NewDevice.Size = new System.Drawing.Size(133, 20);
            this.NewDevice.TabIndex = 4;
            // 
            // NewDevices
            // 
            this.NewDevices.FormattingEnabled = true;
            this.NewDevices.Location = new System.Drawing.Point(7, 20);
            this.NewDevices.Name = "NewDevices";
            this.NewDevices.Size = new System.Drawing.Size(255, 316);
            this.NewDevices.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the computer names in parallel to which migration items will be restored to" +
    ".";
            // 
            // ResoreButton
            // 
            this.ResoreButton.Location = new System.Drawing.Point(495, 433);
            this.ResoreButton.Name = "ResoreButton";
            this.ResoreButton.Size = new System.Drawing.Size(75, 23);
            this.ResoreButton.TabIndex = 3;
            this.ResoreButton.Text = "Restore";
            this.ResoreButton.UseVisualStyleBackColor = true;
            this.ResoreButton.Click += new System.EventHandler(this.ResoreButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(414, 433);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ViewLogs
            // 
            this.ViewLogs.Location = new System.Drawing.Point(28, 433);
            this.ViewLogs.Name = "ViewLogs";
            this.ViewLogs.Size = new System.Drawing.Size(75, 23);
            this.ViewLogs.TabIndex = 5;
            this.ViewLogs.Text = "View Logs";
            this.ViewLogs.UseVisualStyleBackColor = true;
            this.ViewLogs.Click += new System.EventHandler(this.ViewLogs_Click);
            // 
            // RestorationQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 467);
            this.Controls.Add(this.ViewLogs);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ResoreButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RestorationQuery";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Restoration Workstations";
            this.Load += new System.EventHandler(this.RestorationQuery_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RemoveOriginal;
        private System.Windows.Forms.ListBox OriginalDeviceList;
        private System.Windows.Forms.Button AddOriginalDevice;
        private System.Windows.Forms.TextBox OriginalDevice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button RemoveNew;
        private System.Windows.Forms.Button AddNewDevice;
        private System.Windows.Forms.TextBox NewDevice;
        private System.Windows.Forms.ListBox NewDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResoreButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ViewLogs;
    }
}