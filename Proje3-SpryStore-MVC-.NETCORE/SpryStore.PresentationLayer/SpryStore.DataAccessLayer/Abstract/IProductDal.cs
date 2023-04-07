using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpryStore.EntityLayer.Concrete;

namespace SpryStore.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductListWithCategory();
        List<Product> GetLast4Product();

    }
}
