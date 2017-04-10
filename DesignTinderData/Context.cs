using DesignTinderContact;
using DesignTinderModel.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DesignTinderData
{
    public class Context  :  DbContext, IContext
    {
        public Context() {

            Database.Connection.ConnectionString =
                @"Data Source=tcp:watg.database.windows.net,1433;Initial Catalog=DesignTinder;User ID=watg@watg;Password=W@tg2416";

        }
        public DbSet<Project> Projects { get; set; }
    }
    
}