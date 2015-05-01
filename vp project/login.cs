using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vp_project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void log_Click(object sender, EventArgs e)
        {
            
            string login = "admin", password = "admin";
            if (textBox1.Text == login)
            {
                if (textBox2.Text == password)
                {
                    Main_menu obj = new Main_menu();
                    obj.Show();
                    Hide();
                }

                else
                    MessageBox.Show("Incorrect password");
            }

            else
                MessageBox.Show("Incorrect user name or password");
        }

        private void login_Load(object sender, EventArgs e)
        {
           
        }
    }
}
