using BrickStoreBackend.Service;
using Microsoft.AspNetCore.Mvc;

namespace BrickStoreBackend.Controller
{
    [ApiController]
    [Route("product/[controller]")]
    public class ProductController : ControllerBase
    {
     private readonly IProductService _productService;
        
        
    }


}