namespace BankSystemWindow
{
    partial class Form1
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
            btnAdd = new Button();
            txtId = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnModify = new Button();
            txtAge = new TextBox();
            label2 = new Label();
            btnSerch = new Button();
            txtGender = new TextBox();
            label3 = new Label();
            btnRemove = new Button();
            txtName = new TextBox();
            label4 = new Label();
            btnSerchAll = new Button();
            txtSerch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(229, 131);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "添加学生";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(65, 137);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(0, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(802, 282);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "姓名";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "性别";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "年龄";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "学号";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 140);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 3;
            label1.Text = "学号:";
            // 
            // btnModify
            // 
            btnModify.Location = new Point(449, 131);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(94, 29);
            btnModify.TabIndex = 0;
            btnModify.Text = "修改信息";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(65, 96);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 100);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 3;
            label2.Text = "年龄:";
            // 
            // btnSerch
            // 
            btnSerch.Location = new Point(558, 131);
            btnSerch.Name = "btnSerch";
            btnSerch.Size = new Size(94, 29);
            btnSerch.TabIndex = 0;
            btnSerch.Text = "查询学生";
            btnSerch.UseVisualStyleBackColor = true;
            btnSerch.Click += btnSerch_Click;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(65, 53);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(125, 27);
            txtGender.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 56);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 3;
            label3.Text = "性别:";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(340, 131);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 0;
            btnRemove.Text = "删除学生";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(65, 10);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 13);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 3;
            label4.Text = "姓名:";
            // 
            // btnSerchAll
            // 
            btnSerchAll.Location = new Point(669, 131);
            btnSerchAll.Name = "btnSerchAll";
            btnSerchAll.Size = new Size(94, 29);
            btnSerchAll.TabIndex = 0;
            btnSerchAll.Text = "显示所有";
            btnSerchAll.UseVisualStyleBackColor = true;
            btnSerchAll.Click += btnSerchAll_Click;
            // 
            // txtSerch
            // 
            txtSerch.Location = new Point(543, 93);
            txtSerch.Name = "txtSerch";
            txtSerch.Size = new Size(125, 27);
            txtSerch.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtName);
            Controls.Add(btnSerchAll);
            Controls.Add(btnRemove);
            Controls.Add(txtGender);
            Controls.Add(btnSerch);
            Controls.Add(txtSerch);
            Controls.Add(txtAge);
            Controls.Add(btnModify);
            Controls.Add(txtId);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "学生管理系统界面";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtId;
        private DataGridView dataGridView1;
        private Label label1;
        private Button btnModify;
        private TextBox txtAge;
        private Label label2;
        private Button btnSerch;
        private TextBox txtGender;
        private Label label3;
        private Button btnRemove;
        private TextBox txtName;
        private Label label4;
        private Button btnSerchAll;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox txtSerch;
    }
}
