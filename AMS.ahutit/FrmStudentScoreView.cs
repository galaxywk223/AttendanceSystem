using System;
using System.Windows.Forms;
using DAL.ahutit;
using Models.ahutit;

namespace AMS.ahutit
{
    public partial class FrmStudentScoreView : Form
    {
        private readonly Student _student;
        private readonly ScoreService _scoreService = new ScoreService();

        public FrmStudentScoreView(Student student)
        {
            _student = student;
            InitializeComponent();
        }

        private void FrmStudentScoreView_Load(object sender, EventArgs e)
        {
            LoadScore();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadScore();
        }

        private void LoadScore()
        {
            try
            {
                StudentExt? score = _scoreService.GetStudentScoreByStudentId(_student.StdId);
                if (score != null)
                {
                    lblAttendanceCount.Text = score.AttendanceCount.ToString();
                    lblTotalSessions.Text = score.TotalSessions.ToString();
                    lblAttendanceScore.Text = score.AttendanceScore.ToString();
                }
                else
                {
                    lblAttendanceCount.Text = "-";
                    lblTotalSessions.Text = "-";
                    lblAttendanceScore.Text = "-";
                    MessageBox.Show("未查询到您的考勤信息。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询成绩失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
