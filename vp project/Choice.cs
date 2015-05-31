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
    public partial class Choice : Form
    {
        public Choice()
        {
            InitializeComponent();
        }

        private void end_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void this_comp_Click(object sender, EventArgs e)
        {
            Main_menu obj = new Main_menu();
            obj.Show();
            Hide();
        }

        private void remote_comp_Click(object sender, EventArgs e)
        {
            Remote obj1 = new Remote();
            obj1.Show();
            Hide();
        }
    }
}
