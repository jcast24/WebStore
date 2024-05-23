using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Using Route on a class level
                                        // Can also be placed on a method level
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "OK";
        }
    }
}