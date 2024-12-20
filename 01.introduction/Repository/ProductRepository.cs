﻿using _01.introduction.Models;
using System.Collections.Generic;

namespace _01.introduction.Repository
{
    public class ProductRepository : IProductRepository
    {
        private List<ProductModel> products = new List<ProductModel>();
        public int AddProduct(ProductModel product)
        {
            product.Id = products.Count + 1;
            products.Add(product);

            return product.Id;
        }

        public List<ProductModel> GetAllProducts()
        {
            return products;
        }

        public string GetName()
        {
            return "Name from productRepo !";
        }
    }
}
