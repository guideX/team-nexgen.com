using System;
using System.Linq;
using System.Collections.Generic;
using team_nexgen.data.Interfaces;
using team_nexgen.data.Repositories;
using team_nexgen.models;
namespace team_nexgen.business.Controllers {
    public class SoftwareController : IDisposable {
        /// <summary>
        /// Disposed
        /// </summary>
        private bool _disposed = false;
        /// <summary>
        /// Software Repository
        /// </summary>
        private ISoftwareRepository _softwareRepository;
        /// <summary>
        /// Download Url Repository
        /// </summary>
        private IDownloadUrlRepository _downloadUrlRepository;
        /// <summary>
        /// Software Filter Repository
        /// </summary>
        private ISoftwareFilterRepository _softwareFilterRepository;
        /// <summary>
        /// Software Type Repository
        /// </summary>
        private ISoftwareTypeRepository _softwareTypeRepository;
        /// <summary>
        /// Software Filter Join Repository
        /// </summary>
        private ISoftwareFilterJoinRepository _softwareFilterJoinRepository;
        /// <summary>
        /// Software Screenshot Repository
        /// </summary>
        private ISoftwareScreenshotRepository _softwareScreenshotRepository;
        /// <summary>
        /// Software Version Repository
        /// </summary>
        private ISoftwareVersionRepository _softwareVersionRepository;
        /// <summary>
        /// Software Software Type Joins Repository
        /// </summary>
        private ISoftwareSoftwareTypeJoinsRepository _softwareSoftwareTypeJoinsRepository;
        /// <summary>
        /// Sofware Controller
        /// </summary>
        public SoftwareController() {
            _softwareScreenshotRepository = new SoftwareScreenshotRepository();
            _softwareRepository = new SoftwareRepository();
            _downloadUrlRepository = new DownloadUrlRepository();
            _softwareFilterRepository = new SoftwareFilterRepository();
            _softwareTypeRepository = new SoftwareTypeRepository();
            _softwareFilterJoinRepository = new SoftwareFilterJoinRepository();
            _softwareVersionRepository = new SoftwareVersionRepository();
            _softwareSoftwareTypeJoinsRepository = new SoftwareSoftwareTypeJoinsRepository();
        }
        /// <summary>
        /// Read Software Filters By SoftwareID
        /// </summary>
        /// <param name="softwareID"></param>
        /// <returns></returns>
        public List<SoftwareFilterModel> ReadSoftwareFiltersBySoftwareID(int softwareID) {
            var filters = _softwareFilterRepository.ReadSoftwareFiltersBySoftwareID(softwareID);
            if (filters.Any()) {
                return filters.ToList();
            } else {
                return new List<SoftwareFilterModel>();
            }

        }
        /// <summary>
        /// Read Software Versions
        /// </summary>
        /// <param name="softwareID"></param>
        /// <returns></returns>
        public List<SoftwareVersionModel> ReadSoftwareVersion(int softwareID) {
            var versions = _softwareVersionRepository.ReadBySoftwareID(softwareID);
            if (versions.Any()) {
                return versions.ToList();
            } else {
                return new List<SoftwareVersionModel>();
            }
        }
        /// <summary>
        /// Read Screenshots
        /// </summary>
        /// <param name="softwareID"></param>
        /// <returns></returns>
        public List<SoftwareScreenshotModel> ReadScreenshots(int softwareVersionID) {
            var softwares = _softwareScreenshotRepository.ReadBySoftwareVersionID(softwareVersionID);
            if (softwares.Any()) {
                return softwares.ToList();
            } else {
                return new List<SoftwareScreenshotModel>();
            }
        }
        /// <summary>
        /// Read Software By Seo Url
        /// </summary>
        /// <param name="seoUrl"></param>
        /// <returns></returns>
        public SoftwareModel ReadSoftwareBySeoUrl(string seoUrl) {
            var softwares = _softwareRepository.ReadBySeoUrl(seoUrl);
            if (softwares.Any()) {
                return softwares.FirstOrDefault();
            } else {
                return null;
            }
        }
        /// <summary>
        /// Read Software Filters
        /// </summary>
        /// <returns></returns>
        public List<SoftwareFilterModel> ReadSoftwareFilters() {
            var softwareFilters = _softwareFilterRepository.ReadAll();
            if (softwareFilters.Any()) {
                return softwareFilters.ToList();
            } else {
                return new List<SoftwareFilterModel>();
            }
        }
        /// <summary>
        /// Read Software
        /// </summary>
        /// <returns></returns>
        public List<SoftwareModel> ReadSoftwares() {
            var softwares = _softwareRepository.ReadAll();
            if (softwares.Any()) {
                return softwares.ToList();
            } else {
                return new List<SoftwareModel>();
            }
        }
        /// <summary>
        /// Read Software Software Type Joins
        /// </summary>
        /// <returns></returns>
        public List<SoftwareSoftwareTypeJoinModel> ReadSoftwareSoftwareTypeJoins() {
            var joins = _softwareSoftwareTypeJoinsRepository.ReadAll();
            if (joins.Any()) {
                return joins.ToList();
            } else {
                return new List<SoftwareSoftwareTypeJoinModel>();
            }
        }
        /// <summary>
        /// Read Software Types
        /// </summary>
        /// <returns></returns>
        public List<SoftwareTypeModel> ReadSoftwareTypes() {
            var softwareTypes = _softwareTypeRepository.ReadAll().ToList();
            if (softwareTypes.Any()) {
                return softwareTypes.ToList();
            } else {
                return new List<SoftwareTypeModel>();
            }
        }
        /// <summary>
        /// Read Software Filter Joins
        /// </summary>
        /// <returns></returns>
        public List<SoftwareFilterJoinModel> ReadSoftwareFilterJoins() {
            var joins = _softwareFilterJoinRepository.ReadAll();
            if (joins.Any()) {
                return joins.ToList();
            } else {
                return new List<SoftwareFilterJoinModel>();
            }
        }
        /// <summary>
        /// Read Download Urls
        /// </summary>
        /// <param name="softwareID"></param>
        /// <returns></returns>
        public List<DownloadUrlModel> ReadDownloadUrls(int softwareVersionID) {
            var downloads = _downloadUrlRepository.ReadBySoftwareVersionID(softwareVersionID);
            if (downloads.Any()) {
                return downloads.ToList();
            } else {
                return new List<DownloadUrlModel>();
            }
        }
        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="_disposing"></param>
        protected virtual void Dispose(bool _disposing) {
            if (_disposed) {
                return;
            }
            if (_disposing) {
                // Dispose of Repositories
                _softwareRepository = null;
                _downloadUrlRepository = null;
                _softwareFilterRepository = null;
                _softwareTypeRepository = null;
                _softwareFilterJoinRepository = null;
                _softwareScreenshotRepository = null;
                _softwareVersionRepository = null;
            }
        }
    }
}