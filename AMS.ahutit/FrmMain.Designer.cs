namespace AMS.ahutit
{
    partial class FrmMain
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
            tsmiMain = new MenuStrip();
            tsmiSystem = new ToolStripMenuItem();
            tsmiPSW = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            tsmiExit = new ToolStripMenuItem();
            tsmiStudentMan = new ToolStripMenuItem();
            tsmiAdd = new ToolStripMenuItem();
            tsmiClassManage = new ToolStripMenuItem();
            tsmiImport = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tsmiView = new ToolStripMenuItem();
            ssMain = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            tssLabUserName = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            btnChangeUser = new Button();
            btnExit = new Button();
            btnView = new Button();
            btnAtt = new Button();
            btnExport = new Button();
            btnPSW = new Button();
            btnClassManage = new Button();
            btnManange = new Button();
            btnAdd = new Button();
            monthCalendar1 = new MonthCalendar();
            tsmiMain.SuspendLayout();
            ssMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // tsmiMain
            // 
            tsmiMain.ImageScalingSize = new Size(24, 24);
            tsmiMain.Items.AddRange(new ToolStripItem[] { tsmiSystem, tsmiStudentMan });
            tsmiMain.Location = new Point(0, 0);
            tsmiMain.Name = "tsmiMain";
            tsmiMain.Size = new Size(1898, 32);
            tsmiMain.TabIndex = 0;
            tsmiMain.Text = "menuStrip1";
            // 
            // tsmiSystem
            // 
            tsmiSystem.DropDownItems.AddRange(new ToolStripItem[] { tsmiPSW, toolStripMenuItem1, tsmiExit });
            tsmiSystem.Name = "tsmiSystem";
            tsmiSystem.Size = new Size(84, 28);
            tsmiSystem.Text = "系统(&S)";
            // 
            // tsmiPSW
            // 
            tsmiPSW.Name = "tsmiPSW";
            tsmiPSW.Size = new Size(182, 34);
            tsmiPSW.Text = "密码修改";
            tsmiPSW.Click += btnPSW_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(179, 6);
            // 
            // tsmiExit
            // 
            tsmiExit.Name = "tsmiExit";
            tsmiExit.Size = new Size(182, 34);
            tsmiExit.Text = "退出系统";
            tsmiExit.Click += btnExit_Click;
            // 
            // tsmiStudentMan
            // 
            tsmiStudentMan.DropDownItems.AddRange(new ToolStripItem[] { tsmiAdd, tsmiClassManage, tsmiImport, toolStripSeparator1, tsmiView });
            tsmiStudentMan.Name = "tsmiStudentMan";
            tsmiStudentMan.Size = new Size(128, 28);
            tsmiStudentMan.Text = "学员管理(&M)";
            // 
            // tsmiAdd
            // 
            tsmiAdd.Name = "tsmiAdd";
            tsmiAdd.Size = new Size(182, 34);
            tsmiAdd.Text = "添加学员";
            tsmiAdd.Click += btnAdd_Click;
            // 
            // tsmiClassManage
            // 
            tsmiClassManage.Name = "tsmiClassManage";
            tsmiClassManage.Size = new Size(182, 34);
            tsmiClassManage.Text = "班级管理";
            tsmiClassManage.Click += btnClassManage_Click;
            // 
            // tsmiImport
            // 
            tsmiImport.Name = "tsmiImport";
            tsmiImport.Size = new Size(182, 34);
            tsmiImport.Text = "批量导入";
            tsmiImport.Click += tsmiImport_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(179, 6);
            // 
            // tsmiView
            // 
            tsmiView.Name = "tsmiView";
            tsmiView.Size = new Size(182, 34);
            tsmiView.Text = "成绩浏览";
            tsmiView.Click += btnView_Click;
            // 
            // ssMain
            // 
            ssMain.ImageScalingSize = new Size(24, 24);
            ssMain.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, tssLabUserName });
            ssMain.Location = new Point(0, 993);
            ssMain.Name = "ssMain";
            ssMain.Size = new Size(1898, 31);
            ssMain.TabIndex = 1;
            ssMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(135, 24);
            toolStripStatusLabel1.Text = "版本号：V1.0.1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(100, 24);
            toolStripStatusLabel2.Text = "当前用户：";
            // 
            // tssLabUserName
            // 
            tssLabUserName.Name = "tssLabUserName";
            tssLabUserName.Size = new Size(0, 24);
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 32);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnChangeUser);
            splitContainer1.Panel1.Controls.Add(btnExit);
            splitContainer1.Panel1.Controls.Add(btnView);
            splitContainer1.Panel1.Controls.Add(btnAtt);
            splitContainer1.Panel1.Controls.Add(btnExport);
            splitContainer1.Panel1.Controls.Add(btnPSW);
            splitContainer1.Panel1.Controls.Add(btnClassManage);
            splitContainer1.Panel1.Controls.Add(btnManange);
            splitContainer1.Panel1.Controls.Add(btnAdd);
            splitContainer1.Panel1.Controls.Add(monthCalendar1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackgroundImage = Properties.Resources.Main;
            splitContainer1.Size = new Size(1898, 961);
            splitContainer1.SplitterDistance = 341;
            splitContainer1.TabIndex = 2;
            // 
            // btnChangeUser
            // 
            btnChangeUser.Location = new Point(202, 800);
            btnChangeUser.Name = "btnChangeUser";
            btnChangeUser.Size = new Size(119, 55);
            btnChangeUser.TabIndex = 1;
            btnChangeUser.Text = "切换账号";
            btnChangeUser.UseVisualStyleBackColor = true;
            btnChangeUser.Click += btnChangeUser_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(202, 881);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 55);
            btnExit.TabIndex = 1;
            btnExit.Text = "退出系统";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(202, 421);
            btnView.Name = "btnView";
            btnView.Size = new Size(119, 55);
            btnView.TabIndex = 1;
            btnView.Text = "成绩浏览";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnAtt
            // 
            btnAtt.Location = new Point(202, 341);
            btnAtt.Name = "btnAtt";
            btnAtt.Size = new Size(119, 55);
            btnAtt.TabIndex = 1;
            btnAtt.Text = "发起考勤";
            btnAtt.UseVisualStyleBackColor = true;
            btnAtt.Click += btnAtt_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(202, 265);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(119, 55);
            btnExport.TabIndex = 1;
            btnExport.Text = "导出全部";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnPSW
            // 
            btnPSW.Location = new Point(16, 881);
            btnPSW.Name = "btnPSW";
            btnPSW.Size = new Size(119, 55);
            btnPSW.TabIndex = 1;
            btnPSW.Text = "密码修改";
            btnPSW.UseVisualStyleBackColor = true;
            btnPSW.Click += btnPSW_Click;
            // 
            // btnClassManage
            // 
            btnClassManage.Location = new Point(16, 421);
            btnClassManage.Name = "btnClassManage";
            btnClassManage.Size = new Size(119, 55);
            btnClassManage.TabIndex = 1;
            btnClassManage.Text = "班级管理";
            btnClassManage.UseVisualStyleBackColor = true;
            btnClassManage.Click += btnClassManage_Click;
            // 
            // btnManange
            // 
            btnManange.Location = new Point(16, 341);
            btnManange.Name = "btnManange";
            btnManange.Size = new Size(119, 55);
            btnManange.TabIndex = 1;
            btnManange.Text = "学员管理";
            btnManange.UseVisualStyleBackColor = true;
            btnManange.Click += btnManange_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(16, 265);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 55);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "添加学员";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(16, 9);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(splitContainer1);
            Controls.Add(ssMain);
            Controls.Add(tsmiMain);
            MainMenuStrip = tsmiMain;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "管理员端";
            FormClosing += FrmMain_FormClosing;
            tsmiMain.ResumeLayout(false);
            tsmiMain.PerformLayout();
            ssMain.ResumeLayout(false);
            ssMain.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip tsmiMain;
        private ToolStripMenuItem tsmiSystem;
        private ToolStripMenuItem tsmiPSW;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem tsmiExit;
        private ToolStripMenuItem tsmiStudentMan;
        private ToolStripMenuItem tsmiAdd;
        private ToolStripMenuItem tsmiImport;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiView;
        private StatusStrip ssMain;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private SplitContainer splitContainer1;
        private MonthCalendar monthCalendar1;
        private Button btnExit;
        private Button btnView;
        private Button btnAtt;
        private Button btnExport;
        private Button btnPSW;
        private Button btnManange;
        private Button btnClassManage;
        private Button btnAdd;
        private Button btnChangeUser;
        private ToolStripMenuItem tsmiClassManage;
        private ToolStripStatusLabel tssLabUserName;
    }
}

