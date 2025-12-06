using System;
using System.Drawing;
using System.Windows.Forms;

namespace AMS.ahutit
{
    partial class FrmClassManage
    {
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
            dgvClasses = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colClassName = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtClassName = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnClose = new Button();
            lblMajor = new Label();
            txtMajor = new TextBox();
            lblShort = new Label();
            txtShort = new TextBox();
            lblGrade = new Label();
            txtGrade = new TextBox();
            lblClassNo = new Label();
            txtClassNo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
            SuspendLayout();
            // 
            // dgvClasses
            // 
            dgvClasses.AllowUserToAddRows = false;
            dgvClasses.AllowUserToDeleteRows = false;
            dgvClasses.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClasses.AutoGenerateColumns = false;
            dgvClasses.Columns.AddRange(new DataGridViewColumn[] { colId, colClassName });
            dgvClasses.Location = new Point(24, 24);
            dgvClasses.MultiSelect = false;
            dgvClasses.Name = "dgvClasses";
            dgvClasses.ReadOnly = true;
            dgvClasses.RowHeadersVisible = false;
            dgvClasses.RowTemplate.Height = 29;
            dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClasses.Size = new Size(650, 300);
            dgvClasses.TabIndex = 0;
            dgvClasses.SelectionChanged += dgvClasses_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "班级编号";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colClassName
            // 
            colClassName.DataPropertyName = "ClassName";
            colClassName.HeaderText = "班级名称";
            colClassName.MinimumWidth = 8;
            colClassName.Name = "colClassName";
            colClassName.ReadOnly = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(24, 456);
            label1.Name = "label1";
            label1.Size = new Size(108, 24);
            label1.TabIndex = 1;
            label1.Text = "生成班级：";
            // 
            // txtClassName
            // 
            txtClassName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtClassName.Location = new Point(138, 453);
            txtClassName.Name = "txtClassName";
            txtClassName.ReadOnly = true;
            txtClassName.Size = new Size(536, 30);
            txtClassName.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Location = new Point(24, 509);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 40);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "添加";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdate.Location = new Point(152, 509);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 40);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "修改";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Location = new Point(280, 509);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 40);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "删除";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRefresh.Location = new Point(408, 509);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 40);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "刷新";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(564, 509);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 40);
            btnClose.TabIndex = 11;
            btnClose.Text = "关闭";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblMajor
            // 
            lblMajor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMajor.AutoSize = true;
            lblMajor.Location = new Point(24, 346);
            lblMajor.Name = "lblMajor";
            lblMajor.Size = new Size(62, 24);
            lblMajor.TabIndex = 12;
            lblMajor.Text = "专业：";
            // 
            // txtMajor
            // 
            txtMajor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMajor.Location = new Point(92, 343);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(582, 30);
            txtMajor.TabIndex = 2;
            txtMajor.TextChanged += ClassPartChanged;
            // 
            // lblShort
            // 
            lblShort.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblShort.AutoSize = true;
            lblShort.Location = new Point(24, 386);
            lblShort.Name = "lblShort";
            lblShort.Size = new Size(62, 24);
            lblShort.TabIndex = 14;
            lblShort.Text = "简称：";
            // 
            // txtShort
            // 
            txtShort.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtShort.Location = new Point(92, 383);
            txtShort.Name = "txtShort";
            txtShort.Size = new Size(80, 30);
            txtShort.TabIndex = 3;
            txtShort.TextChanged += ClassPartChanged;
            // 
            // lblGrade
            // 
            lblGrade.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(198, 386);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(62, 24);
            lblGrade.TabIndex = 16;
            lblGrade.Text = "年级：";
            // 
            // txtGrade
            // 
            txtGrade.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtGrade.Location = new Point(266, 383);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(80, 30);
            txtGrade.TabIndex = 4;
            txtGrade.TextChanged += ClassPartChanged;
            // 
            // lblClassNo
            // 
            lblClassNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblClassNo.AutoSize = true;
            lblClassNo.Location = new Point(370, 386);
            lblClassNo.Name = "lblClassNo";
            lblClassNo.Size = new Size(82, 24);
            lblClassNo.TabIndex = 18;
            lblClassNo.Text = "班级号：";
            // 
            // txtClassNo
            // 
            txtClassNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtClassNo.Location = new Point(458, 383);
            txtClassNo.Name = "txtClassNo";
            txtClassNo.Size = new Size(80, 30);
            txtClassNo.TabIndex = 5;
            txtClassNo.TextChanged += ClassPartChanged;
            // 
            // FrmClassManage
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 571);
            Controls.Add(txtClassNo);
            Controls.Add(lblClassNo);
            Controls.Add(txtGrade);
            Controls.Add(lblGrade);
            Controls.Add(txtShort);
            Controls.Add(lblShort);
            Controls.Add(txtMajor);
            Controls.Add(lblMajor);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtClassName);
            Controls.Add(label1);
            Controls.Add(dgvClasses);
            Name = "FrmClassManage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "班级管理";
            Load += FrmClassManage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClasses;
        private Label label1;
        private TextBox txtClassName;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnClose;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colClassName;
        private Label lblMajor;
        private TextBox txtMajor;
        private Label lblShort;
        private TextBox txtShort;
        private Label lblGrade;
        private TextBox txtGrade;
        private Label lblClassNo;
        private TextBox txtClassNo;
    }
}
