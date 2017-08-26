using CRM.Domain.Entities;
using System.Collections.Generic;
using System.Data;


namespace CRM.Services.BusinessServices
{
    public interface IClientService
    {

        List<Client> GetAllClients();
        Client GetClientById(decimal id);
        List<Client> SearchClients(object name);
        bool InsertClient(Client client);
        bool UpdateClient(Client client);
        bool DeleteClient(decimal id);

        
    }
}
