using DemoTallerCodigoFacilito.Models;
using DemoTallerCodigoFacilito.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoTallerCodigoFacilito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProducService _producService;
        public ProductController(IProducService producService) 
        {
            this._producService = producService;
        }

        [HttpGet]
        public ActionResult GetAllProduct()
        {
            List<ProductEntity> product = this._producService.GetAllProduct();
            return Ok(product);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody]ProductModels product)
        {
            _producService.CreateProduct(product);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteProduct([FromQuery]int id)
        {
            _producService.DeleteProduct(id);
            return Ok();
        }
        [HttpGet]
        [Route("getProduct/{id}")]
        public IActionResult GetProduct(int id)
        {
            ProductEntity product = _producService.GetProductId(id);
            return Ok(product);
        }

    }
}
