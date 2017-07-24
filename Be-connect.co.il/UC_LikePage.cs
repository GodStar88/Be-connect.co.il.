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
using OpenQA.Selenium;
using System.Threading;

namespace Be_connect.co.il
{
    public partial class UC_LikePage : UserControl
    {

        ThreadStart likePageThread;
        Thread likePageThread_Thread;
        IWebDriver navigator;

        public UC_LikePage()
        {
            InitializeComponent();
        }

        private void LikePageUrl_OnValueChanged(object sender, EventArgs e)
        {
            Settings.Default["LikePageUrl"] = LikePageUrl.Text;
            Settings.Default.Save();
        }

        private void UC_LikePage_Load(object sender, EventArgs e)
        {
            LikePageUrl.Text = Settings.Default["LikePageUrl"].ToString();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            likePageThread = new ThreadStart(likePageThreadStart);
            likePageThread_Thread = new Thread(likePageThread);
            likePageThread_Thread.Start();            
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
            try { likePageThread_Thread.Abort(); } catch (Exception) { }
            new CFormControl().FormText("");
        }
        private void likePageThreadStart()
        {
            CFacebook fb = new CFacebook();
            CFormControl fc = new CFormControl();           
            DataGridView dataGridView = UC_Account.Instance.facebookAccount;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                navigator = fb.googleChrome();
                fb.facebookLogin(navigator, dataGridView.Rows[i].Cells[1].Value.ToString(), dataGridView.Rows[i].Cells[3].Value.ToString());
                fc.FormText("Go to Page");
                fb.gotoUrl(navigator, LikePageUrl.Text);
                fc.FormText("Liking Page");
                fb.likePage(navigator);
                fc.FormText("");
                navigator.Quit();
            }
            Stop();
        }
    }
}
