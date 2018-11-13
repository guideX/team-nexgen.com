using PetaPoco;
namespace team_nexgen.models {
    /// <summary>
    /// Software Filter Model
    /// </summary>
    [TableName("software_filter")]
    [PrimaryKey("SoftwareFilterID")]
    public class SoftwareFilterModel {
        /// <summary>
        /// Software Filter ID
        /// </summary>
        public int SoftwareFilterID { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Html Tag
        /// </summary>
        public string HtmlTag { get; set; }
    }
}