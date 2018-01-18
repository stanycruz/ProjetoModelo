using System.Web.Mvc;

namespace ProjetoModelo.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignOut()
        {
            ViewBag.Message = "Sair";

            return View();
        }
    }
}