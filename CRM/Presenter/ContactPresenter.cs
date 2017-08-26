using CRM.Services.BusinessServices;
using CRM.Desktop.Views;
using System.Data;
using CRM.Domain.Entities;
using System.ComponentModel;
using System;
using System.Collections.Generic;

namespace CRM.Desktop.Presenter
{
    class ContactPresenter : Presenter<IContactView>
    {
        protected Contact contact { get; set; }
        private IContactService _contactService;

        public ContactPresenter(IContactView view, IContactService contactService) : base(view)
        {
            _contactService = contactService;
        }

        public DataTable GetAllContact(decimal clientId)
        {
            DataTable dt = new DataTable();
            var contacts = _contactService.GetAllContact(clientId);
            dt = ConvertToDataTable(contacts);
            return dt;
        }

        public Contact GetContactById(decimal select)
        {
            contact = _contactService.GetContactById(select);
            return contact;
        }

        public DataTable SearchContact(object firstName)
        {
            DataTable dt = new DataTable();

            var contacts = _contactService.SearchContact(firstName);
            foreach (var contact in contacts)
            {
                dt.Rows.Add(contact);
            }
            return dt;
        }

        public bool DeleteContact(int select)
        {
            _contactService.DeleteContact(select);
            return true;
        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
