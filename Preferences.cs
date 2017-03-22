using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileBackupTool
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();

            if(Properties.Settings.Default.CalculateProfileSizes)
            {
                CalculateProfileSizesOption.Checked = true;
            }
            else
            {
                CalculateProfileSizesOption.Checked = false;
            }

            BackupDirectoryField.Text = Properties.Settings.Default.SourceDirectory;
            DestinationDirectoryField.Text = Properties.Settings.Default.DestinationDirectory;
        }

        private void ApplyDirectoriesButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SourceDirectory = BackupDirectoryField.Text;
            Properties.Settings.Default.DestinationDirectory = DestinationDirectoryField.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void ApplyTransferSettingsButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateProfileSizesOption_CheckedChanged(object sender, EventArgs e)
        {
            if(CalculateProfileSizesOption.Checked)
            {
                Properties.Settings.Default.CalculateProfileSizes = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.CalculateProfileSizes = false;
                Properties.Settings.Default.Save();
            }
        }

        private void SetDefaultDirectoriesButton_Click(object sender, EventArgs e)
        {
            BackupDirectoryField.Text = "\\c$\\Users";
            DestinationDirectoryField.Text = Environment.MachineName;
        }
    }
}
