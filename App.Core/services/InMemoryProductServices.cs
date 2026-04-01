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
        public Product Add(Product product)
        {
            if (product != null)
            {
                product.Id = GenerateId();
                _products.Add(product);

            }
            return product;
        }
        public bool Update(Product product)
        {
            
            Product? existing = _products.Find(p => p.Id == product.Id);
            if (existing != null) return false;
            
            existing.Name = product.Name;
            existing.Category = product.Category;
            existing.Price = product.Price;
            existing.Status = product.Status;
            existing.Stock = product.Stock;

            return true;
        }
        public bool Delete(string id)
        {
            Product prodToBeDeleted  = GetById(id);
            _products.Remove(prodToBeDeleted);
            return true;
        }
        public Product GetById(string id)
        {
            Product? prod = _products.Find(p => p.Id == id);
            return prod;
        }
        public List<Product> GetAll()
        {
           return _products.OrderBy(p => p.Name).ToList();
        }
        public List<Product> Search(string text, ProductsCategoryEnum? category, ProductsStatusEnum? status)
        {
            List<Product> _filtered = _products.ToList();
          _filtered =  _filtered.Where(p => p.Name.Contains(text)).ToList();
            if(category is not null) {
            _filtered = _filtered.Where(p => p.Category == category).ToList();
            }
            if (status is not null)
            {
                _filtered = _filtered.Where(p => p.Status == status).ToList();
            }
                return _filtered;
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
