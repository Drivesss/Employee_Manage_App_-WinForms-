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
    public partial class positionWindow : Form
    {
        public positionWindow()
        {
            InitializeComponent();
        }

        private void positionWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeManageAppDBDataSet.position_employee". При необходимости она может быть перемещена или удалена.
            this.position_employeeTableAdapter.Fill(this.employeeManageAppDBDataSet.position_employee);

        }
    }
}
