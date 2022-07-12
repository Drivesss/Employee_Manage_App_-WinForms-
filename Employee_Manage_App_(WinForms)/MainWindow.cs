using ClosedXML.Excel;
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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void applicantButton_Click(object sender, EventArgs e)
        {
            Form applicantWindow = new applicantWindow();
            applicantWindow.ShowDialog();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            Form employeeWindow = new employeeWindow();
            employeeWindow.ShowDialog();    
        }

        private void positionEmployeeButton_Click(object sender, EventArgs e)
        {
            Form positionEmployeeWindow = new positionWindow();
            positionEmployeeWindow.ShowDialog();
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            Form structuralDivisionWindow = new structuralDivisionWindow();
            structuralDivisionWindow.ShowDialog();
        }


    }
}
