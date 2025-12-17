namespace AMS.ahutit
{
    partial class FrmScoreVIew
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnClose = new Button();
            cmbClass = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            txtScore = new TextBox();
            btnViewAll = new Button();
            dgScore = new DataGridView();
            StdId = new DataGridViewTextBoxColumn();
            StdName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            AttendanceCount = new DataGridViewTextBoxColumn();
            AttendanceScore = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgScore).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1164, 49);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(149, 34);
            btnClose.TabIndex = 10;
            btnClose.Text = "关闭";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cmbClass
            // 
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(97, 50);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(220, 32);
            cmbClass.TabIndex = 9;
            cmbClass.SelectedIndexChanged += cmbClass_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 54);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 8;
            label4.Text = "班级：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 54);
            label1.Name = "label1";
            label1.Size = new Size(213, 24);
            label1.TabIndex = 11;
            label1.Text = "按考勤得分(%)快速浏览：>";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(588, 51);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(98, 30);
            txtScore.TabIndex = 12;
            txtScore.TextChanged += txtScore_TextChanged;
            // 
            // btnViewAll
            // 
            btnViewAll.Location = new Point(882, 49);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(149, 34);
            btnViewAll.TabIndex = 10;
            btnViewAll.Text = "显示全部成绩";
            btnViewAll.UseVisualStyleBackColor = true;
            btnViewAll.Click += btnViewAll_Click;
            // 
            // dgScore
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgScore.ColumnHeadersHeight = 50;
            dgScore.Columns.AddRange(new DataGridViewColumn[] { StdId, StdName, Gender, PhoneNumber, AttendanceCount, AttendanceScore });
            dgScore.Location = new Point(3, 122);
            dgScore.Name = "dgScore";
            dgScore.RowHeadersWidth = 62;
            dgScore.Size = new Size(1310, 660);
            dgScore.TabIndex = 13;
            // 
            // StdId
            // 
            StdId.DataPropertyName = "StdId";
            StdId.HeaderText = "学号";
            StdId.MinimumWidth = 8;
            StdId.Name = "StdId";
            StdId.ReadOnly = true;
            StdId.Width = 150;
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
            // AttendanceCount
            // 
            AttendanceCount.DataPropertyName = "AttendanceCount";
            AttendanceCount.HeaderText = "签到次数";
            AttendanceCount.MinimumWidth = 8;
            AttendanceCount.Name = "AttendanceCount";
            AttendanceCount.Width = 200;
            // 
            // AttendanceScore
            // 
            AttendanceScore.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AttendanceScore.DataPropertyName = "AttendanceScore";
            AttendanceScore.HeaderText = "考勤得分(%)";
            AttendanceScore.MinimumWidth = 8;
            AttendanceScore.Name = "AttendanceScore";
            // 
            // FrmScoreVIew
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 817);
            Controls.Add(dgScore);
            Controls.Add(txtScore);
            Controls.Add(label1);
            Controls.Add(btnViewAll);
            Controls.Add(btnClose);
            Controls.Add(cmbClass);
            Controls.Add(label4);
            Name = "FrmScoreVIew";
            Text = "考勤分析";
            ((System.ComponentModel.ISupportInitialize)dgScore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private ComboBox cmbClass;
        private Label label4;
        private Label label1;
        private TextBox txtScore;
        private Button btnViewAll;
        private DataGridView dgScore;
        private DataGridViewTextBoxColumn StdId;
        private DataGridViewTextBoxColumn StdName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn AttendanceCount;
        private DataGridViewTextBoxColumn AttendanceScore;
    }
}