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
using System.Threading;
using OpenQA.Selenium;

namespace Be_connect.co.il
{
    public partial class UC_LikePost : UserControl
    {
        public UC_LikePost()
        {
            InitializeComponent();
        }
        ThreadStart likePostThread;
        Thread likePostThread_Thread;
        IWebDriver navigator;
        private void LikePostUrl_OnValueChanged(object sender, EventArgs e)
        {
            Settings.Default["LikePostUrl"] = LikePostUrl.Text;
            Settings.Default.Save();
        }

        private void commentText_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.Save();
        }
        private void UC_LikePost_Load(object sender, EventArgs e)
        {
            LikePostUrl.Text = Settings.Default["LikePostUrl"].ToString();
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            likePostThread = new ThreadStart(likePostThreadStart);
            likePostThread_Thread = new Thread(likePostThread);
            likePostThread_Thread.Start();
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
            try { likePostThread_Thread.Abort(); } catch (Exception) { }
            new CFormControl().FormText("");
        }
        public void likePostThreadStart()
        {
            CFacebook fb = new CFacebook();
            CFormControl fc = new CFormControl();
            

            DataGridView dataGridView = UC_Account.Instance.facebookAccount;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView.Rows[i].Cells[0].Value))
                {
                    navigator = fb.googleChrome();
                    fb.facebookLogin(navigator, dataGridView.Rows[i].Cells[1].Value.ToString(), dataGridView.Rows[i].Cells[3].Value.ToString());
                    fb.gotoUrl(navigator, LikePostUrl.Text);
                    // fb.gotoUrl(navigator, "https://www.facebook.com/igordro/posts/10210930281467745?comment_id=10210930691077985&comment_tracking=%7Btn%3AR1%7D");

                    fc.FormText("Liking post");
                    fb.likeComments(navigator);
                    fc.FormText("");
                    navigator.Quit();
                }
                
            }
            Stop();
        }


    }
}
