using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;

namespace VirtualMindWebAPI.Classes
{
    public class Cotizador
    {
        private IEstrategiaDeCotizacion _estrategiaDeCotizacion;

        public Cotizador(IEstrategiaDeCotizacion estrategiaDeCotizacion)
        {
            _estrategiaDeCotizacion = estrategiaDeCotizacion;
        }

        public HttpResponseMessage Cotizacion
        {
            get
            {
                return _estrategiaDeCotizacion.Cotizacion;
            }
        }
    }
}