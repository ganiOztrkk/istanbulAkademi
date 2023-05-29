namespace CQRS_Postgre.CQRSPattern.Results
{
    public class GetEmployeeByIDQueryResult
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string EmployeeSurname { get; set; } = string.Empty;
        public string EmployeeTitle { get; set; } = string.Empty;
    }
}
