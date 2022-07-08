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
    public partial class DismissalEmployeeWindow : Form
    {
        SqlConnection connection;
        public DismissalEmployeeWindow()
        {
            InitializeComponent();
        }

        private void DismissalEmployeeWindow_Load(object sender, EventArgs e)
        {
            string work = "Уволен";
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sergeo\Desktop\EmployeeManageAppDB.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand select = new SqlCommand(
                "SELECT " +
                "LastName AS Фамилия, " +
                "FirstName AS Имя, " +
                "MiddleName AS Отчество, " +
                "DateOfBirth AS [Дата рождения], " +
                "Education AS Образование, " +
                "Status AS Статус, " +
                "DateOfEmployment AS [Дата трудоустройства], " +
                "DateOfDismissal AS [Дата увольнения] " +
                "FROM employee " +
                "WHERE(Status = @Status)", connection);

            select.Parameters.AddWithValue("@Status", work);

            SqlDataAdapter adapter = new SqlDataAdapter(select);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridDismissalEmployeeView.DataSource = ds.Tables[0];

            connection.Close();

            dataGridDismissalEmployeeView.ReadOnly = true;

            this.dataGridDismissalEmployeeView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
