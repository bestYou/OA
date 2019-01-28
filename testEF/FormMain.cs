using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace testEF
{
    public partial class FormMain : Office2007Form
    {
        hailyEntities db = new hailyEntities();
        String username = FormSignIn.userName_main;

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

            UpdateInfo();
            SetHeaderName();
        }
        
        /// <summary>
        ///进入指定页面 
        /// </summary>
        /// <param name="page">主界面的不同页面</param>
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

            UpdateInfo();
            SetHeaderName();
        }
  
        #region 《用户中心》  
        public void initUserInfo()  //初始化用户中心
        {
            dgv_userInfo.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgv_userInfo.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            label_user.Text = username;
            labelItem_user.Text = username;

            //判断 当前用户 -> 用户权限
            List<user> list = db.user.Where(u => u.username == username).ToList();
            if (list[0].permission == 0) {
                labelItem_permission.Text = "普通用户:";
                sti_read_permission.Visible = false;    //普通用户“权限审批”、“用户管理”、“软件管理 ”功能页面不可见
                sti_user_control.Visible = false;
                sti_software_control.Visible = false;
            } else if (list[0].permission == 1) {
                labelItem_permission.Text = "管理员:";
            }                                      
        }

        public void UpdateInfo()  //更新 用户中心 信息
        {
            List<shenpi> list_shenpi = db.shenpi.Where(u => u.username == username).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("username");
            dt.Columns.Add("software");
            dt.Columns.Add("model");
            dt.Columns.Add("version");
            dt.Columns.Add("result");
            dt.Columns.Add("send_time");

            DataRow newRow; ;
            for (int i = 0; i < list_shenpi.Count; i++)
            {
                newRow = dt.NewRow();
                newRow["username"] = list_shenpi[i].username;
                newRow["software"] = list_shenpi[i].software;
                newRow["model"] = list_shenpi[i].model;
                newRow["version"] = list_shenpi[i].version;
                String result = "";
                if (list_shenpi[i].is_read == 1 && list_shenpi[i].is_through == 1)
                {
                    result = "通过";
                }
                if (list_shenpi[i].is_read == 1 && list_shenpi[i].is_through == 0)
                {
                    result = "拒绝";
                }
                if (list_shenpi[i].is_read == 0)
                {
                    result = "待处理";
                }
                newRow["result"] = result;
                newRow["send_time"] = list_shenpi[i].send_time;
                dt.Rows.Add(newRow);
            }
            this.dgv_userInfo.DataSource = dt;
        }

        public void SetHeaderName()  //设置 用户中心 列名
        {
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
               
        void DataGridView_userInfo_CellContentClick(object sender, DataGridViewCellEventArgs e) //捕捉<用户中心页面>点击事件，并响应
        {
            if (e.ColumnIndex>=0 && e.RowIndex>=0) {

                String _software = dgv_userInfo.Rows[e.RowIndex].Cells["software"].Value.ToString();
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
       
        public void showSubmissionFile(String software,String version,String model) //给用户显示授权文件
        {

            string pLocalFilePath = "E:\\Program Files\\";//待复制文件的文件夹路径

            pLocalFilePath += software + "_" + version + "_" + model + ".dat";

            if (File.Exists(pLocalFilePath))//必须判断要复制的文件是否存在
            {
                String selectPath = SelectPath();
                if (selectPath != String.Empty)
                {
                    string pSaveFilePath = selectPath + "\\Haily_" + software + "_" + version + "_" + model + ".dat";    //保存至目标文件夹
                    File.Copy(pLocalFilePath, pSaveFilePath, true);//三个参数分别是源文件路径，存储路径，若存储路径有相同文件是否替换
                    MessageBox.Show("下载授权文件成功，保存在：" + pSaveFilePath);
                }
            }
            else
            {
                MessageBox.Show("该条申请已过期,请重新提交申请");
            }
        }
        
        private void sti_user_center_Click(object sender,EventArgs e)  //《用户中心》标签 点击事件
        {
            dgv_userInfo.DataSource = null;
            dgv_userInfo.Columns.Clear();
            UpdateInfo();
            SetHeaderName();
        }

        private void timer_message_Tick(object sender, EventArgs e)  //自动刷新 《用户中心》
        {
            dgv_userInfo.DataSource = null;
            dgv_userInfo.Columns.Clear();
            UpdateInfo();
            SetHeaderName();
        }
        #endregion

        #region 《用户管理》
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
        
        public struct User_Control
        {
            public String name;
            public String model;
        }
        List<user> list_user_control = new List<user>();
        void DataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = dgv_user_control.CurrentCell.ColumnIndex;
            int row = dgv_user_control.CurrentCell.RowIndex;

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
                var userInfoList = from u in db.user
                                   where u.username == _userName
                                   select u;
                user _userInfo = userInfoList.FirstOrDefault();
                if ( _userInfo != null)
                {
                    DialogResult result = MessageBox.Show("确定注销用户用户“"+_userName+"”？","提示窗口", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes) {
                        db.user.Remove(_userInfo);
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
                
        private void bt_add_user_Click(object sender, EventArgs e)  //新增用户
        {
            FormAddUser formAddUser = new FormAddUser();
            formAddUser.Show();            
            this.Close();
        }
        #endregion

        #region 《权限申请》
        //初始化 权限申请页面
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
     
        private void textBoxX1_Click(object sender, EventArgs e)  //权限申请页面 -> 选择软件路径
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
            else
            {
                return String.Empty;
            }
        }

        private string SelectFile() //弹出一个选择具体文件的对话框
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            return file.FileName;
        }

        private void rb_beta_CheckedChanged(object sender, EventArgs e)   //试用版
        {
            if (rb_beta.Checked)
            {
                dateTimePicker.Enabled = true;
                label5.Enabled = true;
            }
            if (!rb_beta.Checked)
            {
                dateTimePicker.Enabled = false;
                label5.Enabled = false;
            }
        }

        #region 《权限申请页面》 -> 选择软件
        // 《权限申请页面》 -> 模块列表
        int count_tbd_model_click = 0;
        private void tbd_model_Click(object sender, EventArgs e)
        {
            if (count_tbd_model_click == 0)
            {
                checkedListBox.Visible = true;
                count_tbd_model_click++;
            }
            else if (count_tbd_model_click == 1)
            {
                checkedListBox.Visible = false;
                count_tbd_model_click--;
            }
        }

        // 《权限申请页面》 -> 模块名显示
        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String list = "";
            tbd_model.Text = "";
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    list += checkedListBox.GetItemText(checkedListBox.Items[i]) + "，";
                }
            }
            if (list.EndsWith("，"))
            {
                list = list.Substring(0, list.Length - 1);
            }
            tbd_model.Text += list;
        }
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

        // 《权限申请页面》 -> 版本号显示
        private void cb_software_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbd_model.Text = "";
            List<software> _list_version = new List<software>();
            String software_name = cb_software.GetItemText(cb_software.Items[cb_software.SelectedIndex]);
            foreach (var _version in list_version)
            {
                if (_version.name == software_name)
                {
                    cb_version.Enabled = true;
                    _list_version.Add(_version);
                }
            }
            //版本号列表combobox绑定List
            cb_version.DataSource = _list_version;
            cb_version.DisplayMember = "version";
        }
        #endregion

        #region 打开并显示CPU号
        private void tp_cpu_Click(object sender, EventArgs e)
        {
            showCPU();

            rtb_cpu.Visible = true;
            splitContainer_cpu.Visible = true;
        }
        private void splitContainer1_Panel1_Click(object sender, EventArgs e)
        {
            showCPU();
        }
        public void showCPU()
        {
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
        #endregion
        #endregion

        #region 《权限审批》       
        public void initPermissionReadPage() //初始化 权限审批页面
        {
            initSendListData();
            initReadListData();
        }
        
        List<shenpi> shenpi_read_list = new List<shenpi>(); //存储 未处理的审批数据
        public void initSendListData()  //初始化 权限审批页面 -> 申请列表数据
        {
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
                
        public void initReadListData()  //初始化 权限审批页面 -> 授权记录数据
        {
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

        #region 《权限审批页面》 -> 提交用户申请
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
            initUserInfo();
        }
        //审批表插入一条数据
        public void submission()
        {
            String software_name = cb_software.GetItemText(cb_software.Items[cb_software.SelectedIndex]);
            String model_name = tbd_model.Text;

            if ((rb_beta.Checked || rb_official.Checked) && software_name != null && model_name != null)
            {
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
            else
            {
                MessageBox.Show("请完善申请信息！");
            }
        }
        //申请信息保存到本地
        public void saveSubmission()
        {
            String software_name = cb_software.GetItemText(cb_software.Items[cb_software.SelectedIndex]);
            String software_version = cb_version.GetItemText(cb_version.Items[cb_version.SelectedIndex]);

            FileStream fs = new FileStream("E:\\Program Files\\" + software_name + "_" + cb_version.Text + "_" + tbd_model.Text + ".dat", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            /*            
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
            sw.WriteLine("  用户名：" + username);
            sw.WriteLine("  用户信息：" + rtb_user_info.Text);
            sw.WriteLine("  软件路径：" + tb_soft_path.Text);
            sw.WriteLine("  申请软件：" + software_name);
            sw.WriteLine("  申请模块：" + tbd_model.Text);
            sw.WriteLine("  版本号：" + software_version);

            if (rb_beta.Checked)
            {
                sw.WriteLine("  软件版本：试用版, 使用截止日期：" + dateTimePicker.Value.ToString());
            }
            if (rb_official.Checked)
            {
                sw.WriteLine("  正式版");
            }
            sw.WriteLine("  CPU号：" + rtb_cpu.Text);
            sw.WriteLine("  单机加密狗序列号：" + tb_djjmg.Text);
            sw.WriteLine("  网络加密狗序列号：" + tb_wljmg.Text);
            sw.WriteLine("  网络加密狗模块字：" + tb_wljmg_model.Text);

            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }
        #endregion
        #endregion

        #region 《软件管理》   
        List<software> list_soft_control = new List<software>();
        public void initSoftwarePage()  //初始化 软件管理页面
        {
            label_software_control.Text = "你好，管理员“" + username + "”";
            List<software> list_software = db.software.ToList();
            foreach (var _software in list_software)
            {
                this.dgv_soft.Rows.Add(_software.name, _software.model,_software.version, "修改", "注销");

                list_soft_control.Add(_software);
            }
        }

        void DataGridViewX1_software_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = dgv_soft.CurrentCell.ColumnIndex;
            int row = dgv_soft.CurrentCell.RowIndex;
            
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
        
        private void but_add_software_Click(object sender, EventArgs e)  // 软件管理页面 -> 新增软件
        {
            FormAddSoftware formAddSoftware = new FormAddSoftware();
            formAddSoftware.Show();

            this.Hide();
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

        #region 登录与退出程序
        public void showSuccess()  //登录成功提示
        {
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

        private void buttonItem1_Click(object sender, EventArgs e)  //退出登录
        {
            FormSignIn formSignIn = new FormSignIn();
            formSignIn.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)  //右上角小叉号，关闭程序
        {
            Application.Exit();
        }
        
        private void timer1_Tick(object sender, EventArgs e)  //登录成功窗口显示时间
        {
            showSuccess();
        }
        #endregion

        #region DataGridView显示行号
        private void dgv_userInfo_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            int row = e.Row.Index + 1;
            e.Row.HeaderCell.Value = string.Format("{0}", row);
        }
        private void dgv_send_list_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            int row = e.Row.Index + 1;
            e.Row.HeaderCell.Value = string.Format("{0}", row);
        }
        private void dgv_read_list_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            int row = e.Row.Index + 1;
            e.Row.HeaderCell.Value = string.Format("{0}", row);
        }
        private void dgv_user_control_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            int row = e.Row.Index + 1;
            e.Row.HeaderCell.Value = string.Format("{0}", row);
        }
        private void dgv_soft_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            int row = e.Row.Index + 1;
            e.Row.HeaderCell.Value = string.Format("{0}", row);
        }
        #endregion

    }
}
