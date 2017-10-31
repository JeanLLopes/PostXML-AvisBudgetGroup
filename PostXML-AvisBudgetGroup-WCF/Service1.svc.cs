using PostXML_AvisBudgetGroup.Model;
using PostXML_AvisBudgetGroup.Service;
using PostXML_AvisBudgetGroup.Service.WebReferenceDirectConnect;
using System;

namespace PostXML_AvisBudgetGroup_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public RequestPing GetPostPingABG()
        {
            #region OBJETO
            var pingRequest = new PingModel
            {
                Message = "Mensagem de Teste - Ambiente de Homologação",
                Version = "1.0",
                Vendor = "Avis",
                UserId = "usuario", //INSERIR USUARIO AO WEB SERVICE
                Password = "senha", //INSERIR SENHA AO WEB SERVICE
                Url = "https://qaservices.carrental.com/wsbang/HTTPSOAPRouter/ws9071",
                EchoToken = Guid.NewGuid().ToString()
            };

            #endregion
            var rQRSServices = new RQRSServices();
            return (RequestPing)rQRSServices.SendPing(pingRequest);
        }
    }
}
