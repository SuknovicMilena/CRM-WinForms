using CRM.Desktop.Presenter;
using CRM.Services.BusinessServices;
using System;
using System.Windows.Forms;

namespace CRM.Desktop.Views.Forms
{
    public partial class FaddProject : Form, IAddProjectView
    {
        public decimal ClientId;
        public AddProjectPresenter addProjectPresenter;

        public string Description

        {
            get
            {
                return txtDescription.Text;
            }

            set
            {
                txtDescription.Text = value;
            }
        }

        public string Category

        {

            get
            {
                return txtCategory.Text;
            }

            set
            {
                txtCategory.Text = value;
            }
        }

        string IAddProjectView.ProjectName

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

        public event EventHandler Button;

        public FaddProject(IProjectService projectService)
        {
            InitializeComponent();
            addProjectPresenter = new AddProjectPresenter(this, projectService);
        }

        public void NotifyButtonClicked(EventArgs e)
        {
            if (Button != null)
                Button(this, e);
        }

        private void addProject_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to want to add this project?", "Add project", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var success = addProjectPresenter.SaveProject(ClientId);
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

        private void FaddProject_Load(object sender, EventArgs e)
        {

        }
    }
}
