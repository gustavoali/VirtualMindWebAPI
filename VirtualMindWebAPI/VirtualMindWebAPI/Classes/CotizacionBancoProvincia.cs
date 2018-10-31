using System.Net;
using System.IO;
using System.Web.Http;
using System.Net.Http;
using Newtonsoft.Json;
using System.Web.Http.Results;
using System.Web;

namespace VirtualMindWebAPI.Classes
{
    public class CotizacionBancoProvincia:IEstrategiaDeCotizacion
    {
        public HttpResponseMessage Cotizacion
        {
            get
            {
                HttpResponseMessage _msg = new HttpResponseMessage(HttpStatusCode.OK);
                _msg.Content = new StringContent(GetBancoProvinciaData());
                return _msg;
            }
        }

        private string GetBancoProvinciaData()
        {
            HttpWebRequest _request;
            _request = WebRequest.Create("http://www.bancoprovincia.com.ar/Principal/Dolar") as HttpWebRequest;
            _request.Method = "GET";
            HttpWebResponse _response = _request.GetResponse() as HttpWebResponse;
            StreamReader _reader = new StreamReader(_response.GetResponseStream());
            return _reader.ReadToEnd();
        }
    }
}