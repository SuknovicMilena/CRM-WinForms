using CRM.Domain.Entities;
using System.Collections.Generic;
using System.Data;


namespace CRM.Data.Interfaces.Interfaces
{
    public interface IContactAccess
    {
        List<Contact> GetAllContact(decimal clientID);
        Contact GetContactById(decimal id);
        List<Contact> SearchContact(object firstName);
        bool AddContact(decimal clientId, Contact contact);
        bool UpdateContact(Contact contact);
        bool DeleteContact(int id);
    }
}
