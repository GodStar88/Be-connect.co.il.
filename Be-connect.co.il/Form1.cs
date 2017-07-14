using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Be_connect.co.il
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Minimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_tab1_Click(object sender, EventArgs e)
        {
            bunifuSeparator.Width = btn_tab1.Width;
            bunifuSeparator.Left = btn_tab1.Left;
        }

        private void btn_tab2_Click(object sender, EventArgs e)
        {
            bunifuSeparator.Width = btn_tab2.Width;
            bunifuSeparator.Left = btn_tab2.Left;
        }

        private void btn_tab3_Click(object sender, EventArgs e)
        {
            bunifuSeparator.Width = btn_tab3.Width;
            bunifuSeparator.Left = btn_tab3.Left;
        }

        private void btn_tab4_Click(object sender, EventArgs e)
        {
            bunifuSeparator.Width = btn_tab4.Width;
            bunifuSeparator.Left = btn_tab4.Left;
        }

        private void btn_tab5_Click(object sender, EventArgs e)
        {
            bunifuSeparator.Width = btn_tab5.Width;
            bunifuSeparator.Left = btn_tab5.Left;
        }
    }
}
