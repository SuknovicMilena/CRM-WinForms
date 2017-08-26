using CRM.Desktop.Presenter;
using CRM.Services.BusinessServices;
using System;
using System.Windows.Forms;

namespace CRM.Desktop.Views.Forms
{
    public partial class FUpdateProject : Form, IAddProjectView
    {
        public decimal ProjectId;
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


        public FUpdateProject(IProjectService projectService)
        {
            InitializeComponent();

            addProjectPresenter = new AddProjectPresenter(this, projectService);
            //addProjectPresenter.GetProjectById(ProjectId);
        }

        public void NotifyButtonClicked(EventArgs e)
        {
            if (Button != null)
                Button(this, e);
        }

        private void updateProject_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to want to update this project?", "Update project", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var success = addProjectPresenter.UpdateProject(ProjectId);
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

        private void FUpdateProject_Load(object sender, EventArgs e)
        {
            addProjectPresenter.GetProjectById(ProjectId);
        }
    }
}
