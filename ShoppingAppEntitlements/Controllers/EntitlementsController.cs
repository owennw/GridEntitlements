using ShoppingAppEntitlements.Models;
using System.Web.Http;

namespace ShoppingAppEntitlements.Controllers
{
    public class EntitlementsController : ApiController
    {
        public Entitlement GetEntitlement()
        {
            return new Entitlement
            {
                ViewCustomers = true,
                EditCustomers = true,
                ViewShopping = true,
            };
        } 
    }
}
