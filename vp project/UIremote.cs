using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Permissions;
using Microsoft.Win32;
using System.Net;
using System.Net.Sockets;

namespace vp_project
{
    public partial class UIremote : Form
    {
        public UIremote()
        {
            InitializeComponent();
        }

        private void UIremote_Load(object sender, EventArgs e)
        {

        }

        private void USB_blocked_Click(object sender, EventArgs e)
        {
            RegistryKey environmentKey;
            string remoteName = "Hamza";

            //if (args.Length == 0)
            //{
            //    Console.WriteLine("Error: The name of the remote " +
            //        "computer must be specified when the program is " +
            //        "invoked.");
            //    return;
            //}

            //else
            //{
            //    remoteName = args[0];
            //}

            try
            {
                // Open HKEY_CURRENT_USER\Environment  
                // on a remote computer.
                environmentKey = RegistryKey.OpenRemoteBaseKey(
                    RegistryHive.LocalMachine, remoteName).OpenSubKey(
                    "SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", true);
                environmentKey.SetValue("Start", 4, RegistryValueKind.DWord);
            }
            catch (IOException a)
            {
                MessageBox.Show(a.GetType().Name + ", " + a.Message);
                return;
            }

            environmentKey.Close();
        }

        private void end_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
