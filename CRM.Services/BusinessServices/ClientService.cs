using CRM.Data.Interfaces.Interfaces;
using CRM.Domain.Entities;
using System.Collections.Generic;
using System.Data;

namespace CRM.Services.BusinessServices
{
    public class ClientService : IClientService
    {
        private IClientAccess _memberAccess;

        public ClientService(IClientAccess access)
        {
            this._memberAccess = access;
        }

        public List<Client> GetAllClients()
        {
            return this._memberAccess.GetAllClients();
        }

        public Client GetClientById(decimal id)
        {
            return this._memberAccess.GetClientById(id);
        }

        public List<Client> SearchClients(object name)
        {
            return this._memberAccess.SearchClients(name);
        }

        public bool InsertClient(Client client)
        {
            return this._memberAccess.AddClient(client);
        }

        public bool UpdateClient(Client client)
        {
            return this._memberAccess.UpdateClient(client);
        }

        public bool DeleteClient(decimal id)
        {
            return this._memberAccess.DeleteClient(id);
        }
    }
}
