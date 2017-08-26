using CRM.Desktop.Presenter;
using CRM.Services.BusinessServices;
using System;
using System.Windows.Forms;

namespace CRM.Desktop.Views.Forms
{
    public partial class FUpdateContact : Form, IContactAddView
    {
        public decimal ContactId;
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

        public FUpdateContact(IContactService contactService)
        {
            InitializeComponent();

            contactPresenter = new AddContactPresenter(this, contactService);
          
        }

        public void NotifyButtonClicked(EventArgs e)
        {
            if (Button != null)
                Button(this, e);
        }

        private void updateContact_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to want to update this contact?", "Update contact", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var success = contactPresenter.UpdateContact(ContactId);
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

        private void FUpdateContact_Load(object sender, EventArgs e)
        {
            contactPresenter.GetContactById(10022);
        }
    }
}
