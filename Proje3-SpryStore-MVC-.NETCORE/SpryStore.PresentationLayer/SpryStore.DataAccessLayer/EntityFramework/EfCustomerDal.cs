using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpryStore.DataAccessLayer.Abstract;
using SpryStore.DataAccessLayer.Concrete;
using SpryStore.DataAccessLayer.Repositories;
using SpryStore.EntityLayer.Concrete;

namespace SpryStore.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public List<Customer> GetEmployeeWithName()
        {
            var context = new Context();
            return context.Customers.Include(x => x.Employee).ToList();
        }
    }
}
