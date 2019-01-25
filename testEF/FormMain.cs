using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEF
{
    public partial class FormMain : Office2007Form
    {
        public FormMain()
        {
            InitializeComponent();

            //初始化用户中心页面
            initUserInfo();

            //初始化用户管理页面
            data_user_initialize();

            //初始化 权限审批页面
            initPermissionReadPage();

            //初始化 软件管理页面
            initSoftwarePage();

            //初始化 权限申请页面
            initSubmissionPage();

            timer1.Enabled = true;


        }

        //登录成功提示
        public void showSuccess() {

            timer1.Enabled = false;

            FormSignInTips formSignInTips = new FormSignInTips();//要弹出的窗体（提示框）
            Point p = new Point(Screen.PrimaryScreen.WorkingArea.Width - formSignInTips.Width, Screen.PrimaryScreen.WorkingArea.Height);
            formSignInTips.PointToScreen(p);
            formSignInTips.Location = p;
            formSignInTips.Show();
            for (int i = 0; i <= formSignInTips.Height; i++)
            {
                formSignInTips.Location = new Point(p.X, p.Y - i);
                Thread.Sleep(5);//将线程沉睡时间调的越小升起的越快
            }

        }

        //构造函数，打开主界面时进入指定页面
        public FormMain(String page) {
            InitializeComponent();

            //初始化用户中心页面
            initUserInfo();

            //初始化用户管理页面
            data_user_initialize();

            //初始化 权限审批页面
            initPermissionReadPage();
            
            //初始化 软件管理页面
            initSoftwarePage();

            //初始化 权限申请页面
            initSubmissionPage();

            if (page == "userControlPage") {
                stc_main.SelectedTabIndex = 3;
            }
            if (page == "softwareControlPage")
            {
                stc_main.SelectedTabIndex = 4;
            }

        }



        hailyEntities db = new hailyEntities();
        String username = FormSignIn.userName_main;   //ConfigurationManager.AppSettings["name"];

        //初始化用户中心
        public void initUserInfo() {

            dgv_userInfo.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgv_userInfo.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            label_user.Text = username;
            labelItem_user.Text = username;

            //判断 当前用户 -> 用户权限
            List<user> list = db.user.Where(u => u.username == username).ToList();
            if (list[0].permission == 0) {
                labelItem_permission.Text = "普通用户:";
                sti_read_permission.Enabled = false;    //普通用户“权限审批”、“用户管理”、“软件管理 ”功能页面不可用
                sti_user_control.Enabled = false;
                sti_software_control.Enabled = false;
            } else if (list[0].permission == 1) {
                labelItem_permission.Text = "管理员:";
            }

            List<shenpi> list_shenpi = db.shenpi.Where(u => u.username == username).ToList();
            foreach (var _shenpi in list_shenpi) {

                String result = "";
                if (_shenpi.is_read==1 && _shenpi.is_through==1) {
                    result = "通过";
                }
                if (_shenpi.is_read == 1 && _shenpi.is_through == 0) {
                    result = "拒绝";
                }
                if (_shenpi.is_read == 0) {
                    result = "待处理";
                }

                UserInfo userInfo = new UserInfo();
                userInfo.username = _shenpi.username;
                userInfo.software = _shenpi.software;
                userInfo.model = _shenpi.model;
                userInfo.version = _shenpi.version;
                userInfo.result = result;
                
                //用户名、软件名、模块名、版本号、申请时间、处理结果
                list_userInfo.Add(userInfo);
            }
            this.dgv_userInfo.DataSource = list_userInfo;

            dgv_userInfo.ColumnHeadersVisible = true;
            dgv_userInfo.Columns[0].HeaderText = "用户名";
            dgv_userInfo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgv_userInfo.Columns[1].HeaderText = "软件名";
            dgv_userInfo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_userInfo.Columns[2].HeaderText = "版本号";
            dgv_userInfo.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgv_userInfo.Columns[3].HeaderText = "模块名";
            dgv_userInfo.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_userInfo.Columns[4].HeaderText = "申请时间";
            dgv_userInfo.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgv_userInfo.Columns[5].HeaderText = "处理结果";
            dgv_userInfo.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //在datagridview中添加button按钮
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnDownload";
            btn.HeaderText = "下载授权文件";
            btn.DefaultCellStyle.NullValue = "下载";
            dgv_userInfo.Columns.Add(btn);

            dgv_userInfo.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            
        }
        List<UserInfo> list_userInfo = new List<UserInfo>();

        //捕捉<用户中心页面>点击事件，并响应
        void DataGridView_userInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex>=0 && e.RowIndex>=0) {

                String _software = dgv_userInfo.Rows[e.RowIndex].Cells["software"].Value.ToString();//list_userInfo[row].software;
                String _version = dgv_userInfo.Rows[e.RowIndex].Cells["version"].Value.ToString();
                String _model = dgv_userInfo.Rows[e.RowIndex].Cells["model"].Value.ToString();
                String _result = dgv_userInfo.Rows[e.RowIndex].Cells["result"].Value.ToString();
                
                if (dgv_userInfo.Columns[e.ColumnIndex].Name == "btnDownload" && _result == "通过")
                {
                    showSubmissionFile(_software, _version, _model);
                }
                if (dgv_userInfo.Columns[e.ColumnIndex].Name == "btnDownload" && _result == "拒绝")
                {
                    MessageBox.Show("下载失败，失败原因：“管理员拒绝了该条申请”。请重新申请或联系管理员！");
                }
                if (dgv_userInfo.Columns[e.ColumnIndex].Name == "btnDownload" && _result == "待处理")
                {
                    MessageBox.Show("下载失败，失败原因：“申请未处理”。请申请通过后再次尝试！");
                }
            }
        }



        struct mess {
            public String mes;
            public String time;
        }
        List<mess> messlist = new List<mess>();

        //退出登录
        private void but_sign_out_Click(object sender, EventArgs e)
        {
            FormSignIn formSignIn = new FormSignIn();
            formSignIn.Show();
            this.Hide();
        }

        //初始化 用户管理页面 -> 用户列表数据
        public void data_user_initialize()
        {
            ptl_user_control.Text = "你好，管理员“"+username+"”";
            List<user> list_user = db.user.ToList();
            foreach (var _user in list_user)
            {
                this.dgv_user_control.Rows.Add(_user.username,_user.company, "修改","注销");
                
                list_user_control.Add(_user);
            }
        }

        //用于捕捉 用户管理页面 -> datagradview点击事件，因为 直接捕捉事件无法获取cell元素，迂回下
        public struct User_Control {
            public String name;
            public String model;
        }
        List<user> list_user_control = new List<user>();

        //捕捉<用户管理页面>点击事件，并响应
        void DataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = dgv_user_control.CurrentCell.ColumnIndex;
            int row = dgv_user_control.CurrentCell.RowIndex;

            //User_Control user_control_read = new User_Control();
            //user_control_read = (User_Control)list_user_control[row];
            String _userName = list_user_control[row].username;

            //修改密码
            if (column == 2) {
                FormUpdateUserInfo formUpdateUserInfo = new FormUpdateUserInfo(list_user_control[row]);
                formUpdateUserInfo.ShowDialog();
                this.Hide();
            }
            //注销用户
            if (column == 3) {
                ////从数据库中删除用户,包括 用户表
                //var permissionList = from u in db.permission
                //                   where u.username == _userName
                //                   select u;
                var userInfoList = from u in db.user
                                   where u.username == _userName
                                   select u;
                //permission _permission = permissionList.FirstOrDefault();
                user _userInfo = userInfoList.FirstOrDefault();
                if (/*_permission != null &&*/ _userInfo != null)
                {
                    DialogResult result = MessageBox.Show("确定注销用户用户“"+_userName+"”？","提示窗口", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes) {
                        db.user.Remove(_userInfo);
                        //db.permission.Remove(_permission);
                        db.SaveChanges();
                        MessageBox.Show("已移除用户" + _userName);

                        dgv_user_control.Rows.Clear();
                        list_user_control.Clear();
                        //刷新 用户管理页面
                        data_user_initialize();
                    } else if (result == DialogResult.No) {
                        //不进行操作，关闭提示窗即可
                    }
                }
                else
                {
                    MessageBox.Show("移除用户失败！");
                }
            }
        }

        //管理员 新增用户模块
        private void bt_add_user_Click(object sender, EventArgs e)
        {
            FormAddUser formAddUser = new FormAddUser();
            formAddUser.Show();
            
            this.Close();
        }

        //初始化  权限申请页面
        List<software> list_model;
        List<software> list_version;
        public void initSubmissionPage() {
            
            List<software> list_software = db.software.ToList();

            list_model = db.software.ToList();
            list_version = db.software.ToList();

            //list去重，得到 软件列表
            for (int i = 0; i < list_software.Count; i++)  //外循环是循环的次数
            {
                for (int j = list_software.Count - 1; j > i; j--)  //内循环是 外循环一次比较的次数
                {
                    if (list_software[i].name == list_software[j].name)
                    {
                        list_software.RemoveAt(j);
                    }
                }
            }

            //list去重，得到 模块列表
            for (int i = 0; i < list_model.Count; i++)  //外循环是循环的次数
            {
                for (int j = list_model.Count - 1; j > i; j--)  //内循环是 外循环一次比较的次数
                {
                    if (list_model[i].model == list_model[j].model)
                    {
                        list_model.RemoveAt(j);
                    }
                }
            }

            //list去重，得到 版本号列表
            for (int i = 0; i < list_version.Count; i++)  //外循环是循环的次数
            {
                for (int j = list_version.Count - 1; j > i; j--)  //内循环是 外循环一次比较的次数
                {
                    if (list_version[i].version == list_version[j].version)
                    {
                        list_version.RemoveAt(j);
                    }
                }
            }


            //软件列表combobox绑定List
            cb_software.DataSource = list_software;
            cb_software.DisplayMember = "name";
            cb_software.ValueMember = "name";

        }



        //初始化 权限审批页面
        public void initPermissionReadPage() {
            initSendListData();
            initReadListData();
        }

        //用于存储 未处理的审批数据
        List<shenpi> shenpi_read_list = new List<shenpi>();
        //初始化 权限审批页面 -> 申请列表数据
        public void initSendListData() {

            List<shenpi> list_shenpi = db.shenpi.ToList();

            //检索每条审批数据，显示未处理的数据
            foreach (var _shenpi in list_shenpi)
            {
                if (_shenpi.is_read==0) {
                    //申请列表：用户名、软件名、模块名、版本号、用途、申请时间
                    this.dgv_send_list.Rows.Add(_shenpi.username,_shenpi.software,_shenpi.model,_shenpi.version,_shenpi.model_tips,_shenpi.use_time, _shenpi.send_time, "通过", "拒绝");
                    shenpi_read_list.Add(_shenpi);
                }               
            }
        }
        
        //初始化 权限审批页面 -> 授权记录数据
        public void initReadListData() {
            List<shenpi> list_shenpi = db.shenpi.ToList();

            //检索每条审批数据，显示未处理的数据
            foreach (var _shenpi in list_shenpi)
            {
                if (_shenpi.is_read == 1)
                {
                    if (_shenpi.is_through==0) {
                        //授权记录：用户名、软件名、模块名、版本号、用途、处理结果、申请时间、处理时间
                        this.dgv_read_list.Rows.Add(_shenpi.username,_shenpi.software, _shenpi.model,_shenpi.version, _shenpi.model_tips,_shenpi.use_time,"拒绝", _shenpi.send_time,_shenpi.read_time);
                    }
                    if (_shenpi.is_through==1) {
                        this.dgv_read_list.Rows.Add(_shenpi.username, _shenpi.software,_shenpi.model,_shenpi.version, _shenpi.model_tips, _shenpi.use_time, "通过", _shenpi.send_time, _shenpi.read_time);
                    }
                }
            }
        }

        //监听 权限审批页面 -> 申请列表 点击事件
        void DataGridViewX_SendList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = dgv_send_list.CurrentCell.ColumnIndex;
            int row = dgv_send_list.CurrentCell.RowIndex;

            shenpi _shenpi = new shenpi();
            _shenpi = (shenpi)shenpi_read_list[row];

            //通过
            if (column == 7)
            {
                //修改 审批表（审批状态）、软件权限表（用户拥有软件权限）
                //修改审批表
                var shenpiList = from u in db.shenpi
                                 where u.Id == _shenpi.Id
                                 select u;
                var shenpiListObject = shenpiList.FirstOrDefault();
                shenpiListObject.is_read = 1;
                shenpiListObject.is_through = 1;
                shenpiListObject.read_time = DateTime.Now;
                
                //软件权限表添加一条记录
                permission _permission = new permission();
                _permission.username = _shenpi.username;
                _permission.software = _shenpi.software;
                _permission.model = _shenpi.model;
                _permission.version = _shenpi.version;
                db.permission.Add(_permission);
                
                //指定状态。
                db.Entry<shenpi>(shenpiListObject).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                //更新 前端显示 -> 申请列表 和 授权记录; 
    
                //清空前端数据
                dgv_send_list.Rows.Clear();
                shenpi_read_list.Clear();
                dgv_read_list.Rows.Clear();

                //同时更新 用户管理页面 -> 用户列表数据
                dgv_user_control.Rows.Clear();
                list_user_control.Clear();

                //重新载入 权限审批页面 -> 申请列表
                initSendListData();
                initReadListData();
                //刷新 用户管理页面
                data_user_initialize();

                //刷新 用户中心页面 -> 申请记录列表
                dgv_userInfo.Rows.Clear();
                initUserInfo();


            }
            //拒绝
            if (column == 8)
            {
                //修改 审批表（审批状态）
                var shenpiList = from u in db.shenpi
                                 where u.Id == _shenpi.Id
                                 select u;
                var shenpiListObject = shenpiList.FirstOrDefault();
                shenpiListObject.is_read = 1;
                shenpiListObject.is_through = 0;
                shenpiListObject.read_time = DateTime.Now;

                db.Entry<shenpi>(shenpiListObject).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                //更新 前端显示 -> 申请列表 和 授权记录
                //清空前端数据
                dgv_send_list.Rows.Clear();
                shenpi_read_list.Clear();
                dgv_read_list.Rows.Clear();
                //重新载入 权限审批页面 -> 申请列表
                initSendListData();
                initReadListData();
            }
        }

        List<software> list_soft_control = new List<software>();
        //初始化 软件管理页面
        public void initSoftwarePage()
        {
            label_software_control.Text = "你好，管理员“" + username + "”";
            List<software> list_software = db.software.ToList();
            foreach (var _software in list_software)
            {
                this.dgv_soft.Rows.Add(_software.name, _software.model,_software.version, "修改", "注销");

                list_soft_control.Add(_software);
            }
        }

        //捕捉<软件管理页面>点击事件，并响应
        void DataGridViewX1_software_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = dgv_soft.CurrentCell.ColumnIndex;
            int row = dgv_soft.CurrentCell.RowIndex;

            //User_Control user_control_read = new User_Control();
            //user_control_read = (User_Control)list_user_control[row];
            String _softwareName = list_soft_control[row].name;

            //修改软件信息
            if (column == 3)
            {
                FormUpdateSoftware formUpdateSoftware = new FormUpdateSoftware(list_soft_control[row]);
                formUpdateSoftware.Show();
                this.Hide();
            }
            //移除软件信息
            if (column == 4)
            {
                //从数据库《软件信息表》中删除记录
                var softwareInfoList = from u in db.software
                                   where u.name == _softwareName
                                   select u;
                software _softwareInfo = softwareInfoList.FirstOrDefault();
                if (_softwareInfo != null)
                {
                    DialogResult result = MessageBox.Show("确定移除软件模块“" + _softwareName+"："+_softwareInfo.model +","+_softwareInfo.version+ "”？", "提示窗口", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        db.software.Remove(_softwareInfo);
                        db.SaveChanges();
                        MessageBox.Show("已移除软件模块" + _softwareName);

                        dgv_soft.Rows.Clear();
                        list_soft_control.Clear();
                        //刷新 软件管理页面
                        initSoftwarePage();
                    }
                    else if (result == DialogResult.No)
                    {
                        //不进行操作，关闭提示窗即可
                    }
                }
                else
                {
                    MessageBox.Show("移除软件失败！");
                }
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

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            but_sign_out.PerformClick();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void superTabControlPanel1_Click(object sender, EventArgs e)
        {

        }

        [System.Runtime.InteropServices.ComVisibleAttribute(true)]


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            //pictureBox8.BackColor = Color.Red;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox8.BackColor = Color.Transparent;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_close.BackColor = Color.Red;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_close.BackColor = Color.Transparent;
        }

        // 软件管理页面 -> 新增软件
        private void but_add_software_Click(object sender, EventArgs e)
        {
            FormAddSoftware formAddSoftware = new FormAddSoftware();
            formAddSoftware.Show();

            this.Hide();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            showSuccess();
        }

        //权限申请页面 -> 选择软件路径
        private void textBoxX1_Click(object sender, EventArgs e)
        {
            tb_soft_path.Text = SelectPath();            
        }

        private string SelectPath() //弹出一个选择文件目录的对话框
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "选择文件存放目录";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                return folder.SelectedPath;
            }
            else {
                return String.Empty;
            }
        }

        private string SelectFile() //弹出一个选择具体文件的对话框
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            return file.FileName;
        }






        private void superTabControlPanel2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        //生成授权文件
        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void rb_beta_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_beta.Checked) {
                dateTimePicker.Enabled = true;
                label5.Enabled = true;
            }
            if (!rb_beta.Checked) {
                dateTimePicker.Enabled = false;
                label5.Enabled = false;
            }


        }

        // 《权限申请页面》 点击可 展开 或 关闭 “软件模块选择列表”
        int count_tbd_model_click = 0;
        private void tbd_model_Click(object sender, EventArgs e)
        {
            if (count_tbd_model_click == 0) {
                checkedListBox.Visible = true;
                count_tbd_model_click++;
            } else if (count_tbd_model_click == 1) {
                checkedListBox.Visible = false;
                count_tbd_model_click--;
            }
        }

        private void tbd_model_MouseMove(object sender, MouseEventArgs e)
        {
            //checkedListBox.Visible = true;
        }

        private void tbd_model_MouseLeave(object sender, EventArgs e)
        {
            //checkedListBox.Visible = false;
        }

        private void tbd_model_DoubleClick(object sender, EventArgs e)
        {
           // checkedListBox.Visible = false;
        }

        private void tbd_model_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //checkedListBox.Visible = false;

        }

        // 《 权限申请页面》 -> 模块名显示
        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String list = "";
            tbd_model.Text = "";
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    //list_model.Add
                    list += checkedListBox.GetItemText(checkedListBox.Items[i]) + "，";
                }
            }
            if (list.EndsWith("，")) {
                list = list.Substring(0,list.Length-1);
                //MessageBox.Show("yes");
            }

            tbd_model.Text += list;

        }

        //选择 待申请软件
        /*
         软件不同，从软件表加载不同的软件所对应的版本号
         */

        //int count_select_init = 0;
        private void cb_software_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbd_model.Text = "";
            List<software> _list_version = new List<software>();
            //_list_version = list_version;
            String software_name = cb_software.GetItemText(cb_software.Items[cb_software.SelectedIndex]);
            foreach (var _version in list_version ) {
                if (_version.name==software_name) {
                    cb_version.Enabled = true;
                    _list_version.Add(_version);
                }
            }

            //版本号列表combobox绑定List
            cb_version.DataSource = _list_version;
            cb_version.DisplayMember = "version";             
        }

        //选择待申请模块，软件名和版本号不同，则模块名不同
        private void cb_version_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbd_model.Text = "";
            #region 选择模块
            checkedListBox.Items.Clear();
            String software_name = cb_software.GetItemText(cb_software.Items[cb_software.SelectedIndex]);
            String version = cb_version.GetItemText(cb_version.Items[cb_version.SelectedIndex]);

            foreach (var _model in list_model)
            {
                if (_model.name == software_name && _model.version == version)
                {
                    tbd_model.Enabled = true;
                    checkedListBox.Items.Add(_model.model);
                }
            }
            #endregion
        }
                
        // 《权限审批页面》 -> 提交用户申请
        private void but_submission_Click(object sender, EventArgs e)
        {
            //审批表插入一条数据
            submission();

            //申请信息保存到本地
            saveSubmission();

            //刷新用户中心、权限审批
            //更新 前端显示 -> 申请列表 和 授权记录; 
            //清空前端数据
            dgv_send_list.Rows.Clear(); //申请列表
            shenpi_read_list.Clear();   
            dgv_read_list.Rows.Clear();
            
            //重新载入 权限审批页面 
            initSendListData(); //申请列表
            initReadListData(); //审批列表
            
            //刷新 用户中心页面 -> 申请记录列表
            dgv_userInfo.Rows.Clear();
            initUserInfo();
  
        }
        //审批表插入一条数据
        public void submission()
        {
            String software_name = cb_software.GetItemText(cb_software.Items[cb_software.SelectedIndex]);
            String model_name = tbd_model.Text;

            if ((rb_beta.Checked || rb_official.Checked) && software_name != null && model_name != null)
            {
                #region //分割多选的模块名，一次仅向数据库插入一条 一个模块的申请记录
                //String[] model_arry = model_name.Split('，');
                //foreach (String _model_name in model_arry)
                //{
                //    shenpi _shenpi = new shenpi();

                //    _shenpi.username = username;
                //    _shenpi.software = software_name;
                //    _shenpi.model = _model_name;
                //    _shenpi.version = "1.0.3";
                //    _shenpi.model_tips = "未填写";
                //    if (rb_beta.Checked) {
                //        _shenpi.use_time = dateTimePicker.Value;
                //    }
                //    _shenpi.is_read = 0;
                //    _shenpi.is_through = 0;
                //    _shenpi.send_time = DateTime.Now;

                //    db.shenpi.Add(_shenpi);
                //    db.SaveChanges();
                //}
                #endregion
                
                shenpi _shenpi = new shenpi();

                _shenpi.username = username;
                _shenpi.software = software_name;
                _shenpi.model = model_name;
                _shenpi.version = cb_version.Text;
                _shenpi.model_tips = "未填写";
                if (rb_beta.Checked)
                {
                    _shenpi.use_time = dateTimePicker.Value;
                }
                _shenpi.is_read = 0;
                _shenpi.is_through = 0;
                _shenpi.send_time = DateTime.Now;

                db.shenpi.Add(_shenpi);
                db.SaveChanges();

                MessageBox.Show("已提交申请");
            }
            else {
                MessageBox.Show("请完善申请信息！");
            }

        }
        //申请信息保存到本地
        public void saveSubmission() {
            String software_name = cb_software.GetItemText(cb_software.Items[cb_software.SelectedIndex]);
            String software_version = cb_version.GetItemText(cb_version.Items[cb_version.SelectedIndex]);

            FileStream fs = new FileStream("E:\\Program Files\\" + software_name+"_"+ cb_version.Text + "_" + tbd_model.Text + ".dat", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            //开始写入
            /*            pLocalFilePath += software + "_" + version + "_" + model + ".dat";
             申请文件格式：
                1. 软件路径
                2. 用户信息
                3. 申请软件
                4. 申请模块
                5. 软件类型
                6. CPU号
                7. 单机加密狗序列号
                8. 网络加密狗序列号
                9. 网络加密狗模块字      
             */
            #region //授权文件Base64编码
            //sw.WriteLine( Base64.EncodeBase64(tb_soft_path.Text) );
            //sw.WriteLine(Base64.EncodeBase64(rtb_user_info.Text));
            //sw.WriteLine(Base64.EncodeBase64(cb_software.GetItemText(cb_software.Items[cb_software.SelectedIndex])));
            //sw.WriteLine(Base64.EncodeBase64(tbd_model.Text));
            //if (rb_beta.Checked) {
            //    sw.WriteLine(Base64.EncodeBase64("试用版," + dateTimePicker.Value.ToString()));
            //}
            //if (rb_official.Checked) {
            //    sw.WriteLine(Base64.EncodeBase64("正式版"));
            //}
            //sw.WriteLine(Base64.EncodeBase64(rtb_cpu.Text));
            //sw.WriteLine(Base64.EncodeBase64(tb_djjmg.Text));
            //sw.WriteLine(Base64.EncodeBase64(tb_wljmg.Text));
            //sw.WriteLine(Base64.EncodeBase64(tb_wljmg_model.Text));
            #endregion
            sw.WriteLine("  用户名："+username);
            sw.WriteLine("  用户信息：" + rtb_user_info.Text);
            sw.WriteLine("  软件路径："+tb_soft_path.Text);
            sw.WriteLine("  申请软件："+software_name);
            sw.WriteLine("  申请模块："+tbd_model.Text);
            sw.WriteLine("  版本号："+software_version);

            if (rb_beta.Checked)
            {
                sw.WriteLine("  软件版本：试用版, 使用截止日期：" + dateTimePicker.Value.ToString());
            }
            if (rb_official.Checked)
            {
                sw.WriteLine("  正式版");
            }
            sw.WriteLine("  CPU号："+rtb_cpu.Text);
            sw.WriteLine("  单机加密狗序列号："+tb_djjmg.Text);
            sw.WriteLine("  网络加密狗序列号："+tb_wljmg.Text);
            sw.WriteLine("  网络加密狗模块字："+tb_wljmg_model.Text);

            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }

        //每隔一定时间，刷新控件
        List<shenpi> list_generate_software ;
        private void timer_message_Tick(object sender, EventArgs e)
        {
            ///刷新用户中心、权限审批
            ///更新 前端显示 -> 申请列表 和 授权记录; 
            ///清空前端数据

            dgv_send_list.Rows.Clear(); //申请列表
            shenpi_read_list.Clear();
            dgv_read_list.Rows.Clear();

            //重新载入 权限审批页面 
            initSendListData(); //申请列表
            initReadListData(); //审批列表

            //刷新 用户中心页面 -> 申请记录列表
            //dgv_userInfo.Rows.Clear();
            list_userInfo.Clear();
            dgv_userInfo.DataSource = null;
            initUserInfo();
            


            ////检索每条审批数据，若通过审批，则可生成授权文件
            //list_generate_software = db.shenpi.Where(u => u.username == username && u.is_read==1 && u.is_through==1).ToList();
            //if (list_generate_software.Count>=1) {
            //    but_generate.Enabled = true;                
            //}
            
        }

        private void rtb_user_info_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("双击事件");
        }

        private void tp_cpu_Click(object sender, EventArgs e)
        {
            showCPU();

            rtb_cpu.Visible = true;
            splitContainer_cpu.Visible = true;

        }

        private void rtb_cpu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("test");
        }

        private void splitContainer1_Panel1_Click(object sender, EventArgs e)
        {
            showCPU();                        
        }

        // 《权限申请页面》 -> 打开并显示cpu号
        public void showCPU() {
            rtb_cpu.Clear();
            //打开文件，并显示
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            openFileDialog.Multiselect = true;//可以选择多个文件
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                String filePath = openFileDialog.FileName;
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            rtb_cpu.Text += line;
                            rtb_cpu.AppendText(Environment.NewLine);
                        }
                        sr.Close();
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }

        //给用户显示授权文件
        public void showSubmissionFile(String software, String version, String model) {

            string pLocalFilePath = "E:\\Program Files\\";//待复制文件的文件夹路径

            pLocalFilePath += software + "_" + version + "_" + model + ".dat";

            if (File.Exists(pLocalFilePath))//必须判断要复制的文件是否存在
            {
                if (SelectPath()!=String.Empty) {

                    string pSaveFilePath = SelectPath() + "\\Haily_" + software + "_" + version + "_" + model + ".dat";    //保存至目标文件夹

                    File.Copy(pLocalFilePath, pSaveFilePath, true);//三个参数分别是源文件路径，存储路径，若存储路径有相同文件是否替换
                    MessageBox.Show("下载授权文件成功，保存在：" + pSaveFilePath);
                }
            }
            else
            {
                MessageBox.Show("该条申请已过期,请重新提交申请");
            }


            //思路为，遍历审核通过的软件列表，则可知 原始存储路径 为“固定文件夹”+“审核通过的软件名”.haily
            //foreach (var submission in list_generate_software) {
            //    String localPath = "";   //动态改变的待复制文件具体路径
            //    localPath += pLocalFilePath+"windows_"+submission.software+".haily";

            //    //复制后，指定存储的路径"E:\\Program Files\\windows_"+software_name+".haily"
            //    String outPath = pSaveFilePath+"\\Haily_"+ submission.software + ".dat";

            //    if (File.Exists(localPath))//必须判断要复制的文件是否存在
            //    {
            //        File.Copy(localPath, outPath, true);//三个参数分别是源文件路径，存储路径，若存储路径有相同文件是否替换
            //        MessageBox.Show("已生成授权文件，保存在：" + outPath);
            //    }
            //    else {
            //        MessageBox.Show("请重新提交申请");
            //    }

            //}

            #region 测试解码授权文件
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //String filePath = "E:\\Program Files\\windows.dat";
            //try
            //{
            //    using (StreamReader sr = new StreamReader(filePath))
            //    {
            //        string line;
            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            rtb_user_info.Text += Base64.DecodeBase64(line);
            //            rtb_user_info.AppendText(Environment.NewLine);
            //        }
            //        sr.Close();
            //    }
            //}
            //catch (Exception ee)
            //{
            //    MessageBox.Show(ee.Message);
            //}
            #endregion

        }

        //《首页》 -> 消息盒子
        int click_message = 0;
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
        //    if (click_message==0) {
        //        dgv_userInfo.Visible = true;
                
        //        click_message++;
        //    }
        //    else if (click_message == 1) {
        //        dgv_userInfo.Visible = false;
        //        //pictureBox_title.Visible = true;
        //        click_message--;
        //    }
            
        }

        //System.Management;//需要添加引用(系统自带)
        /// <summary>
        /// 获取cpu编号
        /// </summary>
        /// <returns></returns>
        public String GetCpuID()
        {
            try
            {
                ManagementClass mc = new ManagementClass("Win32_Processor");
                ManagementObjectCollection moc = mc.GetInstances();

                String strCpuID = null;
                foreach (ManagementObject mo in moc)
                {
                    strCpuID = mo.Properties["ProcessorId"].Value.ToString();
                    break;
                }
                return strCpuID;
            }
            catch
            {
                return "";
            }

        }//end method  

        private void dgv_userInfo_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            int row = e.Row.Index + 1;
            e.Row.HeaderCell.Value = string.Format("{0}", row);
        }
    }
}
