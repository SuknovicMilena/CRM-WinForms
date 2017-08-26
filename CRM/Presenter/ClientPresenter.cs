using CRM.Services.BusinessServices;
using CRM.Desktop.Views;
using System.Data;
using CRM.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace CRM.Desktop.Presenter
{
    public class ClientPresenter : Presenter<IClientView>
    {
        protected Client client { get; set; }
        private IClientService _clientService;

        public ClientPresenter(IClientView view, IClientService client_service) : base(view)
        {
            _clientService = client_service;
        }

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            List<Client> clients = _clientService.GetAllClients();
            dt = ConvertToDataTable(clients);
            return dt;

        }

        public Client GetClientById(int select)
        {
            client = _clientService.GetClientById(select);
            return client;
        }

        public DataTable SearchClients(object name)
        {
            DataTable dt = new DataTable();
            var clients = _clientService.SearchClients(name);

            foreach (var client in clients)
            {
                dt.Rows.Add(client);
            }
            return dt;

        }

        public bool DeleteClient(int select)
        {
            _clientService.DeleteClient(select);
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
