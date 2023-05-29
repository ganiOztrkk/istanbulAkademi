using CQRS_Postgre.CQRSPattern.Results;
using CQRS_Postgre.DAL;

namespace CQRS_Postgre.CQRSPattern.Handlers
{
    public class GetEmployeeQueryHandler
    {
        private readonly Context _context;

        public GetEmployeeQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetEmployeeQueryResult> Handle()
        {
            var values = _context.Employees.Select(x => new GetEmployeeQueryResult()
            {
                EmployeeAge = x.EmployeeAge,
                EmployeeName = x.EmployeeName,
                EmployeeCity = x.EmployeeCity,
                EmployeeID = x.EmployeeID,
                EmployeeSalary = x.EmployeeSalary,
                EmployeeSurname = x.EmployeeSurname,
                EmployeeTitle = x.EmployeeTitle
            }).ToList();
            return values;
        }
    }
}
