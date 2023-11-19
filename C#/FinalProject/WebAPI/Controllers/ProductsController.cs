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

        [HttpGet("getall")] // birden fazla get metodunun çakışmaması için alias veriyoruz.
                            // (alternatif olarak routing de kullanılabilir.)
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result); // result.Data da dönebilirsin
            }
            return BadRequest(result); // veya result.Message
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        // Silme ve Güncelleme işlemleri için de [HttpPost] kullanılıyor.
    }
}