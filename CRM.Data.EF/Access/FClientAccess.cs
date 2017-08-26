using CRM.Data.Interfaces.Interfaces;
using CRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CRM.Data.EF.Access
{
    public class FClientAccess : IClientAccess
    {
        protected CRMContext crmContext;

        public FClientAccess(CRMContext dbContex)
        {
            crmContext = dbContex;
        }

        List<Client> IClientAccess.GetAllClients()
        {
            var clients = crmContext.Clients.ToList();
            return clients;
            ;
        }

        public Client GetClientById(decimal id)
        {
            return crmContext.Clients.Find(id);
        }

        public List<Client> SearchClients(object name)
        {
            throw new NotImplementedException();
        }

        public bool AddClient(Client client)
        {
            crmContext.Clients.Add(client);
            return true;
        }

        public bool UpdateClient(Client client)
        {   
            return true;
        }
        public bool DeleteClient(decimal id)
        {
            var client = crmContext.Clients.Find(id);
            crmContext.Clients.Remove(client);
            return true;
        }

    }
}
