using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpryStore.BusinessLayer.Abstract;
using SpryStore.DataAccessLayer.Abstract;
using SpryStore.EntityLayer.Concrete;

namespace SpryStore.BusinessLayer.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void TInsert(Employee t)
        {
            _employeeDal.Insert(t);
        }

        public void TDelete(Employee t)
        {
            _employeeDal.Delete(t);
        }

        public void TUpdate(Employee t)
        {
            _employeeDal.Update(t);
        }

        public Employee TGetByID(int id)
        {
            return _employeeDal.GetByID(id);
        }

        public List<Employee> TGetList()
        {
            return _employeeDal.GetList();
        }
    }
}
