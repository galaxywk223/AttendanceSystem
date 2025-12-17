namespace AMS.ahutit
{
    partial class FrmStdManage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnSearchByNumDesc = new Button();
            btnSearchByNameDesc = new Button();
            btnSearchByClass = new Button();
            cmbClass = new ComboBox();
            label4 = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            groupBox2 = new GroupBox();
            txtCardNo = new TextBox();
            btnSearchByNum = new Button();
            label1 = new Label();
            btnPrint = new Button();
            dgStd = new DataGridView();
            CardNo = new DataGridViewTextBoxColumn();
            StdName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Birthday = new DataGridViewTextBoxColumn();
            idNo = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            btnClose = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgStd).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearchByNumDesc);
            groupBox1.Controls.Add(btnSearchByNameDesc);
            groupBox1.Controls.Add(btnSearchByClass);
            groupBox1.Controls.Add(cmbClass);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(49, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1029, 92);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "[按照班级查询]";
            // 
            // btnSearchByNumDesc
            // 
            btnSearchByNumDesc.Location = new Point(820, 50);
            btnSearchByNumDesc.Name = "btnSearchByNumDesc";
            btnSearchByNumDesc.Size = new Size(112, 34);
            btnSearchByNumDesc.TabIndex = 7;
            btnSearchByNumDesc.Text = "卡号降序";
            btnSearchByNumDesc.UseVisualStyleBackColor = true;
            btnSearchByNumDesc.Click += btnSearchByNumDesc_Click;
            // 
            // btnSearchByNameDesc
            // 
            btnSearchByNameDesc.Location = new Point(592, 50);
            btnSearchByNameDesc.Name = "btnSearchByNameDesc";
            btnSearchByNameDesc.Size = new Size(112, 34);
            btnSearchByNameDesc.TabIndex = 7;
            btnSearchByNameDesc.Text = "姓名降序";
            btnSearchByNameDesc.UseVisualStyleBackColor = true;
            btnSearchByNameDesc.Click += btnSearchByNameDesc_Click;
            // 
            // btnSearchByClass
            // 
            btnSearchByClass.Location = new Point(388, 50);
            btnSearchByClass.Name = "btnSearchByClass";
            btnSearchByClass.Size = new Size(112, 34);
            btnSearchByClass.TabIndex = 7;
            btnSearchByClass.Text = "查询";
            btnSearchByClass.UseVisualStyleBackColor = true;
            btnSearchByClass.Click += btnSearchByClass_Click;
            // 
            // cmbClass
            // 
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(93, 48);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(220, 32);
            cmbClass.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 52);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 5;
            label4.Text = "班级：";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1110, 91);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "修改";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1247, 91);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "删除";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCardNo);
            groupBox2.Controls.Add(btnSearchByNum);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(49, 110);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1029, 88);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "[按照考勤卡号查询]";
            // 
            // txtCardNo
            // 
            txtCardNo.Location = new Point(93, 46);
            txtCardNo.Name = "txtCardNo";
            txtCardNo.Size = new Size(220, 30);
            txtCardNo.TabIndex = 8;
            // 
            // btnSearchByNum
            // 
            btnSearchByNum.Location = new Point(388, 42);
            btnSearchByNum.Name = "btnSearchByNum";
            btnSearchByNum.Size = new Size(112, 34);
            btnSearchByNum.TabIndex = 7;
            btnSearchByNum.Text = "查询";
            btnSearchByNum.UseVisualStyleBackColor = true;
            btnSearchByNum.Click += btnSearchByNum_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 52);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 5;
            label1.Text = "卡号：";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(1110, 164);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(249, 34);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "打印";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // dgStd
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgStd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgStd.ColumnHeadersHeight = 50;
            dgStd.Columns.AddRange(new DataGridViewColumn[] { CardNo, StdName, Gender, PhoneNumber, Birthday, idNo, ClassName });
            dgStd.Location = new Point(49, 204);
            dgStd.Name = "dgStd";
            dgStd.RowHeadersWidth = 62;
            dgStd.Size = new Size(1310, 585);
            dgStd.TabIndex = 8;
            dgStd.CellDoubleClick += dgStd_CellDoubleClick;
            // 
            // CardNo
            // 
            CardNo.DataPropertyName = "CardNo";
            CardNo.HeaderText = "考勤卡号";
            CardNo.MinimumWidth = 8;
            CardNo.Name = "CardNo";
            CardNo.ReadOnly = true;
            CardNo.Width = 150;
            // 
            // StdName
            // 
            StdName.DataPropertyName = "StdName";
            StdName.HeaderText = "姓名";
            StdName.MinimumWidth = 8;
            StdName.Name = "StdName";
            StdName.ReadOnly = true;
            StdName.Width = 150;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "性别";
            Gender.MinimumWidth = 8;
            Gender.Name = "Gender";
            Gender.Width = 150;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "电话";
            PhoneNumber.MinimumWidth = 8;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Width = 200;
            // 
            // Birthday
            // 
            Birthday.DataPropertyName = "Birthday";
            Birthday.HeaderText = "生日";
            Birthday.MinimumWidth = 8;
            Birthday.Name = "Birthday";
            Birthday.Width = 150;
            // 
            // idNo
            // 
            idNo.DataPropertyName = "idNo";
            idNo.HeaderText = "身份证号码";
            idNo.MinimumWidth = 8;
            idNo.Name = "idNo";
            idNo.Width = 250;
            // 
            // ClassName
            // 
            ClassName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ClassName.DataPropertyName = "ClassName";
            ClassName.HeaderText = "所在班级";
            ClassName.MinimumWidth = 8;
            ClassName.Name = "ClassName";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1110, 24);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(249, 34);
            btnClose.TabIndex = 7;
            btnClose.Text = "关闭";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FrmStdManage
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 805);
            Controls.Add(dgStd);
            Controls.Add(btnDelete);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnPrint);
            Controls.Add(btnClose);
            Controls.Add(btnEdit);
            Name = "FrmStdManage";
            Text = "学员信息管理";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgStd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbClass;
        private Label label4;
        private Button btnSearchByNumDesc;
        private Button btnSearchByNameDesc;
        private Button btnSearchByClass;
        private Button btnEdit;
        private Button btnDelete;
        private GroupBox groupBox2;
        private Button btnSearchByNum;
        private Label label1;
        private TextBox txtCardNo;
        private Button btnPrint;
        private DataGridView dgStd;
        private Button btnClose;
        private DataGridViewTextBoxColumn CardNo;
        private DataGridViewTextBoxColumn StdName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn idNo;
        private DataGridViewTextBoxColumn ClassName;
    }
}