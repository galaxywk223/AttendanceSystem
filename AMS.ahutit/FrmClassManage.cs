using DAL.ahutit;
using Models.ahutit;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AMS.ahutit
{
    public partial class FrmClassManage : Form
    {
        private readonly StudentClassService _classService = new StudentClassService();
        private List<Class> _classList = new List<Class>();

        public FrmClassManage()
        {
            InitializeComponent();
        }

        private void FrmClassManage_Load(object sender, EventArgs e)
        {
            LoadClassList();
        }

        private void LoadClassList()
        {
            _classList = _classService.GetAllClass();
            dgvClasses.DataSource = null;
            dgvClasses.DataSource = _classList;
            ClearInputs();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string? computedName = BuildClassNameFromInputs();
            if (computedName == null) return;

            if (_classService.ClassNameExists(computedName))
            {
                MessageBox.Show("班级名称已存在，请输入新的名称。", "提示");
                txtShort.Focus();
                return;
            }

            int newId = _classService.AddClass(new Class { ClassName = computedName });
            if (newId > 0)
            {
                LoadClassList();
                SelectRowById(newId);
                ClearInputs();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow == null)
            {
                MessageBox.Show("请选择要修改的班级。", "提示");
                return;
            }

            int classId = Convert.ToInt32(dgvClasses.CurrentRow.Cells["colId"].Value);
            string? computedName = BuildClassNameFromInputs();
            if (computedName == null) return;

            if (_classService.ClassNameExists(computedName, classId))
            {
                MessageBox.Show("班级名称已存在，请输入新的名称。", "提示");
                return;
            }

            int rows = _classService.UpdateClass(new Class { Id = classId, ClassName = computedName });
            if (rows == 1)
            {
                LoadClassList();
                SelectRowById(classId);
            }
            else
            {
                MessageBox.Show("更新失败，请稍后重试。", "错误");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow == null)
            {
                MessageBox.Show("请选择要删除的班级。", "提示");
                return;
            }

            int classId = Convert.ToInt32(dgvClasses.CurrentRow.Cells["colId"].Value);
            DialogResult result = MessageBox.Show($"确定删除编号为[{classId}]的班级吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK)
            {
                return;
            }

            int rows = _classService.DeleteClass(classId);
            if (rows == 1)
            {
                LoadClassList();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("删除失败，请稍后重试。", "错误");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadClassList();
        }

        private void dgvClasses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow != null)
            {
                var col = dgvClasses.Columns["colClassName"];
                if (col != null)
                {
                    txtClassName.Text = dgvClasses.CurrentRow.Cells[col.Index].Value?.ToString();
                }
                ClearInputBuildersOnly();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectRowById(int id)
        {
            foreach (DataGridViewRow row in dgvClasses.Rows)
            {
                var colId = dgvClasses.Columns["colId"];
                var colName = dgvClasses.Columns["colClassName"];
                if (colId == null || colName == null) break;
                if (row.Cells[colId.Index].Value != null && Convert.ToInt32(row.Cells[colId.Index].Value) == id)
                {
                    row.Selected = true;
                    dgvClasses.CurrentCell = row.Cells[colName.Index];
                    break;
                }
            }
        }

        private string? BuildClassNameFromInputs()
        {
            string major = txtMajor.Text.Trim();
            string shortName = txtShort.Text.Trim();
            string gradeText = txtGrade.Text.Trim();
            string classNoText = txtClassNo.Text.Trim();

            if (shortName.Length == 0)
            {
                MessageBox.Show("请填写简称。", "提示");
                txtShort.Focus();
                return null;
            }

            if (!int.TryParse(gradeText, out int grade) || grade <= 0)
            {
                MessageBox.Show("年级必须为有效数字，例如 2023。", "提示");
                txtGrade.Focus();
                return null;
            }

            if (!int.TryParse(classNoText, out int classNo) || classNo <= 0)
            {
                MessageBox.Show("班级号必须为正整数。", "提示");
                txtClassNo.Focus();
                return null;
            }

            string gradeSuffix = (grade % 100).ToString("D2");
            string className = $"{shortName}{gradeSuffix}{classNo}";
            txtClassName.Text = className;
            return className;
        }

        private void ClassPartChanged(object sender, EventArgs e)
        {
            BuildClassNameFromInputs();
        }

        private void ClearInputs()
        {
            ClearInputBuildersOnly();
            txtClassName.Clear();
        }

        private void ClearInputBuildersOnly()
        {
            txtMajor.Clear();
            txtShort.Clear();
            txtGrade.Clear();
            txtClassNo.Clear();
        }
    }
}
