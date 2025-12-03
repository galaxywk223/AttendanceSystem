using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Models.ahutit;
using DAL;
using DAL.ahutit;

namespace AMS.ahutit
{
    public partial class FrmLogin : Form
    {
        public SysAdminService objSysAdminService = new SysAdminService();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //数据验证
            if (this.tbxName.Text.Trim().Length == 0)
            {
                MessageBox.Show("您不能输入空字符！", "提示信息", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                this.tbxName.Focus();
                return;
            }
            //登录账号和密码不能包含危险字符%,_等
            if (!Common.DataValidate.IsInteger(tbxName.Text.Trim()))
            {
                MessageBox.Show("登录账号格式不正确，请重新输入！", "提示信息");
                this.tbxName.Focus();
                return;
            }

            if (this.tbxPsw.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入密码！", "提示信息");
                this.tbxPsw.Focus();
                return;
            }


            //数据封装
            SysAdmin objAdmin = new SysAdmin()
            {
                loginid = Convert.ToInt32(tbxName.Text.Trim()),
                Pwd = tbxPsw.Text.Trim()
            };

            //和后台交互
            try
            {
                Program.currentAdmin = objSysAdminService.AdminLogin(objAdmin);
                if (Program.currentAdmin != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误", "提示信息");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库访问异常");
            }

            //处理交互结果（保存数据、返回对象）
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
