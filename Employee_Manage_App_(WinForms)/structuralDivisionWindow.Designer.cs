namespace Employee_Manage_App__WinForms_
{
    partial class structuralDivisionWindow
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
            this.components = new System.ComponentModel.Container();
            this.dataGridDivision = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bossDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structuraldivisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeManageAppDBDataSet = new Employee_Manage_App__WinForms_.EmployeeManageAppDBDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDivision = new System.Windows.Forms.ComboBox();
            this.structuraldivisionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridDivisionEmployee = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.employeeBossComBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeManageAppDBDataSet1 = new Employee_Manage_App__WinForms_.EmployeeManageAppDBDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.structural_divisionTableAdapter = new Employee_Manage_App__WinForms_.EmployeeManageAppDBDataSetTableAdapters.structural_divisionTableAdapter();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Employee_Manage_App__WinForms_.EmployeeManageAppDBDataSetTableAdapters.employeeTableAdapter();
            this.employeeBossComBoxTableAdapter = new Employee_Manage_App__WinForms_.EmployeeManageAppDBDataSetTableAdapters.employeeBossComBoxTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveBoss = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.structuraldivisionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManageAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.structuraldivisionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDivisionEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBossComBoxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManageAppDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDivision
            // 
            this.dataGridDivision.AutoGenerateColumns = false;
            this.dataGridDivision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDivision.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.bossDataGridViewTextBoxColumn});
            this.dataGridDivision.DataSource = this.structuraldivisionBindingSource;
            this.dataGridDivision.Location = new System.Drawing.Point(15, 25);
            this.dataGridDivision.Name = "dataGridDivision";
            this.dataGridDivision.RowHeadersVisible = false;
            this.dataGridDivision.Size = new System.Drawing.Size(280, 384);
            this.dataGridDivision.TabIndex = 0;
            this.dataGridDivision.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDivision_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // bossDataGridViewTextBoxColumn
            // 
            this.bossDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bossDataGridViewTextBoxColumn.DataPropertyName = "Boss";
            this.bossDataGridViewTextBoxColumn.HeaderText = "Boss";
            this.bossDataGridViewTextBoxColumn.Name = "bossDataGridViewTextBoxColumn";
            this.bossDataGridViewTextBoxColumn.ReadOnly = true;
            this.bossDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // structuraldivisionBindingSource
            // 
            this.structuraldivisionBindingSource.DataMember = "structural_division";
            this.structuraldivisionBindingSource.DataSource = this.employeeManageAppDBDataSet;
            // 
            // employeeManageAppDBDataSet
            // 
            this.employeeManageAppDBDataSet.DataSetName = "EmployeeManageAppDBDataSet";
            this.employeeManageAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Список подразделений / Добавление / Удаление";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выбор подразделения";
            // 
            // comboBoxDivision
            // 
            this.comboBoxDivision.DataSource = this.structuraldivisionBindingSource1;
            this.comboBoxDivision.DisplayMember = "Name";
            this.comboBoxDivision.FormattingEnabled = true;
            this.comboBoxDivision.Location = new System.Drawing.Point(313, 26);
            this.comboBoxDivision.Name = "comboBoxDivision";
            this.comboBoxDivision.Size = new System.Drawing.Size(859, 21);
            this.comboBoxDivision.TabIndex = 5;
            this.comboBoxDivision.ValueMember = "ID";
            this.comboBoxDivision.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDivision_SelectionChangeCommitted);
            // 
            // structuraldivisionBindingSource1
            // 
            this.structuraldivisionBindingSource1.DataMember = "structural_division";
            this.structuraldivisionBindingSource1.DataSource = this.employeeManageAppDBDataSet;
            // 
            // dataGridDivisionEmployee
            // 
            this.dataGridDivisionEmployee.AllowUserToAddRows = false;
            this.dataGridDivisionEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDivisionEmployee.Location = new System.Drawing.Point(313, 106);
            this.dataGridDivisionEmployee.Name = "dataGridDivisionEmployee";
            this.dataGridDivisionEmployee.RowHeadersVisible = false;
            this.dataGridDivisionEmployee.Size = new System.Drawing.Size(859, 332);
            this.dataGridDivisionEmployee.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.employeeBossComBoxBindingSource;
            this.comboBox2.DisplayMember = "ФИО";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(313, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(700, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "ID";
            // 
            // employeeBossComBoxBindingSource
            // 
            this.employeeBossComBoxBindingSource.DataMember = "employeeBossComBox";
            this.employeeBossComBoxBindingSource.DataSource = this.employeeManageAppDBDataSet1;
            // 
            // employeeManageAppDBDataSet1
            // 
            this.employeeManageAppDBDataSet1.DataSetName = "EmployeeManageAppDBDataSet";
            this.employeeManageAppDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Начальник подразделения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Список сотрудников в подразделении";
            // 
            // structural_divisionTableAdapter
            // 
            this.structural_divisionTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.employeeManageAppDBDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBossComBoxTableAdapter
            // 
            this.employeeBossComBoxTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(220, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveBoss
            // 
            this.btnSaveBoss.Location = new System.Drawing.Point(1019, 66);
            this.btnSaveBoss.Name = "btnSaveBoss";
            this.btnSaveBoss.Size = new System.Drawing.Size(153, 23);
            this.btnSaveBoss.TabIndex = 11;
            this.btnSaveBoss.Text = "Сохранить начальника";
            this.btnSaveBoss.UseVisualStyleBackColor = true;
            this.btnSaveBoss.Click += new System.EventHandler(this.btnSaveBoss_Click);
            // 
            // structuralDivisionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 450);
            this.Controls.Add(this.btnSaveBoss);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridDivisionEmployee);
            this.Controls.Add(this.comboBoxDivision);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridDivision);
            this.Name = "structuralDivisionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "structuralDivisionWindow";
            this.Load += new System.EventHandler(this.structuralDivisionWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.structuraldivisionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManageAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.structuraldivisionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDivisionEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBossComBoxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManageAppDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDivision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDivision;
        private System.Windows.Forms.DataGridView dataGridDivisionEmployee;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private EmployeeManageAppDBDataSet employeeManageAppDBDataSet;
        private System.Windows.Forms.BindingSource structuraldivisionBindingSource;
        private EmployeeManageAppDBDataSetTableAdapters.structural_divisionTableAdapter structural_divisionTableAdapter;
        private System.Windows.Forms.BindingSource structuraldivisionBindingSource1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EmployeeManageAppDBDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private EmployeeManageAppDBDataSet employeeManageAppDBDataSet1;
        private System.Windows.Forms.BindingSource employeeBossComBoxBindingSource;
        private EmployeeManageAppDBDataSetTableAdapters.employeeBossComBoxTableAdapter employeeBossComBoxTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bossDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSaveBoss;
    }
}