namespace testEF
{
    partial class AddUserControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.saveButton = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxDropDown1 = new DevComponents.DotNetBar.Controls.TextBoxDropDown();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.textBoxDropDown1);
            this.panelEx1.Controls.Add(this.cancelButton);
            this.panelEx1.Controls.Add(this.saveButton);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.textBoxX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.textBoxX1);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(397, 325);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(32, 29);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(261, 32);
            this.labelX5.TabIndex = 20;
            this.labelX5.Text = "创建新用户";
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Location = new System.Drawing.Point(215, 211);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(88, 29);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 31;
            this.cancelButton.Text = "取消";
            // 
            // saveButton
            // 
            this.saveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.saveButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.saveButton.Location = new System.Drawing.Point(121, 211);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 29);
            this.saveButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "创建";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(75, 151);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 20);
            this.labelX3.TabIndex = 27;
            this.labelX3.Text = "权 限:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(75, 125);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 20);
            this.labelX2.TabIndex = 25;
            this.labelX2.Text = "密 码:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // textBoxX2
            // 
            this.textBoxX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.ForeColor = System.Drawing.Color.Black;
            this.textBoxX2.Location = new System.Drawing.Point(156, 125);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(128, 26);
            this.textBoxX2.TabIndex = 24;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(75, 99);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 20);
            this.labelX1.TabIndex = 23;
            this.labelX1.Text = "用户名:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // textBoxX1
            // 
            this.textBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.ForeColor = System.Drawing.Color.Black;
            this.textBoxX1.Location = new System.Drawing.Point(156, 99);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(128, 26);
            this.textBoxX1.TabIndex = 22;
            // 
            // textBoxDropDown1
            // 
            // 
            // 
            // 
            this.textBoxDropDown1.BackgroundStyle.Class = "TextBoxBorder";
            this.textBoxDropDown1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDropDown1.ButtonDropDown.Visible = true;
            this.textBoxDropDown1.Location = new System.Drawing.Point(156, 153);
            this.textBoxDropDown1.Name = "textBoxDropDown1";
            this.textBoxDropDown1.Size = new System.Drawing.Size(128, 24);
            this.textBoxDropDown1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.textBoxDropDown1.TabIndex = 32;
            this.textBoxDropDown1.Text = "";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Name = "AddUser";
            this.Size = new System.Drawing.Size(397, 325);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxDropDown textBoxDropDown1;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX saveButton;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
    }
}
