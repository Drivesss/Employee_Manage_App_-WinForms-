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
        public structuralDivisionWindow()
        {
            InitializeComponent();
        }

        private void structuralDivisionWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet1.employeeBossComBox". При необходимости она может быть перемещена или удалена.
            this.employeeBossComBoxTableAdapter.Fill(this.employeeManageAppDBDataSet1.employeeBossComBox);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.employeeManageAppDBDataSet.employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet.structural_division". При необходимости она может быть перемещена или удалена.
            this.structural_divisionTableAdapter.Fill(this.employeeManageAppDBDataSet.structural_division);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                structuraldivisionBindingSource.EndEdit();

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
    }
}
