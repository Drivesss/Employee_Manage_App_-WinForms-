using System;

namespace Employee_Manage_App__WinForms_.Model
{
    internal class EmployeeClass
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Education { get; set; }
        public string Status { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public DateTime DateOfDismissal { get; set; }
        public StructuralDivisionClass Division { get; set; }
        public PositionEmployeeClass Position { get; set; }

    }
}
