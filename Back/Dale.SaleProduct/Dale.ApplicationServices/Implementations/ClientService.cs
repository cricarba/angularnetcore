using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dale.ApplicationServices.Definitions;
using Dale.Domain;
using Dale.Infraestructure.Definitions;

namespace Dale.ApplicationServices.Implementations
{
    internal class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Client Create(Client client)
        {
            _clientRepository.Create(client);
            return client;
        }

        public bool Delete(int clientId)
        {
            bool result = false;
            Client client = Get(clientId);

            if (client != null)
            {
                _clientRepository.Delete(client);
                result = true;
            }
            return result;
        }

        public Client Get(int clientId)
        {
            Client client = null;
            client = _clientRepository.GetBy(x => x.Id == clientId).FirstOrDefault();
            return client;
        }

        public IEnumerable<Client> GetList()
        {
            return _clientRepository.GetAll();
        }

        public Client Update(Client client)
        {
            _clientRepository.Update(client);
            return client;
        }
    }
}
