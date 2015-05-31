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
    public partial class Remote : Form
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();

        public Remote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Remote_Load(object sender, EventArgs e)
        {
            textRemoteIp.Text = "192.168.1.2";
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }

       

        private void previous_Click(object sender, EventArgs e)
        {
            Choice obj = new Choice();
            obj.Show();
            this.Close();
        }

        private void connection_Click_1(object sender, EventArgs e)
        {
            try
            {
                clientSocket.Connect(textRemoteIp.Text, 8888);
                MessageBox.Show("Connected to server");
                connection.Visible = false;
                textRemoteIp.Visible = false;
                ip_label.Visible = false;
                block_container.Visible = true;
                allow_container.Visible = true;
                previous.Visible = false;
                disconnect.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("No connection could be made because the target machine actively refused it");
            }
        }

        private void rem_block_usb_Click(object sender, EventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("Block usb");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

        private void rem_block_dvd_Click(object sender, EventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("Block dvd");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

        private void rem_block_floppy_Click(object sender, EventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("Block floppy");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

        private void rem_allow_usb_Click(object sender, EventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("Allow usb");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

        private void rem_allow_dvd_Click(object sender, EventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("Allow dvd");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

        private void rem_allow_floppy_Click(object sender, EventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("Allow floppy");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("Disconnect");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            MessageBox.Show("Disconnected from server");
            connection.Visible = true;
            textRemoteIp.Visible = true;
            ip_label.Visible = true;
            block_container.Visible = false;
            allow_container.Visible = false;
            previous.Visible = true;
            disconnect.Visible = false;
        }
    }
}
