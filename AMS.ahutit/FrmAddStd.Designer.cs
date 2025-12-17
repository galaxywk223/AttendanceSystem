namespace AMS.ahutit
{
    partial class FrmAddStd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pcbCamera = new PictureBox();
            pcbView = new PictureBox();
            btnTurnOn = new Button();
            btnGetPic = new Button();
            btnClear = new Button();
            btnFromLocal = new Button();
            groupBox1 = new GroupBox();
            cmbClass = new ComboBox();
            dtpBirthday = new DateTimePicker();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtID = new TextBox();
            txtAttNo = new TextBox();
            txtName = new TextBox();
            label8 = new Label();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            btnConfirm = new Button();
            btnClose = new Button();
            btnTurnOff = new Button();
            imageBox1 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)pcbCamera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbView).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageBox1).BeginInit();
            SuspendLayout();
            // 
            // pcbCamera
            // 
            pcbCamera.BorderStyle = BorderStyle.FixedSingle;
            pcbCamera.Location = new Point(44, 46);
            pcbCamera.Name = "pcbCamera";
            pcbCamera.Size = new Size(422, 437);
            pcbCamera.TabIndex = 0;
            pcbCamera.TabStop = false;
            // 
            // pcbView
            // 
            pcbView.BorderStyle = BorderStyle.FixedSingle;
            pcbView.Location = new Point(931, 46);
            pcbView.Name = "pcbView";
            pcbView.Size = new Size(422, 437);
            pcbView.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbView.TabIndex = 0;
            pcbView.TabStop = false;
            // 
            // btnTurnOn
            // 
            btnTurnOn.Location = new Point(599, 59);
            btnTurnOn.Name = "btnTurnOn";
            btnTurnOn.Size = new Size(199, 64);
            btnTurnOn.TabIndex = 1;
            btnTurnOn.Text = "启动摄像头";
            btnTurnOn.UseVisualStyleBackColor = true;
            btnTurnOn.Click += btnTurnOn_Click;
            // 
            // btnGetPic
            // 
            btnGetPic.Location = new Point(599, 239);
            btnGetPic.Name = "btnGetPic";
            btnGetPic.Size = new Size(199, 64);
            btnGetPic.TabIndex = 1;
            btnGetPic.Text = "开始拍照";
            btnGetPic.UseVisualStyleBackColor = true;
            btnGetPic.Click += btnGetPic_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(599, 329);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(199, 64);
            btnClear.TabIndex = 1;
            btnClear.Text = "清除照片";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnFromLocal
            // 
            btnFromLocal.Location = new Point(599, 419);
            btnFromLocal.Name = "btnFromLocal";
            btnFromLocal.Size = new Size(199, 64);
            btnFromLocal.TabIndex = 1;
            btnFromLocal.Text = "直接选择图片";
            btnFromLocal.UseVisualStyleBackColor = true;
            btnFromLocal.Click += btnFromLocal_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbClass);
            groupBox1.Controls.Add(dtpBirthday);
            groupBox1.Controls.Add(rdbFemale);
            groupBox1.Controls.Add(rdbMale);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(txtAttNo);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(44, 506);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1310, 332);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "学员基本信息";
            // 
            // cmbClass
            // 
            // 
            cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(91, 109);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(220, 32);
            cmbClass.TabIndex = 4;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Format = DateTimePickerFormat.Short;
            dtpBirthday.Location = new Point(923, 36);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(300, 30);
            dtpBirthday.TabIndex = 3;
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(606, 37);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(53, 28);
            rdbFemale.TabIndex = 2;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "女";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(509, 37);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(53, 28);
            rdbMale.TabIndex = 2;
            rdbMale.TabStop = true;
            rdbMale.Text = "男";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(157, 261);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(1066, 30);
            txtAddress.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(551, 187);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(672, 30);
            txtPhone.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(551, 110);
            txtID.Name = "txtID";
            txtID.Size = new Size(672, 30);
            txtID.TabIndex = 1;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtAttNo
            // 
            txtAttNo.Location = new Point(139, 187);
            txtAttNo.Name = "txtAttNo";
            txtAttNo.Size = new Size(184, 30);
            txtAttNo.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(91, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 30);
            txtName.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 261);
            label8.Name = "label8";
            label8.Size = new Size(100, 24);
            label8.TabIndex = 0;
            label8.Text = "家庭住址：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(790, 39);
            label3.Name = "label3";
            label3.Size = new Size(100, 24);
            label3.TabIndex = 0;
            label3.Text = "出生日期：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(416, 187);
            label7.Name = "label7";
            label7.Size = new Size(100, 24);
            label7.TabIndex = 0;
            label7.Text = "联系电话：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 39);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 0;
            label2.Text = "性别：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 113);
            label5.Name = "label5";
            label5.Size = new Size(118, 24);
            label5.TabIndex = 0;
            label5.Text = "身份证号码：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 187);
            label6.Name = "label6";
            label6.Size = new Size(100, 24);
            label6.TabIndex = 0;
            label6.Text = "考勤卡号：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 113);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 0;
            label4.Text = "班级：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 39);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 0;
            label1.Text = "姓名：";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(298, 870);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(199, 64);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "确认添加";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(785, 870);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(199, 64);
            btnClose.TabIndex = 1;
            btnClose.Text = "关闭";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnTurnOff
            // 
            btnTurnOff.Location = new Point(599, 149);
            btnTurnOff.Name = "btnTurnOff";
            btnTurnOff.Size = new Size(199, 64);
            btnTurnOff.TabIndex = 1;
            btnTurnOff.Text = "关闭摄像头";
            btnTurnOff.UseVisualStyleBackColor = true;
            btnTurnOff.Click += btnTurnOff_Click;
            // 
            // imageBox1
            // 
            imageBox1.BorderStyle = BorderStyle.FixedSingle;
            imageBox1.Location = new Point(44, 46);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(422, 437);
            imageBox1.TabIndex = 2;
            imageBox1.TabStop = false;
            // 
            // FrmAddStd
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 970);
            Controls.Add(imageBox1);
            Controls.Add(groupBox1);
            Controls.Add(btnFromLocal);
            Controls.Add(btnClear);
            Controls.Add(btnGetPic);
            Controls.Add(btnClose);
            Controls.Add(btnConfirm);
            Controls.Add(btnTurnOff);
            Controls.Add(btnTurnOn);
            Controls.Add(pcbView);
            Controls.Add(pcbCamera);
            Name = "FrmAddStd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAddStd";
            Load += FrmAddStd_Load;
            ((System.ComponentModel.ISupportInitialize)pcbCamera).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcbCamera;
        private PictureBox pcbView;
        private Button btnTurnOn;
        private Button btnGetPic;
        private Button btnClear;
        private Button btnFromLocal;
        private GroupBox groupBox1;
        private ComboBox cmbClass;
        private DateTimePicker dtpBirthday;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private TextBox txtID;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtAttNo;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnConfirm;
        private Button btnClose;
        private Button btnTurnOff;
        private Emgu.CV.UI.ImageBox imageBox1;
    }
}
