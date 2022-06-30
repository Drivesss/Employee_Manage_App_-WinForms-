﻿namespace Employee_Manage_App__WinForms_
{
    partial class employeeWindow
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
            this.dataGridEmployee = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeManageAppDBDataSet = new Employee_Manage_App__WinForms_.EmployeeManageAppDBDataSet();
            this.ComBoxApplicant = new System.Windows.Forms.ComboBox();
            this.applicant1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.applicantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.positionemployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.structuraldivisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDismissal = new System.Windows.Forms.Button();
            this.applicantTableAdapter = new Employee_Manage_App__WinForms_.EmployeeManageAppDBDataSetTableAdapters.applicantTableAdapter();
            this.position_employeeTableAdapter = new Employee_Manage_App__WinForms_.EmployeeManageAppDBDataSetTableAdapters.position_employeeTableAdapter();
            this.structural_divisionTableAdapter = new Employee_Manage_App__WinForms_.EmployeeManageAppDBDataSetTableAdapters.structural_divisionTableAdapter();
            this.applicant1TableAdapter = new Employee_Manage_App__WinForms_.EmployeeManageAppDBDataSetTableAdapters.applicant1TableAdapter();
            this.employeeTableAdapter = new Employee_Manage_App__WinForms_.EmployeeManageAppDBDataSetTableAdapters.employeeTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfEmploymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfDismissalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionEmployeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structuralDivisionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManageAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicant1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionemployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.structuraldivisionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEmployee
            // 
            this.dataGridEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEmployee.AutoGenerateColumns = false;
            this.dataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.educationDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dateOfEmploymentDataGridViewTextBoxColumn,
            this.dateOfDismissalDataGridViewTextBoxColumn,
            this.positionEmployeeIDDataGridViewTextBoxColumn,
            this.structuralDivisionIDDataGridViewTextBoxColumn});
            this.dataGridEmployee.DataSource = this.employeeBindingSource;
            this.dataGridEmployee.Location = new System.Drawing.Point(12, 83);
            this.dataGridEmployee.Name = "dataGridEmployee";
            this.dataGridEmployee.Size = new System.Drawing.Size(776, 326);
            this.dataGridEmployee.TabIndex = 0;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.employeeManageAppDBDataSet;
            // 
            // employeeManageAppDBDataSet
            // 
            this.employeeManageAppDBDataSet.DataSetName = "EmployeeManageAppDBDataSet";
            this.employeeManageAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ComBoxApplicant
            // 
            this.ComBoxApplicant.DataSource = this.applicant1BindingSource;
            this.ComBoxApplicant.DisplayMember = "ФИО";
            this.ComBoxApplicant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxApplicant.FormattingEnabled = true;
            this.ComBoxApplicant.Location = new System.Drawing.Point(12, 27);
            this.ComBoxApplicant.Name = "ComBoxApplicant";
            this.ComBoxApplicant.Size = new System.Drawing.Size(306, 21);
            this.ComBoxApplicant.TabIndex = 1;
            this.ComBoxApplicant.ValueMember = "ID";
            // 
            // applicant1BindingSource
            // 
            this.applicant1BindingSource.DataMember = "applicant1";
            this.applicant1BindingSource.DataSource = this.employeeManageAppDBDataSet;
            // 
            // applicantBindingSource1
            // 
            this.applicantBindingSource1.DataMember = "applicant";
            this.applicantBindingSource1.DataSource = this.employeeManageAppDBDataSet;
            // 
            // applicantBindingSource
            // 
            this.applicantBindingSource.DataMember = "applicant";
            this.applicantBindingSource.DataSource = this.employeeManageAppDBDataSet;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(627, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить сотрудника";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.positionemployeeBindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(324, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(167, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ValueMember = "ID";
            // 
            // positionemployeeBindingSource
            // 
            this.positionemployeeBindingSource.DataMember = "position_employee";
            this.positionemployeeBindingSource.DataSource = this.employeeManageAppDBDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.structuraldivisionBindingSource;
            this.comboBox3.DisplayMember = "Name";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(497, 27);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(291, 21);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.ValueMember = "ID";
            // 
            // structuraldivisionBindingSource
            // 
            this.structuraldivisionBindingSource.DataMember = "structural_division";
            this.structuraldivisionBindingSource.DataSource = this.employeeManageAppDBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите соискателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Выберите должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Выберите структурное подразделение";
            // 
            // btnDismissal
            // 
            this.btnDismissal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDismissal.Location = new System.Drawing.Point(12, 415);
            this.btnDismissal.Name = "btnDismissal";
            this.btnDismissal.Size = new System.Drawing.Size(161, 23);
            this.btnDismissal.TabIndex = 11;
            this.btnDismissal.Text = "Увольнение сотрудника";
            this.btnDismissal.UseVisualStyleBackColor = true;
            this.btnDismissal.Click += new System.EventHandler(this.btnDismissal_Click);
            // 
            // applicantTableAdapter
            // 
            this.applicantTableAdapter.ClearBeforeFill = true;
            // 
            // position_employeeTableAdapter
            // 
            this.position_employeeTableAdapter.ClearBeforeFill = true;
            // 
            // structural_divisionTableAdapter
            // 
            this.structural_divisionTableAdapter.ClearBeforeFill = true;
            // 
            // applicant1TableAdapter
            // 
            this.applicant1TableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(682, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // educationDataGridViewTextBoxColumn
            // 
            this.educationDataGridViewTextBoxColumn.DataPropertyName = "Education";
            this.educationDataGridViewTextBoxColumn.HeaderText = "Education";
            this.educationDataGridViewTextBoxColumn.Name = "educationDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateOfEmploymentDataGridViewTextBoxColumn
            // 
            this.dateOfEmploymentDataGridViewTextBoxColumn.DataPropertyName = "DateOfEmployment";
            this.dateOfEmploymentDataGridViewTextBoxColumn.HeaderText = "DateOfEmployment";
            this.dateOfEmploymentDataGridViewTextBoxColumn.Name = "dateOfEmploymentDataGridViewTextBoxColumn";
            // 
            // dateOfDismissalDataGridViewTextBoxColumn
            // 
            this.dateOfDismissalDataGridViewTextBoxColumn.DataPropertyName = "DateOfDismissal";
            this.dateOfDismissalDataGridViewTextBoxColumn.HeaderText = "DateOfDismissal";
            this.dateOfDismissalDataGridViewTextBoxColumn.Name = "dateOfDismissalDataGridViewTextBoxColumn";
            // 
            // positionEmployeeIDDataGridViewTextBoxColumn
            // 
            this.positionEmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "PositionEmployeeID";
            this.positionEmployeeIDDataGridViewTextBoxColumn.HeaderText = "PositionEmployeeID";
            this.positionEmployeeIDDataGridViewTextBoxColumn.Name = "positionEmployeeIDDataGridViewTextBoxColumn";
            // 
            // structuralDivisionIDDataGridViewTextBoxColumn
            // 
            this.structuralDivisionIDDataGridViewTextBoxColumn.DataPropertyName = "StructuralDivisionID";
            this.structuralDivisionIDDataGridViewTextBoxColumn.HeaderText = "StructuralDivisionID";
            this.structuralDivisionIDDataGridViewTextBoxColumn.Name = "structuralDivisionIDDataGridViewTextBoxColumn";
            // 
            // employeeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDismissal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ComBoxApplicant);
            this.Controls.Add(this.dataGridEmployee);
            this.Name = "employeeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employeeWindow";
            this.Load += new System.EventHandler(this.employeeWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManageAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicant1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionemployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.structuraldivisionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEmployee;
        private System.Windows.Forms.ComboBox ComBoxApplicant;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDismissal;
        private EmployeeManageAppDBDataSet employeeManageAppDBDataSet;
        private System.Windows.Forms.BindingSource applicantBindingSource;
        private EmployeeManageAppDBDataSetTableAdapters.applicantTableAdapter applicantTableAdapter;
        private System.Windows.Forms.BindingSource positionemployeeBindingSource;
        private EmployeeManageAppDBDataSetTableAdapters.position_employeeTableAdapter position_employeeTableAdapter;
        private System.Windows.Forms.BindingSource structuraldivisionBindingSource;
        private EmployeeManageAppDBDataSetTableAdapters.structural_divisionTableAdapter structural_divisionTableAdapter;
        private System.Windows.Forms.BindingSource applicantBindingSource1;
        private System.Windows.Forms.BindingSource applicant1BindingSource;
        private EmployeeManageAppDBDataSetTableAdapters.applicant1TableAdapter applicant1TableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EmployeeManageAppDBDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfEmploymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfDismissalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionEmployeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn structuralDivisionIDDataGridViewTextBoxColumn;
    }
}