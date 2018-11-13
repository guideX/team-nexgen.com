using PetaPoco;
namespace team_nexgen.models {
    /// <summary>
    /// Software Screenshot Model
    /// </summary>
    [TableName("software_screenshot")]
    [PrimaryKey("SoftwareScreenshotID")]
    public class SoftwareScreenshotModel {
        /// <summary>
        /// Software Screenshot ID
        /// </summary>
        public int SoftwareScreenshotID { get; set; }
        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Software ID
        /// </summary>
        public int SoftwareVersionID { get; set; }
    }
}