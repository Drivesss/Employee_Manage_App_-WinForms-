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
    public partial class structuralDivisionWindow : Form
    {
        public structuralDivisionWindow()
        {
            InitializeComponent();
        }

        private void structuralDivisionWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet.structural_division". При необходимости она может быть перемещена или удалена.
            this.structural_divisionTableAdapter.Fill(this.employeeManageAppDBDataSet.structural_division);

        }
    }
}
