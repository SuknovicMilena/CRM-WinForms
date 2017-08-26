using CRM.Desktop.Presenter;
using System;
using System.Windows.Forms;
using CRM.Services.BusinessServices;

namespace CRM.Desktop.Views.Forms
{
    public partial class FAddContact : Form, IContactAddView
    {
        public decimal ClientId;
        public AddContactPresenter contactPresenter;

        public string FirstName
        {
            get
            {
                return txtFirst.Text;
            }

            set
            {
                txtFirst.Text = value;
            }
        }

        public string LastName
        {
            get
            {
                return txtLastName.Text;
            }

            set
            {
                txtLastName.Text = value;
            }
        }
        public string Role
        {
            get
            {
                return txtRole.Text;
            }

            set
            {
                txtRole.Text = value;
            }
        }
        public string Email
        {
            get
            {
                return txtEmail.Text;
            }

            set
            {
                txtEmail.Text = value;
            }
        }

        public string Phone
        {
            get
            {
                return txtPhone.Text;
            }

            set
            {
                txtPhone.Text = value;
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
        public string State
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

        public event EventHandler Button;

        public FAddContact(IContactService contactService)
        {
            InitializeComponent();
            contactPresenter = new AddContactPresenter(this, contactService);

        }

        private void FAddContact_Load(object sender, EventArgs e)
        {
        }

        public void NotifyButtonClicked(EventArgs e)
        {
            if (Button != null)
                Button(this, e);
        }

        private void addContact_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to want to add this contact?", "Add client", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var success = contactPresenter.SaveContact(ClientId);
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

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
