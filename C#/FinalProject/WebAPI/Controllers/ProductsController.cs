using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // Attribute
    public class ProductsController : ControllerBase
    {
        // herhangi somut bir sınıftan newleme yapmayarak bağımlılığı azaltıyoruz.
        // (IProductService, Manager'ın referansını tutuyor.)
        // Loosely coupled - Gevşek bağlılık
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _productService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result); // result.Data da dönebilirsin
            }
            return BadRequest(result); // veya result.Message
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            var result = _productService.GetById(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            var result = _productService.Add(product);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}