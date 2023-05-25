using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusApi.BusinessLayer.Abstract;
using AkademiPlusApi.DataAccsessLayer.Abstract;
using AkademiPlusApi.EntityLayer.Concrete;

namespace AkademiPlusApi.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TInsert(Customer entity)
        {
            _customerDal.Insert(entity);
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public void TUpdate(Customer entity)
        {
            _customerDal.Update(entity);
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
