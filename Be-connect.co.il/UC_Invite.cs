using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium;

namespace Be_connect.co.il
{
    public partial class UC_Invite : UserControl
    {
        public UC_Invite()
        {
            InitializeComponent();
        }
        ThreadStart eventThread;
        Thread eventThread_Thread;
        IWebDriver navigator;
        private void btn_Start_Click(object sender, EventArgs e)
        {
            eventThread = new ThreadStart(lnviteThreadStart);
            eventThread_Thread = new Thread(eventThread);
            eventThread_Thread.Start();
            btn_Start.Enabled = false;
            btn_Stop.Enabled = true;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Stop();
        }
        public void Stop()
        {
            btn_Start.Enabled = true;
            btn_Stop.Enabled = false;
            try { navigator.Quit(); } catch (Exception) { }
            try { eventThread_Thread.Abort(); } catch (Exception) { }
            new CFormControl().FormText("");
        }
        private void lnviteThreadStart()
        {
            CFacebook fb = new CFacebook();
            CFormControl fc = new CFormControl();
            fc.FormText("Starting");
            DataGridView dataGridView = UC_Account.Instance.facebookAccount;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView.Rows[i].Cells[0].Value))
                {
                    navigator = fb.googleChrome();
                    fb.facebookLogin(navigator, dataGridView.Rows[i].Cells[1].Value.ToString(), dataGridView.Rows[i].Cells[3].Value.ToString());
                    fc.FormText("Go to Event");
                    fb.gotoUrl(navigator, InviteUrl.Text);
                    //fb.gotoUrl(navigator, "https://www.facebook.com/events/1675776565790551");
                    fb.inviteEvent(navigator);
                    fc.FormText("");
                    navigator.Quit();
                }
            }
            Stop();
        }
    }
}
