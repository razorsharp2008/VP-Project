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

       
    }
}
