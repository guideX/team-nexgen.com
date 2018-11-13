using PetaPoco;
namespace team_nexgen.models {
    /// <summary>
    /// Download Url Model
    /// </summary>
    [TableName("download_url")]
    [PrimaryKey("DownloadUrlID")]
    public class DownloadUrlModel {
        /// <summary>
        /// Download Url ID
        /// </summary>
        public int DownloadUrlID { get; set; }
        /// <summary>
        /// SoftwareID
        /// </summary>
        public decimal SoftwareVersionID { get; set; }
        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }
    }
}