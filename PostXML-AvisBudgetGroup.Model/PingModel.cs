using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostXML_AvisBudgetGroup.Model
{
    public class PingModel
    {
        public string Message { get; set; }
        public string Version { get; set; }
        public string Environment { get; set; }
        public string Vendor { get; set; }
        public string Url { get; set; }
        public string UrlLeitura { get; set; }
        public string ReqRespVersion { get; set; }
        public string Target { get; set; }
        public string EchoToken { get; set; }
        public string Iata { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }


    }
}
