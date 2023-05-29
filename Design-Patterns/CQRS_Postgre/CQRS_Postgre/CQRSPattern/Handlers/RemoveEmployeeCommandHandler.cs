using CQRS_Postgre.CQRSPattern.Commands;
using CQRS_Postgre.DAL;

namespace CQRS_Postgre.CQRSPattern.Handlers
{
    public class RemoveEmployeeCommandHandler
    {
        private readonly Context _context;

        public RemoveEmployeeCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveEmployeeCommand command)
        {
            var values = _context.Employees.Find(command.Id);
            if (values != null)
            {
                _context.Employees.Remove(values);
                _context.SaveChanges();
            }
        }
    }
}
