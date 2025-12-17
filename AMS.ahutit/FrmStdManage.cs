using DAL;
using DAL.ahutit;
using Models;
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

namespace AMS.ahutit
{
    public partial class FrmStdManage : Form
    {
        private StudentClassService classService = new StudentClassService();
        private StudentService studentService = new StudentService();
        private List<Student> stdList = new List<Student>();

        public FrmStdManage()
        {
            InitializeComponent();
            cmbClass.DataSource = classService.GetAllClass();
            cmbClass.DisplayMember = "Name";
            cmbClass.ValueMember = "ClassName";
            cmbClass.SelectedIndex = -1;
            dgStd.AutoGenerateColumns = false;
            stdList = studentService.getAllStudents();
            dgStd.DataSource = stdList;
        }

        private void btnSearchByClass_Click(object sender, EventArgs e)
        {
            if (cmbClass.SelectedIndex == -1)
            {
                MessageBox.Show("请选择班级", "提示信息");
                return;
            }
            //执行查询并绑定datagrid
            stdList = studentService.getStudentsByClass(cmbClass.Text);
            dgStd.DataSource = stdList;
        }

        private void btnSearchByNameDesc_Click(object sender, EventArgs e)
        {
            if (dgStd.RowCount == 0) { return; }
            stdList.Sort(new NameDESC());
            dgStd.Refresh();
        }

        private void btnSearchByNumDesc_Click(object sender, EventArgs e)
        {
            if (dgStd.RowCount == 0) { return; }
            stdList.Sort(new StdIDDESC());
            dgStd.Refresh();
        }

        private void btnSearchByNum_Click(object sender, EventArgs e)
        {
            if (dgStd.RowCount == 0) { return; }
            stdList.Clear();
            Student? student = studentService.GetStudentByCardNo(txtCardNo.Text.Trim());
            if (student != null)
            {
                stdList.Add(student);
            }
            dgStd.DataSource=null;
            dgStd.DataSource=stdList;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //确定用户选中一行
            if (dgStd.RowCount == 0)
            {
                MessageBox.Show("没有可修改的学员信息", "提示信息");
                return;
            }
            if (dgStd.CurrentRow == null)
            {
                MessageBox.Show("请选择以为学员", "提示信息");
                return;
            }
            //获取考勤卡号
            string cardNo = dgStd.CurrentRow.Cells["CardNo"].Value?.ToString() ?? string.Empty;
            Student? student = studentService.GetStudentByCardNo(cardNo);
            if (student == null) return;
            FrmStdEdit frmStdEdit = new FrmStdEdit(student);
            if (frmStdEdit.ShowDialog() == DialogResult.OK)
            {
                btnSearchByClass_Click(null, null);
            }
        }


        private void dgStd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取选中单元格所在行的第一列值
            string cardNo = dgStd.CurrentRow.Cells["CardNo"].Value?.ToString() ?? string.Empty;
            Student? student = studentService.GetStudentByCardNo(cardNo);
            if (student == null) return;
            FrmStdDetail frmStdDetail = new FrmStdDetail(student);
            frmStdDetail.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //获取学号
            //确定用户选中一行
            if (dgStd.RowCount == 0)
            {
                MessageBox.Show("没有可修改的学员信息", "提示信息");
                return;
            }
            if (dgStd.CurrentRow == null)
            {
                MessageBox.Show("请选择以为学员", "提示信息");
                return;
            }
            //获取考勤卡号
            string cardNo = dgStd.CurrentRow.Cells["CardNo"].Value?.ToString() ?? string.Empty;
            //Student student = studentService.GetStudentByCardNo(cardNo); // Getting full object not strictly needed for ID if we had it, but for delete we need ID.
            // Wait, deleteStdInfoByID takes stdId. 
            // So I MUST fetch the student to get the StdId.
            Student? student = studentService.GetStudentByCardNo(cardNo);
            if (student == null) return;
            
            DialogResult result=MessageBox.Show("确定要删除考勤卡号为["+ cardNo+"]学员的信息吗？","删除确认",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try 
                {
                    // Cascading delete may affect multiple rows (attendance + student), so check >= 1
                    if (studentService.deleteStdInfoByID(student.StdId.ToString()) >= 1)
                    {
                        //MessageBox.Show("删除学号为[" + stdid + "]学员的信息成功", "提示信息");
                        btnSearchByClass_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("删除考勤卡号为[" + cardNo + "]学员的信息失败", "提示信息");
                    }
                }
                catch { }
            }
        }
    }
    #region 实现排序
    class NameDESC : IComparer<Student>
    {
        public int Compare(Student? std1, Student? std2)
        {
            if (std1 == null && std2 == null) return 0;
            if (std1 == null) return -1;
            if (std2 == null) return 1;
            return std2.StdName.CompareTo(std1.StdName);
        }
    }

    class StdIDDESC : IComparer<Student>
    {
        public int Compare(Student? std1, Student? std2)
        {
            if (std1 == null && std2 == null) return 0;
            if (std1 == null) return -1;
            if (std2 == null) return 1;
            return std2.CardNo.CompareTo(std1.CardNo);
        }
    }
    #endregion
}
