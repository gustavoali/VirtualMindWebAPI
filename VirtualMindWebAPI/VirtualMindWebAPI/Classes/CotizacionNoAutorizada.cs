using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace VirtualMindWebAPI.Classes
{
    public class CotizacionNoAutorizada : IEstrategiaDeCotizacion
    {
        public HttpResponseMessage Cotizacion
        {
            get
            {
                HttpResponseMessage _msg = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                _msg.Content = new StringContent("Cotizacion no disponible");
                return _msg;
            }
        }
    }  
}