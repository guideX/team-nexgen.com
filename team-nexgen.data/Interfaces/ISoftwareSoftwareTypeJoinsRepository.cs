using System.Collections.Generic;
using team_nexgen.models;
namespace team_nexgen.data.Interfaces {
    /// <summary>
    /// Software Software Type Joins Repository
    /// </summary>
    public interface ISoftwareSoftwareTypeJoinsRepository {
        /// <summary>
        /// Read All
        /// </summary>
        /// <returns></returns>
        IEnumerable<SoftwareSoftwareTypeJoinModel> ReadAll();
    }
}