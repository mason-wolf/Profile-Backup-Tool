using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileBackupTool
{

    public partial class ProfileBackupTool : Form
    {
        public ProfileBackupTool()
        {
            InitializeComponent();
            ToolTip AddMachineToolTip = new ToolTip();
            AddMachineToolTip.SetToolTip(AddMachineButton, "Add new target machine.");

            ToolTip RemoveMachineToolTip = new ToolTip();
            RemoveMachineToolTip.SetToolTip(RemoveDeviceButton, "Remove target machine.");

            ToolTip ConnectionsToolTip = new ToolTip();
            ConnectionsToolTip.SetToolTip(ConnectionButton, "Modify backup server connection settings.");
        }

        Thread DirectorySizeCalculator;
        Stopwatch StopWatch;
        System.Windows.Forms.Timer Timer;


        private void ProfileBackupTool_Load(object sender, EventArgs e)
        {
            AddMachineButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        void CalculateDirectorySize(string[] targets)
        {
            DirectoryTools DirectoryTools = new DirectoryTools(TotalSizeContainer, FileTransferContainer, ProcessedFilesContainer);

            foreach (string target in targets)
            {
                if (Properties.Settings.Default.CalculateProfileSizes)
                {
                    DirectoryTools.ApplyAllFiles(target + Properties.Settings.Default.SourceDirectory, DirectoryTools.ProcessDirectorySizes);
               //     DirectoryTools.ApplyAllFiles(target + "\\c$\\Users\\", DirectoryTools.ProcessDirectorySizes);
                }
                StatusBar.Text = "Performing backup...";

                this.Invoke((MethodInvoker)delegate {
                    DeviceList.SelectedIndex = 0;
                    ProgressBar.Visible = true;
                });
                DirectoryTools.PerformBackup(target + Properties.Settings.Default.SourceDirectory, Properties.Settings.Default.DefaultServer + Properties.Settings.Default.DestinationDirectory);
          //      DirectoryTools.PerformBackup(target + "\\c$\\Users", Properties.Settings.Default.DefaultServer);
                StatusBar.Text = "Complete.";

                this.Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        StopButton.Enabled = false;
                        StartTransferButton.Enabled = true;
                        ProgressBar.Maximum = DeviceList.Items.Count;
                        ProgressBar.Value += 1;
                        if (DeviceList.SelectedIndex < DeviceList.Items.Count - 1)
                        {
                            DeviceList.SelectedIndex = DeviceList.SelectedIndex + 1;
                        }
                    }
                    catch
                    {

                    }
                });

            }

            StopWatch.Stop();
            Timer.Stop();

        }

        string[] RetrieveDeviceList()
        {
            string[] DeviceListItems = new string[DeviceList.Items.Count];
            for(int i = 0; i < DeviceList.Items.Count; i++)
            {
                DeviceListItems[i] = DeviceList.Items[i].ToString();
            }
            return DeviceListItems;
        }

        private void StartTransferButton_Click(object sender, EventArgs e)
        {

                StatusBar.Text = "Calculating size of profile(s)...";
                StatusBar.Visible = true;
                StopButton.Enabled = true;
                StartTransferButton.Enabled = false;

                ProcessedFilesContainer.Text = "0";

                int profileCount = 0;

            foreach (string target in DeviceList.Items)
            { 
                  string[] directories = Directory.GetDirectories(target + Properties.Settings.Default.SourceDirectory);
                //  string[] directories = Directory.GetDirectories(target + "\\c$\\Users");

                foreach (string path in directories)
                    {
                        profileCount++;
                        ProfileCountContainer.Text = profileCount.ToString();
                    }

                }
            DirectoryTools DirectoryTools = new DirectoryTools(TotalSizeContainer, FileTransferContainer, ProcessedFilesContainer);

            ProfileLabel.Visible = true;
            ProfileCountContainer.Visible = true;
            TotalSizeLabel.Visible = true;
            TotalSizeContainer.Visible = true;
            ProcessedFilesContainer.Visible = true;
            ProcessedFilesLabel.Visible = true;
            ElapsedTimeContainer.Visible = true;
            ElapsedTimeLabel.Visible = true;

            Timer = new System.Windows.Forms.Timer();
            Timer.Interval = 500;
            Timer.Tick += Ticker;
            Timer.Start();

            StopWatch = new Stopwatch();
            StopWatch.Start();
            
            DirectorySizeCalculator = new Thread(() => CalculateDirectorySize(RetrieveDeviceList()));
            DirectorySizeCalculator.Start();

        }

        private void Ticker(object sender, EventArgs e)
        {
            TimeSpan TimeSpan = StopWatch.Elapsed;
            ElapsedTimeContainer.Text = String.Format("{0:00}:{1:00}:{2:00}", TimeSpan.Hours, TimeSpan.Minutes, TimeSpan.Seconds);
        }


        private void StopButton_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "taskkill";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.Arguments = @"/im xcopy.exe /f";
            p.Start();
            StopButton.Enabled = false;
            StartTransferButton.Enabled = true;
            StatusBar.Text = "Transfer aborted.";
            ProgressBar.Visible = false;
            DirectorySizeCalculator.Abort();
            p.Close();
            p.Dispose();
            Timer.Stop();

        }

        private void addDeviceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddDevice AddDeviceTool = new AddDevice(this);
            AddDeviceTool.Show();
        }

        private void AddMachineButton_Click(object sender, EventArgs e)
        {
            AddDevice AddDeviceTool = new AddDevice(this);
            AddDeviceTool.Show();
        }


        private void newSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void connectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connections Connections = new Connections();
            Connections.Show();
        }

        private void RemoveDeviceButton_Click_1(object sender, EventArgs e)
        {
            DeviceList.Items.Remove(DeviceList.SelectedItem);
        }

        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            Connections Connections = new Connections();
            Connections.Show();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences Preferences = new Preferences();
            Preferences.Show();
        }

        private void PreferencesButton_Click(object sender, EventArgs e)
        {
            Preferences Preferences = new Preferences();
            Preferences.Show();
        }
    }
}
