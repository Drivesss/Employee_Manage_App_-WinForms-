using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Employee_Manage_App__WinForms_
{
    public partial class applicantWindow : Form
    {
        string id;
        DateTimePicker dateTimePicker;
        public applicantWindow()
        {
            InitializeComponent();
        }


        private void applicantWindow_Load(object sender, EventArgs e)
        {
            this.applicantTableAdapter.Fill(this.employeeManageAppDBDataSet.applicant);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                applicantBindingSource.EndEdit();

                // Create the UpdateCommand.
                SqlCommand command = new SqlCommand("UPDATE applicant SET LastName = @LastName, FirstName = @FirstName, MiddleName = @MiddleName, DateOfBirth = @DateOfBirth, Education = @Education WHERE ID = @ID");
                command.Connection = applicantTableAdapter.Connection;
                         
                command.Parameters.AddWithValue("@ID", dataGridApplicant[0, dataGridApplicant.CurrentRow.Index].Value.ToString());
                command.Parameters.AddWithValue("@LastName", dataGridApplicant[1, dataGridApplicant.CurrentRow.Index].Value.ToString());
                command.Parameters.AddWithValue("@FirstName", dataGridApplicant[2, dataGridApplicant.CurrentRow.Index].Value.ToString());
                command.Parameters.AddWithValue("@MiddleName", dataGridApplicant[3, dataGridApplicant.CurrentRow.Index].Value.ToString());
                command.Parameters.AddWithValue("@DateOfBirth", dataGridApplicant[4, dataGridApplicant.CurrentRow.Index].Value.ToString());
                command.Parameters.AddWithValue("@Education", dataGridApplicant[5, dataGridApplicant.CurrentRow.Index].Value.ToString());

                applicantTableAdapter.Adapter.UpdateCommand = command;

                // Create the DeleteCommand.
                SqlCommand command1 = new SqlCommand("DELETE FROM applicant WHERE ID = @ID");
                command1.Connection = applicantTableAdapter.Connection;

                command1.Parameters.AddWithValue("@ID", id);

                applicantTableAdapter.Adapter.DeleteCommand = command1;


                applicantTableAdapter.Update(this.employeeManageAppDBDataSet.applicant);
                MessageBox.Show("You have been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void dataGridApplicant_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    applicantBindingSource.RemoveCurrent();
                }
            }
        }

        private void dataGridApplicant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DatePicker TODO
            if(e.ColumnIndex == 4)
            {
                DateTimePicker dateTimePicker = new DateTimePicker();
                dataGridApplicant.Controls.Add(dateTimePicker);
                dateTimePicker.Format = DateTimePickerFormat.Short;
                Rectangle displayColendar = dataGridApplicant.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dateTimePicker.Size = new Size(displayColendar.Width, displayColendar.Height);
                dateTimePicker.Location = new Point(displayColendar.X, displayColendar.Y);
                dataGridApplicant[4, dataGridApplicant.CurrentRow.Index].Value = dateTimePicker.Text; //????????????????
            }
           

            id = dataGridApplicant[0, dataGridApplicant.CurrentRow.Index].Value.ToString();
        }
    }
}
