using System.Collections.Generic;
using team_nexgen.data.Interfaces;
using team_nexgen.data.Repositories.Base;
using team_nexgen.models;
namespace team_nexgen.data.Repositories {
    /// <summary>
    /// Software Software Type Joins Repository
    /// </summary>
    public class SoftwareSoftwareTypeJoinsRepository : Repository<SoftwareSoftwareTypeJoinModel>, ISoftwareSoftwareTypeJoinsRepository {
        /// <summary>
        /// Read All
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SoftwareSoftwareTypeJoinModel> ReadAll() {
            Db.EnableAutoSelect = false;
            return Db.Query<SoftwareSoftwareTypeJoinModel>("SELECT * FROM SoftwareSoftwareTypeJoin;");
        }
    }
}