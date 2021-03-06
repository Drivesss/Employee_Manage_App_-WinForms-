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
    public partial class positionWindow : Form
    {
        string IdRowDataGrid;
        int IDPositionComBox;
        SqlConnection connection;
        public positionWindow()
        {
            InitializeComponent();
        }

        private void positionWindow_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sergeo\Desktop\EmployeeManageAppDB.mdf;Integrated Security=True;Connect Timeout=30");

            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet.position_employee". При необходимости она может быть перемещена или удалена.
            this.position_employeeTableAdapter.Fill(this.employeeManageAppDBDataSet.position_employee);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                positionemployeeBindingSource.EndEdit();

                // Create the UpdateCommand.
                SqlCommand command = new SqlCommand("UPDATE position_employee SET Name = @Name WHERE ID = @ID");
                command.Connection = position_employeeTableAdapter.Connection;
                         
                command.Parameters.AddWithValue("@ID", dataGridPosition[0, dataGridPosition.CurrentRow.Index].Value.ToString());
                command.Parameters.AddWithValue("@Name", dataGridPosition[1, dataGridPosition.CurrentRow.Index].Value.ToString());

                position_employeeTableAdapter.Adapter.UpdateCommand = command;
                                
                // Create the DeleteCommand.
                SqlCommand command1 = new SqlCommand("DELETE FROM position_employee WHERE ID = @ID");
                command1.Connection = position_employeeTableAdapter.Connection;

                command1.Parameters.AddWithValue("@ID", IdRowDataGrid);

                position_employeeTableAdapter.Adapter.DeleteCommand = command1;

                position_employeeTableAdapter.Update(this.employeeManageAppDBDataSet.position_employee);
                MessageBox.Show("Изменения сохранены", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void dataGridPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdRowDataGrid = dataGridPosition[0, dataGridPosition.CurrentRow.Index].Value.ToString();
        }

        
        //Вывод сотрудников определенной должности
        private void comboBoxPosition_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                IDPositionComBox = Int32.Parse(comboBoxPosition.SelectedValue.ToString());

                connection.Open();

                SqlCommand select = new SqlCommand(
                    "SELECT " +
                    "employee.LastName As Фамилия, " +
                    "employee.FirstName As Имя, " +
                    "employee.MiddleName As Отчество, " +
                    "employee.DateOfBirth As \"Дата рождения\", " +
                    "employee.Education As Образование, " +
                    "employee.Status As Статус, " +
                    "employee.DateOfEmployment \"Дата трудоустройства\", " +
                    "structural_division.Name AS \"Структурное подразделение\", " +
                    "position_employee.Name As Должность " +
                    "FROM employee " +
                    "INNER JOIN position_employee ON employee.PositionEmployeeID = position_employee.ID " +
                    "INNER JOIN structural_division ON employee.StructuralDivisionID = structural_division.ID " +
                    "WHERE(position_employee.ID = @IDPositionComBox)", connection);

               select.Parameters.AddWithValue("@IDPositionComBox", IDPositionComBox);

                SqlDataAdapter adapter = new SqlDataAdapter(select);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridSelectedEmployee.DataSource = ds.Tables[0];

                connection.Close();

                dataGridSelectedEmployee.ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
