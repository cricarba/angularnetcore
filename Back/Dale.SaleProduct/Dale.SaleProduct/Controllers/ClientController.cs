using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dale.ApplicationServices.Definitions;
using Dale.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dale.SaleClient.Controllers
{
     
    [AllowAnonymous]
    [Route("api/client")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpPost]
        public async Task<Client> CreateClient(Client createClient)
        {
            Client client = null;
            try
            {
                client = await Task.Run(() => _clientService.Create(createClient));
            }
            catch (System.Exception)
            {

                throw;
            }
            return client;
        }
        [HttpPut]
        public async Task<Client> UpdateClient(Client updateClient)
        {
            Client client = null;
            try
            {
                client = await Task.Run(() => _clientService.Update(updateClient));
            }
            catch (System.Exception)
            {

                throw;
            }
            return client;
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<bool> DeleteClient(int id)
        {
            bool result = false;
            try
            {
                result = await Task.Run(() => _clientService.Delete(id));
            }
            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Client> Get(int id)
        {
            Client clients = null;
            try
            {
                clients = await Task.Run(() => _clientService.Get(id));
            }
            catch (System.Exception)
            {

                throw;
            }
            return clients;
        }

        [HttpGet]
        public async Task<List<Client>> GetClients()
        {
            List<Client> clients = null;
            try
            {
                clients = await Task.Run(() => _clientService.GetList().ToList());
            }
            catch (System.Exception)
            {

                throw;
            }
            return clients;
        }
    }
}