using PetaPoco;
using System;
namespace team_nexgen.models {
    /// <summary>
    /// Software Model
    /// </summary>
    [TableName("software")]
    [PrimaryKey("SoftwareID")]
    public class SoftwareModel {
        /// <summary>
        /// Software ID
        /// </summary>
        public int SoftwareID { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Is Active
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// Seo Url
        /// </summary>
        public string SeoUrl { get; set; }
        /// <summary>
        /// Image
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// Sub Title
        /// </summary>
        public int SortID { get; set; }
        /// <summary>
        /// Long Description
        /// </summary>
        public string LongDescription { get; set; }
        /// <summary>
        /// Insert Time Stamp
        /// </summary>
        public DateTime InsertTimeStamp { get; set; }
    }
}