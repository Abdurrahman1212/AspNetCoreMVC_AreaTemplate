using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC_AreaTemplate.Areas.Dashboard.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
