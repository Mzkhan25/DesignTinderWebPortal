using DesignTinderModel.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignTinderContact.IRepository
{
    public interface IProjectsRepository
    {
        List<Project> GetAllProjects();
    }
}
