  using CRM.Domain.Entities;
using System.Collections.Generic;
using System.Data;


namespace CRM.Data.Interfaces.Interfaces
{
    public interface IProjectAccess
    {
        List<Projects> GetAllProjects(decimal clientId);
        Projects GetProjectById(decimal id);
        List<Projects> SearchProject(object name);
        bool AddProject(decimal clientId, Projects project);
        bool UpdateProject(Projects project);
        bool DeleteProject(int id);
    }
}
