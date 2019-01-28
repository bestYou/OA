namespace testEF
{
    partial class FormAddSoftware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddSoftware));
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_new_version = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.but_cancel = new DevComponents.DotNetBar.ButtonX();
            this.but_addSoft = new DevComponents.DotNetBar.ButtonX();
            this.tb_new_model = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_new_soft = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.panelEx2.Controls.Add(this.tb_new_version);
            this.panelEx2.Controls.Add(this.but_cancel);
            this.panelEx2.Controls.Add(this.but_addSoft);
            this.panelEx2.Controls.Add(this.tb_new_model);
            this.panelEx2.Controls.Add(this.tb_new_soft);
            this.panelEx2.Controls.Add(this.labelX4);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Margin = new System.Windows.Forms.Padding(2);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(374, 255);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 35;
            this.panelEx2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_close.Image")));
            this.pictureBox_close.Location = new System.Drawing.Point(343, 3);
            this.pictureBox_close.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 37;
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
            this.pictureBox1.Size = new System.Drawing.Size(65, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // tb_new_version
            // 
            this.tb_new_version.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_new_version.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_new_version.Border.Class = "TextBoxBorder";
            this.tb_new_version.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_new_version.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_new_version.ForeColor = System.Drawing.Color.Black;
            this.tb_new_version.Location = new System.Drawing.Point(96, 147);
            this.tb_new_version.Margin = new System.Windows.Forms.Padding(2);
            this.tb_new_version.Name = "tb_new_version";
            this.tb_new_version.Size = new System.Drawing.Size(184, 25);
            this.tb_new_version.TabIndex = 35;
            this.tb_new_version.WatermarkText = "版本号";
            // 
            // but_cancel
            // 
            this.but_cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.but_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but_cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.but_cancel.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_cancel.Location = new System.Drawing.Point(192, 187);
            this.but_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(88, 25);
            this.but_cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.but_cancel.TabIndex = 31;
            this.but_cancel.Text = "取消";
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_addSoft
            // 
            this.but_addSoft.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.but_addSoft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but_addSoft.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.but_addSoft.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_addSoft.Location = new System.Drawing.Point(96, 187);
            this.but_addSoft.Margin = new System.Windows.Forms.Padding(2);
            this.but_addSoft.Name = "but_addSoft";
            this.but_addSoft.Size = new System.Drawing.Size(88, 25);
            this.but_addSoft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.but_addSoft.TabIndex = 30;
            this.but_addSoft.Text = "添加";
            this.but_addSoft.Click += new System.EventHandler(this.but_addSoft_Click);
            // 
            // tb_new_model
            // 
            this.tb_new_model.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_new_model.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_new_model.Border.Class = "TextBoxBorder";
            this.tb_new_model.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_new_model.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_new_model.ForeColor = System.Drawing.Color.Black;
            this.tb_new_model.Location = new System.Drawing.Point(96, 118);
            this.tb_new_model.Margin = new System.Windows.Forms.Padding(2);
            this.tb_new_model.Name = "tb_new_model";
            this.tb_new_model.Size = new System.Drawing.Size(184, 25);
            this.tb_new_model.TabIndex = 24;
            this.tb_new_model.WatermarkText = "模块名";
            // 
            // tb_new_soft
            // 
            this.tb_new_soft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_new_soft.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_new_soft.Border.Class = "TextBoxBorder";
            this.tb_new_soft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_new_soft.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_new_soft.ForeColor = System.Drawing.Color.Black;
            this.tb_new_soft.Location = new System.Drawing.Point(96, 89);
            this.tb_new_soft.Margin = new System.Windows.Forms.Padding(2);
            this.tb_new_soft.Name = "tb_new_soft";
            this.tb_new_soft.Size = new System.Drawing.Size(184, 25);
            this.tb_new_soft.TabIndex = 22;
            this.tb_new_soft.WatermarkText = "软件名";
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
            this.labelX4.Location = new System.Drawing.Point(51, 47);
            this.labelX4.Margin = new System.Windows.Forms.Padding(2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(214, 26);
            this.labelX4.TabIndex = 20;
            this.labelX4.Text = "新增软件";
            // 
            // FormAddSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 255);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddSoftware";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddSoftware";
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_new_version;
        private DevComponents.DotNetBar.ButtonX but_cancel;
        private DevComponents.DotNetBar.ButtonX but_addSoft;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_new_model;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_new_soft;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_close;
    }
}