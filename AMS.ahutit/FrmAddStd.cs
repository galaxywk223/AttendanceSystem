using DAL;
using DAL.ahutit;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;
using Models;
using Models.ahutit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace AMS.ahutit
{
    public partial class FrmAddStd : Form
    {
        private VideoCapture? _capture;
        private bool _isRunning = false;
        private readonly object _captureLock = new object();

        //创建数据访问对象
        private StudentClassService stdClassService = new StudentClassService();
        private StudentService studentService = new StudentService();
        List<Student> stdList = new List<Student>();

        //图片路径
        string ImageName = "";
        string ImagePath = "";

        //是否是摄像头取照片
        private bool _isFromCamera=false;

        public FrmAddStd()
        {
            InitializeComponent();
            imageBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //初始化班级下拉框
            cmbClass.DataSource = stdClassService.GetAllClass();
            cmbClass.DisplayMember = "ClassName";
            cmbClass.ValueMember = "Id";
            cmbClass.SelectedIndex = -1;

        }

        private void FrmAddStd_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DisposeCapture();
            this.Close();
        }

        private void btnFromLocal_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                pcbView.Image = Image.FromFile(ofd.FileName);
                ImagePath = ofd.FileName;
                ImageName = ofd.SafeFileName;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pcbView.Image = null;
            _isFromCamera = false;
            DisposeCapture();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            #region 数据验证
            //非空验证
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("学生姓名不能为空！", "提示信息");
                txtName.Focus();
                return;
            }
            if (txtAttNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("学生考勤卡号不能为空！", "提示信息");
                txtAttNo.Focus();
                return;
            }

            if (!rdbMale.Checked && !rdbFemale.Checked)
            {
                MessageBox.Show("请选择学生性别！", "提示信息");
                return;
            }
            if (cmbClass.SelectedIndex == -1)
            {
                MessageBox.Show("请选择班级！", "提示信息");
                cmbClass.Focus();
                return;
            }
            int age = DateTime.Now.Year - Convert.ToDateTime(dtpBirthday.Text).Year;
            if (age > 40 || age < 16)
            {
                MessageBox.Show("出生日期选择有误！", "提示信息");
                return;
            }

            //身份证号码格式验证
            if (!Common.DataValidate.IsIDCardNo(txtID.Text.Trim()))
            {
                MessageBox.Show("身份证号码不符合要求！", "提示信息");
                txtID.SelectAll();
                txtID.Focus();
                return;
            }
            //验证身份证中的身份日期与用户选择的出生日期是否一致
            string birthday = Convert.ToDateTime(dtpBirthday.Text).ToString("yyyyMMdd");
            if (!txtID.Text.Trim().Contains(birthday))
            {
                MessageBox.Show("身份证中的身份日期与用户选择的出生日期不匹配！", "提示信息");
                txtID.SelectAll();
                txtID.Focus();
                return;
            }
            //判断身份证号码和考勤卡号是否存在
            if (studentService.isIdNoExisted(txtID.Text.Trim()))
            {
                MessageBox.Show("身份证号码已存在！", "提示信息");
                txtID.SelectAll();
                txtID.Focus();
                return;
            }
            if (studentService.isCardNoExisted(txtAttNo.Text.Trim()))
            {
                MessageBox.Show("考勤卡号已存在！", "提示信息");
                txtAttNo.SelectAll();
                txtAttNo.Focus();
                return;
            }

            #endregion

            #region 封装对象
            Student newStudent = new Student()
            {
                StdName = txtName.Text.Trim(),
                Gender = rdbMale.Checked ? "男" : "女",
                Birthday = Convert.ToDateTime(dtpBirthday.Text),
                idNo = txtID.Text.Trim(),
                PhoneNumber = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Classid = Convert.ToInt32(cmbClass.SelectedValue),
                Age = DateTime.Now.Year - Convert.ToDateTime(dtpBirthday.Text).Year,
                CardNo = txtAttNo.Text.Trim(),
                StdImage = ""
            };
            try
            {
                if (!_isFromCamera)
                {
                    //复制图片文件到相对目录
                    if (pcbView.Image != null)
                    {
                        string[] newImageFileInfo = BuildImageName();
                        File.Copy(ImagePath, newImageFileInfo[1]);
                        newStudent.StdImage = newImageFileInfo[0];
                    }
                }
                else 
                {
                    string NewImageName = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString() + ".png" ;                    
                    string fileNameDes = AppDomain.CurrentDomain.BaseDirectory + "/image/" + NewImageName;
                    newStudent.StdImage = NewImageName;
                    try { pcbView.Image.Save(fileNameDes); }
                    catch (Exception)
                    {
                        MessageBox.Show("文件保存出错！", "错误");
                    }
                    
                    
                }
                    int stdid = studentService.addNewStd(newStudent);
                if (stdid > 0)
                {
                    newStudent.StdId = stdid;
                    stdList.Add(newStudent);
                    DialogResult result = MessageBox.Show("添加[" + txtName.Text.Trim() + "]学员成功，是否继续添加？", "添加成功", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //输入控件清空

                        txtName.Text = "";
                        txtAddress.Text = "";
                        txtAttNo.Text = "";
                        txtID.Text = "";
                        txtPhone.Text = "";
                        cmbClass.SelectedIndex = -1;
                        pcbView.Image = null;
                        dtpBirthday.Text = DateTime.Today.ToString();
                        rdbFemale.Checked = false;
                        rdbMale.Checked = false;
                    }
                    else
                    {
                        //MessageBox.Show("添加[" + txtName.Text.Trim() + "]学员成功", "添加成功");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("添加[" + txtName.Text.Trim() + "]学员失败！", "添加失败");
                }
            }
            catch (Exception)
            {
                throw;
            }
            //

            #endregion
        }

        private string[] BuildImageName()
        {
            string[] returnString = { "", "" };
            string[] OnlyImageName = ImageName.Split('.');
            string NewImageName = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString() + "." + OnlyImageName[OnlyImageName.Length - 1];
            returnString[0] = NewImageName;
            //long unixTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            string fileNameDes = AppDomain.CurrentDomain.BaseDirectory + "/image/" + NewImageName;
            returnString[1] = fileNameDes;
            //File.Copy(ImagePath, fileNameDes);
            return returnString;
        }

        private void ProcessFrame(object? sender, EventArgs e)
        {
            try
            {
                if (!_isRunning)
                {
                    return;
                }

                Mat displayFrame;
                using (Mat frame = new Mat())
                {
                    lock (_captureLock)
                    {
                        if (_capture == null || _capture.Ptr == IntPtr.Zero)
                        {
                            return;
                        }
                        _capture.Retrieve(frame);
                    }
                    displayFrame = frame.Clone();
                }

                // 跨线程更新UI
                this.BeginInvoke((MethodInvoker)delegate
                {
                    imageBox1.Image?.Dispose();
                    imageBox1.Image = displayFrame;
                });
            }
            catch (AccessViolationException)
            {
                // Camera stream may have been torn down; clean up to avoid crashing
                DisposeCapture();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"处理错误: {ex.Message}");
            }
        }

        private void btnTurnOn_Click(object sender, EventArgs e)
        {
            lock (_captureLock)
            {
                if (_capture == null || _capture.Ptr == IntPtr.Zero)
                {
                    _capture = new VideoCapture(0); // 0表示默认摄像头
                    _capture.ImageGrabbed += ProcessFrame;
                }

                if (!_isRunning)
                {
                    _capture.Start();
                    _isRunning = true;
                }
                else
                {
                    _capture.Stop();
                    _isRunning = false;
                }
            }
        }

        private void btnGetPic_Click(object sender, EventArgs e)
        {
            lock (_captureLock)
            {
                if (_capture != null && _isRunning == true && _capture.Ptr != IntPtr.Zero)
                {
                    //摄像头取照
                    _isFromCamera = true;
                    using Mat mat = _capture.QueryFrame();
                    // 将Emgu CV的Image<Bgr, byte>转换为Bitmap并显示在PictureBox中
                    Bitmap bitmap = mat.ToBitmap();
                    pcbView.Image = bitmap; // 这里假设你的PictureBox的名字是pictureBoxDisplay                
                }
            }
            return;
        }

        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            DisposeCapture();
            return;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            DateTime? birth = TryParseBirthdayFromId(txtID.Text.Trim());
            if (birth.HasValue)
            {
                dtpBirthday.Value = birth.Value;
            }
        }

        private static DateTime? TryParseBirthdayFromId(string idNo)
        {
            if (idNo.Length >= 14)
            {
                string birthStr = idNo.Substring(6, 8);
                if (DateTime.TryParseExact(birthStr, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birth))
                {
                    return birth;
                }
            }
            return null;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DisposeCapture();
            base.OnFormClosing(e);
        }

        private void DisposeCapture()
        {
            lock (_captureLock)
            {
                if (_capture != null)
                {
                    try
                    {
                        _capture.ImageGrabbed -= ProcessFrame;
                        if (_isRunning)
                        {
                            _capture.Stop();
                        }
                        _capture.Dispose();
                    }
                    finally
                    {
                        _capture = null;
                        _isRunning = false;
                    }
                }
            }
        }
    }
}
