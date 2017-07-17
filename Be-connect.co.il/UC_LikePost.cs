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
            Settings.Default["commentText"] = commentText.Text;
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
            fc.FormText("Starting");
            navigator = fb.googleChrome();
            fc.FormText("Login Facebook");
            fb.facebookLogin(navigator, UC_Account.Instance.username, UC_Account.Instance.userpass);
            fc.FormText("");
            fb.gotoUrl(navigator, LikePostUrl.Text);
            fc.FormText("Liking post");
            fb.likeComments(navigator, commentText.Text);
            fc.FormText("");
            //Stop();
        }


    }
}
