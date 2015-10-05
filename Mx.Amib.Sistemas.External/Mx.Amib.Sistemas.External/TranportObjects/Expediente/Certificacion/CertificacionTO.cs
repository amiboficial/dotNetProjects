using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mx.Amib.Sistemas.External.Expediente.Persona;
using Mx.Amib.Sistemas.External.Expediente.Certificacion.Catalog;

namespace Mx.Amib.Sistemas.External.Expediente.Certificacion
{
    public class CertificacionTO
    {
        long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        DateTime fechaInicio;

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        DateTime fechaFin;

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }
        DateTime fechaObtencion;

        public DateTime FechaObtencion
        {
            get { return fechaObtencion; }
            set { fechaObtencion = value; }
        }
        bool isAutorizado;

        public bool IsAutorizado
        {
            get { return isAutorizado; }
            set { isAutorizado = value; }
        }
        bool isApoderado;

        public bool IsApoderado
        {
            get { return isApoderado; }
            set { isApoderado = value; }
        }
        bool isUltima;

        public bool IsUltima
        {
            get { return isUltima; }
            set { isUltima = value; }
        }

        long statusEntHistorialInforme;

        public long StatusEntHistorialInforme
        {
            get { return statusEntHistorialInforme; }
            set { statusEntHistorialInforme = value; }
        }
        string obsEntHistorialInforme;

        public string ObsEntHistorialInforme
        {
            get { return obsEntHistorialInforme; }
            set { obsEntHistorialInforme = value; }
        }
        long statusEntCartaRec;

        public long StatusEntCartaRec
        {
            get { return statusEntCartaRec; }
            set { statusEntCartaRec = value; }
        }
        string obsEntCartaRec;

        public string ObsEntCartaRec
        {
            get { return obsEntCartaRec; }
            set { obsEntCartaRec = value; }
        }
        long statusConstBolVal;

        public long StatusConstBolVal
        {
            get { return statusConstBolVal; }
            set { statusConstBolVal = value; }
        }
        string obsConstBolVal;

        public string ObsConstBolVal
        {
            get { return obsConstBolVal; }
            set { obsConstBolVal = value; }
        }

        DateTime fechaCreacion;

        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }
        DateTime fechaModificacion;

        public DateTime FechaModificacion
        {
            get { return fechaModificacion; }
            set { fechaModificacion = value; }
        }

        VarianteFiguraTO varianteFigura;

        public VarianteFiguraTO VarianteFigura
        {
            get { return varianteFigura; }
            set { varianteFigura = value; }
        }
        StatusAutorizacionTO statusAutorizacion;

        public StatusAutorizacionTO StatusAutorizacion
        {
            get { return statusAutorizacion; }
            set { statusAutorizacion = value; }
        }
        StatusCertificacionTO statusCertificacion;

        public StatusCertificacionTO StatusCertificacion
        {
            get { return statusCertificacion; }
            set { statusCertificacion = value; }
        }
        long idVarianteFigura;

        public long IdVarianteFigura
        {
            get { return idVarianteFigura; }
            set { idVarianteFigura = value; }
        }
        long idStatusAutorizacion;

        public long IdStatusAutorizacion
        {
            get { return idStatusAutorizacion; }
            set { idStatusAutorizacion = value; }
        }
        long idStatusCertificacion;

        public long IdStatusCertificacion
        {
            get { return idStatusCertificacion; }
            set { idStatusCertificacion = value; }
        }

        SustentanteTO sustentante;

        public SustentanteTO Sustentante
        {
            get { return sustentante; }
            set { sustentante = value; }
        }
        List<ValidacionTO> validaciones;

        public List<ValidacionTO> Validaciones
        {
            get { return validaciones; }
            set { validaciones = value; }
        }
    }
}
