using ShoppingAppEntitlements.Models;
using System.Web.Http;

namespace ShoppingAppEntitlements.Controllers
{
    public class EntitlementsController : ApiController
    {
        public IHttpActionResult GetEntitlement(int id)
        {
            Entitlement entitlement = null;
            switch (id)
            {
                case 1:
                    entitlement = new Entitlement
                    {
                        ViewCustomers = true,
                        EditCustomers = true,
                        ViewShopping = true,
                    };

                    break;
                case 2:
                    entitlement = new Entitlement
                    {
                        ViewCustomers = true,
                        EditCustomers = true,
                        ViewShopping = false,
                    };

                    break;
                case 3:
                    entitlement = new Entitlement
                    {
                        ViewCustomers = true,
                        EditCustomers = false,
                        ViewShopping = true,
                    };

                    break;
                case 4:
                    entitlement = new Entitlement
                    {
                        ViewCustomers = false,
                        EditCustomers = false,
                        ViewShopping = false,
                    };

                    break;
                default:
                    return NotFound();

            }

            return Ok(entitlement);
        } 
    }
}
