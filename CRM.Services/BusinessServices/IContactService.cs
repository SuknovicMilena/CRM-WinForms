using CRM.Domain.Entities;
using System.Collections.Generic;
using System.Data;

namespace CRM.Services.BusinessServices
{
  public  interface IContactService
    {
        List<Contact> GetAllContact(decimal clientId);
        Contact GetContactById(decimal id);
        List<Contact> SearchContact(object firstName);
        bool InsertContact(decimal clientId, Contact contact);
        bool UpdateContact(Contact contact);
        bool DeleteContact(int id);
    }
}
