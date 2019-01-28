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
    public partial class FormUpdateUserInfo : Form
    {
        public FormUpdateUserInfo()
        {
            InitializeComponent();

            cb_new_permission.SelectedIndex = 0;
        }

        String userName;

        public FormUpdateUserInfo(user _user) {
            InitializeComponent();

            cb_new_permission.SelectedIndex = 0;
            userName = _user.username;
            tb_username.Text = _user.username;
            tb_company.Text = _user.company;
        }

        public void updateUserInfo(String userName)
        {
            if (tb_username.Text != null && tb_up_password.Text != null && tb_company.Text != null)
            {
                hailyEntities db = new hailyEntities();

                //查询要获取的对象
                var userInfo = from u in db.user
                               where u.username == userName
                               select u;
                //获得具体对象
                var userInfoObject = userInfo.FirstOrDefault();

                //修改密码
                userInfoObject.password = EncodeMD5.getMD5(tb_up_password.Text.Trim());

                ////如果用户名与原始用户名不同，则修改用户名
                //if (userName != tb_username.Text)
                //{
                //    //用户信息表中的用户名
                //    userInfoObject.username = tb_username.Text;

                //    //软件授权记录表中的用户名，也应修改
                //    var permissionInfo = from u in db.permission
                //                         where u.username == userName
                //                         select u;
                //    var softwareInfoObject = permissionInfo.FirstOrDefault();


                //    softwareInfoObject.username = tb_username.Text;
                //    db.Entry<permission>(softwareInfoObject).State = System.Data.Entity.EntityState.Modified;
                //}
                userInfoObject.company = tb_company.Text;

                userInfoObject.permission = cb_new_permission.SelectedIndex;

                //指定状态。
                db.Entry<user>(userInfoObject).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("用户信息已更新！");

                FormMain formMain = new FormMain("userControlPage");
                formMain.Show();

                this.Hide();
            }
            else if (tb_username.Text == null)
            {
                MessageBox.Show("请输入用户名！", "缺少参数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb_up_password == null && tb_username != null)
            {
                MessageBox.Show("请输入密码！", "缺少参数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                MessageBox.Show("请重新输入用户信息！", "缺少参数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
   
        private void but_up_user_Click(object sender, EventArgs e)
        {
            updateUserInfo(userName);
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
