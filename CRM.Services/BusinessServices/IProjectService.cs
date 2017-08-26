using CRM.Domain.Entities;
using System.Collections.Generic;
using System.Data;


namespace CRM.Services.BusinessServices
{
    public interface IProjectService
    {
        List<Projects> GetAllProjects(decimal clientId);
        Projects GetProjectById(decimal id);
        List<Projects> SearchProject(object name);
        bool InsertProject(decimal clientId, Projects project);
        bool UpdateProject(Projects project);
        bool DeleteProject(int id);
    }
}
