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
            string className = txtClassName.Text.Trim();
            if (className.Length == 0)
            {
                MessageBox.Show("请输入班级名称。", "提示");
                txtClassName.Focus();
                return;
            }

            if (_classService.ClassNameExists(className))
            {
                MessageBox.Show("班级名称已存在，请输入新的名称。", "提示");
                txtClassName.Focus();
                return;
            }

            int newId = _classService.AddClass(new Class { ClassName = className });
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
            string className = txtClassName.Text.Trim();
            if (className.Length == 0)
            {
                MessageBox.Show("请输入班级名称。", "提示");
                txtClassName.Focus();
                return;
            }

            if (_classService.ClassNameExists(className, classId))
            {
                MessageBox.Show("班级名称已存在，请输入新的名称。", "提示");
                return;
            }

            int rows = _classService.UpdateClass(new Class { Id = classId, ClassName = className });
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
            if (_classService.ClassHasStudents(classId))
            {
                MessageBox.Show("该班级下存在学员，无法删除。请先移除或转移学员。", "提示");
                return;
            }
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

        private void ClearInputs()
        {
            txtClassName.Clear();
        }
    }
}
