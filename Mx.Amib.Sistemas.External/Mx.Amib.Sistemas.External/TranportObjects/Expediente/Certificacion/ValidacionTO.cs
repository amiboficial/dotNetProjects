using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mx.Amib.Sistemas.External.Expediente.Certificacion.Catalog;

namespace Mx.Amib.Sistemas.External.Expediente.Certificacion
{
    public class ValidacionTO
    {
        private DateTime fechaAplicacion;

        public DateTime FechaAplicacion
        {
            get { return fechaAplicacion; }
            set { fechaAplicacion = value; }
        }
        private DateTime fechaInicio;

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        private DateTime fechaFin;

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }
        private string autorizadoPorUsuario;

        public string AutorizadoPorUsuario
        {
            get { return autorizadoPorUsuario; }
            set { autorizadoPorUsuario = value; }
        }
        private List<EventoPuntosTO> eventosPuntos;

        public List<EventoPuntosTO> EventosPuntos
        {
            get { return eventosPuntos; }
            set { eventosPuntos = value; }
        }
        private MetodoValidacionTO metodoValidacion;

        public MetodoValidacionTO MetodoValidacion
        {
            get { return metodoValidacion; }
            set { metodoValidacion = value; }
        }
        private long idMetodoValidacion;

        public long IdMetodoValidacion
        {
            get { return idMetodoValidacion; }
            set { idMetodoValidacion = value; }
        }

        private CertificacionTO certificacion;

        public CertificacionTO Certificacion
        {
            get { return certificacion; }
            set { certificacion = value; }
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
