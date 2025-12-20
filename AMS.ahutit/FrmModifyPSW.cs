using Models.ahutit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAL.ahutit;

namespace AMS.ahutit
{
    public partial class FrmModifyPSW : Form
    {
        public FrmModifyPSW()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            #region 密码验证
            //验证输入
            if (txtOldPSW.Text.Trim().Length == 0)
            {
                MessageBox.Show("原密码不能为空", "输入错误");
                txtOldPSW.Focus();
                return;
            }
            //验证原密码是否正确
            if (txtOldPSW.Text.Trim() != Program.currentAdmin.Pwd)
            {
                MessageBox.Show("原密码输入错误", "输入错误");
                txtOldPSW.Focus();
                txtOldPSW.SelectAll();
                return;
            }
            //判断新密码长度
            if (this.txtNewPSW.Text.Trim().Length < 6)
            {
                MessageBox.Show("新密码长度不能小于6位", "提示");
                txtNewPSW.Focus();
                return;
            }
            //验证两次输入一致
            if (txtConfirmPSW.Text.Trim().Length == 0)
            {
                MessageBox.Show("请再次输入新密码", "提示");
                txtConfirmPSW.Focus();
                return;
            }
            if (txtConfirmPSW.Text.Trim() != txtNewPSW.Text.Trim())
            {
                MessageBox.Show("两次输入密码不一致", "提示");
                txtNewPSW.Text = "";
                txtConfirmPSW.Text = "";
                return;
            }
            #endregion

            #region 修改密码
            try
            {
                SysAdmin sysAdmin = new SysAdmin()
                {
                    loginid = Program.currentAdmin.loginid,
                    Pwd = txtNewPSW.Text.Trim()
                };
                if (new SysAdminService().ModifyPSW(sysAdmin) == 1)
                {
                    MessageBox.Show("密码修改成功，请重新登录", "提示");
                    //修改系统对象的密码
                    Program.currentAdmin.Pwd = txtNewPSW.Text.Trim();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }                
            }
            catch{
                throw;            
            }
            #endregion
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
