using System.Web.Mvc;

namespace Space_it.Web.Controllers
{
    
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Auth()
        {
            return View();
        }
    }
}