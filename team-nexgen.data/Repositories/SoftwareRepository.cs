using System.Collections.Generic;
using team_nexgen.data.Interfaces;
using team_nexgen.data.Repositories.Base;
using team_nexgen.models;
namespace team_nexgen.data.Repositories {
    /// <summary>
    /// Software Repository
    /// </summary>
    public class SoftwareRepository : Repository<SoftwareModel>, ISoftwareRepository {
        /// <summary>
        /// Read All
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SoftwareModel> ReadAll() {
            return Db.Query<SoftwareModel>("WHERE IsActive = 1 ORDER BY SortID;");
        }
        /// <summary>
        /// Read By Seo Url
        /// </summary>
        /// <param name="SeoUrl"></param>
        /// <returns></returns>
        public IEnumerable<SoftwareModel> ReadBySeoUrl(string SeoUrl) {
            return Db.Query<SoftwareModel>("WHERE SeoUrl = @0;", SeoUrl);
        }
    }
}