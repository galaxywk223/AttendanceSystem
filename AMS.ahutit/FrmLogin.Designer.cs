namespace AMS.ahutit
{
    partial class FrmLogin
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tbxName = new TextBox();
            label2 = new Label();
            tbxPsw = new TextBox();
            btnLogin = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(28, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(428, 420);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(518, 105);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 1;
            label1.Text = "登录账号：";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(601, 102);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(346, 30);
            tbxName.TabIndex = 0;
            tbxName.Text = "1001";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(518, 197);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 1;
            label2.Text = "登录密码：";
            // 
            // tbxPsw
            // 
            tbxPsw.Location = new Point(601, 194);
            tbxPsw.Name = "tbxPsw";
            tbxPsw.Size = new Size(346, 30);
            tbxPsw.TabIndex = 1;
            tbxPsw.Text = "123456";
            tbxPsw.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(565, 339);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "登录";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(789, 339);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 3;
            btnClose.Text = "退出";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FrmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1026, 494);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(tbxPsw);
            Controls.Add(label2);
            Controls.Add(tbxName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "[学员考勤管理系统]-用户登录";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tbxName;
        private Label label2;
        private TextBox tbxPsw;
        private Button btnLogin;
        private Button btnClose;
    }
}