using App.Core.contracts;
using App.Core.models;
using App.Core.services;

using App.Core.utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.services
{
    public class InMemoryProductServices : IProductServices
    {
        private List<Product> _products;
        public InMemoryProductServices()
        {
            _products = new List<Product>();
            GenerateFakeProducts();
        }
        public Product Add(Product products)
        {
            throw new NotImplementedException();
        }
        public bool Update(Product products)
        {
            return false;
        }
        public bool Delete(string id)
        {
            return false;
        }
        public Product GetById(string id)
        {
            throw new NotImplementedException();
        }
        public List<Product> GetAll()
        {
           return _products.OrderBy(p => p.Name).ToList();
        }
        public List<Product> Search(string text, ProductsCategoryEnum? category, ProductsStatusEnum? status)
        {
            throw new NotImplementedException();
        }

        public void GenerateFakeProducts()
        {
            _products.Clear();
            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Laptop",
                Category = ProductsCategoryEnum.Electronics,
                Price = 15000.00m,
                Stock = 10,
                Status = ProductsStatusEnum.Active,

            });
            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Usb-C Cables",
                Category = ProductsCategoryEnum.Clothing,
                Price = 4500m,
                Stock = 10,
                Status = ProductsStatusEnum.Active,

            });
        }
        private string GenerateId()
        {
            return "P-" + Guid.NewGuid().ToString("N").Substring(0, 6);
        }
    }
}
