using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Models;
using DAL;
using Models.ahutit;
using DAL.ahutit;

namespace AMS.ahutit
{
    public partial class FrmStdDetail : Form
    {

        //Student thisStudent = new Student();
        //public FrmStdDetail()
        //{
        //    InitializeComponent();
        //}
        private readonly Student _student;
        private readonly bool _allowEdit;
        private bool _isEditing = false;
        private bool _imageChanged = false;
        private string _newImagePath = string.Empty;

        public FrmStdDetail(Student student, bool allowEdit = false) 
        {
            InitializeComponent();
            _student = student;
            _allowEdit = allowEdit;
            //thisStudent = student;
            this.txtName.Text = student.StdName;
            this.txtAddress.Text = student.Address;
            txtID.Text = student.idNo;
            this.txtGender.Text = student.Gender;
            this.txtBirthday.Text = student.Birthday.ToString("yyyy-MM-dd");
            this.txtPhone.Text = student.PhoneNumber;
            txtAttNo.Text = student.CardNo;
            txtClassName.Text = student.ClassName;
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "image", student.StdImage ?? string.Empty);
            if (File.Exists(imagePath))
            {
                picStdImage.Image = Image.FromFile(imagePath);
            }
            else
            {
                picStdImage.Image = null;
            }

            ApplyReadOnlyState();
            btnEdit.Visible = _allowEdit;
            btnSave.Visible = _allowEdit;
            btnChangeImage.Visible = _allowEdit;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStdDetail_Load(object sender, EventArgs e)
        {
            //this.txtID.Text = thisStudent.StdId.ToString();
            //this.txtName.Text = thisStudent.StdName;
            //this.txtAddress.Text = thisStudent.Address;
            //this.txtAttNo.Text = thisStudent.CardNo;
            //this.txtGender.Text = thisStudent.Gender;
            //this.txtBirthday.Text = thisStudent.Birthday.ToString();
            //this.txtPhone.Text = thisStudent.PhoneNumber;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!_allowEdit) return;
            _isEditing = true;
            _imageChanged = false;
            _newImagePath = string.Empty;
            ApplyReadOnlyState();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_allowEdit) return;
            string newAddress = txtAddress.Text.Trim();
            string newPhone = txtPhone.Text.Trim();
            string imageName = _student.StdImage;
            try
            {
                if (_imageChanged && !string.IsNullOrEmpty(_newImagePath))
                {
                    string? ext = Path.GetExtension(_newImagePath);
                    if (string.IsNullOrEmpty(ext)) ext = ".png";
                    string newImageName = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString() + ext;
                    string imageDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "image");
                    if (!Directory.Exists(imageDir)) Directory.CreateDirectory(imageDir);
                    string destPath = Path.Combine(imageDir, newImageName);
                    File.Copy(_newImagePath, destPath, true);
                    imageName = newImageName;
                }

                int result = new StudentService().UpdateStudentProfileLimited(_student.StdId, newAddress, newPhone, imageName);
                if (result > 0)
                {
                    _student.Address = newAddress;
                    _student.PhoneNumber = newPhone;
                    _student.StdImage = imageName;
                    MessageBox.Show("信息更新成功", "提示");
                    _isEditing = false;
                    ApplyReadOnlyState();
                }
                else
                {
                    MessageBox.Show("信息更新失败", "错误");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新失败: " + ex.Message, "错误");
            }
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            if (!_allowEdit || !_isEditing) return;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                picStdImage.Image?.Dispose();
                _newImagePath = ofd.FileName;
                _imageChanged = true;
                picStdImage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void ApplyReadOnlyState()
        {
            txtName.ReadOnly = true;
            txtGender.ReadOnly = true;
            txtClassName.ReadOnly = true;
            txtBirthday.ReadOnly = true;
            txtID.ReadOnly = true;
            txtAttNo.ReadOnly = true;
            txtPhone.ReadOnly = !_isEditing;
            txtAddress.ReadOnly = !_isEditing;
            btnSave.Enabled = _isEditing;
            btnChangeImage.Enabled = _isEditing;
            btnEdit.Enabled = !_isEditing;
        }
    }
}
