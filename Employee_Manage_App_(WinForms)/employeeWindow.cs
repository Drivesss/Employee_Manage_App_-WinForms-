using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Manage_App__WinForms_
{
    public partial class employeeWindow : Form
    {
        public employeeWindow()
        {
            InitializeComponent();
        }

        private void employeeWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet.applicant1". При необходимости она может быть перемещена или удалена.
            this.applicant1TableAdapter.Fill(this.employeeManageAppDBDataSet.applicant1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet.structural_division". При необходимости она может быть перемещена или удалена.
            this.structural_divisionTableAdapter.Fill(this.employeeManageAppDBDataSet.structural_division);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet.position_employee". При необходимости она может быть перемещена или удалена.
            this.position_employeeTableAdapter.Fill(this.employeeManageAppDBDataSet.position_employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet.applicant". При необходимости она может быть перемещена или удалена.
            this.applicantTableAdapter.Fill(this.employeeManageAppDBDataSet.applicant);

        }
    }
}
