using System.Collections.Generic;
using team_nexgen.data.Interfaces.Base;
using team_nexgen.models;
namespace team_nexgen.data.Interfaces {
    /// <summary>
    /// Software Type Repository
    /// </summary>
    public interface ISoftwareTypeRepository : IRepository<SoftwareTypeModel> {
        /// <summary>
        /// Read All
        /// </summary>
        /// <returns></returns>
        IEnumerable<SoftwareTypeModel> ReadAll();
    }
}