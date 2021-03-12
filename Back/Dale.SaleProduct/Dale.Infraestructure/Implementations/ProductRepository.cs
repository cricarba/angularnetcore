using Dale.Domain;
using Dale.Infraestructure.Definitions;
using Dale.Infraestructure.Definitions.Context;

namespace Dale.Infraestructure.Implementations
{
    internal class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDaleContext daleContext) : base(daleContext)
        {
        }
    }
}
