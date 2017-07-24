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
using System.Text.RegularExpressions;

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
        public DataGridView facebookAccount
        {
            get { return dataGridView_Account; }
            set { dataGridView_Account = value; }
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
            accountLoad();
            AccountName.Text = Settings.Default["AccountName"].ToString();
            AccountPass.Text = Settings.Default["AccountPass"].ToString();

            CKey ck = new CKey();
            if (!ck.keyCheck()) Application.Exit();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (AccountName.Text == "" || AccountPass.Text == "")
                {
                    MessageBox.Show("Please enter a username and password!");
                    return;
                }
                string p = "";
                for (int i = 0; i < AccountPass.Text.Length; i++)
                {
                    p = p + "*";
                }
                dataGridView_Account.Rows.Add(false, AccountName.Text, p, AccountPass.Text);
                Settings.Default["AccountList"] =  Settings.Default["AccountList"].ToString() + Environment.NewLine + AccountName.Text + ":" + p + ":" + AccountPass.Text + Environment.NewLine;
                Settings.Default.Save();
            }
            catch (Exception)
            {
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            new CFormControl().gridRowsDelete(dataGridView_Account);
            string text = "";
            for (int i = 0; i < dataGridView_Account.Rows.Count; i++)
            {
                text = text + dataGridView_Account.Rows[i].Cells[1].Value.ToString() + ":" + dataGridView_Account.Rows[i].Cells[2].Value.ToString() + ":" + dataGridView_Account.Rows[i].Cells[3].Value.ToString() + Environment.NewLine;
            }

            Settings.Default["AccountList"] = text;
            Settings.Default.Save();

        }

        private void checkBox_Account_CheckedChanged(object sender, EventArgs e)
        {
            new CFormControl().checkAll(dataGridView_Account, checkBox_Account);
        }
        private void accountLoad()
        {
            string text = "";
            try
            {
                text = Settings.Default["AccountList"].ToString();
            }
            catch (Exception)
            {
            }
            var csv = new StringBuilder();
            string[] contact = Regex.Split(text, "\r\n");

            for (int i = 0; i < contact.Length; i++)
            {
                try
                {
                    string[] info = contact[i].Split(':');
                    dataGridView_Account.Rows.Add(false, info[0], info[1], info[2]);
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
