using PetaPoco;
namespace team_nexgen.models {
    /// <summary>
    /// Software Type Model
    /// </summary>
    [TableName("software_type")]
    [PrimaryKey("SoftwareTypeID")]
    public class SoftwareTypeModel {
        /// <summary>
        /// Software Type ID
        /// </summary>
        public int SoftwareTypeID { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Parent ID
        /// </summary>
        public int? ParentID { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        public int Weight { get; set; }
    }
}