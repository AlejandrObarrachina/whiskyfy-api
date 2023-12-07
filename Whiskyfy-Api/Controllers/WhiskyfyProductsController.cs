using Microsoft.AspNetCore.Mvc;

namespace Whiskyfy_Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class WhiskyfyProductsController : ControllerBase
    {

        private readonly ILogger<WhiskyfyProductsController> _logger;

        public WhiskyfyProductsController(ILogger<WhiskyfyProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "get-products")]
        public IEnumerable<Object> GetProducts()
        {
            return new Object[] { };
        }
    }

}
