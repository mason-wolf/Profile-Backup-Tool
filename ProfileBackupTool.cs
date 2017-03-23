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
        }

        Thread DirectorySizeCalculator;
        Stopwatch StopWatch;

        System.Windows.Forms.Timer Timer;


       private void InitiateTransfer(string[] targets)
        {
            DirectoryTools DirectoryTools = new DirectoryTools(TotalSizeContainer, FileTransferContainer, ProcessedFilesContainer);

            foreach (string target in targets)
            {

                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.UseShellExecute = false;
                    psi.FileName = @"c:\windows\system32\reset.exe";
                    psi.RedirectStandardOutput = true;
                    psi.Arguments = "Session Console /Server:" + target.Remove(0, 2);
                    using (Process proc = Process.Start(psi))
                    {
                        using (System.IO.StreamReader reader = proc.StandardOutput)
                        {
                            string result = reader.ReadToEnd();
                            MessageBox.Show(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



                // If CalculateProfileSizes setting is enabled, determine transfer size before initiating backup.

                if (Properties.Settings.Default.CalculateProfileSizes)
                {
                    DirectoryTools.CalculateProfileSizes(target + Properties.Settings.Default.SourceDirectory, DirectoryTools.ProcessDirectorySizes);
                }

                StatusBar.Text = "Performing backup...";

                // Select the first item in the target panel, increments after each thread is finished to indicate
                // which target is being worked on.

                this.Invoke((MethodInvoker)delegate {
                    DeviceList.SelectedIndex = 0;
                    ProgressBar.Visible = true;
                });

                // By default the destination in the backup location is the target's host name.
                // Optionally a custom destination can be specified. 

                if(Properties.Settings.Default.UseCustomDestination == true)
                {
                    DirectoryTools.PerformTransfer(target + Properties.Settings.Default.SourceDirectory, Properties.Settings.Default.DefaultServer + Properties.Settings.Default.DestinationDirectory);
                }
                else
                {
                    DirectoryTools.PerformTransfer(target + Properties.Settings.Default.SourceDirectory, Properties.Settings.Default.DefaultServer + target.Remove(0, 2));
                }

                StatusBar.Text = "Complete.";

                // Show progress after each task is performed, move on to the next item in the panel.

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

        private string[] RetrieveDeviceList()
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
            FileTransferContainer.Clear();
                StatusBar.Text = "Calculating size of profile(s)...";
                StatusBar.Visible = true;
                StopButton.Enabled = true;
                StartTransferButton.Enabled = false;

                ProcessedFilesContainer.Text = "0";

                int profileCount = 0;

            // Count how many directories are found.

            foreach (string target in DeviceList.Items)
            { 
                  string[] directories = Directory.GetDirectories(target + Properties.Settings.Default.SourceDirectory);

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
            
            DirectorySizeCalculator = new Thread(() => InitiateTransfer(RetrieveDeviceList()));
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
            var NewSessionConfirmation = MessageBox.Show("Start a new session? All current operations will be interrupted.",
                "New Session", MessageBoxButtons.YesNo);

            if (NewSessionConfirmation == DialogResult.Yes)
            {
                ProfileBackupTool ProfileBackupTool = new ProfileBackupTool();
                ProfileBackupTool.Show();
                this.Close();
            }
            else
            {

            }
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


        private void ProfileBackupTool_Load(object sender, EventArgs e)
        {
            AddMachineButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            RemoveDeviceButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            ConnectionButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            PreferencesButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);


            ToolTip AddMachineToolTip = new ToolTip();
            AddMachineToolTip.SetToolTip(AddMachineButton, "Add new target machine.");

            ToolTip RemoveMachineToolTip = new ToolTip();
            RemoveMachineToolTip.SetToolTip(RemoveDeviceButton, "Remove target machine.");

            ToolTip ConnectionsToolTip = new ToolTip();
            ConnectionsToolTip.SetToolTip(ConnectionButton, "Modify backup server connection settings.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceList.Items.Remove(DeviceList.SelectedItem);
        }
    }
}
