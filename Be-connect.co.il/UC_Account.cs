using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Be_connect.co.il.Properties;

namespace Be_connect.co.il
{
    public partial class UC_Account : UserControl
    {
        private static UC_Account _instance;
        public UC_Account()
        {
            InitializeComponent();
            _instance = this;
        }
        public string username
        {
            get { return AccountName.Text; }
            set { AccountName.Text = value; }
        }
        public string userpass
        {
            get { return AccountPass.Text; }
            set { AccountPass.Text = value; }
        }
        public static UC_Account Instance { get { return _instance; } }

        private void AccountName_OnValueChanged(object sender, EventArgs e)
        {
            Settings.Default["AccountName"] = AccountName.Text;
            Settings.Default.Save();
        }

        private void AccountPass_OnValueChanged(object sender, EventArgs e)
        {
            Settings.Default["AccountPass"] = AccountPass.Text;
            Settings.Default.Save();
        }

        private void UC_Account_Load(object sender, EventArgs e)
        {
            AccountName.Text = Settings.Default["AccountName"].ToString();
            AccountPass.Text = Settings.Default["AccountPass"].ToString();
        }
    }
}
