using Microsoft.AspNetCore.Identity;
using ShopCET46.Web.Data.Entities;
using ShopCET46.Web.Helpers;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCET46.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;
        private readonly Random _random;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
            _random = new Random();
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            var user = await _userHelper.GetUserByEmailAsync("ricardo.formando.cinel@gmail.com");
            if(user == null)
            {
                user = new User
                {
                    FirstName = "Rafael",
                    LastName = "Santos",
                    Email = "ricardo.formando.cinel@gmail.com",
                    UserName = "ricardo.formando.cinel@gmail.com",
                    PhoneNumber = "123456789"
                };

                var result = await _userHelper.AddUserAsync(user, "123456");
                if(result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }

            if (!_context.Products.Any())
            {
                this.AddProduct("Boné do Glorioso", user);
                this.AddProduct("Cuecas do Glorioso", user);
                this.AddProduct("Biquini do Glorioso", user);
                await _context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name, User user)
        {
            _context.Products.Add(new Product
            {
                Name = name,
                Price = _random.Next(500),
                IsAvailable = true,
                Stock = _random.Next(1000),
                User = user
            });
        }
    }
}
