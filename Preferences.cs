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

            string TransferDateThreshold = Properties.Settings.Default.TransferDateThreshold.ToString();
            DateTime Date = (Convert.ToDateTime(TransferDateThreshold));

            string day = Date.Day.ToString();
            string month = Date.Month.ToString();
            string year = Date.Year.ToString();


            mm.Text = month;
            dd.Text = day;
            yyyy.Text = year;

            if (Properties.Settings.Default.UseCustomDestination == true)
            {
                DestinationDirectoryField.Enabled = true;
                CustomDirectoryOption.Checked = false;
            }

            if (Properties.Settings.Default.CopyAll == true)
            {
                FolderContainer.Enabled = false;
                CopyAllOption.Checked = true;
            }
            else
            {
                FolderContainer.Enabled = true;
            }

            if (Properties.Settings.Default.ForceUserLogoff == true)
            {
                ForceUserLogoffOption.Checked = true;
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
            int day = Convert.ToInt32(dd.Text);
            int month = Convert.ToInt32(mm.Text);
            int year = Convert.ToInt32(yyyy.Text);

            Properties.Settings.Default.TransferDateThreshold = new DateTime(year, month, day);
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void CalculateProfileSizesOption_CheckedChanged(object sender, EventArgs e)
        {
            if (CalculateProfileSizesOption.Checked)
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
            BackupDirectoryField.Text = "\\C$\\Users";
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


        private void ShowErrorsOption_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowErrorsOption.Checked)
            {
                Properties.Settings.Default.ShowErrors = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.ShowErrors = false;
                Properties.Settings.Default.Save();
            }
        }

        private void ForceUserLogoffOption_CheckedChanged(object sender, EventArgs e)
        {
            if(ForceUserLogoffOption.Checked)
            {
                Properties.Settings.Default.ForceUserLogoff = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.ForceUserLogoff = false;
                Properties.Settings.Default.Save();
            }
        }

        private void DesktopOption_CheckedChanged(object sender, EventArgs e)
        {
            if (DesktopOption.Checked)
            {
                Properties.Settings.Default.Folders.Add("Desktop");
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Folders.Remove("Desktop");
                Properties.Settings.Default.Save();
            }
        }

        private void DocumentsOption_CheckedChanged(object sender, EventArgs e)
        {
            if (DocumentsOption.Checked)
            {
                Properties.Settings.Default.Folders.Add("Documents");
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Folders.Remove("Documents");
                Properties.Settings.Default.Save();
            }
        }

        private void DownloadsOption_CheckedChanged(object sender, EventArgs e)
        {
            if (DownloadsOption.Checked)
            {
                Properties.Settings.Default.Folders.Add("Downloads");
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Folders.Remove("Downloads");
                Properties.Settings.Default.Save();
            }
        }

        private void FavoritesOption_CheckedChanged(object sender, EventArgs e)
        {
            if (FavoritesOption.Checked)
            {
                Properties.Settings.Default.Folders.Add("Favorites");
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Folders.Remove("Favorites");
                Properties.Settings.Default.Save();
            }
        }

        private void PicturesOption_CheckedChanged(object sender, EventArgs e)
        {
            if (PicturesOption.Checked)
            {
                Properties.Settings.Default.Folders.Add("Pictures");
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Folders.Remove("Pictures");
                Properties.Settings.Default.Save();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default.CopyAll.ToString());
        }

        private void MusicOption_CheckedChanged(object sender, EventArgs e)
        {
            if (MusicOption.Checked)
            {
                Properties.Settings.Default.Folders.Add("Music");
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Folders.Remove("Music");
                Properties.Settings.Default.Save();
            }
        }

        private void CopyAllOption_CheckedChanged(object sender, EventArgs e)
        {
            if (CopyAllOption.Checked)
            {
                Properties.Settings.Default.CopyAll = true;
                FolderContainer.Enabled = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.CopyAll = false;
                FolderContainer.Enabled = true;
                Properties.Settings.Default.Save();
            }
        }
    }
}
