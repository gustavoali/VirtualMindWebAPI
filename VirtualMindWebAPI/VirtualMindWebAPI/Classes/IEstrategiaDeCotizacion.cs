using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http;

namespace VirtualMindWebAPI.Classes
{
    public interface IEstrategiaDeCotizacion
    {
        HttpResponseMessage Cotizacion { get; }
    }
}
