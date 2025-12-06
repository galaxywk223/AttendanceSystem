using DAL.ahutit;
using Models.ahutit;
using System.Diagnostics;

namespace AMS.ahutit
{
    public partial class FrmMain : Form
    {
        StudentService studentService=new StudentService();
        public FrmMain()
        {
            InitializeComponent();
            //显示当前用户
            this.tssLabUserName.Text = Program.currentAdmin != null ? Program.currentAdmin.AdminName : "管理员";
            btnAtt.Visible = false; // 管理员不需要考勤打卡
        }

        private void ϵͳToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #region 关闭前面的窗体嵌入新窗体
        private void closePreForm()
        {
            foreach (Control item in this.splitContainer1.Panel2.Controls)
            {
                if (item is Form)
                {
                    Form objForm = (Form)item;
                    objForm.Close();
                }
            }
        }

        private void openForm(Form objForm)
        {
            objForm.TopLevel = false;
            objForm.WindowState = FormWindowState.Maximized;
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Parent = this.splitContainer1.Panel2;
            objForm.Show();
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //先判断当前容器中是否存在此窗体，如果存在就关掉这个窗体
            //通过遍历,封装方法
            //foreach (Control item in this.splitContainer1.Panel2.Controls)
            //{
            //    if (item is Form)
            //    {
            //        Form objForm = (Form)item;
            //        objForm.Close();
            //    }
            //}
            closePreForm();
            FrmAddStd frmAddStd = new FrmAddStd();
            //封装方法
            openForm(frmAddStd);
            //frmAddStd.TopLevel = false;
            //frmAddStd.WindowState = FormWindowState.Maximized;
            //frmAddStd.FormBorderStyle = FormBorderStyle.None;
            //frmAddStd.Parent = this.splitContainer1.Panel2;
            //frmAddStd.Show();
        }

        private void btnManange_Click(object sender, EventArgs e)
        {
            closePreForm();
            FrmStdManage frmStdManage = new FrmStdManage();
            //封装方法
            openForm(frmStdManage);
        }

        private void btnClassManage_Click(object sender, EventArgs e)
        {
            closePreForm();
            FrmClassManage frmClassManage = new FrmClassManage();
            openForm(frmClassManage);
        }

        private void tsmiClassManage_Click(object sender, EventArgs e)
        {
            btnClassManage_Click(sender, e);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出吗？", "退出确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出吗？", "退出确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            //创建登录窗体
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Text = "[切换账号]";
            DialogResult result = frmLogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (Program.currentAdmin != null)
                {
                    this.tssLabUserName.Text = Program.currentAdmin.AdminName;
                }
                else if (Program.currentStudent != null)
                {
                    // 切到学员端
                    FrmStudentMain frmStudentMain = new FrmStudentMain();
                    frmStudentMain.Show();
                    this.Close();
                }
            }
        }

        private void btnPSW_Click(object sender, EventArgs e)
        {
            FrmModifyPSW frmModifyPSW = new FrmModifyPSW();
            frmModifyPSW.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            closePreForm();
            FrmScoreVIew frmScoreVIew = new FrmScoreVIew();
            //封装方法
            openForm(frmScoreVIew);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //设置列标题
            Dictionary<string,string> columnNames=new Dictionary<string, string>();
            columnNames.Add("StdId", "学号");
            columnNames.Add("StdName", "姓名");
            columnNames.Add("Birthday", "出生日期");
            columnNames.Add("Gender", "性别");
            columnNames.Add("idNo", "身份证号");
            columnNames.Add("Age", "年龄");
            columnNames.Add("StdImage", "照片");
            columnNames.Add("PhoneNumber", "手机号码");
            columnNames.Add("Address", "地址");
            columnNames.Add("CardNo", "考勤卡号");
            columnNames.Add("Classid", "班级ID");
            columnNames.Add("ClassName", "所在班级");

            List<Student> ExportStudentList = studentService.getAllStudents();
            //调用到处方法
            bool result = NPOIService.ExportToExcel<Student>("StudentList.xlsx", ExportStudentList, columnNames, 1);
            if (result)
            {
                DialogResult dialog = MessageBox.Show("导出成功！是否打开文件？", "导出成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    ProcessStartInfo psi = new ProcessStartInfo("StudentList.xlsx") { UseShellExecute = true };
                    Process.Start(psi);
                }
            }
        }
    }
}
