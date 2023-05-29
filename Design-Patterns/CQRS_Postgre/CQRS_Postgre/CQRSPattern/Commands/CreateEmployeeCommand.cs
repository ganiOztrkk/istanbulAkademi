namespace CQRS_Postgre.CQRSPattern.Commands
{
    public class CreateEmployeeCommand
    {
        public string EmployeeName { get; set; } = string.Empty;
        public string EmployeeSurname { get; set; } = string.Empty;
        public string EmployeeTitle { get; set; } = string.Empty;
        public int EmployeeAge { get; set; }
        public string EmployeeCity { get; set; } = string.Empty;
        public decimal EmployeeSalary { get; set; }
    }
}
