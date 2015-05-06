using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace vp_project
{
    public partial class block : Form
    {
        public block()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Main_menu obj = new Main_menu();
            obj.Show();
            Hide();
        }

        private void save_changes_Click(object sender, EventArgs e)
        {
            if ((dvd_check.Checked == true) || (usb_check.Checked == true) || (floppy_check.Checked == true) ||
               (phone_check.Checked == true))
            {
                if (dvd_check.Checked == true)
                {
                    Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\cdrom", "Start", 4, Microsoft.Win32.RegistryValueKind.DWord);
                    MessageBox.Show("DVD access is blocked");
                }

                if (usb_check.Checked == true)
                {
                    if (full_block_check.Checked == true)
                    {
                        Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 4, Microsoft.Win32.RegistryValueKind.DWord);
                        MessageBox.Show("USB access is fully blocked");
                    }

                    else if (write_protect_check.Checked == true)
                    {
                        RegistryKey key = Registry.LocalMachine.OpenSubKey
               ("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", true);
                        if (key == null)
                        {
                            Registry.LocalMachine.CreateSubKey
                                ("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", RegistryKeyPermissionCheck.ReadWriteSubTree);
                            key = Registry.LocalMachine.OpenSubKey
                            ("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", true);
                            key.SetValue("WriteProtect", 1, RegistryValueKind.DWord);
                        }

                        else if (key.GetValue("WriteProtect") != (object)(1))
                        {
                            key.SetValue("WriteProtect", 1, RegistryValueKind.DWord);
                        }

                        MessageBox.Show("The USB is write protected");
                    }
                }

                if (phone_check.Checked == true)
                {
                    

                    MessageBox.Show("Mobile phone access is blocked");
                }

                if (floppy_check.Checked == true)
                {
                    Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\flpydisk", "Start", 4, Microsoft.Win32.RegistryValueKind.DWord);
                    MessageBox.Show("Floppy access is blocked");
                }
            }

            else
                MessageBox.Show("Please select a device to block access");
        }
        
            private void all_checked_Click(object sender, EventArgs e)
        {
            if (all_checked.Checked == false)
            {
                reset_checked.Checked = false;
                all_checked.Checked = true;
                floppy_check.Checked = true;
                dvd_check.Checked = true;
                phone_check.Checked = true;
                usb_check.Checked = true;
                if (usb_check.Checked == true)
                {
                    full_block_check.Visible = true;
                    full_block_check.Checked = false;
                    write_protect_check.Visible = true;
                    write_protect_check.Checked = false;
                }
            }

            else if (all_checked.Checked == true)
            {
                all_checked.Checked = false;
            }
        }

            private void dvd_check_Click(object sender, EventArgs e)
            {
                if (dvd_check.Checked == false)
                {
                    dvd_check.Checked = true;
                }

                else if (dvd_check.Checked == true)
                {
                    dvd_check.Checked = false;
                }
            }

            private void reset_checked_Click(object sender, EventArgs e)
            {
                if (reset_checked.Checked == false)
                {
                    all_checked.Checked = false;
                    reset_checked.Checked = true;
                    floppy_check.Checked = false;
                    dvd_check.Checked = false;
                    phone_check.Checked = false;
                    usb_check.Checked = false;
                    if (usb_check.Checked == false)
                    {
                        full_block_check.Visible = false;
                        full_block_check.Checked = false;
                        write_protect_check.Checked = false;
                        write_protect_check.Visible = false;
                    }
                }

                else if (reset_checked.Checked == true)
                {
                    reset_checked.Checked = false;
                }
            }

            private void floppy_check_Click(object sender, EventArgs e)
            {
                if (floppy_check.Checked == false)
                {
                    floppy_check.Checked = true;
                }

                else if (floppy_check.Checked == true)
                {
                    floppy_check.Checked = false;
                }
            }

            private void phone_check_Click(object sender, EventArgs e)
            {
                if (phone_check.Checked == false)
                {
                    phone_check.Checked = true;
                }

                else if (phone_check.Checked == true)
                {
                    phone_check.Checked = false;
                }
            }

            private void usb_check_Click(object sender, EventArgs e)
            {
                if (usb_check.Checked == false)
                {
                    usb_check.Checked = true;
                    full_block_check.Visible = true;
                    full_block_check.Checked = false;
                    write_protect_check.Visible = true;
                    write_protect_check.Checked = false;
                }

                else if (usb_check.Checked == true)
                {
                    usb_check.Checked = false;
                    full_block_check.Visible = false;
                    full_block_check.Checked = false;
                    write_protect_check.Checked = false;
                    write_protect_check.Visible = false;
                }
            }

            private void full_block_check_Click(object sender, EventArgs e)
            {
                if (full_block_check.Checked == false)
                {
                    full_block_check.Checked = true;
                }
            }

            private void write_protect_check_Click(object sender, EventArgs e)
            {
                if (write_protect_check.Checked == false)
                {
                    write_protect_check.Checked = true;
                }
            }

            private void write_protect_check_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void usb_group_Enter(object sender, EventArgs e)
            {

            }  
    }
}
