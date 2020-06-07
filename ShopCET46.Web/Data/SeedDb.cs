using ShopCET46.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCET46.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private Random _random;

        public SeedDb(DataContext context)
        {
            _context = context;
            _random = new Random();
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            if (!_context.Products.Any())
            {
                this.AddProduct("Boné do Glorioso");
                this.AddProduct("Cuecas do Glorioso");
                this.AddProduct("Biquini do Glorioso");
                await _context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name)
        {
            _context.Products.Add(new Product
            {
                Name = name,
                Price = _random.Next(500),
                IsAvailable = true,
                Stock = _random.Next(1000)
            });
        }
    }
}
