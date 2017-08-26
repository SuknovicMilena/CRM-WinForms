using CRM.Desktop.Views;
using CRM.Services.BusinessServices;
using CRM.Domain.Entities;

namespace CRM.Desktop.Presenter
{
    public class AddContactPresenter : Presenter<IContactAddView>
    {
        protected Contact contact { get; set; }
        private IContactService _contactService;

        public AddContactPresenter(IContactAddView view, IContactService contactService) : base(view)
        {
            _contactService = contactService;
        }

        public Contact GetContactById(decimal select)
        {
            contact = _contactService.GetContactById(select);

            View.FirstName = contact.FirstName;
            View.LastName = contact.LastName;
            View.Role = contact.Email;
            View.Phone = contact.Phone;
            View.City = contact.City;
            View.ZipCode = contact.ZipCode;
            View.ZipCode = contact.ZipCode;
            View.State = contact.State;

            return contact;
        }

        public bool SaveContact(decimal select)
        {
            Contact contact = new Contact();

            contact.FirstName = View.FirstName;
            contact.LastName = View.LastName;
            contact.Role = View.Role;
            contact.Email = View.Email;
            contact.Phone = View.Phone;
            contact.Address = View.Address;
            contact.City = View.City;
            contact.ZipCode = View.ZipCode;
            contact.State = View.State;
            contact.ClientId = select;

            //if (string.IsNullOrEmpty(contact.FirstName) || string.IsNullOrEmpty(contact.LastName) || string.IsNullOrEmpty(contact.Role) || string.IsNullOrEmpty(contact.Email) || string.IsNullOrEmpty(contact.Phone) || string.IsNullOrEmpty(contact.Address) || string.IsNullOrEmpty(contact.Address) || string.IsNullOrEmpty(contact.City) || string.IsNullOrEmpty(contact.ZipCode) || string.IsNullOrEmpty(contact.State))
            //{
            //    MessageBox.Show("Fields can not be empty!", "Message");
            //    return false;
            //}

            var success = _contactService.InsertContact(select, contact);

            if (success)
            {
                return true;
            }
            return false;
        }

        public bool UpdateContact(decimal select)
        {
            contact.FirstName = View.FirstName;
            contact.LastName = View.LastName;
            contact.Role = View.Role;
            contact.Email = View.Email;
            contact.Phone = View.Phone;
            contact.Address = View.Address;
            contact.City = View.City;
            contact.ZipCode = View.ZipCode;
            contact.State = View.State;
            contact.ClientId = select;

            //if (string.IsNullOrEmpty(contact.FirstName) || string.IsNullOrEmpty(contact.LastName) || string.IsNullOrEmpty(contact.Role) || string.IsNullOrEmpty(contact.Email) || string.IsNullOrEmpty(contact.Phone) || string.IsNullOrEmpty(contact.Address) || string.IsNullOrEmpty(contact.Address) || string.IsNullOrEmpty(contact.City) || string.IsNullOrEmpty(contact.ZipCode) || string.IsNullOrEmpty(contact.State))
            //{
            //    MessageBox.Show("Fields can not be empty!", "Message");
            //    return false;
            //}

            var success = _contactService.UpdateContact(contact);

            if (success)
            {
                return true;
            }
            return false;
        }


    }
}
