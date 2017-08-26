using CRM.Services.BusinessServices;
using System.Data;
using CRM.Domain.Entities;
using CRM.Desktop.Views;
using System.ComponentModel;
using System.Collections.Generic;
using System;

namespace CRM.Desktop.Presenter
{
    public class ProjectPresenter : Presenter<IProjectView>
    {
        protected Projects project { get; set; }
        private IProjectService _projectService;

        public ProjectPresenter(IProjectView view, IProjectService projectService) : base(view)
        {
            this._projectService = projectService;
        }

        public DataTable GetAllProjects(decimal clientId)
        {
            DataTable dt = new DataTable();
            var projects =  _projectService.GetAllProjects(clientId);
            dt = ConvertToDataTable(projects);
            return dt;
        }

        public DataTable SearchProject(object name)
        {
            DataTable dt = new DataTable();
            var projects =  _projectService.SearchProject(name);
            foreach (var project in projects)
            {
                dt.Rows.Add(project);
            }
            return dt;

        }

        public bool DeleteProject(int select)
        {
            _projectService.DeleteProject(select);
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
