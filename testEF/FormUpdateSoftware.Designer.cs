namespace testEF
{
    partial class FormUpdateSoftware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateSoftware));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_up_version = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.but_cancel = new DevComponents.DotNetBar.ButtonX();
            this.but_up_user = new DevComponents.DotNetBar.ButtonX();
            this.tb_up_model = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_up_software = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.panelEx1.Controls.Add(this.tb_up_version);
            this.panelEx1.Controls.Add(this.but_cancel);
            this.panelEx1.Controls.Add(this.but_up_user);
            this.panelEx1.Controls.Add(this.tb_up_model);
            this.panelEx1.Controls.Add(this.tb_up_software);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(2);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(356, 255);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 3;
            this.panelEx1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(329, 3);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 38;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.pictureBoxClose_MouseLeave);
            this.pictureBoxClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxClose_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // tb_up_version
            // 
            this.tb_up_version.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_up_version.Border.Class = "TextBoxBorder";
            this.tb_up_version.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_up_version.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_up_version.ForeColor = System.Drawing.Color.Black;
            this.tb_up_version.Location = new System.Drawing.Point(97, 160);
            this.tb_up_version.Margin = new System.Windows.Forms.Padding(2);
            this.tb_up_version.Name = "tb_up_version";
            this.tb_up_version.Size = new System.Drawing.Size(169, 25);
            this.tb_up_version.TabIndex = 32;
            this.tb_up_version.WatermarkText = "版本号";
            // 
            // but_cancel
            // 
            this.but_cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.but_cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.but_cancel.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_cancel.Location = new System.Drawing.Point(184, 191);
            this.but_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(82, 23);
            this.but_cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.but_cancel.TabIndex = 31;
            this.but_cancel.Text = "取消";
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_up_user
            // 
            this.but_up_user.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.but_up_user.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.but_up_user.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_up_user.Location = new System.Drawing.Point(97, 191);
            this.but_up_user.Margin = new System.Windows.Forms.Padding(2);
            this.but_up_user.Name = "but_up_user";
            this.but_up_user.Size = new System.Drawing.Size(82, 23);
            this.but_up_user.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.but_up_user.TabIndex = 30;
            this.but_up_user.Text = "修改";
            this.but_up_user.Click += new System.EventHandler(this.but_up_user_Click);
            // 
            // tb_up_model
            // 
            this.tb_up_model.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_up_model.Border.Class = "TextBoxBorder";
            this.tb_up_model.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_up_model.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_up_model.ForeColor = System.Drawing.Color.Black;
            this.tb_up_model.Location = new System.Drawing.Point(97, 131);
            this.tb_up_model.Margin = new System.Windows.Forms.Padding(2);
            this.tb_up_model.Name = "tb_up_model";
            this.tb_up_model.Size = new System.Drawing.Size(169, 25);
            this.tb_up_model.TabIndex = 24;
            this.tb_up_model.WatermarkText = "模块名";
            // 
            // tb_up_software
            // 
            this.tb_up_software.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_up_software.Border.Class = "TextBoxBorder";
            this.tb_up_software.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_up_software.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_up_software.ForeColor = System.Drawing.Color.Black;
            this.tb_up_software.Location = new System.Drawing.Point(97, 102);
            this.tb_up_software.Margin = new System.Windows.Forms.Padding(2);
            this.tb_up_software.Name = "tb_up_software";
            this.tb_up_software.Size = new System.Drawing.Size(169, 25);
            this.tb_up_software.TabIndex = 22;
            this.tb_up_software.WatermarkText = "软件名";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(56, 55);
            this.labelX5.Margin = new System.Windows.Forms.Padding(2);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(196, 26);
            this.labelX5.TabIndex = 20;
            this.labelX5.Text = "修改软件信息";
            // 
            // FormUpdateSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 255);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUpdateSoftware";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUpdateSoftware";
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX but_cancel;
        private DevComponents.DotNetBar.ButtonX but_up_user;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_up_model;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_up_software;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_up_version;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}