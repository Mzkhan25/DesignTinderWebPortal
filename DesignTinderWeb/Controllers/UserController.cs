using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Config;
using Microsoft.Azure.Mobile.Server;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using DesignTinderWeb.DataObjects;
using DesignTinderWeb.Models;

namespace DesignTinderWeb.Controllers
{
    public class UserController : TableController<User>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<User>(context, Request);
        }

        // GET tables/Project
        [EnableQuery(MaxTop = 1000)]
        public IQueryable<User> GetAllProject()
        {
            return Query();
        }

        // GET tables/Project/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<User> GetProject(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Project/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<User> PatchProject(string id, Delta<User> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Project
        public async Task<IHttpActionResult> PostProject(User item)
        {
            User current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Project/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteProject(string id)
        {
            return DeleteAsync(id);
        }
    }
}
