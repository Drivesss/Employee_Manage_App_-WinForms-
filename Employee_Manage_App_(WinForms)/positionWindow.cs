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
        public positionWindow()
        {
            InitializeComponent();
        }

        private void positionWindow_Load(object sender, EventArgs e)
        {
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

        }
    }
}
