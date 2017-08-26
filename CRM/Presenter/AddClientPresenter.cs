using CRM.Desktop.Views;
using CRM.Domain.Entities;
using CRM.Services.BusinessServices;

namespace CRM.Desktop.Presenter
{
    public class AddClientPresenter : Presenter<IClientAddView>
    {
        protected Client client { get; set; }
        private IClientService _clientService;

        public AddClientPresenter(IClientAddView view, IClientService clientService) : base(view)
        {
            _clientService = clientService;
        }

        public bool SaveClient()
        {
            Client client = new Client();
            client.Address = View.Address;
            client.City = View.City;
            client.Name = View.ClientName;
            client.Notes = View.Notes;
            client.ZipCode = View.ZipCode;
            client.Website = View.Website;
            client.State = View.State;
            client.PhoneNumber = View.PhoneNumber;

            //if (string.IsNullOrEmpty(client.Address) || string.IsNullOrEmpty(client.City) || string.IsNullOrEmpty(client.Name) || string.IsNullOrEmpty(client.Notes) || string.IsNullOrEmpty(client.ZipCode) || string.IsNullOrEmpty(client.Website) || string.IsNullOrEmpty(client.State) || string.IsNullOrEmpty(client.PhoneNumber))
            //{
            //    MessageBox.Show("Fields can not be empty!", "Message");
            //    return false;
            //}

            var success = _clientService.InsertClient(client);
            if (success)
            {
                return true;
            }

            return false;
        }

        public Client GetClientById(int select)
        {
            client = _clientService.GetClientById(select);

            View.ClientName = client.Name;
            View.Notes = client.Notes;
            View.PhoneNumber = client.PhoneNumber;
            View.State = client.State;
            View.Website = client.Website;
            View.City = client.City;
            View.Address = client.Address;
            View.ZipCode = client.ZipCode;

            return client;
        }

        public bool UpdateClient()
        {
            client.Address = View.Address;
            client.City = View.City;
            client.Name = View.ClientName;
            client.Notes = View.Notes;
            client.ZipCode = View.ZipCode;
            client.Website = View.Website;
            client.State = View.State;
            client.PhoneNumber = View.PhoneNumber;

            //if (string.IsNullOrEmpty(client.Address) || string.IsNullOrEmpty(client.City) || string.IsNullOrEmpty(client.Name) || string.IsNullOrEmpty(client.Notes) || string.IsNullOrEmpty(client.ZipCode) || string.IsNullOrEmpty(client.Website) || string.IsNullOrEmpty(client.State) || string.IsNullOrEmpty(client.PhoneNumber))
            //{
            //    MessageBox.Show("Fields can not be empty!", "Message");
            //    return false;
            //}

            var success = _clientService.UpdateClient(client);

            if (success)
            {
                return true;
            }
            return false;
        }
    }
}
