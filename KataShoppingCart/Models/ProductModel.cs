using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KataShoppingCart.Models
{
    public class ProductModel
    {
        private List<Product> products;

        public ProductModel()
        {
            this.products = new List<Product>() {
                new Product {
                    Id = "A",
                    Name = "Vauxhall",
                    Price = 10
                },
                new Product {
                    Id = "B",
                    Name = "Ford",
                    Price = 15
                },
                new Product {
                    Id = "C",
                    Name = "Nissan",
                    Price = 40
                },
                new Product {
                    Id = "D",
                    Name = "Tesla",
                    Price = 55
                }
            };
        }

        public List<Product> findAll()
        {
            return this.products;
        }

        public Product find(string id)
        {
            return this.products.Single(p => p.Id.Equals(id));
        }

    }
}