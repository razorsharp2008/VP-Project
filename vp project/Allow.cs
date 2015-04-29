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
            if (dvd_check.Checked == true || floppy_check.Checked == true || dvd_check.Checked == true ||
               phone_check.Checked == true)
            {
                MessageBox.Show("Selected devices can be accessed");
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
            }

            else if (usb_check.Checked == true)
            {
                usb_check.Checked = false;
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
    }
}
