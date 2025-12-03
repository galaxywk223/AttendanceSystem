using DAL.ahutit;
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
        public FrmScoreVIew()
        {
            InitializeComponent();
            cmbClass.DataSource = classService.GetAllClass();
            cmbClass.DisplayMember = "Name";
            cmbClass.ValueMember = "ClassName";
            cmbClass.SelectedIndex = -1;
            dgScore.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
