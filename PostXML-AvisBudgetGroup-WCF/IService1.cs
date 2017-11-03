using PostXML_AvisBudgetGroup.Service.WebReferenceDirectConnect;
using System.ServiceModel;

namespace PostXML_AvisBudgetGroup_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        PostXML_AvisBudgetGroup.Service.WebReferenceDirectConnect.OTA_PingRS GetPostPingABG();

        // TODO: Add your service operations here
    }

}
