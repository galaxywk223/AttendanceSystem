using System;
using System.Windows.Forms;
using Models.ahutit;

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

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            FrmStdDetail detail = new FrmStdDetail(_student);
            detail.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.currentStudent = null;
            this.Close();
        }
    }
}
