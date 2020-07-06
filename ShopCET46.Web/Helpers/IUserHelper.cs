﻿using Microsoft.AspNetCore.Identity;
using ShopCET46.Web.Data.Entities;
using ShopCET46.Web.Models;
using System.Threading.Tasks;

namespace ShopCET46.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();
    }
}
