using System.Web.Mvc;
using team_nexgen.com.Helpers;
namespace team_nexgen.com.Controllers {
    /// <summary>
    /// Software Controller
    /// </summary>
    public class SoftwareController : Controller {
        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(string seoUrl) {
            return View(SoftwareHelper.Software()); // Get Software
        }
        /// <summary>
        /// Detail
        /// </summary>
        /// <param name="seoUrl"></param>
        /// <returns></returns>
        public ActionResult Detail(string seoUrl) {
            return View(SoftwareHelper.Detail(seoUrl)); // Get Detail
        }
    }
}