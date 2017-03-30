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
    public partial class AddDevices : Form
    {
        ListBox DeviceList;

        public AddDevices(ListBox Devices)
        {
            DeviceList = Devices;

            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            foreach (string line in Devices.Lines)
            {
                DeviceList.Items.Add(line);
                this.Close();
            }
        }
    }
}
