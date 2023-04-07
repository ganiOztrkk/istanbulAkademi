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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TInsert(Product t)
        {
            if (t.ProductName != "" && t.ProductName.Length is >= 5 and <= 20)
            {
                _productDal.Insert(t);
            }
            else
            {
                //hata mesajı
            }
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }

        public Product TGetByID(int id)
        {
            return _productDal.GetByID(id);
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

        public List<Product> TGetProductListWithCategory()
        {
            return _productDal.GetProductListWithCategory();
        }

        public List<Product> TGetLast4Product()
        {
            return _productDal.GetLast4Product();
        }
    }
}
