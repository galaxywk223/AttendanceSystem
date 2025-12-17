namespace AMS.ahutit
{
    partial class FrmStudentMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnViewProfile = new Button();
            btnLogout = new Button();
            btnLogout = new Button();
            btnScore = new Button();
            btnSignIn = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblWelcome.Location = new Point(30, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(165, 31);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "欢迎，学员";
            // 
            // btnViewProfile
            // 
            btnViewProfile.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnViewProfile.Location = new Point(35, 90);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.Size = new Size(220, 48);
            btnViewProfile.TabIndex = 1;
            btnViewProfile.Text = "查看个人信息";
            btnViewProfile.UseVisualStyleBackColor = true;
            btnViewProfile.Click += btnViewProfile_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnLogout.Location = new Point(275, 90);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(140, 48);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "退出登录";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnScore
            // 
            btnScore.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnScore.Location = new Point(485, 90);
            btnScore.Name = "btnScore";
            btnScore.Size = new Size(180, 48);
            btnScore.TabIndex = 3;
            btnScore.Text = "查看我的成绩";
            btnScore.UseVisualStyleBackColor = true;
            btnScore.Click += btnScore_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSignIn.Location = new Point(35, 30); // Top left near welcome? Or below? Let's put it prominent.
            btnSignIn.Location = new Point(485, 30); // Top right?
            // Existing buttons are at Y=90.
            // Let's put it at Y=90, X=...
            // btnViewProfile X=35 W=220 (Ends 255)
            // btnLogout X=275 W=140 (Ends 415)
            // btnScore X=485 W=180 (Ends 665)
            // Need checks.
            // Let's resize form to wider if needed or put it on a new row.
            // Form is 700x170.
            // Let's put Sign In prominent on top or replace one? No, keep all.
            // Let's put Sign In at X=485, Y=30 (Next to Welcome?)
            btnSignIn.Location = new Point(485, 23); // Aligned with Welcome roughly? Welcome is 30,30.
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(180, 48);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "考勤签到";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;

            // 
            // FrmStudentMain
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 170);
            Controls.Add(btnSignIn);
            Controls.Add(btnScore);
            Controls.Add(btnLogout);
            Controls.Add(btnViewProfile);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmStudentMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "学员端";
            Load += FrmStudentMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnViewProfile;
        private Button btnLogout;
        private Button btnScore;
        private Button btnSignIn;
    }
}
