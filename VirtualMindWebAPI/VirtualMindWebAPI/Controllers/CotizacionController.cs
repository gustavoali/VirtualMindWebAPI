using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VirtualMindWebAPI.Classes;

namespace VirtualMindWebAPI.Controllers
{
    public class CotizacionController : ApiController
    {
        // GET: api/Cotizacion/id
        public HttpResponseMessage Get(string id)
        {
            Cotizador _cotizador;
            string moneda = id;
            moneda = moneda.ToUpper();
            _cotizador = CotizacionUtil.Seleccionar(moneda);
            return _cotizador.Cotizacion;
        }
     }
}
