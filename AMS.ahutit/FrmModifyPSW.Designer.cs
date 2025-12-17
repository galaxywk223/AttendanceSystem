namespace AMS.ahutit
{
    partial class FrmModifyPSW
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
            label1 = new Label();
            txtOldPSW = new TextBox();
            txtNewPSW = new TextBox();
            label2 = new Label();
            txtConfirmPSW = new TextBox();
            label3 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 83);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 0;
            label1.Text = "原密码：";
            // 
            // txtOldPSW
            // 
            txtOldPSW.Location = new Point(250, 77);
            txtOldPSW.Name = "txtOldPSW";
            txtOldPSW.Size = new Size(309, 30);
            txtOldPSW.TabIndex = 1;
            txtOldPSW.UseSystemPasswordChar = true;
            // 
            // txtNewPSW
            // 
            txtNewPSW.Location = new Point(250, 136);
            txtNewPSW.Name = "txtNewPSW";
            txtNewPSW.Size = new Size(309, 30);
            txtNewPSW.TabIndex = 3;
            txtNewPSW.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 142);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 2;
            label2.Text = "新密码：";
            // 
            // txtConfirmPSW
            // 
            txtConfirmPSW.Location = new Point(250, 197);
            txtConfirmPSW.Name = "txtConfirmPSW";
            txtConfirmPSW.Size = new Size(309, 30);
            txtConfirmPSW.TabIndex = 5;
            txtConfirmPSW.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 203);
            label3.Name = "label3";
            label3.Size = new Size(100, 24);
            label3.TabIndex = 4;
            label3.Text = "确认密码：";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(168, 318);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(112, 34);
            btnOK.TabIndex = 6;
            btnOK.Text = "确认";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(416, 318);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FrmModifyPSW
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 423);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtConfirmPSW);
            Controls.Add(label3);
            Controls.Add(txtNewPSW);
            Controls.Add(label2);
            Controls.Add(txtOldPSW);
            Controls.Add(label1);
            Name = "FrmModifyPSW";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "修改密码";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOldPSW;
        private TextBox txtNewPSW;
        private Label label2;
        private TextBox txtConfirmPSW;
        private Label label3;
        private Button btnOK;
        private Button btnCancel;
    }
}