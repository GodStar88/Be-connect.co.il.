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
using System.IO;
using System.Threading;
using OpenQA.Selenium;

namespace Be_connect.co.il
{
    public partial class UC_Post : UserControl
    {
        public UC_Post()
        {
            InitializeComponent();
        }

        private void PoatUrl_OnValueChanged(object sender, EventArgs e)
        {
            Settings.Default["PoatUrl"] = PoatUrl.Text;
            Settings.Default.Save();
        }

        private void UC_Post_Load(object sender, EventArgs e)
        {
            PoatUrl.Text = Settings.Default["PoatUrl"].ToString();
            writePost.Text = Settings.Default["writePost"].ToString();
            imageListLoad();
        }

        private void photoSelect_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(photoSelect, 0, 23);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Photo file";
            theDialog.Filter = "All files|*.*";
            theDialog.Multiselect = true;
            theDialog.InitialDirectory = Settings.Default["photoFile"].ToString();
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Default["photoFile"] = Path.GetDirectoryName(theDialog.FileName);
                Settings.Default.Save();

                string path = Path.GetFullPath(theDialog.FileName);
                Image image = Image.FromFile(path);

                int image_width = 162;
                int image_height = 167;
                Padding p = new System.Windows.Forms.Padding();
                if (image.Height < image.Width)
                {
                    image_height = 167 * image.Height / image.Width;
                    p.Top = (167 - image_height) / 2;
                }
                if (image.Height >= image.Width)
                {
                    image_width = 162 * image.Width / image.Height;
                    p.Left = (162 - image_width);
                }
                image = (Image)(new Bitmap(image, new Size(image_width, image_height)));
                imagePath.Padding = p;
                imagePath.Image = image;
                Settings.Default["imageList"] = path;
                Settings.Default.Save();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagePath.Image = null;
            Settings.Default["imageList"] = "";
            Settings.Default.Save();
        }

        private void imageListLoad()
        {
            var path = Settings.Default["imageList"].ToString();
            try
            {
                Image image = Image.FromFile(path);
                int image_width = 162;
                int image_height = 167;
                Padding p = new System.Windows.Forms.Padding();
                if (image.Height < image.Width)
                {
                    image_height = 167 * image.Height / image.Width;
                    p.Top = (167 - image_height) / 2;
                }
                if (image.Height >= image.Width)
                {
                    image_width = 162 * image.Width / image.Height;
                    p.Left = (162 - image_width);
                }
                image = (Image)(new Bitmap(image, new Size(image_width, image_height)));
                imagePath.Padding = p;
                imagePath.Image = (Image)(new Bitmap(image, new Size(image_width, image_height)));
            }
            catch (Exception)
            {
            }
        }

        private void writePost_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["writePost"] = writePost.Text;
            Settings.Default.Save();
        }


        ThreadStart postThread;
        Thread postThread_Thread;
        IWebDriver navigator;

        private void btn_Start_Click(object sender, EventArgs e)
        {
            postThread = new ThreadStart(postThreadStart);
            postThread_Thread = new Thread(postThread);
            postThread_Thread.Start();
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
            try { postThread_Thread.Abort(); } catch (Exception) { }
            new CFormControl().FormText("");
        }

        private void postThreadStart()
        {
            CFacebook fb = new CFacebook();
            CFormControl fc = new CFormControl();
            fc.FormText("Starting");

            navigator = fb.googleChrome();
            fc.FormText("Login Facebook");
            fb.facebookLogin(navigator, UC_Account.Instance.username, UC_Account.Instance.userpass);
            if (PoatUrl.Text.Contains("groups"))
            {
                fc.FormText("Go to Group");
                fb.gotoUrl(navigator, PoatUrl.Text);
                fc.FormText("Posting");
                fb.groupPost(navigator, writePost.Text);
            }
            else
            {
                fc.FormText("Go to Page");
                fb.gotoUrl(navigator, PoatUrl.Text);
                fc.FormText("Posting");
                fb.pagePost(navigator, writePost.Text);
            }
            fc.FormText("");
            Stop();
        }
    }
}
