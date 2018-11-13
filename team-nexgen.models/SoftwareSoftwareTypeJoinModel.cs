using PetaPoco;
namespace team_nexgen.models {
    /// <summary>
    /// Software Software Type Join Model
    /// </summary>
    [TableName("SoftwareSoftwareTypeJoin")]
    [PrimaryKey("SoftwareSoftwareTypeJoinID")]
    public class SoftwareSoftwareTypeJoinModel {
        /// <summary>
        /// Software Software Type Join ID
        /// </summary>
        public int SoftwareSoftwareTypeJoinID { get; set; }
        /// <summary>
        /// Software ID
        /// </summary>
        public int SoftwareID { get; set; }
        /// <summary>
        /// Software Type ID
        /// </summary>
        public int SoftwareTypeID { get; set; }
    }
}