namespace Be_connect.co.il
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AccountPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AccountName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_Add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkBox_Account = new System.Windows.Forms.CheckBox();
            this.dataGridView_Account = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Account)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(105, 140);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(105, 65);
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
            this.AccountPass.Location = new System.Drawing.Point(142, 140);
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
            this.AccountName.Location = new System.Drawing.Point(142, 65);
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
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.checkBox_Account);
            this.groupBox1.Controls.Add(this.dataGridView_Account);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.AccountName);
            this.groupBox1.Controls.Add(this.AccountPass);
            this.groupBox1.Location = new System.Drawing.Point(114, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 407);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(383, 16);
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
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(243, 485);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(318, 16);
            this.bunifuCustomLabel2.TabIndex = 124;
            this.bunifuCustomLabel2.Text = "Please Input Facebook Account username and password";
            // 
            // btn_Add
            // 
            this.btn_Add.AccessibleDescription = "";
            this.btn_Add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btn_Add.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Add.BorderRadius = 3;
            this.btn_Add.ButtonText = "Add";
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Add.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Add.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Add.Iconimage")));
            this.btn_Add.Iconimage_right = null;
            this.btn_Add.Iconimage_right_Selected = null;
            this.btn_Add.Iconimage_Selected = null;
            this.btn_Add.IconMarginLeft = 0;
            this.btn_Add.IconMarginRight = 0;
            this.btn_Add.IconRightVisible = true;
            this.btn_Add.IconRightZoom = 0D;
            this.btn_Add.IconVisible = true;
            this.btn_Add.IconZoom = 50D;
            this.btn_Add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Add.IsTab = false;
            this.btn_Add.Location = new System.Drawing.Point(379, 82);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.btn_Add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btn_Add.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Add.selected = false;
            this.btn_Add.Size = new System.Drawing.Size(95, 30);
            this.btn_Add.TabIndex = 132;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Add.Textcolor = System.Drawing.Color.White;
            this.btn_Add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.AccessibleDescription = "";
            this.btn_Delete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btn_Delete.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Delete.BorderRadius = 3;
            this.btn_Delete.ButtonText = "Delete";
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Delete.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Delete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Iconimage")));
            this.btn_Delete.Iconimage_right = null;
            this.btn_Delete.Iconimage_right_Selected = null;
            this.btn_Delete.Iconimage_Selected = null;
            this.btn_Delete.IconMarginLeft = 0;
            this.btn_Delete.IconMarginRight = 0;
            this.btn_Delete.IconRightVisible = true;
            this.btn_Delete.IconRightZoom = 0D;
            this.btn_Delete.IconVisible = true;
            this.btn_Delete.IconZoom = 50D;
            this.btn_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Delete.IsTab = false;
            this.btn_Delete.Location = new System.Drawing.Point(379, 139);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.btn_Delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btn_Delete.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Delete.selected = false;
            this.btn_Delete.Size = new System.Drawing.Size(95, 30);
            this.btn_Delete.TabIndex = 130;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Delete.Textcolor = System.Drawing.Color.White;
            this.btn_Delete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // checkBox_Account
            // 
            this.checkBox_Account.AutoSize = true;
            this.checkBox_Account.Location = new System.Drawing.Point(76, 201);
            this.checkBox_Account.Name = "checkBox_Account";
            this.checkBox_Account.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Account.TabIndex = 131;
            this.checkBox_Account.UseVisualStyleBackColor = true;
            this.checkBox_Account.CheckedChanged += new System.EventHandler(this.checkBox_Account_CheckedChanged);
            // 
            // dataGridView_Account
            // 
            this.dataGridView_Account.AllowUserToAddRows = false;
            this.dataGridView_Account.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Account.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Account.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Account.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Account.Location = new System.Drawing.Point(69, 196);
            this.dataGridView_Account.Name = "dataGridView_Account";
            this.dataGridView_Account.RowHeadersVisible = false;
            this.dataGridView_Account.RowHeadersWidth = 20;
            this.dataGridView_Account.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Account.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Account.Size = new System.Drawing.Size(438, 194);
            this.dataGridView_Account.TabIndex = 129;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 25;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 99.77968F;
            this.Column2.HeaderText = "Username";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 210;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 127.7965F;
            this.Column3.HeaderText = "Password";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 210;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Password";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 60;
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
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Account)).EndInit();
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
        private Bunifu.Framework.UI.BunifuFlatButton btn_Add;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Delete;
        private System.Windows.Forms.CheckBox checkBox_Account;
        private System.Windows.Forms.DataGridView dataGridView_Account;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
