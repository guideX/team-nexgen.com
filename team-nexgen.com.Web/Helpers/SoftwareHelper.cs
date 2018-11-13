using System.Linq;
using team_nexgen.business.Controllers;
using team_nexgen.com.Models;
namespace team_nexgen.com.Helpers {
    /// <summary>
    /// Software Helper
    /// </summary>
    public static class SoftwareHelper {
        /// <summary>
        /// Software
        /// </summary>
        /// <returns></returns>
        public static SoftwareViewModel Software() {
            var model = new SoftwareViewModel();
            model.Title = "Software";
            model.BreadCrumb1.Title = "Home";
            model.BreadCrumb1.Url = "/";
            model.BreadCrumb2.Title = "Software";
            model.BreadCrumb2.Url = "/software";
            using (var c = new SoftwareController()) {
                model.Softwares = c.ReadSoftwares();
                model.SoftwareFilters = c.ReadSoftwareFilters();
                model.SoftwareFilterJoins = c.ReadSoftwareFilterJoins();
            }
            return model;
        }
        /// <summary>
        /// Detail
        /// </summary>
        /// <param name="seoUrl"></param>
        /// <returns></returns>
        public static DetailViewModel Detail(string seoUrl) {
            var model = new DetailViewModel();
            model.BreadCrumb1.Title = "Home";
            model.BreadCrumb1.Url = "/";
            model.BreadCrumb2.Title = "Software";
            model.BreadCrumb2.Url = "/software";
            using (var c = new SoftwareController()) {
                model.Software = c.ReadSoftwareBySeoUrl(seoUrl);
                if (model.Software == null) { return null; }
                model.Versions = c.ReadSoftwareVersion(model.Software.SoftwareID);
                var d = model.Versions.Where(v => v.IsDefault).ToList();
                model.SoftwareFilters = c.ReadSoftwareFiltersBySoftwareID(model.Software.SoftwareID);
                if (d.Any()) {
                    model.DefaultVersion = d.FirstOrDefault();
                    model.Screenshots = c.ReadScreenshots(model.DefaultVersion.SoftwareVersionID);
                    model.DownloadUrls = c.ReadDownloadUrls(model.DefaultVersion.SoftwareVersionID);
                    
                }
                model.Title = model.Software.Description;
                model.BreadCrumb3.Title = model.Software.Description;
                model.BreadCrumb3.Url = model.Software.SeoUrl;
            }
            return model;
        }
    }
}