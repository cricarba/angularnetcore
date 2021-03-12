using Dale.Domain;
using Dale.Infraestructure.Definitions;
using Dale.Infraestructure.Definitions.Context;

namespace Dale.Infraestructure.Implementations
{
    internal class BillRepository : RepositoryBase<Bill>, IBillRepository
    {
        public BillRepository(IDaleContext daleContext) : base(daleContext)
        {
        }
    }
}
