using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusApi.BusinessLayer.Abstract;
using AkademiPlusApi.DataAccsessLayer.Abstract;
using AkademiPlusApi.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace AkademiPlusApi.BusinessLayer.Concrete
{
    public class BalanceManager : IBalanceService
    {
        private readonly IBalanceDal _balanceDal;

        public BalanceManager(IBalanceDal balanceDal)
        {
            _balanceDal = balanceDal;
        }

        public void TInsert(Balance entity)
        {
            _balanceDal.Insert(entity);
        }

        public void TDelete(Balance entity)
        {
            _balanceDal.Delete(entity);
        }

        public void TUpdate(Balance entity)
        {
            _balanceDal.Update(entity);
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
