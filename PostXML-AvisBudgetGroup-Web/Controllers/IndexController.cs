using PostXML_AvisBudgetGroup.Model;
using PostXML_AvisBudgetGroup.Service;
using System;
using System.Web.Mvc;

namespace PostXML_AvisBudgetGroup_Web.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            #region OBJETO
            var pingRequest = new PingModel
            {
                Message = "Mensagem de Teste - Ambiente de Produção",
                Version = "1.0",
                Vendor = "Avis",
                UserId = "COOBRASTUR", //INSERIR USUARIO AO WEB SERVICE
                Password = @"'`EH{w{QmSAR", //INSERIR SENHA AO WEB SERVICE
                Url = "https://qaservices.carrental.com/wsbang/HTTPSOAPRouter/ws9071",
                EchoToken = Guid.NewGuid().ToString()
            };

            #endregion
            var rQRSServices = new RQRSServices();
            var resultDeserialize = (PostXML_AvisBudgetGroup.Service.WebReferenceDirectConnect.OTA_PingRS)rQRSServices.SendPing(pingRequest);
            return View(resultDeserialize);
        }
    }
}