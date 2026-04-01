using App.Core.models;
using App.Core.utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.contracts
{
    public interface IProductServices
    {
        public Product Add(Product products);
        public bool Update(Product products);
        public bool Delete(string id);
        public Product GetById(string id);
        public List<Product> GetAll();
        public List<Product> Search(string text, ProductsCategoryEnum? category, ProductsStatusEnum? status);
    }
}
