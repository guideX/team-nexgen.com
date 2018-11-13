using System.Collections.Generic;
using team_nexgen.data.Interfaces.Base;
using team_nexgen.models;
namespace team_nexgen.data.Interfaces {
    /// <summary>
    /// Software Filter Repository
    /// </summary>
    public interface ISoftwareFilterRepository : IRepository<SoftwareFilterModel> {
        /// <summary>
        /// Read Software Filters By Software ID
        /// </summary>
        /// <returns></returns>
        IEnumerable<SoftwareFilterModel> ReadSoftwareFiltersBySoftwareID(int softwareID);
        /// <summary>
        /// Read All
        /// </summary>
        /// <returns></returns>
        IEnumerable<SoftwareFilterModel> ReadAll();
    }
}