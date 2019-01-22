using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEF
{
    public partial class FormUpdateSoftware : Office2007Form
    {
        public FormUpdateSoftware()
        {
            InitializeComponent();
        }

        software soft_main = new software();
        public FormUpdateSoftware(software soft) {
            InitializeComponent();

            soft_main = soft;

            tb_up_software.Text = soft.name;
            tb_up_model.Text = soft.model;
            tb_up_version.Text = soft.version;

        }



        private void but_cancel_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain("softwareControlPage");
            formMain.Show();

            this.Hide();
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void but_up_user_Click(object sender, EventArgs e)
        {
            updateSoftwareInfo();

            FormMain formMain = new FormMain("softwareControlPage");
            formMain.Show();

            this.Hide();
        }

        public void updateSoftwareInfo()
        {
            if (tb_up_software.Text != null && tb_up_model.Text != null && tb_up_version.Text != null)
            {

                hailyEntities db = new hailyEntities();

                //查询要获取的对象
                var softwareInfo = from u in db.software
                                   where (u.Id == soft_main.Id)
                                   select u;
                //获得具体对象
                var softwareInfoObject = softwareInfo.FirstOrDefault();

                //修改软件名
                softwareInfoObject.name = tb_up_software.Text.Trim();
                softwareInfoObject.model = tb_up_model.Text.Trim();
                softwareInfoObject.version = tb_up_version.Text.Trim();

                //指定状态。
                db.Entry<software>(softwareInfoObject).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("软件信息已更新！");

                this.Close();
            }
            else if (tb_up_software.Text == null)
            {
                MessageBox.Show("请输入软件名！", "缺少参数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb_up_model == null && tb_up_software != null)
            {
                MessageBox.Show("请输入模块名！", "缺少参数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (tb_up_software.Text != null && tb_up_model.Text != null && tb_up_version.Text == null) {
                MessageBox.Show("请输入软件版本号！", "缺少参数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        #region 右上角小叉号
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            but_cancel.PerformClick();
        }

        private void pictureBoxClose_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxClose.BackColor = Color.Red;
        }

        private void pictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClose.BackColor = Color.Transparent;
        }
        #endregion

    }
}
