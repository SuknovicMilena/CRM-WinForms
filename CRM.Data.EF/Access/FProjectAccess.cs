using CRM.Data.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Domain.Entities;

namespace CRM.Data.EF.Access
{
    public class FProjectAccess : IProjectAccess
    {
        protected CRMContext crmContext;

        public FProjectAccess(CRMContext dbContex)
        {
            crmContext = dbContex;
        }

        public List<Projects> GetAllProjects(decimal clientId)
        {
            return crmContext.Projects.ToList();
        }

        public Projects GetProjectById(decimal id)
        {
           return crmContext.Projects.Find(id);
        }

        public List<Projects> SearchProject(object name)
        {
            throw new NotImplementedException();
        }

        public bool AddProject(decimal clientId, Projects project)
        {
            crmContext.Projects.Add(project);
            return true;
        }

        public bool UpdateProject(Projects project)
        {
            return true;
        }

        public bool DeleteProject(int id)
        {
            var project = crmContext.Projects.Find(id);
            crmContext.Projects.Remove(project);
            return true;
        }

    }
}
