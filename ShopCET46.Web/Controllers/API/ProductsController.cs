using Microsoft.AspNetCore.Mvc;
using ShopCET46.Web.Data;

namespace ShopCET46.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_productRepository.GetAll());
        }

        /*if(ModelState.IsValid)
         {
            var path = string.Empty;
            if(model.ImageFile != null && model.ImageFile.Length > 0)
            {
                path = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "wwwroot\\images\\Products",
                    model.ImageFile.FileName);
        
                using(var stream = new FileStream(path, FileMode.Create))
                {
                    await model.ImageFile.CopyToAsync(stream);
                }
                path = $"~/images/Products/{model.ImageFile.FileName}";
            }
            var product = this.ToProduct(model, path);
        
         private Product ToProduct(ProductViewModel view, string path)
        {
            return new Product
            {
                Id = view.Id,
                ImageUrl = path,
                IsAvailable = view.IsAvailable,
                LastPurchase = view.LastPurchase,
                LastSale = view.LastSale,
                Name = view.Name,
                Price = view.Price,
                Stock = view.Stock,
                User = view.User};}

        private ProductViewModel ToProductViewModel(Product product)
        {
            return new ProductViewModel
        {
            Id = view.Id,
                ImageUrl = path,
                IsAvailable = view.IsAvailable,
                LastPurchase = view.LastPurchase,
                LastSale = view.LastSale,
                Name = view.Name,
                Price = view.Price,
                Stock = view.Stock,
                User = view.User};}
        */
    }
}
