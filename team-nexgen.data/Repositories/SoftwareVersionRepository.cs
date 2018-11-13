using System.Collections.Generic;
using team_nexgen.data.Interfaces;
using team_nexgen.data.Repositories.Base;
using team_nexgen.models;
namespace team_nexgen.data.Repositories {
    /// <summary>
    /// Software Version Repository
    /// </summary>
    public class SoftwareVersionRepository : Repository<SoftwareVersionModel>, ISoftwareVersionRepository {
        /// <summary>
        /// Read By Software ID
        /// </summary>
        /// <param name="softwareID"></param>
        /// <returns></returns>
        public IEnumerable<SoftwareVersionModel> ReadBySoftwareID(int softwareID) {
            return Db.Query<SoftwareVersionModel>("WHERE SoftwareID = @0;", softwareID);
        }
    }
}