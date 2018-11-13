using PetaPoco;
namespace team_nexgen.models {
    /// <summary>
    /// Software Filter Join
    /// </summary>
    [TableName("software_filter_join")]
    [PrimaryKey("SoftwareFilterJoinID")]
    public class SoftwareFilterJoinModel {
        /// <summary>
        /// Software Filter Join ID
        /// </summary>
        public int SoftwareFilterJoinID { get; set; }
        /// <summary>
        /// Software ID
        /// </summary>
        public int SoftwareID { get; set; }
        /// <summary>
        /// Filter ID
        /// </summary>
        public int SoftwareFilterID { get; set; }
    }
}