using System;
using System.Windows.Forms;
using Models.ahutit;

using DAL.ahutit;

namespace AMS.ahutit
{
    public partial class FrmStudentMain : Form
    {
        private readonly Student _student;
        private readonly ScoreService _scoreService = new ScoreService();

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

        private void btnScore_Click(object sender, EventArgs e)
        {
            try
            {
                StudentExt? score = _scoreService.GetStudentScoreByStudentId(_student.StdId);
                if (score != null)
                {
                    MessageBox.Show($"签到次数：{score.AttendanceCount}\n考勤总次数：{score.TotalSessions}\n\n当前考勤得分：{score.AttendanceScore}", "我的考勤分析", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("未查询到您的考勤信息。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询成绩失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
