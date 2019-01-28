using DevComponents.DotNetBar;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace testEF
{
    public partial class FormAddUser : Office2007Form
    {
        public FormAddUser()
        {
            InitializeComponent();

            cb_new_permission.SelectedIndex = 0;

        }

        public void addUser() {

            if (tb_new_user.Text.Trim() != "" && tb_new_password.Text.Trim() != "" && tb_company.Text.Trim() != "")
            {
                hailyEntities db = new hailyEntities();
                user _user_add = new user();

                _user_add.username = tb_new_user.Text;
                _user_add.password = EncodeMD5.getMD5(tb_new_password.Text.Trim());//tb_new_password.Text;
                _user_add.permission = cb_new_permission.SelectedIndex;
                _user_add.company = tb_company.Text;

                db.user.Add(_user_add);
                db.SaveChanges();
                MessageBox.Show("用户创建成功！");

                FormMain formMain = new FormMain("userControlPage");
                formMain.Show();

                this.Close();
            }
            else if (tb_new_user.Text.Trim() == "") {
                MessageBox.Show("请输入用户名！", "缺少参数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb_new_password.Text.Trim() == "" && tb_new_user.Text.Trim() != "")
            {
                MessageBox.Show("请输入密码！", "缺少参数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (tb_new_user.Text.Trim() != "" && tb_new_password.Text.Trim() != "" && tb_company.Text.Trim() == "") {
                MessageBox.Show("请输入公司名！", "缺少参数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void but_creat_user_Click(object sender, EventArgs e)
        {
            addUser();
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

        #region 右上角小叉号
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
