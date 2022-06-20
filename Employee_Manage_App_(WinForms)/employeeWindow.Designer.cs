namespace Employee_Manage_App__WinForms_
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.applicantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeManageAppDBDataSet = new Employee_Manage_App__WinForms_.EmployeeManageAppDBDataSet();
            this.applicantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.positionemployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.structuraldivisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.applicantTableAdapter = new Employee_Manage_App__WinForms_.EmployeeManageAppDBDataSetTableAdapters.applicantTableAdapter();
            this.position_employeeTableAdapter = new Employee_Manage_App__WinForms_.EmployeeManageAppDBDataSetTableAdapters.position_employeeTableAdapter();
            this.structural_divisionTableAdapter = new Employee_Manage_App__WinForms_.EmployeeManageAppDBDataSetTableAdapters.structural_divisionTableAdapter();
            this.applicant1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicant1TableAdapter = new Employee_Manage_App__WinForms_.EmployeeManageAppDBDataSetTableAdapters.applicant1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManageAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionemployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.structuraldivisionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicant1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.applicant1BindingSource;
            this.comboBox1.DisplayMember = "ФИО";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(306, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "ID";
            // 
            // applicantBindingSource1
            // 
            this.applicantBindingSource1.DataMember = "applicant";
            this.applicantBindingSource1.DataSource = this.employeeManageAppDBDataSet;
            // 
            // employeeManageAppDBDataSet
            // 
            this.employeeManageAppDBDataSet.DataSetName = "EmployeeManageAppDBDataSet";
            this.employeeManageAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicantBindingSource
            // 
            this.applicantBindingSource.DataMember = "applicant";
            this.applicantBindingSource.DataSource = this.employeeManageAppDBDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить сотрудника";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.positionemployeeBindingSource;
            this.comboBox2.DisplayMember = "Name";
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(627, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Удалить сотрудника";
            this.button2.UseVisualStyleBackColor = true;
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
            // applicant1BindingSource
            // 
            this.applicant1BindingSource.DataMember = "applicant1";
            this.applicant1BindingSource.DataSource = this.employeeManageAppDBDataSet;
            // 
            // applicant1TableAdapter
            // 
            this.applicant1TableAdapter.ClearBeforeFill = true;
            // 
            // employeeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "employeeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employeeWindow";
            this.Load += new System.EventHandler(this.employeeWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManageAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionemployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.structuraldivisionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicant1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
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
    }
}