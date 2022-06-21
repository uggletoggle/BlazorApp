using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Title = "Producto Medico",
                Description = "Tomografo xxl",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/Wilcox.jpg/150px-Wilcox.jpg",
                Price = 9.99m
            },
            new Product
            {
                Id = 2,
                Title = "Producto Agricola",
                Description = "Tractor usado",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/f/f7/VioletNeuron.png",
                Price = 6.99m
            },
            new Product
            {
                Id = 3,
                Title = "Producto Farmacia",
                Description = "Ciclopramida",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fb/Dulce_Pi%C3%B1onate%2C_Isla_Margarita.jpg/1280px-Dulce_Pi%C3%B1onate%2C_Isla_Margarita.jpg",
                Price = 3.99m
            },

        };

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(Products);
        }
    }
}
