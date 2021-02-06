using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstrack;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
            new Product{ProductId=1,CategoryId=1,ProductName="Bardak 6'lı parça",UnitPrice=15,UnitsInStock=15},
             new Product{ProductId=2,CategoryId=2,ProductName="Telefon Galaxy S8",UnitPrice=500,UnitsInStock=3},
              new Product{ProductId=3,CategoryId=3,ProductName="Klavye Logitech G6",UnitPrice=1500,UnitsInStock=2},
               new Product{ProductId=4,CategoryId=4,ProductName="Mouse Apple Touch",UnitPrice=150,UnitsInStock=65},
                new Product{ProductId=5,CategoryId=5,ProductName="Kamere Cannon UV89",UnitPrice=80,UnitsInStock=1}

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product producToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);//tek bir elemana bulmaya yarar//
                                                                                                      //=> İŞARETİ HER BİR P İÇİN DEMEK
            _products.Remove(producToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product producToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);//tek bir elemana bulmaya yarar//
                                                                                                      //=> İŞARETİ HER BİR P İÇİN DEMEK
            producToUpdate.ProductName = product.ProductName;
            producToUpdate.UnitPrice = product.UnitPrice;
            producToUpdate.CategoryId = product.CategoryId;
            producToUpdate.UnitsInStock = product.UnitsInStock;
        }
       public List<Product> GetAllCategory(int categoryId){
          return  _products.Where(p => p.CategoryId == categoryId).ToList();
        }//sql select custemerId from customers dedigin zaman sana yeni liste veriyor ya buda aynı işlemi görüyor   

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get()
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
