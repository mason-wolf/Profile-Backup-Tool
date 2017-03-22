using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            if (Properties.Settings.Default.CalculateProfileSizes)
            {
                CalculateProfileSizesOption.Checked = true;
            }
            else
            {
                CalculateProfileSizesOption.Checked = false;
            }

            BackupDirectoryField.Text = Properties.Settings.Default.SourceDirectory;
            DestinationDirectoryField.Text = Properties.Settings.Default.DestinationDirectory;

            if (Properties.Settings.Default.UseCustomDestination == true)
            {
                DestinationDirectoryField.Enabled = true;
                CustomDirectoryOption.Checked = false;
            }

            if (Properties.Settings.Default.CopyAll == true)
            {
                ExclusionField.Enabled = false;
                ExclusionsList.Enabled = false;
                AddExclusionButton.Enabled = false;
                RemoveExclusionButton.Enabled = false;
            }

            List<string> lines = new List<string>();

                using (StreamReader r = new StreamReader("config\\exclusions.txt"))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }

                foreach (string line in lines)
                {
                    ExclusionsList.Items.Add(line);
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

        private void AddExclusionButton_Click(object sender, EventArgs e)
        {
            string Exclusion = ExclusionField.Text;
            ExclusionsList.Items.Add(Exclusion);
            File.AppendAllText("config\\exclusions.txt", Exclusion + Environment.NewLine);
        }

        private void RemoveExclusionButton_Click(object sender, EventArgs e)
        {
            string item = ExclusionsList.SelectedItem.ToString();
            string tempFile = Path.GetTempFileName();
            string filePath = "config\\exclusions.txt";
            try
            {
                using (var sr = new StreamReader(filePath))
                {
                    using (var sw = new StreamWriter(tempFile))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line != item)
                            {
                                sw.WriteLine(line);
                            }
                        }
                    }
                }
            }
            catch (Exception we)
            {
                MessageBox.Show(we.ToString());
            }

            File.Delete(filePath);
            File.Move(tempFile, filePath);
            ExclusionsList.Items.Remove(ExclusionsList.SelectedItem);
        }

        private void CopyAllOption_CheckedChanged(object sender, EventArgs e)
        {
            if(CopyAllOption.Checked)
            {
                Properties.Settings.Default.CopyAll = true;
                Properties.Settings.Default.Save();
                ExclusionField.Enabled = false;
                ExclusionsList.Enabled = false;
                ExclusionsLabel.Enabled = false;
                AddExclusionButton.Enabled = false;
                RemoveExclusionButton.Enabled = false;
            }
            else
            {
                Properties.Settings.Default.CopyAll = false;
                Properties.Settings.Default.Save();
                ExclusionField.Enabled = true;
                ExclusionsList.Enabled = true;
                AddExclusionButton.Enabled = true;
                RemoveExclusionButton.Enabled = true;
                ExclusionsLabel.Enabled = true;
            }
        }
    }
}
