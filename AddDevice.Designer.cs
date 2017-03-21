namespace ProfileBackupTool
{
    partial class AddDevice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDevice));
            this.DeviceName = new System.Windows.Forms.TextBox();
            this.AddDeviceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectionStatus = new System.Windows.Forms.Label();
            this.CurrentMachineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeviceName
            // 
            this.DeviceName.Location = new System.Drawing.Point(24, 73);
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Size = new System.Drawing.Size(310, 20);
            this.DeviceName.TabIndex = 0;
            // 
            // AddDeviceButton
            // 
            this.AddDeviceButton.Location = new System.Drawing.Point(259, 124);
            this.AddDeviceButton.Name = "AddDeviceButton";
            this.AddDeviceButton.Size = new System.Drawing.Size(75, 23);
            this.AddDeviceButton.TabIndex = 1;
            this.AddDeviceButton.Text = "Add";
            this.AddDeviceButton.UseVisualStyleBackColor = true;
            this.AddDeviceButton.Click += new System.EventHandler(this.AddDeviceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter fully qualified UNC path:\r\n\r\nex. \"\\\\COMPUTERNAME\"\r\n\r\n";
            // 
            // ConnectionStatus
            // 
            this.ConnectionStatus.AutoSize = true;
            this.ConnectionStatus.Location = new System.Drawing.Point(21, 105);
            this.ConnectionStatus.Name = "ConnectionStatus";
            this.ConnectionStatus.Size = new System.Drawing.Size(114, 13);
            this.ConnectionStatus.TabIndex = 3;
            this.ConnectionStatus.Text = "Checking connection..";
            this.ConnectionStatus.Visible = false;
            // 
            // CurrentMachineButton
            // 
            this.CurrentMachineButton.Location = new System.Drawing.Point(141, 124);
            this.CurrentMachineButton.Name = "CurrentMachineButton";
            this.CurrentMachineButton.Size = new System.Drawing.Size(112, 23);
            this.CurrentMachineButton.TabIndex = 4;
            this.CurrentMachineButton.Text = "Current Machine";
            this.CurrentMachineButton.UseVisualStyleBackColor = true;
            this.CurrentMachineButton.Click += new System.EventHandler(this.CurrentMachineButton_Click);
            // 
            // AddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 159);
            this.Controls.Add(this.CurrentMachineButton);
            this.Controls.Add(this.ConnectionStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddDeviceButton);
            this.Controls.Add(this.DeviceName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Computer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DeviceName;
        private System.Windows.Forms.Button AddDeviceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ConnectionStatus;
        private System.Windows.Forms.Button CurrentMachineButton;
    }
}