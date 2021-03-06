﻿using System;
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

        private static Form1 _instance;

        public Form1()
        {
            InitializeComponent();
            _instance = this;
        }

        public string TextStatus
        {
            get { return label_State.Text; }
            set { label_State.Text = value; }
        }
        public static Form1 Instance { get { return _instance; } }

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
            uC_Event1.Visible = false;
            uC_LikePage1.Visible = false;
            uC_Post1.Visible = false;
            uC_LikePost1.Visible = false;
            uC_Invite1.Visible = false;
            uC_Account1.Show();
        }

        private void btn_tab2_Click(object sender, EventArgs e)
        {
            bunifuSeparator.Width = btn_tab2.Width;
            bunifuSeparator.Left = btn_tab2.Left;
            uC_Event1.Visible = false;
            uC_Account1.Visible = false;
            uC_Post1.Visible = false;
            uC_LikePage1.Visible = false;
            uC_Invite1.Visible = false;
            uC_LikePost1.Show();
        }

        private void btn_tab3_Click(object sender, EventArgs e)
        {
            bunifuSeparator.Width = btn_tab3.Width;
            bunifuSeparator.Left = btn_tab3.Left;
            uC_Event1.Visible = false;
            uC_Account1.Visible = false;
            uC_Post1.Visible = false;
            uC_LikePost1.Visible = false;
            uC_Invite1.Visible = false;
            uC_LikePage1.Show();

        }

        private void btn_tab4_Click(object sender, EventArgs e)
        {
            bunifuSeparator.Width = btn_tab4.Width;
            bunifuSeparator.Left = btn_tab4.Left;
            uC_Account1.Visible = false;
            uC_LikePage1.Visible = false;
            uC_Post1.Visible = false;
            uC_LikePost1.Visible = false;
            uC_Invite1.Visible = false;
            uC_Event1.Show();
        }

        private void btn_tab5_Click(object sender, EventArgs e)
        {
            bunifuSeparator.Width = btn_tab5.Width;
            bunifuSeparator.Left = btn_tab5.Left;
            uC_Account1.Visible = false;
            uC_LikePage1.Visible = false;
            uC_Event1.Visible = false;
            uC_LikePost1.Visible = false;
            uC_Invite1.Visible = false;
            uC_Post1.Show();
        }

        private void btn_tab6_Click(object sender, EventArgs e)
        {
            bunifuSeparator.Width = btn_tab6.Width;
            bunifuSeparator.Left = btn_tab6.Left;
            uC_Account1.Visible = false;
            uC_LikePage1.Visible = false;
            uC_Event1.Visible = false;
            uC_LikePost1.Visible = false;
            uC_Post1.Visible = false;
            uC_Invite1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // FrmLogin login = new FrmLogin();
            // login.ShowDialog();
            // this.ShowInTaskbar = false;
        }
    }
}
