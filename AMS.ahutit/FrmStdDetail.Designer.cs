namespace AMS.ahutit
{
    partial class FrmStdDetail
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
            picStdImage = new PictureBox();
            groupBox1 = new GroupBox();
            txtClassName = new TextBox();
            txtBirthday = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtID = new TextBox();
            txtAttNo = new TextBox();
            txtGender = new TextBox();
            txtName = new TextBox();
            label8 = new Label();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)picStdImage).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // picStdImage
            // 
            picStdImage.Location = new Point(12, 24);
            picStdImage.Name = "picStdImage";
            picStdImage.Size = new Size(364, 470);
            picStdImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picStdImage.TabIndex = 0;
            picStdImage.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtClassName);
            groupBox1.Controls.Add(txtBirthday);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(txtAttNo);
            groupBox1.Controls.Add(txtGender);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(411, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(752, 482);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "学员基本信息";
            // 
            // txtClassName
            // 
            txtClassName.Enabled = false;
            txtClassName.Location = new Point(91, 129);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(220, 30);
            txtClassName.TabIndex = 6;
            // 
            // txtBirthday
            // 
            txtBirthday.Location = new Point(492, 129);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new Size(220, 30);
            txtBirthday.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(157, 394);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(555, 30);
            txtAddress.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(469, 300);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(243, 30);
            txtPhone.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(157, 216);
            txtID.Name = "txtID";
            txtID.Size = new Size(555, 30);
            txtID.TabIndex = 1;
            // 
            // txtAttNo
            // 
            txtAttNo.Location = new Point(157, 300);
            txtAttNo.Name = "txtAttNo";
            txtAttNo.Size = new Size(184, 30);
            txtAttNo.TabIndex = 1;
            // 
            // txtGender
            // 
            txtGender.Enabled = false;
            txtGender.Location = new Point(492, 39);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(220, 30);
            txtGender.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(91, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 30);
            txtName.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 391);
            label8.Name = "label8";
            label8.Size = new Size(100, 24);
            label8.TabIndex = 0;
            label8.Text = "家庭住址：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 129);
            label3.Name = "label3";
            label3.Size = new Size(100, 24);
            label3.TabIndex = 0;
            label3.Text = "出生日期：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(363, 303);
            label7.Name = "label7";
            label7.Size = new Size(100, 24);
            label7.TabIndex = 0;
            label7.Text = "联系电话：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 39);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 0;
            label2.Text = "性别：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 215);
            label5.Name = "label5";
            label5.Size = new Size(118, 24);
            label5.TabIndex = 0;
            label5.Text = "身份证号码：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 303);
            label6.Name = "label6";
            label6.Size = new Size(100, 24);
            label6.TabIndex = 0;
            label6.Text = "考勤卡号：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 129);
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
            // btnClose
            // 
            btnClose.Location = new Point(663, 538);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 4;
            btnClose.Text = "关闭";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FrmStdDetail
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 601);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Controls.Add(picStdImage);
            MaximizeBox = false;
            Name = "FrmStdDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "学员详细信息";
            Load += FrmStdDetail_Load;
            ((System.ComponentModel.ISupportInitialize)picStdImage).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picStdImage;
        private GroupBox groupBox1;
        private TextBox txtBirthday;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtID;
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
        private TextBox txtClassName;
        private Button btnClose;
        private TextBox txtGender;
    }
}