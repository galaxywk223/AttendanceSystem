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
            // FrmStudentMain
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 170);
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
    }
}
