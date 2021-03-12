using Dale.Domain;
using Dale.Infraestructure.Definitions;
using Dale.Infraestructure.Definitions.Context;

namespace Dale.Infraestructure.Implementations
{
    internal class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(IDaleContext daleContext) : base(daleContext)
        {
        }
    }
}
