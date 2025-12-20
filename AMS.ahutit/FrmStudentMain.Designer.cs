namespace AMS.ahutit
{
    partial class FrmStudentMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            btnLogout = new Button();
            btnChangePwd = new Button();
            btnScore = new Button();
            btnViewProfile = new Button();
            btnSignIn = new Button();
            panelContent = new Panel();
            lblWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnLogout);
            splitContainer1.Panel1.Controls.Add(btnChangePwd);
            splitContainer1.Panel1.Controls.Add(btnScore);
            splitContainer1.Panel1.Controls.Add(btnViewProfile);
            splitContainer1.Panel1.Controls.Add(btnSignIn);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelContent);
            splitContainer1.Panel2.Controls.Add(lblWelcome);
            splitContainer1.Size = new Size(980, 640);
            splitContainer1.SplitterDistance = 220;
            splitContainer1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnLogout.Location = new Point(30, 360);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(160, 45);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "退出登录";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnChangePwd
            // 
            btnChangePwd.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnChangePwd.Location = new Point(30, 290);
            btnChangePwd.Name = "btnChangePwd";
            btnChangePwd.Size = new Size(160, 45);
            btnChangePwd.TabIndex = 3;
            btnChangePwd.Text = "修改密码";
            btnChangePwd.UseVisualStyleBackColor = true;
            btnChangePwd.Click += btnChangePwd_Click;
            // 
            // btnScore
            // 
            btnScore.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnScore.Location = new Point(30, 220);
            btnScore.Name = "btnScore";
            btnScore.Size = new Size(160, 45);
            btnScore.TabIndex = 2;
            btnScore.Text = "查看考勤";
            btnScore.UseVisualStyleBackColor = true;
            btnScore.Click += btnScore_Click;
            // 
            // btnViewProfile
            // 
            btnViewProfile.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnViewProfile.Location = new Point(30, 150);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.Size = new Size(160, 45);
            btnViewProfile.TabIndex = 1;
            btnViewProfile.Text = "查看个人信息";
            btnViewProfile.UseVisualStyleBackColor = true;
            btnViewProfile.Click += btnViewProfile_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSignIn.Location = new Point(30, 80);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(160, 45);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "考勤签到";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContent.Location = new Point(20, 80);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(700, 520);
            panelContent.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblWelcome.Location = new Point(20, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(158, 31);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "欢迎，学员";
            // 
            // FrmStudentMain
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 640);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimumSize = new Size(900, 600);
            Name = "FrmStudentMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "学员端";
            Load += FrmStudentMain_Load;
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnLogout;
        private Button btnChangePwd;
        private Button btnScore;
        private Button btnViewProfile;
        private Button btnSignIn;
        private Panel panelContent;
        private Label lblWelcome;
    }
}
