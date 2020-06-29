using Microsoft.AspNetCore.Http;
using ShopCET46.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCET46.Web.Models
{
    public class ProductViewModel : Product
    {
        [Display(Name="Image")]
        public IFormFile Image { get; set; }
    }
}
