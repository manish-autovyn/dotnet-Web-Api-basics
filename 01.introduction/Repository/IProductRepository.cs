using _01.introduction.Models;
using System.Collections.Generic;

namespace _01.introduction.Repository
{
    public interface IProductRepository
    {
        int AddProduct(ProductModel product);
        List<ProductModel> GetAllProducts();

        string GetName();
    }
}