namespace testEF
{
    partial class FormUpdateUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateUserInfo));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_company = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cb_new_permission = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbi_user = new DevComponents.Editors.ComboItem();
            this.cbi_admin = new DevComponents.Editors.ComboItem();
            this.but_cancel = new DevComponents.DotNetBar.ButtonX();
            this.but_up_user = new DevComponents.DotNetBar.ButtonX();
            this.tb_up_password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_username = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.pictureBoxClose);
            this.panelEx1.Controls.Add(this.pictureBox1);
            this.panelEx1.Controls.Add(this.tb_company);
            this.panelEx1.Controls.Add(this.cb_new_permission);
            this.panelEx1.Controls.Add(this.but_cancel);
            this.panelEx1.Controls.Add(this.but_up_user);
            this.panelEx1.Controls.Add(this.tb_up_password);
            this.panelEx1.Controls.Add(this.tb_username);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(2);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(374, 255);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
            this.panelEx1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(347, 3);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 39;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.pictureBoxClose_MouseLeave);
            this.pictureBoxClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxClose_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::testEF.Properties.Resources.haily_main;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 32);
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
            this.cbi_user,
            this.cbi_admin});
            this.cb_new_permission.Location = new System.Drawing.Point(100, 168);
            this.cb_new_permission.Margin = new System.Windows.Forms.Padding(2);
            this.cb_new_permission.Name = "cb_new_permission";
            this.cb_new_permission.Size = new System.Drawing.Size(184, 25);
            this.cb_new_permission.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_new_permission.TabIndex = 33;
            this.cb_new_permission.WatermarkText = "用户权限";
            // 
            // cbi_user
            // 
            this.cbi_user.Text = "普通用户";
            // 
            // cbi_admin
            // 
            this.cbi_admin.Text = "管理员";
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
            this.but_up_user.Text = "修改";
            this.but_up_user.Click += new System.EventHandler(this.but_up_user_Click);
            // 
            // tb_up_password
            // 
            this.tb_up_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_up_password.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_up_password.Border.Class = "TextBoxBorder";
            this.tb_up_password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_up_password.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_up_password.ForeColor = System.Drawing.Color.Black;
            this.tb_up_password.Location = new System.Drawing.Point(100, 110);
            this.tb_up_password.Margin = new System.Windows.Forms.Padding(2);
            this.tb_up_password.Name = "tb_up_password";
            this.tb_up_password.Size = new System.Drawing.Size(184, 25);
            this.tb_up_password.TabIndex = 24;
            this.tb_up_password.WatermarkText = "新密码";
            // 
            // tb_username
            // 
            this.tb_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_username.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_username.Border.Class = "TextBoxBorder";
            this.tb_username.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_username.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_username.ForeColor = System.Drawing.Color.Black;
            this.tb_username.Location = new System.Drawing.Point(100, 81);
            this.tb_username.Margin = new System.Windows.Forms.Padding(2);
            this.tb_username.Name = "tb_username";
            this.tb_username.ReadOnly = true;
            this.tb_username.Size = new System.Drawing.Size(184, 25);
            this.tb_username.TabIndex = 22;
            this.tb_username.WatermarkText = "用户名";
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(58, 38);
            this.labelX5.Margin = new System.Windows.Forms.Padding(2);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(214, 26);
            this.labelX5.TabIndex = 20;
            this.labelX5.Text = "修改用户信息";
            // 
            // FormUpdateUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 255);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUpdateUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUpdatePassword";
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_new_permission;
        private DevComponents.Editors.ComboItem cbi_user;
        private DevComponents.Editors.ComboItem cbi_admin;
        private DevComponents.DotNetBar.ButtonX but_cancel;
        private DevComponents.DotNetBar.ButtonX but_up_user;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_up_password;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_username;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_company;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}