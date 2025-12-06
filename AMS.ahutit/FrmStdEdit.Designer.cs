namespace AMS.ahutit
{
    partial class FrmStdEdit
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
            btnClose = new Button();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtIDNo = new TextBox();
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
            groupBox1 = new GroupBox();
            dtpBirthday = new DateTimePicker();
            cmbClass = new ComboBox();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            txtStdID = new TextBox();
            label9 = new Label();
            picStdImage = new PictureBox();
            btnChangeImage = new Button();
            btnConfirm = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStdImage).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(980, 523);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(149, 64);
            btnClose.TabIndex = 7;
            btnClose.Text = "关闭";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(129, 407);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(617, 30);
            txtAddress.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(463, 319);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(283, 30);
            txtPhone.TabIndex = 1;
            // 
            // txtIDNo
            // 
            txtIDNo.Location = new Point(492, 231);
            txtIDNo.Name = "txtIDNo";
            txtIDNo.Size = new Size(254, 30);
            txtIDNo.TabIndex = 1;
            txtIDNo.TextChanged += txtIDNo_TextChanged;
            // 
            // txtAttNo
            // 
            txtAttNo.Location = new Point(129, 319);
            txtAttNo.Name = "txtAttNo";
            txtAttNo.Size = new Size(212, 30);
            txtAttNo.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(91, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 30);
            txtName.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 410);
            label8.Name = "label8";
            label8.Size = new Size(100, 24);
            label8.TabIndex = 0;
            label8.Text = "家庭住址：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 234);
            label3.Name = "label3";
            label3.Size = new Size(100, 24);
            label3.TabIndex = 0;
            label3.Text = "出生日期：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(374, 322);
            label7.Name = "label7";
            label7.Size = new Size(100, 24);
            label7.TabIndex = 0;
            label7.Text = "联系电话：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 146);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 0;
            label2.Text = "性别：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 234);
            label5.Name = "label5";
            label5.Size = new Size(118, 24);
            label5.TabIndex = 0;
            label5.Text = "身份证号码：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 322);
            label6.Name = "label6";
            label6.Size = new Size(100, 24);
            label6.TabIndex = 0;
            label6.Text = "考勤卡号：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 146);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 0;
            label4.Text = "班级：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 61);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 0;
            label1.Text = "姓名：";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpBirthday);
            groupBox1.Controls.Add(cmbClass);
            groupBox1.Controls.Add(rdbFemale);
            groupBox1.Controls.Add(rdbMale);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtIDNo);
            groupBox1.Controls.Add(txtAttNo);
            groupBox1.Controls.Add(txtStdID);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(420, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(752, 482);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "学员基本信息";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Format = DateTimePickerFormat.Short;
            dtpBirthday.Location = new Point(129, 231);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(212, 30);
            dtpBirthday.TabIndex = 10;
            // 
            // cmbClass
            // 
            cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(91, 142);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(250, 32);
            cmbClass.TabIndex = 9;
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(606, 142);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(53, 28);
            rdbFemale.TabIndex = 7;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "女";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(492, 142);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(53, 28);
            rdbMale.TabIndex = 8;
            rdbMale.TabStop = true;
            rdbMale.Text = "男";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // txtStdID
            // 
            txtStdID.Enabled = false;
            txtStdID.Location = new Point(484, 58);
            txtStdID.Name = "txtStdID";
            txtStdID.Size = new Size(252, 30);
            txtStdID.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(374, 61);
            label9.Name = "label9";
            label9.Size = new Size(64, 24);
            label9.TabIndex = 0;
            label9.Text = "学号：";
            // 
            // picStdImage
            // 
            picStdImage.Location = new Point(21, 24);
            picStdImage.Name = "picStdImage";
            picStdImage.Size = new Size(364, 470);
            picStdImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picStdImage.TabIndex = 5;
            picStdImage.TabStop = false;
            // 
            // btnChangeImage
            // 
            btnChangeImage.Location = new Point(110, 523);
            btnChangeImage.Name = "btnChangeImage";
            btnChangeImage.Size = new Size(199, 64);
            btnChangeImage.TabIndex = 8;
            btnChangeImage.Text = "更换图片";
            btnChangeImage.UseVisualStyleBackColor = true;
            btnChangeImage.Click += btnChangeImage_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(562, 523);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(199, 64);
            btnConfirm.TabIndex = 9;
            btnConfirm.Text = "确认修改";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // FrmStdEdit
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 638);
            Controls.Add(btnConfirm);
            Controls.Add(btnChangeImage);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Controls.Add(picStdImage);
            Name = "FrmStdEdit";
            Text = "FrmStdEdit";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStdImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtIDNo;
        private TextBox txtAttNo;
        private TextBox txtName;
        private Label label8;
        private Label label3;
        private Label label7;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtStdID;
        private Label label9;
        private PictureBox picStdImage;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private ComboBox cmbClass;
        private DateTimePicker dtpBirthday;
        private Button btnChangeImage;
        private Button btnConfirm;
    }
}
