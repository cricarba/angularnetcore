
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dale.ApplicationServices.Definitions;
using Dale.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dale.SaleProduct.Controllers
{
    [AllowAnonymous]
    [Route("api/product")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<Product> CreateProduct(Product createProduct)
        {
            Product product = null;
            try
            {
                product = await Task.Run(() => _productService.Create(createProduct));
            }
            catch (System.Exception)
            {

                throw;
            }
            return product;
        }
        [HttpPut]
        public async Task<Product> UpdateProduct(Product updateProduct)
        {
            Product product = null;
            try
            {
                product = await Task.Run(() => _productService.Update(updateProduct));
            }
            catch (System.Exception)
            {

                throw;
            }
            return product;
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<bool> DeleteProduct(int id)
        {
            bool result = false;
            try
            {
                result = await Task.Run(() => _productService.Delete(id));
            }
            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Product> Get(int id)
        {
            Product products = null;
            try
            {
                products = await Task.Run(() => _productService.Get(id));
            }
            catch (System.Exception)
            {

                throw;
            }
            return products;
        }

        [HttpGet]
        public async Task<List<Product>> GetProducts()
        {
            List<Product> products = null;
            try
            {
                products = await Task.Run(() => _productService.GetList().ToList());
            }
            catch (System.Exception)
            {

                throw;
            }
            return products;
        }
    }
}