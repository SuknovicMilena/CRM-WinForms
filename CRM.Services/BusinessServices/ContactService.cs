using System.Data;
using CRM.Data.Interfaces.Interfaces;
using CRM.Domain.Entities;
using System.Collections.Generic;

namespace CRM.Services.BusinessServices
{
    public class ContactService : IContactService
    {
        private IContactAccess _memberAccess;

        public ContactService(IContactAccess access)
        {
            this._memberAccess = access;
        }

        public Contact GetContactById(decimal id)
        {
            return this._memberAccess.GetContactById(id);
        }

        public List<Contact> GetAllContact(decimal clientId)
        {
            return this._memberAccess.GetAllContact(clientId);
        }

        public Contact GetContactById(int id)
        {
            return this._memberAccess.GetContactById(id);
        }

        public List<Contact> SearchContact(object firstName)
        {
            return this._memberAccess.SearchContact(firstName);
        }

        public bool InsertContact(decimal clientId, Contact contact)
        {
            return this._memberAccess.AddContact(clientId, contact);
        }

        public bool UpdateContact(Contact contact)
        {
            return this._memberAccess.UpdateContact(contact);
        }

        public bool DeleteContact(int id)
        {
            return this._memberAccess.DeleteContact(id);
        }
    }
}
