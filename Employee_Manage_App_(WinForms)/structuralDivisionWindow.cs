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
    public partial class structuralDivisionWindow : Form
    {
        string IdRowDataGrid;
        int IDDivisionComBox;
        SqlConnection connection;
        public structuralDivisionWindow()
        {
            InitializeComponent();
        }

        private void structuralDivisionWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet7.structural_division_boss_join". При необходимости она может быть перемещена или удалена.
            this.structural_division_boss_joinTableAdapter.Fill(this.employeeManageAppDBDataSet7.structural_division_boss_join);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet6.structural_division_boss_join". При необходимости она может быть перемещена или удалена.
            this.structural_division_boss_joinTableAdapter.Fill(this.employeeManageAppDBDataSet6.structural_division_boss_join);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet5.structural_division_boss_join". При необходимости она может быть перемещена или удалена.
            this.structural_division_boss_joinTableAdapter.Fill(this.employeeManageAppDBDataSet5.structural_division_boss_join);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet4.structural_division_boss_join". При необходимости она может быть перемещена или удалена.
            this.structural_division_boss_joinTableAdapter.Fill(this.employeeManageAppDBDataSet4.structural_division_boss_join);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet3.structural_division_boss_join". При необходимости она может быть перемещена или удалена.
            this.structural_division_boss_joinTableAdapter.Fill(this.employeeManageAppDBDataSet3.structural_division_boss_join);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet.structural_division_boss_join". При необходимости она может быть перемещена или удалена.
            this.structural_division_boss_joinTableAdapter.Fill(this.employeeManageAppDBDataSet.structural_division_boss_join);
            try
            {


                // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet1.employeeBossComBox". При необходимости она может быть перемещена или удалена.
                this.employeeBossComBoxTableAdapter.Fill(this.employeeManageAppDBDataSet1.employeeBossComBox);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet.employee". При необходимости она может быть перемещена или удалена.
                this.employeeTableAdapter.Fill(this.employeeManageAppDBDataSet.employee);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet.structural_division". При необходимости она может быть перемещена или удалена.
                this.structural_divisionTableAdapter.Fill(this.employeeManageAppDBDataSet.structural_division);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sergeo\Desktop\EmployeeManageAppDB.mdf;Integrated Security=True;Connect Timeout=30");

        }


        //Сохранение изменеий в названии отдела
        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                //structuraldivisionBindingSource.EndEdit();
                structuraldivisionbossjoinBindingSource5.EndEdit(); 

                // Create the UpdateCommand.
                SqlCommand command = new SqlCommand("UPDATE structural_division SET Name = @Name WHERE ID = @ID");
                command.Connection = structural_divisionTableAdapter.Connection;

                command.Parameters.AddWithValue("@ID", dataGridDivision[0, dataGridDivision.CurrentRow.Index].Value.ToString());
                command.Parameters.AddWithValue("@Name", dataGridDivision[1, dataGridDivision.CurrentRow.Index].Value.ToString());

                structural_divisionTableAdapter.Adapter.UpdateCommand = command;

                // Create the DeleteCommand.
                SqlCommand command1 = new SqlCommand("DELETE FROM structural_division WHERE ID = @ID");
                command1.Connection = structural_divisionTableAdapter.Connection;

                command1.Parameters.AddWithValue("@ID", IdRowDataGrid);

                structural_divisionTableAdapter.Adapter.DeleteCommand = command1;

                structural_divisionTableAdapter.Update(this.employeeManageAppDBDataSet.structural_division);
                MessageBox.Show("Изменения сохранены", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void dataGridDivision_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdRowDataGrid = dataGridDivision[0, dataGridDivision.CurrentRow.Index].Value.ToString();
        }

        private void comboBoxDivision_SelectionChangeCommitted(object sender, EventArgs e)
        {
            IDDivisionComBox = Int32.Parse(comboBoxDivision.SelectedValue.ToString());

            try
            {
                connection.Open();

                SqlCommand select = new SqlCommand(
                    "SELECT " +
                    "employee.LastName AS Фамилия, " +
                    "employee.FirstName AS Имя, " +
                    "employee.MiddleName AS Отчество, " +
                    "employee.DateOfBirth AS [Дата рождения], " +
                    "employee.Education AS Образование, " +
                    "employee.Status AS Статус, " +
                    "employee.DateOfEmployment AS [Дата трудоустройства], " +
                    "position_employee.Name AS Должность, " +
                    "structural_division.Name AS [Структурное подразделение] " +
                    "FROM employee " +
                    "INNER JOIN position_employee ON employee.PositionEmployeeID = position_employee.ID " +
                    "INNER JOIN structural_division ON employee.StructuralDivisionID = structural_division.ID " +
                    "WHERE(structural_division.ID = @IDDivisionComBox)", connection);

                select.Parameters.AddWithValue("@IDDivisionComBox", IDDivisionComBox);

                SqlDataAdapter adapter = new SqlDataAdapter(select);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridDivisionEmployee.DataSource = ds.Tables[0];

                connection.Close();

                dataGridDivisionEmployee.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnSaveBoss_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand update = new SqlCommand("UPDATE structural_division SET Boss = @IDcomboBoxBossEmployee WHERE(ID = @ID)", connection);

                update.Parameters.AddWithValue("@IDcomboBoxBossEmployee", Int32.Parse(comboBoxBossEmployee.SelectedValue.ToString()));
                update.Parameters.AddWithValue("@ID", comboBoxDivision.SelectedValue.ToString());
                update.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            structuralDivisionWindow_Load(sender, e);
        }
    }
}
