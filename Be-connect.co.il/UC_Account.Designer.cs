﻿namespace Be_connect.co.il
{
    partial class UC_Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Account));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AccountPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AccountName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(69, 140);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(69, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // AccountPass
            // 
            this.AccountPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AccountPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AccountPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AccountPass.HintForeColor = System.Drawing.Color.Empty;
            this.AccountPass.HintText = "";
            this.AccountPass.isPassword = true;
            this.AccountPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.AccountPass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.AccountPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.AccountPass.LineThickness = 3;
            this.AccountPass.Location = new System.Drawing.Point(106, 140);
            this.AccountPass.Margin = new System.Windows.Forms.Padding(4);
            this.AccountPass.Name = "AccountPass";
            this.AccountPass.Size = new System.Drawing.Size(203, 30);
            this.AccountPass.TabIndex = 25;
            this.AccountPass.Text = "password";
            this.AccountPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AccountPass.OnValueChanged += new System.EventHandler(this.AccountPass_OnValueChanged);
            // 
            // AccountName
            // 
            this.AccountName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AccountName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AccountName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AccountName.HintForeColor = System.Drawing.Color.Empty;
            this.AccountName.HintText = "";
            this.AccountName.isPassword = false;
            this.AccountName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.AccountName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.AccountName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.AccountName.LineThickness = 3;
            this.AccountName.Location = new System.Drawing.Point(106, 65);
            this.AccountName.Margin = new System.Windows.Forms.Padding(4);
            this.AccountName.Name = "AccountName";
            this.AccountName.Size = new System.Drawing.Size(203, 30);
            this.AccountName.TabIndex = 24;
            this.AccountName.Text = "username";
            this.AccountName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AccountName.OnValueChanged += new System.EventHandler(this.AccountName_OnValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.AccountName);
            this.groupBox1.Controls.Add(this.AccountPass);
            this.groupBox1.Location = new System.Drawing.Point(218, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 225);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(372, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(248, 387);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(318, 16);
            this.bunifuCustomLabel2.TabIndex = 124;
            this.bunifuCustomLabel2.Text = "Please Input Facebook Account username and password";
            // 
            // UC_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Account";
            this.Size = new System.Drawing.Size(800, 525);
            this.Load += new System.EventHandler(this.UC_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AccountPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AccountName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}