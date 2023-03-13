using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.EntityLayer.Concrete;

namespace RentACar.DataAccessLayer.Abstract
{
    public interface ICarDal : IGenericDal<Car>
    {
        void CarListByBrand();
    }
}
