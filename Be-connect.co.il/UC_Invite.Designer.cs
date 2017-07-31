namespace Be_connect.co.il
{
    partial class UC_Invite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Invite));
            this.btn_Stop = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Start = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.InviteUrl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_Stop.Image")));
            this.btn_Stop.ImageActive = null;
            this.btn_Stop.Location = new System.Drawing.Point(427, 256);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(50, 50);
            this.btn_Stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Stop.TabIndex = 139;
            this.btn_Stop.TabStop = false;
            this.btn_Stop.Zoom = 10;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Transparent;
            this.btn_Start.Image = ((System.Drawing.Image)(resources.GetObject("btn_Start.Image")));
            this.btn_Start.ImageActive = null;
            this.btn_Start.Location = new System.Drawing.Point(307, 256);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(50, 50);
            this.btn_Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Start.TabIndex = 138;
            this.btn_Start.TabStop = false;
            this.btn_Start.Zoom = 10;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(149, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 136;
            this.pictureBox2.TabStop = false;
            // 
            // InviteUrl
            // 
            this.InviteUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InviteUrl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.InviteUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InviteUrl.HintForeColor = System.Drawing.Color.Empty;
            this.InviteUrl.HintText = "";
            this.InviteUrl.isPassword = false;
            this.InviteUrl.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.InviteUrl.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.InviteUrl.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.InviteUrl.LineThickness = 3;
            this.InviteUrl.Location = new System.Drawing.Point(205, 148);
            this.InviteUrl.Margin = new System.Windows.Forms.Padding(4);
            this.InviteUrl.Name = "InviteUrl";
            this.InviteUrl.Size = new System.Drawing.Size(446, 30);
            this.InviteUrl.TabIndex = 137;
            this.InviteUrl.Text = "https://www.facebook.com/events/calendar/";
            this.InviteUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UC_Invite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.InviteUrl);
            this.Name = "UC_Invite";
            this.Size = new System.Drawing.Size(800, 525);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btn_Stop;
        private Bunifu.Framework.UI.BunifuImageButton btn_Start;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox InviteUrl;
    }
}
