﻿using ShopCET46.Web.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopCET46.Web.Data
{
    public interface IRepository
    {
        void AddProduct(Product product);
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts();
        bool ProductExists(int id);
        void RemoveProduct(Product product);
        Task<bool> SaveAllAsync();
        void UpdateProduct(Product product);
    }
}