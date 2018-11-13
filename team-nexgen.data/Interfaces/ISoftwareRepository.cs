using System.Collections.Generic;
using team_nexgen.data.Interfaces.Base;
using team_nexgen.models;
namespace team_nexgen.data.Interfaces {
    /// <summary>
    /// Software Repository
    /// </summary>
    public interface ISoftwareRepository : IRepository<SoftwareModel> {
        /// <summary>
        /// Read By Seo Url
        /// </summary>
        /// <param name="SeoUrl"></param>
        /// <returns></returns>
        IEnumerable<SoftwareModel> ReadBySeoUrl(string SeoUrl);
        /// <summary>
        /// Read All
        /// </summary>
        /// <returns></returns>
        IEnumerable<SoftwareModel> ReadAll();
    }
}