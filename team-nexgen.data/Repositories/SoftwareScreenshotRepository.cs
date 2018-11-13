using System.Collections.Generic;
using team_nexgen.data.Interfaces;
using team_nexgen.data.Repositories.Base;
using team_nexgen.models;
namespace team_nexgen.data.Repositories {
    /// <summary>
    /// Software Screenshot Repository
    /// </summary>
    public class SoftwareScreenshotRepository : Repository<SoftwareScreenshotModel>, ISoftwareScreenshotRepository {
        /// <summary>
        /// Read By SoftwareID
        /// </summary>
        /// <param name="softwareID"></param>
        /// <returns></returns>
        public IEnumerable<SoftwareScreenshotModel> ReadBySoftwareVersionID(int softwareVersionID) {
            return Db.Query<SoftwareScreenshotModel>("WHERE SoftwareVersionID = @0", softwareVersionID);
        }
    }
}