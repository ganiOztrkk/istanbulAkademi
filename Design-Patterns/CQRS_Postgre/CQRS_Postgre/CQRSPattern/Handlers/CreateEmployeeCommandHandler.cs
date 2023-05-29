using CQRS_Postgre.CQRSPattern.Commands;
using CQRS_Postgre.DAL;

namespace CQRS_Postgre.CQRSPattern.Handlers
{
    public class CreateEmployeeCommandHandler
    {
        private readonly Context _context;

        public CreateEmployeeCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateEmployeeCommand command)
        {
            _context.Employees.Add(new Employee()
            {
                EmployeeAge = command.EmployeeAge,
                EmployeeCity = command.EmployeeCity,
                EmployeeName = command.EmployeeName,
                EmployeeSalary = command.EmployeeSalary,
                EmployeeSurname = command.EmployeeSurname,
                EmployeeTitle = command.EmployeeTitle
            });
            _context.SaveChanges();
        }
    }
}
