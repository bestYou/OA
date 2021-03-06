﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace testEF
{
    public partial class FormAddSoftware : Form
    {
        public FormAddSoftware()
        {
            InitializeComponent();
        }

        private void but_addSoft_Click(object sender, EventArgs e)
        {
            addSoftware();
        }

        public void addSoftware()
        {
            if (tb_new_soft.Text.Trim() != "" && tb_new_model.Text.Trim() != "" && tb_new_version.Text.Trim() != "")
            {
                hailyEntities db = new hailyEntities();
                software _software_add = new software();
                                
                _software_add.name = tb_new_soft.Text;
                _software_add.model = tb_new_model.Text;  //默认授予新用户的软件模块使用
                _software_add.version = tb_new_version.Text;

                db.software.Add(_software_add);
                db.SaveChanges();
                MessageBox.Show("软件添加成功！");

                FormMain formMain = new FormMain("softwareControlPage");
                formMain.Show();

                this.Close();
            }
            else if (tb_new_soft.Text.Trim() == "")
            {
                MessageBox.Show("请输入软件名！", "缺少参数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb_new_model.Text.Trim() == "" && tb_new_soft.Text.Trim() != "")
            {
                MessageBox.Show("请输入模块名！", "缺少参数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb_new_soft.Text.Trim() != "" && tb_new_model.Text.Trim() != "" && tb_new_version.Text.Trim() == "")
            {
                MessageBox.Show("请输入版本号！", "缺少参数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain("softwareControlPage");
            formMain.Show();

            this.Hide();
        }

        #region 无边框移动窗口
        //无边框移动窗口
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private void panel_Top_MouseDown(object sender, MouseEventArgs e)         //panel_Top为最上部的panel
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        #endregion

        #region 右上角小叉号逻辑处理：单击、移动、离开
        //右上角小叉号
        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            but_cancel.PerformClick();
        }

        private void pictureBox_close_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_close.BackColor = Color.Red;
        }

        private void pictureBox_close_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_close.BackColor = Color.Transparent;
        }

        #endregion

    }
}
