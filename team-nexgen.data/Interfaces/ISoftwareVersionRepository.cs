using System.Collections.Generic;
using team_nexgen.models;
namespace team_nexgen.data.Interfaces {
    /// <summary>
    /// Software Version Repository
    /// </summary>
    public interface ISoftwareVersionRepository {
        /// <summary>
        /// Read By Software ID
        /// </summary>
        /// <param name="softwareID"></param>
        /// <returns></returns>
        IEnumerable<SoftwareVersionModel> ReadBySoftwareID(int softwareID);
    }
}