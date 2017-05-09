using Profile_Backup_Tool;
using ProfileBackupTool.DeviceManagement;
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
        ProcessStartInfo RemoteSessionTerminator;

        System.Windows.Forms.Timer Timer;


       private void InitiateTransfer(string[] targets)
        {
            DirectoryTools DirectoryTools = new DirectoryTools(TotalSizeContainer, FileTransferContainer, ProcessedFilesContainer);


            foreach (string target in targets)
            {

                // If ForceUserLogOff option is enabled, terminate the remote sessions before calculating profile sizes

                if (Properties.Settings.Default.ForceUserLogoff)
                {
                    try
                    {
                        StatusBar.Text = "Disconnecting remote sessions..";
                        RemoteSessionTerminator = new ProcessStartInfo();
                        RemoteSessionTerminator.UseShellExecute = false;
                        RemoteSessionTerminator.CreateNoWindow = true;
                        RemoteSessionTerminator.FileName = @"c:\windows\system32\reset.exe";
                        RemoteSessionTerminator.RedirectStandardError = true;
                        RemoteSessionTerminator.Arguments = "Session Console /Server:" + target.Remove(0, 2);

                        using (Process proc = Process.Start(RemoteSessionTerminator))
                        {
                            using (System.IO.StreamReader reader = proc.StandardError)
                            {
                                string result = reader.ReadToEnd();
                            }
                        }
                    }

                    catch
                    {
                        MessageBox.Show("Remote session termination is not supported on this system.");
                    }

                }


                // Select the first item in the target panel, increments after each thread is finished to indicate
                // which target is being worked on.

                this.Invoke((MethodInvoker)delegate
                {
                    DeviceList.SelectedIndex = 0;

                    if (DeviceList.Items.Count > 1)
                    {
                        ProgressBar.Visible = true;
                    }
                });

                // By default the destination in the backup location is the target's host name.
                // Optionally a custom destination can be specified. 

                // If restore mode is enabled, reverse the operation.

                if (Properties.Settings.Default.RestoreMode == true)
                {
                    StatusBar.Text = "Restoring...";

                    foreach (string originalDevice in Properties.Settings.Default.OriginalDevices)
                    {
                            DirectoryTools.PerformTransfer(Properties.Settings.Default.DefaultServer + originalDevice, target + Properties.Settings.Default.SourceDirectory + @"\" + originalDevice);
                    }

                    StatusBar.Text = "Complete.";

                    string LogFile = "logs\\" + Environment.UserName + "-restoration.txt";

                    using (StreamWriter w = File.AppendText(LogFile))
                    {
                        w.Write(DateTime.Now);
                        w.Write(Environment.NewLine);
                        w.Write(target.Remove(0, 2) + Environment.NewLine);
                        w.Write("Total Profiles Detected: " + ProfileCountContainer.Text + Environment.NewLine);
                        w.Write("Size of Profiles Transfered: " + TotalSizeContainer.Text + Environment.NewLine);
                        w.Write("Processed Files: " + ProcessedFilesContainer.Text + Environment.NewLine);
                        w.Write("Elapsed Time: " + ElapsedTimeContainer.Text + Environment.NewLine);
                        w.Write("Backup Location: \\" + "\\" + Properties.Settings.Default.DefaultServer + "\\" + target.Remove(0, 2) + Environment.NewLine);
                        w.Write(Environment.NewLine);
                    }

                }
                else
                {
                    StatusBar.Text = "Performing backup...";

                    // If using custom destination, copy to specified directory rather than creating workstation directory with profiles as subdirectories.

                    if (Properties.Settings.Default.UseCustomDestination == true)
                    {
                        Transfer(target, Properties.Settings.Default.DestinationDirectory, DirectoryTools);
                    }
                    else
                    {
                        Transfer(target, target.Remove(0, 2), DirectoryTools);
                    }

                    if (StatusBar.Text == "")
                    {
                        StatusBar.Text = "Transfer failed. Verify target is online and that you have sufficient privileges.";
                        File.AppendAllText("logs\\" + Environment.UserName + ".txt", target + ": FAILED" + Environment.NewLine);
                    }
                    else
                    {
                        // If CalculateProfileSizes setting is enabled, determine transfer size after initiating backup.

                        if (Properties.Settings.Default.CalculateProfileSizes)
                        {
                            StatusBar.Text = "Calculating size of profile(s)...";
                            DirectoryTools.CalculateProfileSizes(Properties.Settings.Default.DefaultServer + target, DirectoryTools.ProcessDirectorySizes);
                        }

                        int ProfilesTransfered = 0;

                        try
                        {
                            string[] users = Directory.GetDirectories(Properties.Settings.Default.DefaultServer + target);

                            foreach (string user in users)
                            {
                                DateTime CreationDateThreshold = Properties.Settings.Default.TransferDateThreshold;

                                var lastModifiedDate = new DirectoryInfo(user);

                                DateTime created = lastModifiedDate.LastWriteTime;

                                if (created > CreationDateThreshold)
                                {
                                    foreach (string folder in Properties.Settings.Default.Folders)
                                    {
                                        ProfilesTransfered++;
                                    }
                                }
                            }
                        }
                        catch { }

                        StatusBar.Text = "Complete.";

                        string LogFile = "logs\\" + Environment.UserName + ".txt";

                        using (StreamWriter w = File.AppendText(LogFile))
                        {
                            w.Write(DateTime.Now);
                            w.Write(Environment.NewLine);
                            w.Write(target.Remove(0, 2) + Environment.NewLine);
                            w.Write("Total Profiles Detected: " + ProfileCountContainer.Text + Environment.NewLine);
                            w.Write("Size of Profiles Transfered: " + TotalSizeContainer.Text + Environment.NewLine);
                            w.Write("Profiles Transfered: " + ProfilesTransfered + Environment.NewLine);
                            w.Write("Processed Files: " + ProcessedFilesContainer.Text + Environment.NewLine);
                            w.Write("Elapsed Time: " + ElapsedTimeContainer.Text + Environment.NewLine);
                            w.Write("Backup Location: \\" + "\\" + Properties.Settings.Default.DefaultServer + "\\" + target.Remove(0, 2) + Environment.NewLine);
                            w.Write(Environment.NewLine);
                        }
                    }

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
        }

        private void Transfer(string Source, string Destination, DirectoryTools DirectoryTool)
        {

            if (Properties.Settings.Default.CopyAll == true)
            {   
                if (Properties.Settings.Default.UseCustomDestination)
                {
                    DirectoryTool.PerformTransfer(Source + Properties.Settings.Default.SourceDirectory, Properties.Settings.Default.DefaultServer + Properties.Settings.Default.DestinationDirectory);
                }
                else
                {
                    DirectoryTool.PerformTransfer(Source + Properties.Settings.Default.SourceDirectory, Properties.Settings.Default.DefaultServer + Source.Remove(0, 2));
                }

            }
            else
            {
                try
                {
                    string[] users = Directory.GetDirectories(Source + Properties.Settings.Default.SourceDirectory);

                    foreach (string user in users)
                    {
                        DateTime CreationDateThreshold = Properties.Settings.Default.TransferDateThreshold;

                        var lastModifiedDate = new DirectoryInfo(user);

                        DateTime created = lastModifiedDate.LastWriteTime;

                        if (created > CreationDateThreshold)
                        {
                            foreach (string folder in Properties.Settings.Default.Folders)
                            {

                                    var userName = new DirectoryInfo(user).Name;
                                    DirectoryTool.PerformTransfer(user + "\\" + folder, Properties.Settings.Default.DefaultServer + "\\" + Destination + "\\" + userName + "\\" + folder);
                            }
                        }                  
                    }
                }
                catch { }

            }
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
            StatusBar.Visible = true;
            StopButton.Enabled = true;
            StartTransferButton.Enabled = false;
            ProgressBar.Value = 0;
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

        private void AddMachineButton_Click(object sender, EventArgs e)
        {
            AddDevice AddDeviceTool = new AddDevice(this);
            AddDeviceTool.Show();
        }


        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            Connections Connections = new Connections();
            Connections.Show();
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
            DisconnectSessionButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
            AddBatchButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);

            if(Properties.Settings.Default.RestoreMode)
            {
                restorationModeToolStripMenuItem1.Checked = true;
                backupModeToolStripMenuItem1.Checked = false;
                Text = "Profile Backup Tool - Restoration Mode";
                RestorationTargetsButton.Enabled = true;
                AddBatchButton.Enabled = false;
                AddMachineButton.Enabled = false;

            }
            else
            {
                restorationModeToolStripMenuItem1.Checked = false;
                backupModeToolStripMenuItem1.Checked = true;
                Text = "Profile Backup Tool - Backup Mode";
                RestorationTargetsButton.Enabled = false;
                AddBatchButton.Enabled = true;
                AddMachineButton.Enabled = true;

            }

            ToolTip AddMachineToolTip = new ToolTip();
            AddMachineToolTip.SetToolTip(AddMachineButton, "Add new target machine.");

            ToolTip RemoveMachineToolTip = new ToolTip();
            RemoveMachineToolTip.SetToolTip(RemoveDeviceButton, "Remove target machine.");

            ToolTip ConnectionsToolTip = new ToolTip();
            ConnectionsToolTip.SetToolTip(ConnectionButton, "Modify backup server connection settings.");

            ToolTip PreferencesToolTip = new ToolTip();
            PreferencesToolTip.SetToolTip(PreferencesButton, "Edit application preferences.");

            ToolTip DisconnectSessionToolip = new ToolTip();
            DisconnectSessionToolip.SetToolTip(DisconnectSessionButton, "Disconnect users from remote workstation.");

            ToolTip AddMachinesToolTip = new ToolTip();
            AddMachinesToolTip.SetToolTip(AddBatchButton, "Add batch of devices.");

        }

        private void removeDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceList.Items.Remove(DeviceList.SelectedItem);
        }

        private void disconnectRemoteSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoteSessionTerminator rst = new RemoteSessionTerminator();
            rst.Show();
        }

        private void DisconnectSessionButton_Click(object sender, EventArgs e)
        {
            RemoteSessionTerminator rst = new RemoteSessionTerminator();
            rst.Show();
        }

        private void AddBatchButton_Click(object sender, EventArgs e)
        {
            AddDevices AddDevices = new AddDevices(DeviceList);
            AddDevices.Show();
            StartTransferButton.Enabled = true;
        }

        private void backupModeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            backupModeToolStripMenuItem1.Checked = true;
            restorationModeToolStripMenuItem1.Checked = false;
            Properties.Settings.Default.RestoreMode = false;
            Properties.Settings.Default.Save();
            Text = "Profile Backup Tool - Backup Mode";
            RestorationTargetsButton.Enabled = false;
            AddBatchButton.Enabled = true;
            AddMachineButton.Enabled = true;
        }

        private void restorationModeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            backupModeToolStripMenuItem1.Checked = false;
            restorationModeToolStripMenuItem1.Checked = true;
            Properties.Settings.Default.RestoreMode = true;
            Properties.Settings.Default.Save();
            Text = "Profile Backup Tool - Restoration Mode";
            RestorationTargetsButton.Enabled = true;
            AddBatchButton.Enabled = false;
            AddMachineButton.Enabled = false;
            RestorationQuery RestorationQuery = new RestorationQuery(DeviceList, StartTransferButton);
            RestorationQuery.Show();
        }

        private void fIleToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void connectionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Connections Connections = new Connections();
            Connections.Show();
        }

        private void preferencesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Preferences Preferences = new Preferences();
            Preferences.Show();
        }

        private void addDeviceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddDevice AddDevice = new AddDevice(this);
            AddDevice.Show();
        }



        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DeviceList.Items.Remove(DeviceList.SelectedItem);
        }

        private void disconnectRemoteSessionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RemoteSessionTerminator rst = new RemoteSessionTerminator();
            rst.Show();
        }

        private void addBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDevices AddDevices = new AddDevices(DeviceList);
            AddDevices.Show();
        }

        private void saveReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveSession = new SaveFileDialog();
            saveSession.DefaultExt = "*.txt";
            saveSession.Filter = "txt|*.txt";
            saveSession.FileName = Environment.UserName + "-Profile Backup Session";
            if (saveSession.ShowDialog() == DialogResult.OK)
            {
                FileTransferContainer.SaveFile(saveSession.FileName, RichTextBoxStreamType.UnicodePlainText);
            }
        }

        private void RemoveDeviceButton_Click(object sender, EventArgs e)
        {
            DeviceList.Items.Remove(DeviceList.SelectedItem);
        }

        private void backupHistoryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BackupHistory BackupHistory = new BackupHistory();
            BackupHistory.Show();
        }

        private void RestorationTargetsButton_Click(object sender, EventArgs e)
        {
            RestorationQuery RestorationQuery = new RestorationQuery(DeviceList, StartTransferButton);
            RestorationQuery.Show();
        }
    }
}
