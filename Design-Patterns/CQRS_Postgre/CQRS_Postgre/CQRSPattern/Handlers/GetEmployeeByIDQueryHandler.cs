using CQRS_Postgre.CQRSPattern.Queries;
using CQRS_Postgre.CQRSPattern.Results;
using CQRS_Postgre.DAL;

namespace CQRS_Postgre.CQRSPattern.Handlers
{
    public class GetEmployeeByIDQueryHandler
    {
        private readonly Context _context;

        public GetEmployeeByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetEmployeeByIDQueryResult Handle(GetEmployeeByIDQuery query)
        {
            var values = _context.Set<Employee>().Find(query.Id);
            return new GetEmployeeByIDQueryResult()
            {
                EmployeeID = values.EmployeeID,
                EmployeeTitle = values.EmployeeTitle,
                EmployeeName = values.EmployeeName,
                EmployeeSurname = values.EmployeeSurname
            };
        }
    }
}
