using System;
using System.Collections.Generic;
using System.Text;

using Entities.Concrete;

namespace DataAccess.Abstract
{
   public interface IProductDal
    {
        List<Product> GetAll();
        List<Product> GetById(string brandId);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
    }
}
