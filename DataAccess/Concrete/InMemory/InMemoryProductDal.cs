using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccess.Abstract;

using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product{ProductId=1, BrandId="Fiat", ColorId="Beyaz", DailyPrice=350, ModelYear=2019, Description="Ticari"},
             new Product{ProductId=2, BrandId="Ford", ColorId="Siyah", DailyPrice=375 ,ModelYear=2020 ,Description="Ticari"},
              new Product{ProductId=3, BrandId="Peugeot", ColorId="Metalik Gri", DailyPrice=300, ModelYear=2018, Description="Sahis"},
               new Product{ProductId=4, BrandId="Man", ColorId="Beyaz", DailyPrice=800 ,ModelYear=2019, Description="Otobus"}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete); 
        }

        public List<Product> GetAll()
        {
            return _products; 
        }

        public List<Product> GetById(string brandId)
        {
            return _products.Where(p => p.BrandId == brandId).ToList();
        }

        public void Update(Product product)
        {
            //Id bazli yapilarda singleordefault kullanmak daha uygun bir yol
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.ColorId = product.ColorId;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.ModelYear = product.ModelYear;
            productToUpdate.Description = product.Description;
        }
    }
}
