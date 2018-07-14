using System;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WebServiceApplication.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRESTService" in both code and config file together.
    [ServiceContract]
    public interface IRESTService
    {
        [OperationContract]
        //GET: getting data from service
        //Bare: display Json as plain string without any wrapped package
        //UriTemplate: link how to call the method (TURI can be provided with any name but here is mentioned same as the method name)
        [WebInvoke(Method ="GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate= "DoGetRequest")]
        String DoGetRequest();

        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "DoPostRequest")]
        int DoPostRequest(int value);

        [WebInvoke(Method ="POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "DoAddValues")]
        int DoAddValues(AddValues value);
    }
}
