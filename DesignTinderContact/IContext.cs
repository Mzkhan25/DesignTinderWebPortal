using DesignTinderModel.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DesignTinderContact
{
    public interface IContext
    {
        DbSet<Project> Projects { get; set; } 
        int SaveChanges();
        Task<int> SaveChangesAsync();
        DbEntityEntry Entry(object o);
        void Dispose();
    }
}