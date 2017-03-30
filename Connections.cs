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
    public partial class Connections : Form
    {

        public Connections()
        {
            InitializeComponent();

            List<string> lines = new List<string>();
            try
            {
                using (StreamReader r = new StreamReader("config\\connections.txt"))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        if(line != "")
                        {
                            lines.Add(line);
                        }

                    }
                }

                foreach (string line in lines)
                {
                    ConnectionsList.Items.Add(line);
                }
            }
            catch
            {
                Directory.CreateDirectory("config");
                File.Create("config\\connections.txt").Close();
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddConnectionButton_Click(object sender, EventArgs e)
        {
            if(ValidateAccessCheckBox.Checked)
            {
                ValidateAccesibility();
            }

            // TODO: add server without verifying
        }

        public void ValidateAccesibility()
        {

            string ServerAddress = ServerAddressField.Text;

            try
            {
                File.Open(ServerAddress + "dummy.txt", FileMode.Create).Close();
                File.Delete(ServerAddress + "dummy.txt");

                if (ServerAddress != "")
                {

                    if (SetAsDefaultCheckbox.Checked)
                    {
                        Properties.Settings.Default.DefaultServer = ServerAddress;
                        Properties.Settings.Default.Save();
                        SetAsDefaultCheckbox.Checked = true;
                    }

                    ConnectionsList.Items.Add(ServerAddress);
                    File.AppendAllText("config\\connections.txt", ServerAddress + Environment.NewLine);
                }

            }
            catch
            {
                MessageBox.Show("Unable to contact network resource. Make sure UNC is valid .");
            }
        }

        private void SetAsDefaultCheckbox_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                    Properties.Settings.Default.DefaultServer = ConnectionsList.SelectedItem.ToString();
            }
            catch
            {

            }
        }

        private void RemoveConnectionButton_Click(object sender, EventArgs e)
        {
            if (ConnectionsList.Items.Count != 0)
            {
                try
                {
                    string item = ConnectionsList.SelectedItem.ToString();
                    string tempFile = Path.GetTempFileName();
                    string filePath = "config\\connections.txt";

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

                    File.Delete(filePath);
                    File.Move(tempFile, filePath);
                    ConnectionsList.Items.Remove(ConnectionsList.SelectedItem);
                    SetAsDefaultCheckbox.Checked = false;
                }
                catch 
                {
               //     MessageBox.Show(we.ToString());
                }
            }       
        }

        private void ConnectionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ConnectionsList.SelectedItem.ToString() == Properties.Settings.Default.DefaultServer)
                {
                    SetAsDefaultCheckbox.Checked = true;
                }
                else
                {
                    SetAsDefaultCheckbox.Checked = false;
                }
            }
            catch
            {

            }
        }
    }
}
