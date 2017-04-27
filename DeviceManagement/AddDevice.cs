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
    public partial class AddDevice : Form
    {
        public AddDevice()
        {
            InitializeComponent();
        }

        private ProfileBackupTool main = null;

        public AddDevice(Form parent)
        {
            main = parent as ProfileBackupTool;
            InitializeComponent();
        }

        private void AddDeviceButton_Click(object sender, EventArgs e)
        {
            string ComputerName = DeviceName.Text;
            ConnectionStatus.Show();
            try
            {
                File.Open(ComputerName + "\\c$\\users\\public\\dummy.txt", FileMode.Create).Close();
                main.DeviceList.Items.Add(ComputerName);
                main.StartTransferButton.Enabled = true;
                File.Delete(ComputerName + "\\c$\\Users\\public\\dummy.txt");
                this.Close();
            }
            catch (Exception InvalidPath)
            {
                MessageBox.Show(InvalidPath.ToString());
                MessageBox.Show("Unable to reach target machine. Check permissions and ensure name is valid.");
                ConnectionStatus.Text = " Invalid computer name or insufficient privilages on target.";
                ConnectionStatus.ForeColor = Color.Red;
            }

        }

        private void CurrentMachineButton_Click(object sender, EventArgs e)
        {
            DeviceName.Text = @"\\" + Environment.MachineName;
        }
    }
}
