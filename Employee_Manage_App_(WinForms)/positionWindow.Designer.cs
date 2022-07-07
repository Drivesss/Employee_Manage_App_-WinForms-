namespace Employee_Manage_App__WinForms_
{
    partial class positionWindow
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
            this.dataGridPosition = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionemployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeManageAppDBDataSet = new Employee_Manage_App__WinForms_.EmployeeManageAppDBDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.positionemployeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeManageAppDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridSelectedEmployee = new System.Windows.Forms.DataGridView();
            this.position_employeeTableAdapter = new Employee_Manage_App__WinForms_.EmployeeManageAppDBDataSetTableAdapters.position_employeeTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionemployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManageAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionemployeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManageAppDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelectedEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPosition
            // 
            this.dataGridPosition.AutoGenerateColumns = false;
            this.dataGridPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridPosition.DataSource = this.positionemployeeBindingSource;
            this.dataGridPosition.Location = new System.Drawing.Point(15, 25);
            this.dataGridPosition.Name = "dataGridPosition";
            this.dataGridPosition.Size = new System.Drawing.Size(280, 384);
            this.dataGridPosition.TabIndex = 0;
            this.dataGridPosition.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPosition_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // positionemployeeBindingSource
            // 
            this.positionemployeeBindingSource.DataMember = "position_employee";
            this.positionemployeeBindingSource.DataSource = this.employeeManageAppDBDataSet;
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
            this.label2.Size = new System.Drawing.Size(240, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Список должностей / Добавление/ Удаление";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вывести сотрудников определенной должности";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DataSource = this.positionemployeeBindingSource1;
            this.comboBoxPosition.DisplayMember = "Name";
            this.comboBoxPosition.DropDownWidth = 859;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(313, 26);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(859, 21);
            this.comboBoxPosition.TabIndex = 5;
            this.comboBoxPosition.ValueMember = "ID";
            this.comboBoxPosition.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPosition_SelectionChangeCommitted);
            // 
            // positionemployeeBindingSource1
            // 
            this.positionemployeeBindingSource1.DataMember = "position_employee";
            this.positionemployeeBindingSource1.DataSource = this.employeeManageAppDBDataSetBindingSource;
            // 
            // employeeManageAppDBDataSetBindingSource
            // 
            this.employeeManageAppDBDataSetBindingSource.DataSource = this.employeeManageAppDBDataSet;
            this.employeeManageAppDBDataSetBindingSource.Position = 0;
            // 
            // dataGridSelectedEmployee
            // 
            this.dataGridSelectedEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSelectedEmployee.Location = new System.Drawing.Point(313, 53);
            this.dataGridSelectedEmployee.Name = "dataGridSelectedEmployee";
            this.dataGridSelectedEmployee.Size = new System.Drawing.Size(859, 385);
            this.dataGridSelectedEmployee.TabIndex = 6;
            // 
            // position_employeeTableAdapter
            // 
            this.position_employeeTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(220, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // positionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridSelectedEmployee);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridPosition);
            this.Name = "positionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "positionWindow";
            this.Load += new System.EventHandler(this.positionWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionemployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManageAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionemployeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManageAppDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelectedEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.DataGridView dataGridSelectedEmployee;
        private System.Windows.Forms.BindingSource employeeManageAppDBDataSetBindingSource;
        private EmployeeManageAppDBDataSet employeeManageAppDBDataSet;
        private System.Windows.Forms.BindingSource positionemployeeBindingSource;
        private EmployeeManageAppDBDataSetTableAdapters.position_employeeTableAdapter position_employeeTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource positionemployeeBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}