using Microsoft.AspNetCore.Mvc;
using Sample_Web_API_Project.Model;
using Sample_Web_API_Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Sample_Web_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _prodservice;
        public ProductController(IProductServices prodservice)
        {
            _prodservice = prodservice;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Product/GetProducts")]
        public IActionResult GetProducts()
        {
            return new ObjectResult(_prodservice.GetAllProducts());
        }
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct(Product prod)
        {
            return new ObjectResult(_prodservice.AddProduct(prod));
        }

        [HttpPost]
        [Route("ModifyProduct")]
        public IActionResult ModifyProduct(Product prod)
        {
            return new ObjectResult(_prodservice.ModifyProduct(prod));
        }

        [HttpGet]
        [Route("DeleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            return new ObjectResult(_prodservice.DeleteProduct(id));
        }


    }
}
