using DAL.ahutit;
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

namespace AMS.ahutit
{
    public partial class FrmScoreVIew : Form
    {
        private StudentClassService classService = new StudentClassService();
        private ScoreService scoreService = new ScoreService();
        private List<StudentExt> allScores = new List<StudentExt>();

        public FrmScoreVIew()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            // Init Class ComboBox
            cmbClass.DataSource = classService.GetAllClass();
            cmbClass.DisplayMember = "ClassName";
            cmbClass.ValueMember = "ClassName"; // Using Name as value for easier filtering string match, or use ClassId if preferred. Service uses string className.
            cmbClass.SelectedIndex = -1;

            // Init DataGrid Columns Mapping
            dgScore.AutoGenerateColumns = false;
            
            // Load Initial Data
            LoadScoreData();
        }

        private void LoadScoreData()
        {
            try
            {
                allScores = scoreService.GetStudentScores();
                dgScore.DataSource = null;
                dgScore.DataSource = allScores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载成绩数据失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            cmbClass.SelectedIndex = -1;
            txtScore.Text = "";
            FilterData();
        }

        private void FilterData()
        {
            if (allScores == null || allScores.Count == 0) return;

            var filtered = allScores.AsEnumerable();

            // Filter by Class
            if (cmbClass.SelectedIndex != -1 && cmbClass.SelectedValue != null)
            {
                string selectedClass = cmbClass.SelectedValue.ToString();
                filtered = filtered.Where(s => s.ClassName == selectedClass);
            }

            // Filter by Attendance Score
            if (!string.IsNullOrWhiteSpace(txtScore.Text) && int.TryParse(txtScore.Text.Trim(), out int minScore))
            {
                filtered = filtered.Where(s => s.AttendanceScore >= minScore);
            }

            dgScore.DataSource = filtered.ToList();
        }
    }
}
