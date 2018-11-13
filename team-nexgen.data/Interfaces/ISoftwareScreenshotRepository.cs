using System.Collections.Generic;
using team_nexgen.data.Interfaces.Base;
using team_nexgen.models;
namespace team_nexgen.data.Interfaces {
    /// <summary>
    /// Software Screenshot Repository
    /// </summary>
    public interface ISoftwareScreenshotRepository : IRepository<SoftwareScreenshotModel> {
        /// <summary>
        /// Read By Software ID
        /// </summary>
        /// <param name="softwareID"></param>
        /// <returns></returns>
        IEnumerable<SoftwareScreenshotModel> ReadBySoftwareVersionID(int softwareVersionID);
    }
}