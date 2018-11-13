using System.Web.Mvc;
using team_nexgen.com.Models;
namespace team_nexgen.com.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            var model = new SoftwareViewModel() {
                Title = "Home"
            };
            model.BreadCrumb1.Title = "Home";
            model.BreadCrumb1.Url = "/";
            return View(model);
        }
    }
}