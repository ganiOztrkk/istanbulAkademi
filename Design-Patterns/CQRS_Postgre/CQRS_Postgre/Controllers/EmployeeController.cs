using CQRS_Postgre.CQRSPattern.Commands;
using CQRS_Postgre.CQRSPattern.Handlers;
using CQRS_Postgre.CQRSPattern.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Postgre.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly GetEmployeeQueryHandler _handler;
        private readonly GetEmployeeByIDQueryHandler _handlerId;
        private readonly CreateEmployeeCommandHandler _handlerCreateEmployee;
        private readonly RemoveEmployeeCommandHandler _handlerRemoveEmployee;
        private readonly GetEmployeeUpdateByIDQueryHandler _handlerGetEmployee;
        private readonly UpdateEmployeeCommandHandler _handlerUpdateEmployee;

        public EmployeeController(GetEmployeeQueryHandler handler, GetEmployeeByIDQueryHandler handlerId, CreateEmployeeCommandHandler handlerCreateEmployee, RemoveEmployeeCommandHandler handlerRemoveEmployee, GetEmployeeUpdateByIDQueryHandler handlerGetEmployee, UpdateEmployeeCommandHandler handlerUpdateEmployee)
        {
            _handler = handler;
            _handlerId = handlerId;
            _handlerCreateEmployee = handlerCreateEmployee;
            _handlerRemoveEmployee = handlerRemoveEmployee;
            _handlerGetEmployee = handlerGetEmployee;
            _handlerUpdateEmployee = handlerUpdateEmployee;
        }

        public IActionResult Index()
        {
            var values = _handler.Handle();
            return View(values);
        }

        public IActionResult EmployeeDetails(int id)
        {
            var values = _handlerId.Handle(new GetEmployeeByIDQuery(id));
            return View(values);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(CreateEmployeeCommand command)
        {
            _handlerCreateEmployee.Handle(command);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteEmployee(int id)
        {
            _handlerRemoveEmployee.Handle(new RemoveEmployeeCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateEmployee(int id)
        {
            var value = _handlerGetEmployee.Handle(new GetEmployeeUpdateByIDQuery(id));
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateEmployee(UpdateEmployeeCommand command)
        {
            _handlerUpdateEmployee.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
