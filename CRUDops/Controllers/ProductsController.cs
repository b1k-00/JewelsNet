using Microsoft.AspNetCore.Mvc;

namespace CRUDops.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
