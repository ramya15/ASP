using System;
using System.Runtime.Serialization;
using System.ServiceModel.Activation;

namespace WebServiceApplication.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RESTService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RESTService.svc or RESTService.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RESTService : IRESTService
    {
        public String DoGetRequest()
        {
            return "REST WCF Service!";
        }

        public int DoPostRequest(int value)
        {
            return value * value;
        }

        public int DoAddValues(AddValues val)
        {
            return val.value1 + val.value2;
        }
    }

    [DataContract]
    public class AddValues
    {
        [DataMember]
        public int value1 { get; set; }
        [DataMember]
        public int value2 { get; set; }

        public AddValues()
        {
            value1 = 0;
            value2 = 0;
        }
    }
}
