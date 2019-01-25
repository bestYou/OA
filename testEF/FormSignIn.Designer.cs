namespace testEF
{
    partial class FormSignIn
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignIn));
            this.signIn = new DevComponents.DotNetBar.ButtonX();
            this.tb_username = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cb_save_password = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cb_auto_sign_in = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // signIn
            // 
            this.signIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.signIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signIn.BackColor = System.Drawing.Color.SkyBlue;
            this.signIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.signIn.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.signIn.Location = new System.Drawing.Point(100, 250);
            this.signIn.Margin = new System.Windows.Forms.Padding(2);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(265, 36);
            this.signIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.signIn.TabIndex = 0;
            this.signIn.Text = "登录";
            this.signIn.TextColor = System.Drawing.SystemColors.ControlText;
            this.signIn.Click += new System.EventHandler(this.signIn_Click);
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
            this.tb_username.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_username.ForeColor = System.Drawing.Color.Black;
            this.tb_username.Location = new System.Drawing.Point(177, 144);
            this.tb_username.Margin = new System.Windows.Forms.Padding(2);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(188, 32);
            this.tb_username.TabIndex = 1;
            this.tb_username.Tag = "";
            this.tb_username.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.tb_username.WatermarkText = "用户名";
            this.tb_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_username_KeyDown);
            // 
            // tb_password
            // 
            this.tb_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_password.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_password.Border.Class = "TextBoxBorder";
            this.tb_password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_password.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_password.ForeColor = System.Drawing.Color.Black;
            this.tb_password.Location = new System.Drawing.Point(177, 191);
            this.tb_password.Margin = new System.Windows.Forms.Padding(2);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(188, 32);
            this.tb_password.TabIndex = 2;
            this.tb_password.WatermarkText = "密码";
            this.tb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_password_KeyDown);
            // 
            // cb_save_password
            // 
            this.cb_save_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.cb_save_password.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cb_save_password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_save_password.Location = new System.Drawing.Point(167, 226);
            this.cb_save_password.Margin = new System.Windows.Forms.Padding(2);
            this.cb_save_password.Name = "cb_save_password";
            this.cb_save_password.Size = new System.Drawing.Size(100, 18);
            this.cb_save_password.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_save_password.TabIndex = 4;
            this.cb_save_password.Text = "记住密码";
            // 
            // cb_auto_sign_in
            // 
            this.cb_auto_sign_in.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.cb_auto_sign_in.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cb_auto_sign_in.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_auto_sign_in.Location = new System.Drawing.Point(272, 226);
            this.cb_auto_sign_in.Margin = new System.Windows.Forms.Padding(2);
            this.cb_auto_sign_in.Name = "cb_auto_sign_in";
            this.cb_auto_sign_in.Size = new System.Drawing.Size(92, 18);
            this.cb_auto_sign_in.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_auto_sign_in.TabIndex = 5;
            this.cb_auto_sign_in.Text = "自动登录";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.pictureBoxClose);
            this.panelEx1.Controls.Add(this.pictureBox1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(2);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(464, 105);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEx1.Style.BackgroundImage")));
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 7;
            this.panelEx1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(436, 2);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.pictureBoxClose_MouseLeave);
            this.pictureBoxClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxClose_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(86, 144);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.cb_auto_sign_in);
            this.Controls.Add(this.cb_save_password);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.signIn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Haily";
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX signIn;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_username;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_password;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb_save_password;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb_auto_sign_in;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}

