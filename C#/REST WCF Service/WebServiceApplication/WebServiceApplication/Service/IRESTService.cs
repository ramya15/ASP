using System.ServiceModel;
using System.ServiceModel.Web;

namespace WebServiceApplication.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRESTService" in both code and config file together.
    [ServiceContract]
    public interface IRESTService
    {
        [OperationContract]
        [WebInvoke(Method ="GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate="DoWork")]
        void DoWork();
    }
}
