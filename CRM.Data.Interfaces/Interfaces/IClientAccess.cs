using CRM.Domain.Entities;
using System.Collections.Generic;
using System.Data;


namespace CRM.Data.Interfaces.Interfaces
{
    public interface IClientAccess
    {
        List<Client> GetAllClients();
        Client GetClientById(decimal id);
        List<Client> SearchClients(object name);
        bool AddClient(Client client);
        bool UpdateClient(Client client);
        bool DeleteClient(decimal id);
    }
}
