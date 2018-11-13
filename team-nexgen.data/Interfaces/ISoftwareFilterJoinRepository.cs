using System.Collections.Generic;
using team_nexgen.data.Interfaces.Base;
using team_nexgen.models;
namespace team_nexgen.data.Interfaces {
    /// <summary>
    /// Software Filter Join Repository
    /// </summary>
    public interface ISoftwareFilterJoinRepository : IRepository<SoftwareFilterJoinModel> {
        /// <summary>
        /// Read All
        /// </summary>
        /// <returns></returns>
        IEnumerable<SoftwareFilterJoinModel> ReadAll();
    }
}