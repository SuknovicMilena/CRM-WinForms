using CRM.Desktop.Presenter;
using CRM.Services.BusinessServices;
using System;
using System.Windows.Forms;

namespace CRM.Desktop.Views.Forms
{
    public partial class FAddClient : Form, IClientAddView
    {
        public int? ClientId { get; set; }
        private AddClientPresenter clientPresenter;
        public event EventHandler Button;

        public string ClientName
        {
            get
            {
                return txtName.Text;
            }

            set
            {
                txtName.Text = value;
            }
        }

        public string Address
        {
            get
            {
                return txtAddress.Text;
            }

            set
            {
                txtAddress.Text = value;
            }
        }

        public string City
        {
            get
            {
                return txtCity.Text;
            }

            set
            {
                txtCity.Text = value;
            }
        }

        public string ZipCode
        {
            get
            {
                return txtZipCode.Text;
            }

            set
            {
                txtZipCode.Text = value;
            }
        }

        string IClientAddView.State
        {
            get
            {
                return txtState.Text;
            }

            set
            {
                txtState.Text = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return txtPhoneNumber.Text;
            }

            set
            {
                txtPhoneNumber.Text = value;
            }
        }

        public string Website
        {
            get
            {
                return txtWebsite.Text;
            }

            set
            {
                txtWebsite.Text = value;
            }

        }

        public string Notes
        {
            get
            {
                return txtNotes.Text;
            }

            set
            {
                txtNotes.Text = value;
            }
        }

        public FAddClient(IClientService clientService)
        {
            InitializeComponent();
            clientPresenter = new AddClientPresenter(this, clientService);
            ClientId = null;
        }

        private void FAddClient_Load(object sender, EventArgs e)
        {
            if (ClientId.HasValue)
            {
                Add.Visible = false;
                Update.Visible = true;
                clientPresenter.GetClientById(ClientId.Value);
            }
        }

        public void NotifyButtonClicked(EventArgs e)
        {
            if (Button != null)
                Button(this, e);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to want to add this client?", "Add client", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var success = clientPresenter.SaveClient();
                if (success)
                {
                    MessageBox.Show("Success!", "Message");
                    this.Hide();
                    NotifyButtonClicked(e);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Nothing was added!", "Message");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to want to update this client?", "Update client", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var success = clientPresenter.UpdateClient();
                if (success)
                {
                    MessageBox.Show("Success!", "Message");
                    this.Hide();
                    NotifyButtonClicked(e);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Nothing was updated!", "Message");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }


    }

}
