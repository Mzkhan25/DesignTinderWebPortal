using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DesignTinderContact.IRepository;
using DesignTinderModel.Class;
using DesignTinderContact;

namespace DesignTinderData.Repository
{
    public class ProjectsRepository : IProjectsRepository
    {
        private readonly IContext _db;
        public ProjectsRepository()
        {
            _db = new Context();
        }
        public ProjectsRepository(IContext db)
        {
            _db = db;
        }
        public List<Project> GetAllProjects()
        {
            return _db.Projects.ToList();
        }
    }
}