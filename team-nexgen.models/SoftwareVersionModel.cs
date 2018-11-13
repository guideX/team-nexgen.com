using PetaPoco;
namespace team_nexgen.models {
    /// <summary>
    /// Software Version Model
    /// </summary>
    [TableName("software_version")]
    [PrimaryKey("SoftwareVersionID")]
    public class SoftwareVersionModel {
        /// <summary>
        /// Software Version ID
        /// </summary>
        public int SoftwareVersionID { get; set; }
        /// <summary>
        /// Version
        /// </summary>
        public decimal Version { get; set; }
        /// <summary>
        /// Software ID
        /// </summary>
        public int SoftwareID { get; set; }
        /// <summary>
        /// Is Default
        /// </summary>
        public bool IsDefault { get; set; }
    }
}