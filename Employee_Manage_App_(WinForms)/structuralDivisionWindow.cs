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


            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet.DivisionJoinBossName". При необходимости она может быть перемещена или удалена.
                this.divisionJoinBossNameTableAdapter.Fill(this.employeeManageAppDBDataSet.DivisionJoinBossName);
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

        private void dataGridDivision_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdRowDataGrid = dataGridDivision[0, dataGridDivision.CurrentRow.Index].Value.ToString();
        }

        //Вывод сотрудников в подразделении 
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

        //Добавление начальниа подразделения
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

        //Удаление начальника подразделения
        private void btnDeleteBoss_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand UpdateBossCommand = new SqlCommand(
                    "UPDATE structural_division " +
                    "SET Boss = @Boss " +
                    "WHERE ID = @ID", connection);

                UpdateBossCommand.Parameters.AddWithValue("@Boss", DBNull.Value);
                UpdateBossCommand.Parameters.AddWithValue("@ID", Int32.Parse(comboBoxDivision.SelectedValue.ToString()));

                UpdateBossCommand.ExecuteNonQuery();

                connection.Close();
                structuralDivisionWindow_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Добавление отдела
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                SqlCommand addCommand = new SqlCommand("INSERT INTO structural_division (Name) VALUES(@Name)", connection);
                addCommand.Parameters.AddWithValue("@Name", dataGridDivision[1, dataGridDivision.CurrentRow.Index].Value.ToString());
                addCommand.ExecuteNonQuery();

                connection.Close();

                structuralDivisionWindow_Load(sender, e);

                MessageBox.Show("Подразделение добавлено", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Сохранение изменеий в названии отдела
        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("UPDATE structural_division SET Name = @Name WHERE ID = @ID",connection);

                command.Parameters.AddWithValue("@ID", dataGridDivision[0, dataGridDivision.CurrentRow.Index].Value.ToString());
                command.Parameters.AddWithValue("@Name", dataGridDivision[1, dataGridDivision.CurrentRow.Index].Value.ToString());

                command.ExecuteNonQuery();

                connection.Close();

                structuralDivisionWindow_Load(sender, e);

                MessageBox.Show("Изменения сохранены", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        //Удаление отдела
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите удалить подразделение?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                    == DialogResult.Yes)
                {
                    connection.Open();

                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM structural_division WHERE ID = @ID", connection);
                    deleteCommand.Parameters.AddWithValue("@ID", IdRowDataGrid);
                    deleteCommand.ExecuteNonQuery();

                    connection.Close();

                    structuralDivisionWindow_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
