namespace ProfileBackupTool
{
    partial class Connections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connections));
            this.label1 = new System.Windows.Forms.Label();
            this.ServerAddressField = new System.Windows.Forms.TextBox();
            this.AddConnectionButton = new System.Windows.Forms.Button();
            this.ConnectionsList = new System.Windows.Forms.ListBox();
            this.RemoveConnectionButton = new System.Windows.Forms.Button();
            this.ValidateAccessCheckBox = new System.Windows.Forms.CheckBox();
            this.SetAsDefaultCheckbox = new System.Windows.Forms.CheckBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Address:";
            // 
            // ServerAddressField
            // 
            this.ServerAddressField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ServerAddressField.Location = new System.Drawing.Point(211, 39);
            this.ServerAddressField.Name = "ServerAddressField";
            this.ServerAddressField.Size = new System.Drawing.Size(176, 20);
            this.ServerAddressField.TabIndex = 1;
            // 
            // AddConnectionButton
            // 
            this.AddConnectionButton.Location = new System.Drawing.Point(338, 74);
            this.AddConnectionButton.Name = "AddConnectionButton";
            this.AddConnectionButton.Size = new System.Drawing.Size(49, 23);
            this.AddConnectionButton.TabIndex = 2;
            this.AddConnectionButton.Text = "Add";
            this.AddConnectionButton.UseVisualStyleBackColor = true;
            this.AddConnectionButton.Click += new System.EventHandler(this.AddConnectionButton_Click);
            // 
            // ConnectionsList
            // 
            this.ConnectionsList.FormattingEnabled = true;
            this.ConnectionsList.Location = new System.Drawing.Point(13, 13);
            this.ConnectionsList.Name = "ConnectionsList";
            this.ConnectionsList.Size = new System.Drawing.Size(179, 160);
            this.ConnectionsList.TabIndex = 3;
            this.ConnectionsList.SelectedIndexChanged += new System.EventHandler(this.ConnectionsList_SelectedIndexChanged);
            // 
            // RemoveConnectionButton
            // 
            this.RemoveConnectionButton.Location = new System.Drawing.Point(13, 180);
            this.RemoveConnectionButton.Name = "RemoveConnectionButton";
            this.RemoveConnectionButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveConnectionButton.TabIndex = 4;
            this.RemoveConnectionButton.Text = "Remove...";
            this.RemoveConnectionButton.UseVisualStyleBackColor = true;
            this.RemoveConnectionButton.Click += new System.EventHandler(this.RemoveConnectionButton_Click);
            // 
            // ValidateAccessCheckBox
            // 
            this.ValidateAccessCheckBox.AutoSize = true;
            this.ValidateAccessCheckBox.Checked = true;
            this.ValidateAccessCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ValidateAccessCheckBox.Location = new System.Drawing.Point(232, 112);
            this.ValidateAccessCheckBox.Name = "ValidateAccessCheckBox";
            this.ValidateAccessCheckBox.Size = new System.Drawing.Size(123, 17);
            this.ValidateAccessCheckBox.TabIndex = 5;
            this.ValidateAccessCheckBox.Text = "Validate accessibility";
            this.ValidateAccessCheckBox.UseVisualStyleBackColor = true;
            // 
            // SetAsDefaultCheckbox
            // 
            this.SetAsDefaultCheckbox.AutoSize = true;
            this.SetAsDefaultCheckbox.Location = new System.Drawing.Point(232, 144);
            this.SetAsDefaultCheckbox.Name = "SetAsDefaultCheckbox";
            this.SetAsDefaultCheckbox.Size = new System.Drawing.Size(93, 17);
            this.SetAsDefaultCheckbox.TabIndex = 6;
            this.SetAsDefaultCheckbox.Text = "Set as Default";
            this.SetAsDefaultCheckbox.UseVisualStyleBackColor = true;
            this.SetAsDefaultCheckbox.CheckedChanged += new System.EventHandler(this.SetAsDefaultCheckbox_CheckedChanged);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(311, 180);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 7;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // Connections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 213);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.SetAsDefaultCheckbox);
            this.Controls.Add(this.ValidateAccessCheckBox);
            this.Controls.Add(this.RemoveConnectionButton);
            this.Controls.Add(this.ConnectionsList);
            this.Controls.Add(this.AddConnectionButton);
            this.Controls.Add(this.ServerAddressField);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Connections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Connections";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerAddressField;
        private System.Windows.Forms.Button AddConnectionButton;
        private System.Windows.Forms.ListBox ConnectionsList;
        private System.Windows.Forms.Button RemoveConnectionButton;
        private System.Windows.Forms.CheckBox ValidateAccessCheckBox;
        private System.Windows.Forms.CheckBox SetAsDefaultCheckbox;
        private System.Windows.Forms.Button ApplyButton;
    }
}