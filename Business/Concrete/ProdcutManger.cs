using Business.Abstrack;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProdcutManger : IProductService
    {
        IProductDal _prodcutDal;
        public ProdcutManger(IProductDal productDal)
        {
            _prodcutDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _prodcutDal.GetAll();
           
        }
              public List<Product> GetAllByCategoryId(int id)
        {
            return _prodcutDal.GetAll(p=>p.CategoryId==id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _prodcutDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}
