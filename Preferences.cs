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
            if(Properties.Settings.Default.UseCustomDestination == true)
            {
                DestinationDirectoryField.Enabled = true;
                CustomDirectoryOption.Checked = false;
            }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!CustomDirectoryOption.Checked)
            {
                DestinationDirectoryField.Enabled = true;
                Properties.Settings.Default.UseCustomDestination = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                DestinationDirectoryField.Enabled = false;
                Properties.Settings.Default.UseCustomDestination = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
