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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        bool login = false;
        private void button1_Click(object sender, EventArgs e)
        {
            string username = "Beconnect";
            string password = "Connect2018";
            if (username.Contains(textBox_Name.Text) && password.Contains(textBox_Password.Text) && textBox_Name.Text != "" && textBox_Password.Text != "")
            {
                login = true;
                this.Close();
            } 
            else
                Application.Exit();

        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!login)
               Application.Exit();
        }
    }
}
