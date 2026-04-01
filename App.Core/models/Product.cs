using App.Core.utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ProductsCategoryEnum Category { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }


        public ProductsStatusEnum Status { get; set; }
    }
}
