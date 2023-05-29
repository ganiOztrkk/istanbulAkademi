using CQRS_Postgre.CQRSPattern.Queries;
using CQRS_Postgre.CQRSPattern.Results;
using CQRS_Postgre.DAL;

namespace CQRS_Postgre.CQRSPattern.Handlers
{
    public class GetEmployeeUpdateByIDQueryHandler
    {
        private readonly Context _context;

        public GetEmployeeUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetEmployeeUpdateQueryResult Handle(GetEmployeeUpdateByIDQuery query)
        {
            var values = _context.Employees.Find(query.Id);
            return new GetEmployeeUpdateQueryResult()
            {
                EmployeeAge = values.EmployeeAge,
                EmployeeName = values.EmployeeName,
                EmployeeCity = values.EmployeeCity,
                EmployeeID = values.EmployeeID,
                EmployeeSalary = values.EmployeeSalary,
                EmployeeSurname = values.EmployeeSurname,
                EmployeeTitle = values.EmployeeTitle
            };
        }
    }
}
