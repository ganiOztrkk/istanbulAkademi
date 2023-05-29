using CQRS_Postgre.CQRSPattern.Commands;
using CQRS_Postgre.DAL;

namespace CQRS_Postgre.CQRSPattern.Handlers
{
    public class UpdateEmployeeCommandHandler
    {
        private readonly Context _context;

        public UpdateEmployeeCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateEmployeeCommand command)
        {
            var values = _context.Employees.Find(command.EmployeeID);
            if (values != null)
            {
                values.EmployeeSurname = command.EmployeeSurname;
                values.EmployeeName = command.EmployeeName;
                values.EmployeeCity = command.EmployeeCity;
                values.EmployeeSalary = command.EmployeeSalary;
                values.EmployeeAge = command.EmployeeAge;
                values.EmployeeTitle = command.EmployeeTitle;
                _context.SaveChanges();
            }
        }
    }
}
