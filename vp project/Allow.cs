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
    public partial class Allow : Form
    {
        public Allow()
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
                    Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\cdrom", "Start", 3, Microsoft.Win32.RegistryValueKind.DWord);
                    MessageBox.Show("DVD access is allowed");
                }

                if (usb_check.Checked == true)
                {
                    if (Allow_access.Checked == true)
                    {
                        Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 3, Microsoft.Win32.RegistryValueKind.DWord);
                        MessageBox.Show("USB/Portable HDD access is allowed");
                    }

                    else if (Disable_write_protect.Checked == true)
                    {
                        RegistryKey key = Registry.LocalMachine.OpenSubKey
                        ("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", true);
                        if (key != null)
                        {
                            key.SetValue("WriteProtect", 0, RegistryValueKind.DWord);
                        }
                        key.Close();
                        MessageBox.Show("USB/Portable HDD is no longer write protected");
                    }
                }


                if (phone_check.Checked == true)
                {
                    MessageBox.Show("Mobile phone access is allowed");
                }

                if (floppy_check.Checked == true)
                {
                   Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\flpydisk", "Start", 3, Microsoft.Win32.RegistryValueKind.DWord);
                   MessageBox.Show("Floppy access is allowed");
                }
            }

            else
                MessageBox.Show("Please select a device to allow access");
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
                    Allow_access.Visible = true;
                    Allow_access.Checked = false;
                    Disable_write_protect.Visible = true;
                    Disable_write_protect.Checked = false;
                }
            }

            else if (all_checked.Checked == true)
            {
                all_checked.Checked = false;
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
                Allow_access.Visible = true;
                Allow_access.Checked = false;
                Disable_write_protect.Visible = true;
                Disable_write_protect.Checked = false;
            }

            else if (usb_check.Checked == true)
            {
                usb_check.Checked = false;
                Allow_access.Visible = false;
                Allow_access.Checked = false;
                Disable_write_protect.Visible = false;
                Disable_write_protect.Checked = false;
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
                    Allow_access.Visible = false;
                    Allow_access.Checked = false;
                    Disable_write_protect.Visible = false;
                    Disable_write_protect.Checked = false;
                }
            }

            else if (reset_checked.Checked == true)
            {
                reset_checked.Checked = false;
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

        private void usb_check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Disable_write_protect_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Allow_access_Click(object sender, EventArgs e)
        {
            if(Allow_access.Checked == false)
            {
                Allow_access.Checked = true;
            }
        }

        private void Disable_write_protect_Click(object sender, EventArgs e)
        {
            if(Disable_write_protect.Checked == false)
            {
                Disable_write_protect.Checked = true;
            }
        }

        
    }
}
