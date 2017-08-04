namespace Be_connect.co.il
{
    partial class UC_LikePost
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_LikePost));
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_Stop = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Start = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LikePostUrl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuSwitch_Comments = new Bunifu.Framework.UI.BunifuSwitch();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(257, 415);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(267, 16);
            this.bunifuCustomLabel2.TabIndex = 135;
            this.bunifuCustomLabel2.Text = "Please input Facebook page url and Click \"Start\"";
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_Stop.Image")));
            this.btn_Stop.ImageActive = null;
            this.btn_Stop.Location = new System.Drawing.Point(426, 305);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(50, 50);
            this.btn_Stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Stop.TabIndex = 134;
            this.btn_Stop.TabStop = false;
            this.btn_Stop.Zoom = 10;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Transparent;
            this.btn_Start.Image = ((System.Drawing.Image)(resources.GetObject("btn_Start.Image")));
            this.btn_Start.ImageActive = null;
            this.btn_Start.Location = new System.Drawing.Point(306, 305);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(50, 50);
            this.btn_Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Start.TabIndex = 133;
            this.btn_Start.TabStop = false;
            this.btn_Start.Zoom = 10;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(145, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 131;
            this.pictureBox2.TabStop = false;
            // 
            // LikePostUrl
            // 
            this.LikePostUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LikePostUrl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LikePostUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LikePostUrl.HintForeColor = System.Drawing.Color.Empty;
            this.LikePostUrl.HintText = "";
            this.LikePostUrl.isPassword = false;
            this.LikePostUrl.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.LikePostUrl.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.LikePostUrl.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.LikePostUrl.LineThickness = 3;
            this.LikePostUrl.Location = new System.Drawing.Point(201, 109);
            this.LikePostUrl.Margin = new System.Windows.Forms.Padding(4);
            this.LikePostUrl.Name = "LikePostUrl";
            this.LikePostUrl.Size = new System.Drawing.Size(446, 30);
            this.LikePostUrl.TabIndex = 132;
            this.LikePostUrl.Text = "https://www.facebook.com/homeownerwashere/";
            this.LikePostUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LikePostUrl.OnValueChanged += new System.EventHandler(this.LikePostUrl_OnValueChanged);
            // 
            // bunifuSwitch_Comments
            // 
            this.bunifuSwitch_Comments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSwitch_Comments.BorderRadius = 0;
            this.bunifuSwitch_Comments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuSwitch_Comments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch_Comments.Location = new System.Drawing.Point(256, 201);
            this.bunifuSwitch_Comments.Name = "bunifuSwitch_Comments";
            this.bunifuSwitch_Comments.Oncolor = System.Drawing.Color.SeaGreen;
            this.bunifuSwitch_Comments.Onoffcolor = System.Drawing.Color.DarkGray;
            this.bunifuSwitch_Comments.Size = new System.Drawing.Size(51, 19);
            this.bunifuSwitch_Comments.TabIndex = 136;
            this.bunifuSwitch_Comments.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch_Comments.Value = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(142, 203);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(91, 16);
            this.bunifuCustomLabel1.TabIndex = 137;
            this.bunifuCustomLabel1.Text = "Like  Comments";
            // 
            // UC_LikePost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuSwitch_Comments);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LikePostUrl);
            this.Name = "UC_LikePost";
            this.Size = new System.Drawing.Size(800, 525);
            this.Load += new System.EventHandler(this.UC_LikePost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuImageButton btn_Stop;
        private Bunifu.Framework.UI.BunifuImageButton btn_Start;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LikePostUrl;
        private Bunifu.Framework.UI.BunifuSwitch bunifuSwitch_Comments;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
