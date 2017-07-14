namespace Be_connect.co.il
{
    partial class UC_Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Event));
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_Stop = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Start = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.EventUrl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(261, 369);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(269, 16);
            this.bunifuCustomLabel2.TabIndex = 135;
            this.bunifuCustomLabel2.Text = "Please input Facebook Event url and Click \"Start\"";
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_Stop.Image")));
            this.btn_Stop.ImageActive = null;
            this.btn_Stop.Location = new System.Drawing.Point(430, 259);
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
            this.btn_Start.Location = new System.Drawing.Point(310, 259);
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
            this.pictureBox2.Location = new System.Drawing.Point(152, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 131;
            this.pictureBox2.TabStop = false;
            // 
            // EventUrl
            // 
            this.EventUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EventUrl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EventUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EventUrl.HintForeColor = System.Drawing.Color.Empty;
            this.EventUrl.HintText = "";
            this.EventUrl.isPassword = false;
            this.EventUrl.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.EventUrl.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.EventUrl.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.EventUrl.LineThickness = 3;
            this.EventUrl.Location = new System.Drawing.Point(208, 151);
            this.EventUrl.Margin = new System.Windows.Forms.Padding(4);
            this.EventUrl.Name = "EventUrl";
            this.EventUrl.Size = new System.Drawing.Size(446, 30);
            this.EventUrl.TabIndex = 132;
            this.EventUrl.Text = "https://www.facebook.com/homeownerwashere/";
            this.EventUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EventUrl.OnValueChanged += new System.EventHandler(this.EventUrl_OnValueChanged);
            // 
            // UC_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.EventUrl);
            this.Name = "UC_Event";
            this.Size = new System.Drawing.Size(800, 525);
            this.Load += new System.EventHandler(this.UC_Event_Load);
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox EventUrl;
    }
}
