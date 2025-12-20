using System;
using System.Windows.Forms;
using Models.ahutit;

using DAL.ahutit;

namespace AMS.ahutit
{
    public partial class FrmStudentMain : Form
    {
        private readonly Student _student;

        public FrmStudentMain()
        {
            _student = Program.currentStudent ?? throw new InvalidOperationException("未找到当前学员信息");
            InitializeComponent();
        }

        private void FrmStudentMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"欢迎，{_student.StdName}（班级：{_student.ClassName}，卡号：{_student.CardNo}）";
        }

        private void ClosePreForm()
        {
            foreach (Control item in panelContent.Controls)
            {
                if (item is Form)
                {
                    Form objForm = (Form)item;
                    objForm.Close();
                }
            }
        }

        private void OpenForm(Form objForm)
        {
            objForm.TopLevel = false;
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Parent = panelContent;
            objForm.Show();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            ClosePreForm();
            FrmStdDetail detail = new FrmStdDetail(_student, true);
            OpenForm(detail);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.IsLogout = true;
            this.Close();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            ClosePreForm();
            FrmStudentScoreView scoreView = new FrmStudentScoreView(_student);
            OpenForm(scoreView);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            AttendanceService attService = new AttendanceService();
            try
            {
                int result = attService.SignIn(_student.StdId);
                if (result > 0)
                {
                    MessageBox.Show("签到成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("签到失败。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "签到提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            ClosePreForm();
            FrmStudentModifyPSW modify = new FrmStudentModifyPSW(_student);
            OpenForm(modify);
        }
    }
}
