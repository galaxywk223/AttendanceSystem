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
            stdList.Add(studentService.getStudentByStdID(txtStdID.Text.Trim()));
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
            //获取学号
            string stdid = dgStd.CurrentRow.Cells["StdId"].Value.ToString();
            Student student = studentService.getStudentByStdID(stdid);
            FrmStdEdit frmStdEdit = new FrmStdEdit(student);
            if (frmStdEdit.ShowDialog() == DialogResult.OK)
            {
                btnSearchByClass_Click(null, null);
            }
        }


        private void dgStd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取选中单元格所在行的第一列值
            string stdID = dgStd.CurrentRow.Cells["StdId"].Value.ToString();
            Student student = studentService.getStudentByStdID(stdID);
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
            //获取学号
            string stdid = dgStd.CurrentRow.Cells["StdId"].Value.ToString();
            Student student = studentService.getStudentByStdID(stdid);
            DialogResult result=MessageBox.Show("确定要删除学号为["+ stdid+"]学员的信息吗？","删除确认",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try 
                {
                    if (studentService.deleteStdInfoByID(student) == 1)
                    {
                        //MessageBox.Show("删除学号为[" + stdid + "]学员的信息成功", "提示信息");
                        btnSearchByClass_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("删除学号为[" + stdid + "]学员的信息失败", "提示信息");
                    }
                }
                catch { }
            }
        }
    }
    #region 实现排序
    class NameDESC : IComparer<Student>
    {
        public int Compare(Student std1, Student std2)
        {
            return std2.StdName.CompareTo(std1.StdName);
        }
    }

    class StdIDDESC : IComparer<Student>
    {
        public int Compare(Student std1, Student std2)
        {
            return std2.StdId.CompareTo(std1.StdId);
        }
    }
    #endregion
}
