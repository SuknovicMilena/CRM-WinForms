using System.Data;
using CRM.Data.Interfaces.Interfaces;
using CRM.Domain.Entities;
using System.Collections.Generic;

namespace CRM.Services.BusinessServices
{
    public class ProjectService : IProjectService
    {
        private IProjectAccess _memberAccess;

        public ProjectService(IProjectAccess access)
        {
            this._memberAccess = access;
        }

        public List<Projects> GetAllProjects(decimal clientId)
        {
            return this._memberAccess.GetAllProjects(clientId);
        }

        public Projects GetProjectById(decimal id)
        {
            return this._memberAccess.GetProjectById(id);
        }

        public List<Projects> SearchProject(object name)
        {
            return this._memberAccess.SearchProject(name);
        }

        public bool InsertProject(decimal clientId, Projects project)
        {
            return this._memberAccess.AddProject(clientId, project);
        }

        public bool UpdateProject(Projects project)
        {
            return this._memberAccess.UpdateProject(project);
        }

        public bool DeleteProject(int id)
        {
            return this._memberAccess.DeleteProject(id);
        }
    }
}
