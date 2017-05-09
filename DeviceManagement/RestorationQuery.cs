using Profile_Backup_Tool;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProfileBackupTool.DeviceManagement
{
    public partial class RestorationQuery : Form
    {
        ListBox DeviceList;
        Button StartTransfer;

        public RestorationQuery(ListBox Devices, Button Transfer)
        {
            DeviceList = Devices;
            StartTransfer = Transfer;
            InitializeComponent();
        }

        private void RestorationQuery_Load(object sender, EventArgs e)
        {
            foreach(var item in Properties.Settings.Default.OriginalDevices)
            {
                OriginalDeviceList.Items.Add(item);
            }
        }

        private void AddOriginalDevice_Click(object sender, EventArgs e)
        {
            string originalDevice = OriginalDevice.Text;
            OriginalDeviceList.Items.Add(originalDevice);
        }

        private void RemoveOriginal_Click(object sender, EventArgs e)
        {
            OriginalDeviceList.Items.Remove(OriginalDeviceList.SelectedItem);
        }

        private void ViewLogs_Click(object sender, EventArgs e)
        {
            BackupHistory BackupHistory = new BackupHistory();
            BackupHistory.Show();
        }

        private void AddNewDevice_Click(object sender, EventArgs e)
        {
            string newDevice = NewDevice.Text;
            NewDevices.Items.Add(newDevice);
        }

        private void RemoveNew_Click(object sender, EventArgs e)
        {
            NewDevices.Items.Remove(NewDevices.SelectedItem);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResoreButton_Click(object sender, EventArgs e)
        {

            StringCollection originalDevices = new StringCollection();

            foreach (string item in OriginalDeviceList.Items)
            {
                originalDevices.Add(item);
            }

            foreach (string item in NewDevices.Items)
            {
                DeviceList.Items.Add(item);
            }

            Properties.Settings.Default.OriginalDevices = originalDevices;
            Properties.Settings.Default.Save();
            StartTransfer.Enabled = true;
            this.Close();
        }
    }
}
