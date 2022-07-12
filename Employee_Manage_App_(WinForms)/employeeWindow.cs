using ClosedXML.Excel;
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
        string IdRowDataGrid;
        int IDcomboBoxPosition;
        int IDcomboBoxDivision;
        SqlConnection connection;
        public employeeWindow()
        {
            InitializeComponent();
        }

        private void employeeWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet6._employeeDataTable". При необходимости она может быть перемещена или удалена.
            this.employeeDataTableTableAdapter.Fill(this.employeeManageAppDBDataSet6._employeeDataTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet5._employeeDataTable". При необходимости она может быть перемещена или удалена.
            this.employeeDataTableTableAdapter.Fill(this.employeeManageAppDBDataSet5._employeeDataTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet4._employeeDataTable". При необходимости она может быть перемещена или удалена.
            this.employeeDataTableTableAdapter.Fill(this.employeeManageAppDBDataSet4._employeeDataTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet3._employeeDataTable". При необходимости она может быть перемещена или удалена.
            this.employeeDataTableTableAdapter.Fill(this.employeeManageAppDBDataSet3._employeeDataTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet2._employeeDataTable". При необходимости она может быть перемещена или удалена.
            this.employeeDataTableTableAdapter.Fill(this.employeeManageAppDBDataSet2._employeeDataTable);
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


            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sergeo\Desktop\EmployeeManageAppDB.mdf;Integrated Security=True;Connect Timeout=30");

        }

        //При выборе строки получает её индекс
        private void dataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdRowDataGrid = dataGridEmployee[0, dataGridEmployee.CurrentRow.Index].Value.ToString();
        }


        //Перенос из списка соискателй в сотрудники
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Получаем ID элемента ComboBox в таблице applicant SQL
            IDComboBox = ComBoxApplicant.SelectedValue.ToString();
            IDcomboBoxPosition = Int32.Parse(comboBoxPosition.SelectedValue.ToString());
            IDcomboBoxDivision = Int32.Parse(comboBoxDivision.SelectedValue.ToString());   


            //Добавляется сотрудник в таблицу employee SQL и отображается в dataGrid
            try
            {
               employeeBindingSource.EndEdit();

                string Work = "Работает";
                DateTime DateOfEmployment = DateTime.Now;


                // Команда добавления строки из applicant
                SqlCommand insertCommand = new SqlCommand(
                    "INSERT INTO employee (LastName, FirstName, MiddleName, DateOfBirth, Education, Status, DateOfEmployment, PositionEmployeeID, StructuralDivisionID) " +
                    "SELECT LastName, FirstName, MiddleName, DateOfBirth, Education, @Status, @DateOfEmployment, @PositionEmployeeID, @StructuralDivisionID FROM applicant " +
                    "WHERE id = @ID");
                insertCommand.Connection = employeeTableAdapter.Connection;

                //Открыл подключение к базе данных
                insertCommand.Connection.Open();

                insertCommand.Parameters.AddWithValue("@ID", IDComboBox);
                insertCommand.Parameters.AddWithValue("@Status", Work);
                insertCommand.Parameters.AddWithValue("@DateOfEmployment", DateOfEmployment);
                insertCommand.Parameters.AddWithValue("@PositionEmployeeID", IDcomboBoxPosition);
                insertCommand.Parameters.AddWithValue("@StructuralDivisionID", IDcomboBoxDivision);

                employeeTableAdapter.Adapter.InsertCommand = insertCommand;

                //Выполнил команду
                employeeTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();

                //Закрыл подключение к базе данных
                insertCommand.Connection.Close();

                employeeTableAdapter.Update(this.employeeManageAppDBDataSet.employee);


                //// Команда удаления из списка соискателей 
                //SqlCommand DeleteCommand = new SqlCommand("DELETE FROM applicant WHERE ID = @ID");
                //DeleteCommand.Connection = applicantTableAdapter.Connection;
                //DeleteCommand.Connection.Open();

                //DeleteCommand.Parameters.AddWithValue("@ID", IDComboBox);

                //applicantTableAdapter.Adapter.DeleteCommand = DeleteCommand;
                //applicantTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
                //DeleteCommand.Connection.Close();
                //applicantTableAdapter.Update(this.employeeManageAppDBDataSet.applicant);

                //Обновил данные в таблице
                employeeWindow_Load(sender, e);

                MessageBox.Show("Сотрудник добавлен", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //Увольнение сотрудника
        private void btnDismissal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите уволить сотрудника?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string Work = "Уволен";
                    DateTime DateOfDismissal = DateTime.Now;

                    //Сотрудник удаляется с позиции начальника подразделения
                    connection.Open();
                    SqlCommand UpdateBossCommand = new SqlCommand(
                        "UPDATE structural_division " +
                        "SET Boss = @Boss " +
                        "WHERE Name = @Name",connection);

                    UpdateBossCommand.Parameters.AddWithValue("@Boss", DBNull.Value);
                    UpdateBossCommand.Parameters.AddWithValue("@Name", dataGridEmployee[10, dataGridEmployee.CurrentRow.Index].Value.ToString());

                    UpdateBossCommand.ExecuteNonQuery();

                    connection.Close();

                    employeeBindingSource.EndEdit();

                    SqlCommand UpdateCommand = new SqlCommand(
                        "UPDATE employee " +
                        "SET Status = @Status, " +
                        "DateOfDismissal = @DateOfDismissal, " +
                        "PositionEmployeeID = @PositionEmployeeID, " +
                        "StructuralDivisionID = @StructuralDivisionID " +
                        "WHERE ID = @ID");

                    UpdateCommand.Connection = employeeTableAdapter.Connection;
                    UpdateCommand.Connection.Open();

                    UpdateCommand.Parameters.AddWithValue("@ID", IdRowDataGrid);
                    //Ставится статус "уволен"
                    UpdateCommand.Parameters.AddWithValue("@Status", Work);
                    //Ставится дата увольнения
                    UpdateCommand.Parameters.AddWithValue("@DateOfDismissal", DateOfDismissal);
                    //Удаляется должность
                    UpdateCommand.Parameters.AddWithValue("@PositionEmployeeID", DBNull.Value);
                    //Удаляется структурное подразделение
                    UpdateCommand.Parameters.AddWithValue("@StructuralDivisionID", DBNull.Value);

                    employeeTableAdapter.Adapter.UpdateCommand = UpdateCommand;
                    employeeTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();

                    UpdateCommand.Connection.Close();
                    employeeTableAdapter.Update(this.employeeManageAppDBDataSet.employee);

                    employeeWindow_Load(sender, e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        //Сохранение внесенных изменений в таблицу
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                applicantBindingSource.EndEdit();

                // Create the UpdateCommand.
                SqlCommand UpdateCommand = new SqlCommand(
                    "UPDATE employee " +
                    "SET LastName = @LastName, " +
                    "FirstName = @FirstName, " +
                    "MiddleName = @MiddleName, " +
                    "DateOfBirth = @DateOfBirth, " +
                    "Education = @Education " +
                    //"PositionEmployeeID = @PositionEmployeeID, " +
                    //"StructuralDivisionID = @StructuralDivisionID, " +
                    "WHERE ID = @ID");
                UpdateCommand.Connection = employeeTableAdapter.Connection;
                UpdateCommand.Connection.Open();

                UpdateCommand.Parameters.AddWithValue("@ID", IdRowDataGrid);
                UpdateCommand.Parameters.AddWithValue("@LastName", dataGridEmployee[1, dataGridEmployee.CurrentRow.Index].Value.ToString());
                UpdateCommand.Parameters.AddWithValue("@FirstName", dataGridEmployee[2, dataGridEmployee.CurrentRow.Index].Value.ToString());
                UpdateCommand.Parameters.AddWithValue("@MiddleName", dataGridEmployee[3, dataGridEmployee.CurrentRow.Index].Value.ToString());
                UpdateCommand.Parameters.AddWithValue("@DateOfBirth", dataGridEmployee[4, dataGridEmployee.CurrentRow.Index].Value.ToString());
                UpdateCommand.Parameters.AddWithValue("@Education", dataGridEmployee[5, dataGridEmployee.CurrentRow.Index].Value.ToString());
                //UpdateCommand.Parameters.AddWithValue("@PositionEmployeeID", dataGridEmployee[9, dataGridEmployee.CurrentRow.Index].Value.ToString());
                //UpdateCommand.Parameters.AddWithValue("@StructuralDivisionID", dataGridEmployee[10, dataGridEmployee.CurrentRow.Index].Value.ToString());

                employeeTableAdapter.Adapter.UpdateCommand = UpdateCommand;

                employeeTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                UpdateCommand.Connection.Close();
                employeeTableAdapter.Update(this.employeeManageAppDBDataSet.employee);
                employeeWindow_Load(sender, e);
                MessageBox.Show("Изменения сохранены", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Удаление строки сотрудника
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите удалить строку?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    applicantBindingSource.EndEdit();

                    SqlCommand DeleteCommand = new SqlCommand("DELETE FROM employee WHERE ID = @ID");
                    DeleteCommand.Connection = applicantTableAdapter.Connection;
                    DeleteCommand.Connection.Open();

                    DeleteCommand.Parameters.AddWithValue("@ID", IdRowDataGrid);

                    employeeTableAdapter.Adapter.DeleteCommand = DeleteCommand;
                    employeeTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
                    DeleteCommand.Connection.Close();
                    employeeTableAdapter.Update(this.employeeManageAppDBDataSet.employee);
                    employeeWindow_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDismissalEmployeeView_Click(object sender, EventArgs e)
        {
            Form DismissalEmployeeWindow = new DismissalEmployeeWindow();
            DismissalEmployeeWindow.ShowDialog();
            
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.employeeManageAppDBDataSet.employee.CopyToDataTable(), "employee");
                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("Данные в Excel успешно сохранены","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
