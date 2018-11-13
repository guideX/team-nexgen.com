using System.Collections.Generic;
using team_nexgen.com.Models.Base;
using team_nexgen.models;
namespace team_nexgen.com.Models {
    /// <summary>
    /// Detail View Model
    /// </summary>
    public class DetailViewModel : EveryPageViewModel {
        /// <summary>
        /// Software
        /// </summary>
        public SoftwareModel Software { get; set; }
        /// <summary>
        /// Screenshots
        /// </summary>
        public List<SoftwareScreenshotModel> Screenshots { get; set; }
        /// <summary>
        /// Versions
        /// </summary>
        public List<SoftwareVersionModel> Versions { get; set; }
        /// <summary>
        /// Download Urls
        /// </summary>
        public List<DownloadUrlModel> DownloadUrls { get; set; }
        /// <summary>
        /// Default Version
        /// </summary>
        public SoftwareVersionModel DefaultVersion { get; set; }
        /// <summary>
        /// Software Filters
        /// </summary>
        public List<SoftwareFilterModel> SoftwareFilters { get; set; }
        /// <summary>
        /// Entry Point
        /// </summary>
        public DetailViewModel() {
            Screenshots = new List<SoftwareScreenshotModel>();
            DownloadUrls = new List<DownloadUrlModel>();
            SoftwareFilters = new List<SoftwareFilterModel>();
        }
    }
}