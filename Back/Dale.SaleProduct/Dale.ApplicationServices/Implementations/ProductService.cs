using System;
using System.Collections.Generic;
using System.Linq;
using Dale.ApplicationServices.Definitions;
using Dale.Domain;
using Dale.Infraestructure.Definitions;

namespace Dale.ApplicationServices.Implementations
{
    internal class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product Create(Product product)
        {
            _productRepository.Create(product);
            return product;
        }

        public bool Delete(int productId)
        {
            bool result = false;
            Product product = Get(productId);

            if (product != null)
            {
                _productRepository.Delete(product);
                result = true;
            }
            return result;
        }

        public Product Get(int productId)
        {
            Product product = null;
            product = _productRepository.GetBy(x => x.Id == productId).FirstOrDefault();
            return product;
        }

        public IEnumerable<Product> GetList()
        {
            return _productRepository.GetAll();
        }

        public Product Update(Product product)
        {
            _productRepository.Update(product);
            return product;
        }
    }
}
