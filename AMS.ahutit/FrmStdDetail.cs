using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public FrmStdDetail(Student student) 
        {
            InitializeComponent();
            //thisStudent = student;
            this.txtID.Text = student.StdId.ToString();
            this.txtName.Text = student.StdName;
            this.txtAddress.Text = student.Address;
            txtID.Text = student.idNo;
            this.txtGender.Text = student.Gender;
            this.txtBirthday.Text = student.Birthday.ToString();
            this.txtPhone.Text = student.PhoneNumber;
            txtAttNo.Text = student.CardNo;
            txtClassName.Text = student.ClassName;
            //string fileNameDes = AppDomain.CurrentDomain.BaseDirectory + "/image/" + NewImageName;
            picStdImage.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/image/" + student.StdImage);


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
    }
}
