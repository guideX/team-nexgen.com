using System.Collections.Generic;
using team_nexgen.data.Interfaces;
using team_nexgen.data.Repositories.Base;
using team_nexgen.models;
namespace team_nexgen.data.Repositories {
    /// <summary>
    /// Download url Repository
    /// </summary>
    public class DownloadUrlRepository : Repository<DownloadUrlModel>, IDownloadUrlRepository {
        /// <summary>
        /// Read By Software ID
        /// </summary>
        /// <param name="softwareID"></param>
        /// <returns></returns>
        public IEnumerable<DownloadUrlModel> ReadBySoftwareVersionID(int softwareVersionID) {
            return Db.Query<DownloadUrlModel>("WHERE SoftwareVersionID = @0;", softwareVersionID);
        }
    }
}