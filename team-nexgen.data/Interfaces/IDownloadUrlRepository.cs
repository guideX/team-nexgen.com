using System.Collections.Generic;
using team_nexgen.data.Interfaces.Base;
using team_nexgen.models;
namespace team_nexgen.data.Interfaces {
    public interface IDownloadUrlRepository : IRepository<DownloadUrlModel> {
        /// <summary>
        /// Read By Software ID
        /// </summary>
        /// <param name="softwareID"></param>
        /// <returns></returns>
        IEnumerable<DownloadUrlModel> ReadBySoftwareVersionID(int softwareVersionID);
    }
}