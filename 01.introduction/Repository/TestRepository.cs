using _01.introduction.Models;
using System.Collections.Generic;

namespace _01.introduction.Repository
{
    public class TestRepository : IProductRepository
    {
        public int AddProduct(ProductModel product)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        public string GetName()
        {
            return "get name from testrepo";
        }
    }
}
