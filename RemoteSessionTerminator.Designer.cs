namespace ProfileBackupTool
{
    partial class RemoteSessionTerminator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteSessionTerminator));
            this.label1 = new System.Windows.Forms.Label();
            this.DeviceName = new System.Windows.Forms.TextBox();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter fully qualified UNC path:\r\nCurrently logged in users will be logged off.\r\n\r" +
    "\n";
            // 
            // DeviceName
            // 
            this.DeviceName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DeviceName.Location = new System.Drawing.Point(32, 74);
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Size = new System.Drawing.Size(310, 20);
            this.DeviceName.TabIndex = 4;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(267, 110);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(75, 23);
            this.DisconnectButton.TabIndex = 5;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // RemoteSessionTerminator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 145);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.DeviceName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoteSessionTerminator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Disconnect Remote Session";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeviceName;
        private System.Windows.Forms.Button DisconnectButton;
    }
}