using CRM.Services.BusinessServices;
using CRM.Desktop.Views;
using CRM.Domain.Entities;

namespace CRM.Desktop.Presenter
{
    public class AddProjectPresenter : Presenter<IAddProjectView>
    {
        protected Projects project { get; set; }
        private IProjectService _projectService;

        public AddProjectPresenter(IAddProjectView view, IProjectService projectService) : base(view)
        {
            this._projectService = projectService;
        }

        public Projects GetProjectById(decimal select)
        {
            project = _projectService.GetProjectById(select);

            View.ProjectName = project.Name;
            View.Description = project.Description;
            View.Category = project.Category;

            return project;
        }

        public bool SaveProject(decimal select)
        {
            Projects project = new Projects();

            project.Category = View.Category;
            project.Description = View.Description;
            project.Name = View.ProjectName;

            //if (string.IsNullOrEmpty(project.Description) || string.IsNullOrEmpty(project.Category) || string.IsNullOrEmpty(project.Name))
            //{
            //    MessageBox.Show("Fields can not be empty!", "Message");
            //    return false;
            //}

            var success = _projectService.InsertProject(select, project);
            if (success)
            {
                return true;
            }

            return false;
        }

        public bool UpdateProject(decimal select)
        {
            project.Category = View.Category;
            project.Description = View.Description;
            project.Name = View.ProjectName;

            //if (string.IsNullOrEmpty(project.Description) || string.IsNullOrEmpty(project.Category) || string.IsNullOrEmpty(project.Name))
            //{
            //    MessageBox.Show("Fields can not be empty!", "Message");
            //    return false;
            //}

            var success = _projectService.UpdateProject(project);
            if (success)
            {
                return true;
            }

            return false;
        }

    }
}
