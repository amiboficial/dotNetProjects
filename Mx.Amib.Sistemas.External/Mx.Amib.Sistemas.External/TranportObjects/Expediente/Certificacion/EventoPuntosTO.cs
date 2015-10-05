using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mx.Amib.Sistemas.External.Expediente.Certificacion
{
    public class EventoPuntosTO
    {
        private long? idEvento;

        public long? IdEvento
        {
            get { return idEvento; }
            set { idEvento = value; }
        }
        private int puntaje;

        public int Puntaje
        {
            get { return puntaje; }
            set { puntaje = value; }
        }

        private ValidacionTO validacion;

        public ValidacionTO Validacion
        {
            get { return validacion; }
            set { validacion = value; }
        }

        private DateTime fechaCreacion;

        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }
        private DateTime fechaModificacion;

        public DateTime FechaModificacion
        {
            get { return fechaModificacion; }
            set { fechaModificacion = value; }
        }
    }
}
