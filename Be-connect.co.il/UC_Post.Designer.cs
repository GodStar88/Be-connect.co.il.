﻿namespace Be_connect.co.il
{
    partial class UC_Post
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Post));
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_Stop = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Start = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PoatUrl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.imagePath = new System.Windows.Forms.PictureBox();
            this.writePost = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.photoSelect = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(237, 464);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(372, 16);
            this.bunifuCustomLabel2.TabIndex = 135;
            this.bunifuCustomLabel2.Text = "Please input Facebook page / Group url, Write post and Click \"Start\"";
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_Stop.Image")));
            this.btn_Stop.ImageActive = null;
            this.btn_Stop.Location = new System.Drawing.Point(423, 356);
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
            this.btn_Start.Location = new System.Drawing.Point(303, 356);
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
            this.pictureBox2.Location = new System.Drawing.Point(161, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 131;
            this.pictureBox2.TabStop = false;
            // 
            // PoatUrl
            // 
            this.PoatUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PoatUrl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PoatUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PoatUrl.HintForeColor = System.Drawing.Color.Empty;
            this.PoatUrl.HintText = "";
            this.PoatUrl.isPassword = false;
            this.PoatUrl.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.PoatUrl.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.PoatUrl.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.PoatUrl.LineThickness = 3;
            this.PoatUrl.Location = new System.Drawing.Point(217, 56);
            this.PoatUrl.Margin = new System.Windows.Forms.Padding(4);
            this.PoatUrl.Name = "PoatUrl";
            this.PoatUrl.Size = new System.Drawing.Size(446, 30);
            this.PoatUrl.TabIndex = 132;
            this.PoatUrl.Text = "https://www.facebook.com/homeownerwashere/";
            this.PoatUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PoatUrl.OnValueChanged += new System.EventHandler(this.PoatUrl_OnValueChanged);
            // 
            // imagePath
            // 
            this.imagePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePath.Location = new System.Drawing.Point(481, 153);
            this.imagePath.Name = "imagePath";
            this.imagePath.Size = new System.Drawing.Size(162, 167);
            this.imagePath.TabIndex = 137;
            this.imagePath.TabStop = false;
            // 
            // writePost
            // 
            this.writePost.Location = new System.Drawing.Point(130, 153);
            this.writePost.Multiline = true;
            this.writePost.Name = "writePost";
            this.writePost.Size = new System.Drawing.Size(320, 167);
            this.writePost.TabIndex = 136;
            this.writePost.Text = "Hi";
            this.writePost.TextChanged += new System.EventHandler(this.writePost_TextChanged);
            // 
            // photoSelect
            // 
            this.photoSelect.Location = new System.Drawing.Point(659, 297);
            this.photoSelect.Name = "photoSelect";
            this.photoSelect.Size = new System.Drawing.Size(25, 23);
            this.photoSelect.TabIndex = 138;
            this.photoSelect.Text = "...";
            this.photoSelect.UseVisualStyleBackColor = true;
            this.photoSelect.Click += new System.EventHandler(this.photoSelect_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // UC_Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.photoSelect);
            this.Controls.Add(this.imagePath);
            this.Controls.Add(this.writePost);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PoatUrl);
            this.Name = "UC_Post";
            this.Size = new System.Drawing.Size(800, 525);
            this.Load += new System.EventHandler(this.UC_Post_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuImageButton btn_Stop;
        private Bunifu.Framework.UI.BunifuImageButton btn_Start;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PoatUrl;
        private System.Windows.Forms.PictureBox imagePath;
        private System.Windows.Forms.TextBox writePost;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button photoSelect;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}
