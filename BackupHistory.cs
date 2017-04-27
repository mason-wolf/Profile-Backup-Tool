using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Profile_Backup_Tool
{
    public partial class BackupHistory : Form
    {
        public BackupHistory()
        {
            InitializeComponent();
        }

        private void BackupHistory_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("logs\\" + Environment.UserName + ".txt"))
                {
                    BackupHistoryContainer.AppendText(sr.ReadToEnd());
                }
            }
            catch
            {
                BackupHistoryContainer.Text = "No log found.";
                ExportButton.Enabled = false;
                ClearButton.Enabled = false;
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            var NewSessionConfirmation = MessageBox.Show("Clear the log? All previous session data will be lost.",
  "Clear History", MessageBoxButtons.YesNo);

            if (NewSessionConfirmation == DialogResult.Yes)
            {
                File.Delete("logs\\" + Environment.UserName + ".txt");
                BackupHistoryContainer.Clear();
                BackupHistoryContainer.Text = "No log found.";
                ExportButton.Enabled = false;
                ClearButton.Enabled = false;
            }
            else
            {

            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "(*.txt)|*.txt";
            saveFileDialog.FileName = Environment.UserName + "-Profile Backup Session";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                BackupHistoryContainer.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void ViewAllButton_Click(object sender, EventArgs e)
        {

        }
    }
}
