namespace AMS.ahutit
{
    partial class FrmStudentModifyPSW
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
            grpBox = new GroupBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtConfirmPSW = new TextBox();
            txtNewPSW = new TextBox();
            txtOldPSW = new TextBox();
            lblConfirm = new Label();
            lblNew = new Label();
            lblOld = new Label();
            lblTitle = new Label();
            grpBox.SuspendLayout();
            SuspendLayout();
            // 
            // grpBox
            // 
            grpBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpBox.Controls.Add(btnCancel);
            grpBox.Controls.Add(btnSave);
            grpBox.Controls.Add(txtConfirmPSW);
            grpBox.Controls.Add(txtNewPSW);
            grpBox.Controls.Add(txtOldPSW);
            grpBox.Controls.Add(lblConfirm);
            grpBox.Controls.Add(lblNew);
            grpBox.Controls.Add(lblOld);
            grpBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 134);
            grpBox.Location = new Point(40, 90);
            grpBox.Name = "grpBox";
            grpBox.Size = new Size(620, 310);
            grpBox.TabIndex = 0;
            grpBox.TabStop = false;
            grpBox.Text = "修改密码";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(340, 240);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 40);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "清空";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(170, 240);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "确认修改";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtConfirmPSW
            // 
            txtConfirmPSW.Location = new Point(170, 180);
            txtConfirmPSW.Name = "txtConfirmPSW";
            txtConfirmPSW.Size = new Size(360, 33);
            txtConfirmPSW.TabIndex = 5;
            txtConfirmPSW.UseSystemPasswordChar = true;
            // 
            // txtNewPSW
            // 
            txtNewPSW.Location = new Point(170, 120);
            txtNewPSW.Name = "txtNewPSW";
            txtNewPSW.Size = new Size(360, 33);
            txtNewPSW.TabIndex = 4;
            txtNewPSW.UseSystemPasswordChar = true;
            // 
            // txtOldPSW
            // 
            txtOldPSW.Location = new Point(170, 60);
            txtOldPSW.Name = "txtOldPSW";
            txtOldPSW.Size = new Size(360, 33);
            txtOldPSW.TabIndex = 3;
            txtOldPSW.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(40, 183);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(92, 27);
            lblConfirm.TabIndex = 2;
            lblConfirm.Text = "确认密码";
            // 
            // lblNew
            // 
            lblNew.AutoSize = true;
            lblNew.Location = new Point(40, 123);
            lblNew.Name = "lblNew";
            lblNew.Size = new Size(92, 27);
            lblNew.TabIndex = 1;
            lblNew.Text = "新密码";
            // 
            // lblOld
            // 
            lblOld.AutoSize = true;
            lblOld.Location = new Point(40, 63);
            lblOld.Name = "lblOld";
            lblOld.Size = new Size(92, 27);
            lblOld.TabIndex = 0;
            lblOld.Text = "原密码";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblTitle.Location = new Point(40, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(158, 31);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "学员密码修改";
            // 
            // FrmStudentModifyPSW
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 450);
            Controls.Add(lblTitle);
            Controls.Add(grpBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmStudentModifyPSW";
            Text = "FrmStudentModifyPSW";
            grpBox.ResumeLayout(false);
            grpBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpBox;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtConfirmPSW;
        private TextBox txtNewPSW;
        private TextBox txtOldPSW;
        private Label lblConfirm;
        private Label lblNew;
        private Label lblOld;
        private Label lblTitle;
    }
}
