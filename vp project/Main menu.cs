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
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        private void block_Click(object sender, EventArgs e)
        {
            block obj = new block();
            obj.Show();
            Hide();
        }

        private void allow_Click(object sender, EventArgs e)
        {
            Allow obj1 = new Allow();
            obj1.Show();
            Hide();
        }

        private void end_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }


    }
}
