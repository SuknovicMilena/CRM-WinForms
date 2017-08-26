using CRM.Data.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using CRM.Domain.Entities;

namespace CRM.Data.EF.Access
{
    public class FContactAccess : IContactAccess
    {
        protected CRMContext crmContext;

        public FContactAccess(CRMContext dbContex)
        {
            crmContext = dbContex;
        }

        public List<Contact> GetAllContact(decimal clientID)
        {
            return crmContext.Contacts.ToList();
        }

        public Contact GetContactById(decimal id)
        {
            return crmContext.Contacts.Find(id);
        }

        public List<Contact> SearchContact(object firstName)
        {
            throw new NotImplementedException();
        }

        public bool AddContact(decimal clientId, Contact contact)
        {
            crmContext.Contacts.Add(contact);
            return true;
        }

        public bool UpdateContact(Contact contact)
        {
            return true;
        }

        public bool DeleteContact(int id)
        {
            var contact = crmContext.Contacts.Find(id);
            crmContext.Contacts.Remove(contact);
            return true;
        }

    }
}
