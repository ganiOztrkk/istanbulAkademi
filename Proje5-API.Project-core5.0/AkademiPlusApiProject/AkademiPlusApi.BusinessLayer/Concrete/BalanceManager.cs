using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusApi.BusinessLayer.Abstract;
using AkademiPlusApi.DataAccessLayer.Abstract;
using AkademiPlusApi.EntityLayer.Concrete;

namespace AkademiPlusApi.BusinessLayer.Concrete
{
    public class BalanceManager : IBalanceService
    {
        private readonly IBalanceDal _balanceDal;

        public BalanceManager(IBalanceDal balanceDal)
        {
            _balanceDal = balanceDal;
        }

        public void TInsert(Balance t)
        {
            _balanceDal.Insert(t);
        }

        public void TDelete(Balance t)
        {
            _balanceDal.Delete(t);
        }

        public void TUpdate(Balance t)
        {
            _balanceDal.Update(t);
        }

        public List<Balance> TGetList()
        {
            return _balanceDal.GetList();
        }

        public Balance TGetByID(int id)
        {
            return _balanceDal.GetByID(id);
        }
    }
}
