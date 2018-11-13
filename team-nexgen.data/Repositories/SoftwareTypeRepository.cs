using System.Collections.Generic;
using team_nexgen.data.Interfaces;
using team_nexgen.data.Repositories.Base;
using team_nexgen.models;
namespace team_nexgen.data.Repositories {
    /// <summary>
    /// Software Type Repository
    /// </summary>
    public class SoftwareTypeRepository : Repository<SoftwareTypeModel>, ISoftwareTypeRepository {
        /// <summary>
        /// Read All
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SoftwareTypeModel> ReadAll() {
            Db.EnableAutoSelect = false;
            return Db.Query<SoftwareTypeModel>("SELECT * FROM software_type;");
        }
    }
}