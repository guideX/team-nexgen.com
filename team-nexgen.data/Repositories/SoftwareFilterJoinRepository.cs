using System.Collections.Generic;
using team_nexgen.data.Interfaces;
using team_nexgen.data.Repositories.Base;
using team_nexgen.models;
namespace team_nexgen.data.Repositories {
    /// <summary>
    /// Software Filter Join Repository
    /// </summary>
    public class SoftwareFilterJoinRepository : Repository<SoftwareFilterJoinModel>, ISoftwareFilterJoinRepository {
        /// <summary>
        /// Read All
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SoftwareFilterJoinModel> ReadAll() {
            return Db.Query<SoftwareFilterJoinModel>("");
        }
    }
}