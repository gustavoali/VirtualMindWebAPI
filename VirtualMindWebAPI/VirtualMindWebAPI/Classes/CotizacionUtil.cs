using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualMindWebAPI.Classes
{
    public static class CotizacionUtil
    {
        public static Cotizador Seleccionar(string moneda)
        {
            Cotizador _cotizador;
            if (moneda == "DOLAR")
            {
                _cotizador = new Cotizador(new CotizacionBancoProvincia());
            }
            else
            {
                _cotizador = new Cotizador(new CotizacionNoAutorizada());
            }
            return _cotizador;
        }
    }
}