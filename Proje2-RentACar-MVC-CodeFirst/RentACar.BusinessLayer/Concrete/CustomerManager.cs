using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.BusinessLayer.Abstract;
using RentACar.DataAccessLayer.Abstract;
using RentACar.EntityLayer.Concrete;

namespace RentACar.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
        }

        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
        }

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();
        }

        public Customer TGetByID(int id)
        {
            return _customerDal.GetByID(id);
        }
    }
}
