namespace AMS.ahutit
{
    partial class FrmStudentScoreView
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
            lblTitle = new Label();
            grpBox = new GroupBox();
            lblAttendanceScore = new Label();
            lblTotalSessions = new Label();
            lblAttendanceCount = new Label();
            labelScore = new Label();
            labelTotal = new Label();
            labelCount = new Label();
            btnRefresh = new Button();
            grpBox.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblTitle.Location = new Point(40, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(158, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "我的考勤情况";
            // 
            // grpBox
            // 
            grpBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpBox.Controls.Add(lblAttendanceScore);
            grpBox.Controls.Add(lblTotalSessions);
            grpBox.Controls.Add(lblAttendanceCount);
            grpBox.Controls.Add(labelScore);
            grpBox.Controls.Add(labelTotal);
            grpBox.Controls.Add(labelCount);
            grpBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 134);
            grpBox.Location = new Point(40, 90);
            grpBox.Name = "grpBox";
            grpBox.Size = new Size(620, 220);
            grpBox.TabIndex = 1;
            grpBox.TabStop = false;
            grpBox.Text = "统计信息";
            // 
            // lblAttendanceScore
            // 
            lblAttendanceScore.AutoSize = true;
            lblAttendanceScore.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblAttendanceScore.Location = new Point(210, 160);
            lblAttendanceScore.Name = "lblAttendanceScore";
            lblAttendanceScore.Size = new Size(24, 31);
            lblAttendanceScore.TabIndex = 5;
            lblAttendanceScore.Text = "-";
            // 
            // lblTotalSessions
            // 
            lblTotalSessions.AutoSize = true;
            lblTotalSessions.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblTotalSessions.Location = new Point(210, 110);
            lblTotalSessions.Name = "lblTotalSessions";
            lblTotalSessions.Size = new Size(24, 31);
            lblTotalSessions.TabIndex = 4;
            lblTotalSessions.Text = "-";
            // 
            // lblAttendanceCount
            // 
            lblAttendanceCount.AutoSize = true;
            lblAttendanceCount.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblAttendanceCount.Location = new Point(210, 60);
            lblAttendanceCount.Name = "lblAttendanceCount";
            lblAttendanceCount.Size = new Size(24, 31);
            lblAttendanceCount.TabIndex = 3;
            lblAttendanceCount.Text = "-";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Location = new Point(40, 165);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(130, 27);
            labelScore.TabIndex = 2;
            labelScore.Text = "当前考勤得分";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(40, 115);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(140, 27);
            labelTotal.TabIndex = 1;
            labelTotal.Text = "考勤总次数";
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(40, 65);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(116, 27);
            labelCount.TabIndex = 0;
            labelCount.Text = "签到次数";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(40, 330);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 40);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "刷新";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FrmStudentScoreView
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 450);
            Controls.Add(btnRefresh);
            Controls.Add(grpBox);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmStudentScoreView";
            Text = "FrmStudentScoreView";
            Load += FrmStudentScoreView_Load;
            grpBox.ResumeLayout(false);
            grpBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpBox;
        private Label lblAttendanceScore;
        private Label lblTotalSessions;
        private Label lblAttendanceCount;
        private Label labelScore;
        private Label labelTotal;
        private Label labelCount;
        private Button btnRefresh;
    }
}
