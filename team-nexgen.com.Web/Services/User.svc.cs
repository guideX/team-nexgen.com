using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using team_nexgen.models;
namespace team_nexgen.com.Services {
    /// <summary>
    /// User
    /// </summary>
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class User {
        /// <summary>
        /// Read User
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        public UserModel ReadUser(string userName, string password) {
            return new UserModel();
        }
    }
}