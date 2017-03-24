﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileBackupTool
{
    public partial class RemoteSessionTerminator : Form
    {
        public RemoteSessionTerminator()
        {
            InitializeComponent();
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            // TODO: Modularize multiple appearances of the following operations
            try
            {
                ProcessStartInfo RemoteSessionTerminator = new ProcessStartInfo();
                RemoteSessionTerminator.UseShellExecute = false;
                RemoteSessionTerminator.FileName = @"c:\windows\system32\reset.exe";
                RemoteSessionTerminator.RedirectStandardError = true;
                RemoteSessionTerminator.Arguments = "Session Console /Server:" + DeviceName.Text.Remove(0, 2);

                using (Process proc = Process.Start(RemoteSessionTerminator))
                {
                    using (System.IO.StreamReader reader = proc.StandardError)
                    {
                        string result = reader.ReadToEnd();
                        MessageBox.Show(result);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Remote session termination is not supported on this system.");
            }

            this.Close();
        }
    }
}
