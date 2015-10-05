using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mx.Amib.Sistemas.External.Expediente.Certificacion.Catalog
{
    public enum StatusAutorizacionTypes
    {
        NoAutorizado = 0,
        DictamenPrevio = 1,
        EnAutorizacion = 2,
        AutorizadoSinPoderes = 3,
        Autorizado = 4,
        Suspendida = 5,
        Revocada = 6,
        Vencida = 7
    }
}
