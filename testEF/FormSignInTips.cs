using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEF
{
    public partial class FormSignInTips : Form
    {
        public FormSignInTips()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (this.Opacity > 0 && this.Opacity <= 1)//开始执行弹出窗渐渐透明
            {
                this.Opacity = this.Opacity - 0.01;//透明频度0.05
            }
            if (this.Opacity == 0)//当透明度==0的时候，关闭弹出窗以释放资源。
            {
                this.Close();
            }
        }

        private void FormSignInTips_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
