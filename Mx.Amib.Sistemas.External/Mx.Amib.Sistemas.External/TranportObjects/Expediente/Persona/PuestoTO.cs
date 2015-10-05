using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mx.Amib.Sistemas.External.Expediente.Persona
{
    public class PuestoTO
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        private long idInstitucion;

        public long IdInstitucion
        {
            get { return idInstitucion; }
            set { idInstitucion = value; }
        }
        private DateTime fechaInicio;

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        private DateTime? fechaFin;

        public DateTime? FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }
        private string nombrePuesto;

        public string NombrePuesto
        {
            get { return nombrePuesto; }
            set { nombrePuesto = value; }
        }
        private bool esActual;

        public bool EsActual
        {
            get { return esActual; }
            set { esActual = value; }
        }

        private long statusEntManifProtesta;

        public long StatusEntManifProtesta
        {
            get { return statusEntManifProtesta; }
            set { statusEntManifProtesta = value; }
        }
        private string obsEntManifProtesta;

        public string ObsEntManifProtesta
        {
            get { return obsEntManifProtesta; }
            set { obsEntManifProtesta = value; }
        }
        private long statusEntCartaInter;

        public long StatusEntCartaInter
        {
            get { return statusEntCartaInter; }
            set { statusEntCartaInter = value; }
        }
        private string obsEntCartaInter;

        public string ObsEntCartaInter
        {
            get { return obsEntCartaInter; }
            set { obsEntCartaInter = value; }
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

        private SustentanteTO sustentante;

        public SustentanteTO Sustentante
        {
            get { return sustentante; }
            set { sustentante = value; }
        }
    }
}
