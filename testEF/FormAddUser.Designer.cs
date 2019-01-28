namespace testEF
{
    partial class FormAddUser
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUser));
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_company = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cb_new_permission = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.but_cancel = new DevComponents.DotNetBar.ButtonX();
            this.but_up_user = new DevComponents.DotNetBar.ButtonX();
            this.tb_new_password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_new_user = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.pictureBox_close);
            this.panelEx2.Controls.Add(this.pictureBox1);
            this.panelEx2.Controls.Add(this.tb_company);
            this.panelEx2.Controls.Add(this.cb_new_permission);
            this.panelEx2.Controls.Add(this.but_cancel);
            this.panelEx2.Controls.Add(this.but_up_user);
            this.panelEx2.Controls.Add(this.tb_new_password);
            this.panelEx2.Controls.Add(this.tb_new_user);
            this.panelEx2.Controls.Add(this.labelX4);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Margin = new System.Windows.Forms.Padding(2);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(374, 255);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 34;
            this.panelEx2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_close.Image")));
            this.pictureBox_close.Location = new System.Drawing.Point(347, 3);
            this.pictureBox_close.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 38;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            this.pictureBox_close.MouseLeave += new System.EventHandler(this.pictureBox_close_MouseLeave);
            this.pictureBox_close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_close_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // tb_company
            // 
            this.tb_company.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_company.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_company.Border.Class = "TextBoxBorder";
            this.tb_company.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_company.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_company.ForeColor = System.Drawing.Color.Black;
            this.tb_company.Location = new System.Drawing.Point(100, 139);
            this.tb_company.Margin = new System.Windows.Forms.Padding(2);
            this.tb_company.Name = "tb_company";
            this.tb_company.Size = new System.Drawing.Size(184, 25);
            this.tb_company.TabIndex = 35;
            this.tb_company.WatermarkText = "公司名称";
            // 
            // cb_new_permission
            // 
            this.cb_new_permission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_new_permission.DisplayMember = "Text";
            this.cb_new_permission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_new_permission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_new_permission.FormattingEnabled = true;
            this.cb_new_permission.ItemHeight = 19;
            this.cb_new_permission.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cb_new_permission.Location = new System.Drawing.Point(100, 168);
            this.cb_new_permission.Margin = new System.Windows.Forms.Padding(2);
            this.cb_new_permission.Name = "cb_new_permission";
            this.cb_new_permission.Size = new System.Drawing.Size(184, 25);
            this.cb_new_permission.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_new_permission.TabIndex = 33;
            this.cb_new_permission.WatermarkText = "用户权限";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "普通用户";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "管理员";
            // 
            // but_cancel
            // 
            this.but_cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.but_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but_cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.but_cancel.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_cancel.Location = new System.Drawing.Point(196, 207);
            this.but_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(88, 25);
            this.but_cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.but_cancel.TabIndex = 31;
            this.but_cancel.Text = "取消";
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_up_user
            // 
            this.but_up_user.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.but_up_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but_up_user.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.but_up_user.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_up_user.Location = new System.Drawing.Point(100, 207);
            this.but_up_user.Margin = new System.Windows.Forms.Padding(2);
            this.but_up_user.Name = "but_up_user";
            this.but_up_user.Size = new System.Drawing.Size(88, 25);
            this.but_up_user.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.but_up_user.TabIndex = 30;
            this.but_up_user.Text = "创建";
            this.but_up_user.Click += new System.EventHandler(this.but_creat_user_Click);
            // 
            // tb_new_password
            // 
            this.tb_new_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_new_password.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_new_password.Border.Class = "TextBoxBorder";
            this.tb_new_password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_new_password.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_new_password.ForeColor = System.Drawing.Color.Black;
            this.tb_new_password.Location = new System.Drawing.Point(100, 110);
            this.tb_new_password.Margin = new System.Windows.Forms.Padding(2);
            this.tb_new_password.Name = "tb_new_password";
            this.tb_new_password.Size = new System.Drawing.Size(184, 25);
            this.tb_new_password.TabIndex = 24;
            this.tb_new_password.WatermarkText = "新密码";
            // 
            // tb_new_user
            // 
            this.tb_new_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_new_user.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_new_user.Border.Class = "TextBoxBorder";
            this.tb_new_user.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_new_user.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_new_user.ForeColor = System.Drawing.Color.Black;
            this.tb_new_user.Location = new System.Drawing.Point(100, 81);
            this.tb_new_user.Margin = new System.Windows.Forms.Padding(2);
            this.tb_new_user.Name = "tb_new_user";
            this.tb_new_user.Size = new System.Drawing.Size(184, 25);
            this.tb_new_user.TabIndex = 22;
            this.tb_new_user.WatermarkText = "用户名";
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(58, 38);
            this.labelX4.Margin = new System.Windows.Forms.Padding(2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(214, 26);
            this.labelX4.TabIndex = 20;
            this.labelX4.Text = "创建新用户";
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 255);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddUser";
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_company;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_new_permission;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.ButtonX but_cancel;
        private DevComponents.DotNetBar.ButtonX but_up_user;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_new_password;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_new_user;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_close;
    }
}