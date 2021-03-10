using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Service.Interface;

namespace MVC_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductAPIController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/Product
        [HttpGet]
        public IEnumerable<ProductModel> Get()
        {
            return _productService.GetAll();
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "Get")]
        public ProductModel Get(int id)
        {
            return _productService.GetProduct(id);
        }

        // POST: api/Product
        [HttpPost]
        public int Create([FromBody] ProductModel product)
        {
            return _productService.CreateProduct(product);
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public int Put([FromBody] ProductModel product)
        {
            return _productService.Update(product);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _productService.Delete(id);
        }
    }
}
