using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEF
{
    public partial class FormSignIn : Office2007Form
    {
        public FormSignIn()
        {
            InitializeComponent();

            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);

            isAutoSignIn();
        }

        public static String userName_main; //未勾选时用户名也得传递，全局静态变量
        String passWord ;

        private void signIn_Click(object sender, EventArgs e)
        {
            hailyEntities db = new hailyEntities();

            try
            {
                userName_main = tb_username.Text.ToString();
                if (ConfigurationManager.AppSettings["password"].Length == 32)
                {
                    passWord = ConfigurationManager.AppSettings["password"];
                }
                else {
                    passWord = EncodeMD5.getMD5(tb_password.Text.Trim());//tb_password.Text.ToString();
                }
                //1.判断用户名是否存在
                List<user> list = db.user.Where(u => u.username == userName_main).ToList();
                if (list.Count >= 1)
                {
                    //用户存在
                    //2.判断密码是否正确
                    List<user> list2 = db.user.Where(u => u.username == userName_main && u.password == passWord).ToList();
                    if (list2.Count >= 1)
                    {
                        //用户存在且密码正确
                        //MessageBox.Show("登录成功！", "温馨提示");
     
                        saveAutoSignIn();

                        FormMain formMain = new FormMain();
                        formMain.Show();

                        
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("用户存在但密码不正确！", "温馨提示");
                    }
                }
                else
                {
                    MessageBox.Show("用户不存在！", "温馨提示");
                }
            }
            catch
            {
            }
        }

        //记录本次登录 是否勾选 自动登录、记住密码
        public void saveAutoSignIn() {
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (cb_auto_sign_in.Checked)
            {
                cfa.AppSettings.Settings["autologin"].Value = "true";
                cfa.AppSettings.Settings["rememberme"].Value = "true";
                cfa.AppSettings.Settings["name"].Value = userName_main;
                cfa.AppSettings.Settings["password"].Value = passWord;
                cfa.Save();
            }
            else
            {
                if (cb_save_password.Checked)
                {
                    cfa.AppSettings.Settings["autologin"].Value = "false";
                    cfa.AppSettings.Settings["rememberme"].Value = "true";
                    cfa.AppSettings.Settings["name"].Value = userName_main;
                    cfa.AppSettings.Settings["password"].Value = passWord;
                    cfa.Save();
                }
                else
                {
                    cfa.AppSettings.Settings["autologin"].Value = "false";
                    cfa.AppSettings.Settings["rememberme"].Value = "false";
                    cfa.AppSettings.Settings["name"].Value = "";
                    cfa.AppSettings.Settings["password"].Value = "";
                }
            }
            cfa.Save();
        }

        //界面加载时，判断上次登录勾选状态
        public void isAutoSignIn() {
            //如果记住密码为true 那么把值 赋值给文本框
            if (ConfigurationManager.AppSettings["rememberme"].Equals("true"))
            {
                tb_username.Text = ConfigurationManager.AppSettings["name"];
                tb_password.Text = ConfigurationManager.AppSettings["password"];
                cb_save_password.Checked = true;
            }
            //如果是自动登录  那么拿获取 配置文件中的账号密码  然后到数据库里边查询 登录
            if (ConfigurationManager.AppSettings["autologin"].Equals("true"))
            {
                cb_auto_sign_in.Checked = true;

                //要加自动登录，应该给登录加个延时，给用户一个取消的选择
            }

        }

        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);


        #region 输入框焦点事件响应、输入框按键捕捉
        private void tb_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                tb_password.Focus();
            }
            
        }

        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                signIn.PerformClick();
            }

        }
        #endregion

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


        private void pictureBoxUser_Click(object sender, EventArgs e)
        {

        }

        #region 右上角小X
        //右上角小X，关闭窗口
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void signIn_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }


    }
}
