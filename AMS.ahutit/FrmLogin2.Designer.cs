namespace AMS.ahutit
{
    partial class FrmLogin2
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
            txtUserName = new TextBox();
            btnOK = new Button();
            txtPSW = new TextBox();
            label2 = new Label();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 417);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(502, 66);
            label1.Name = "label1";
            label1.Size = new Size(104, 24);
            label1.TabIndex = 1;
            label1.Text = "UserName:";
            label1.Click += label1_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(633, 60);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(296, 30);
            txtUserName.TabIndex = 2;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(539, 261);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(112, 34);
            btnOK.TabIndex = 3;
            btnOK.Text = "Login";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // txtPSW
            // 
            txtPSW.Location = new Point(633, 111);
            txtPSW.Name = "txtPSW";
            txtPSW.Size = new Size(296, 30);
            txtPSW.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(502, 117);
            label2.Name = "label2";
            label2.Size = new Size(99, 24);
            label2.TabIndex = 4;
            label2.Text = "PassWord:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(742, 261);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmLogin2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 450);
            Controls.Add(btnCancel);
            Controls.Add(txtPSW);
            Controls.Add(label2);
            Controls.Add(btnOK);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FrmLogin2";
            Text = "FrmLogin2";
            Load += FrmLogin2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtUserName;
        private Button btnOK;
        private TextBox txtPSW;
        private Label label2;
        private Button btnCancel;
    }
}