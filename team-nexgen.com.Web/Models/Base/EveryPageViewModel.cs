using System.Collections.Generic;
using team_nexgen.business.Controllers;
using team_nexgen.models;
namespace team_nexgen.com.Models.Base {
    /// <summary>
    /// Bread Crumb
    /// </summary>
    public class BreadCrumb {
        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }
    }
    /// <summary>
    /// Every Page View Model
    /// </summary>
    public abstract class EveryPageViewModel {
        /// <summary>
        /// Softwares
        /// </summary>
        public List<SoftwareModel> Softwares { get; set; } = new List<SoftwareModel>();
        /// <summary>
        /// Software Filters
        /// </summary>
        public List<SoftwareFilterModel> SoftwareFilters { get; set; } = new List<SoftwareFilterModel>();
        /// <summary>
        /// Software Filter Joins
        /// </summary>
        public List<SoftwareFilterJoinModel> SoftwareFilterJoins { get; set; } = new List<SoftwareFilterJoinModel>();
        /// <summary>
        /// Software Types
        /// </summary>
        public List<SoftwareTypeModel> SoftwareTypes { get; set; } = new List<SoftwareTypeModel>();
        /// <summary>
        /// Software Software Type Joins
        /// </summary>
        public List<SoftwareSoftwareTypeJoinModel> SoftwareSoftwareTypeJoins { get; set; } = new List<SoftwareSoftwareTypeJoinModel>();
        /// <summary>
        /// Bread Crumb 1
        /// </summary>
        public BreadCrumb BreadCrumb1 { get; set; } = new BreadCrumb();
        /// <summary>
        /// Bread Crumb 2
        /// </summary>
        public BreadCrumb BreadCrumb2 { get; set; } = new BreadCrumb();
        /// <summary>
        /// Bread Crumb 3
        /// </summary>
        public BreadCrumb BreadCrumb3 { get; set; } = new BreadCrumb();
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Every Page View Model
        /// </summary>
        public EveryPageViewModel() {
            using (var c = new SoftwareController()) {
                Softwares = c.ReadSoftwares();
                SoftwareFilters = c.ReadSoftwareFilters();
                SoftwareFilterJoins = c.ReadSoftwareFilterJoins();
                SoftwareTypes = c.ReadSoftwareTypes();
                SoftwareSoftwareTypeJoins = c.ReadSoftwareSoftwareTypeJoins();
            }
        }
    }
}