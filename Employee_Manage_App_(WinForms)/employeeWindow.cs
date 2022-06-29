using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Manage_App__WinForms_
{
    public partial class employeeWindow : Form
    {
        string IDComboBox;
        public employeeWindow()
        {
            InitializeComponent();
        }

        private void employeeWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.employeeManageAppDBDataSet.employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet.applicant1". При необходимости она может быть перемещена или удалена.
            this.applicant1TableAdapter.Fill(this.employeeManageAppDBDataSet.applicant1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet.structural_division". При необходимости она может быть перемещена или удалена.
            this.structural_divisionTableAdapter.Fill(this.employeeManageAppDBDataSet.structural_division);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet.position_employee". При необходимости она может быть перемещена или удалена.
            this.position_employeeTableAdapter.Fill(this.employeeManageAppDBDataSet.position_employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet.applicant". При необходимости она может быть перемещена или удалена.
            this.applicantTableAdapter.Fill(this.employeeManageAppDBDataSet.applicant);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Получаем ID элемента ComboBox в таблице applicant SQL
            IDComboBox = ComBoxApplicant.SelectedValue.ToString();

            //Добавляется сотрудник в таблицу employee SQL и отображается в dataGrid
            try
            {
                employeeBindingSource.EndEdit();

                // Create the InsertCommand
                //SqlCommand command = new SqlCommand("INSERT INTO employee (LastName, FirstName, MiddleName, DateOfBirth, Education) VALUES(@LastName, @FirstName, @MiddleName, @DateOfBirth)");
                SqlCommand command = new SqlCommand(
                    "INSERT INTO employee (LastName, FirstName, MiddleName, DateOfBirth, Education) " +
                    "SELECT LastName, FirstName, MiddleName, DateOfBirth, Education " +
                    "FROM applicant WHERE id = @ID");
                command.Connection = employeeTableAdapter.Connection;

                command.Parameters.Add("@ID", IDComboBox);


                employeeTableAdapter.Adapter.InsertCommand = command;

                employeeTableAdapter.Update(this.employeeManageAppDBDataSet.employee);

                MessageBox.Show("Сотрудник добавлен", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Вы действительно хотите уволить сотрудника?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Ставится статус "уволен"
                //Ставится дата увольнения
                //Удаляется должность
                //Удаляется структурне подразделение
            }
        }
    }
}
