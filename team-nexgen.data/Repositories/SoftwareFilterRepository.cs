using System.Collections.Generic;
using team_nexgen.data.Interfaces;
using team_nexgen.data.Repositories.Base;
using team_nexgen.models;
namespace team_nexgen.data.Repositories {
    /// <summary>
    /// Software Filter Repository
    /// </summary>
    public class SoftwareFilterRepository : Repository<SoftwareFilterModel>, ISoftwareFilterRepository {
        /// <summary>
        /// Read Software Fitlers by SoftwareID
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SoftwareFilterModel> ReadSoftwareFiltersBySoftwareID(int softwareID) {
            return Db.Query<SoftwareFilterModel>("SELECT sf.* FROM software_filter sf, software_filter_join sfj WHERE sfj.SoftwareID = @0 AND sfj.SoftwareFilterID = sf.SoftwareFilterID;", softwareID.ToString());
        }
        /// <summary>
        /// Read All
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SoftwareFilterModel> ReadAll() {
            return Db.Query<SoftwareFilterModel>("");
        }
    }
}