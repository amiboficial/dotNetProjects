using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mx.Amib.Sistemas.External.Expediente.Certificacion.Catalog
{
    public class VarianteFiguraTO
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private bool vigente;

        public bool Vigente
        {
            get { return vigente; }
            set { vigente = value; }
        }
        private long numeroVersion;

        public long NumeroVersion
        {
            get { return numeroVersion; }
            set { numeroVersion = value; }
        }
        private long idFigura;

        public long IdFigura
        {
            get { return idFigura; }
            set { idFigura = value; }
        }
        private string nombreFigura;

        public string NombreFigura
        {
            get { return nombreFigura; }
            set { nombreFigura = value; }
        }
        private string nombreAcuseFigura;

        public string NombreAcuseFigura
        {
            get { return nombreAcuseFigura; }
            set { nombreAcuseFigura = value; }
        }
        private bool esAutorizableFigura;

        public bool EsAutorizableFigura
        {
            get { return esAutorizableFigura; }
            set { esAutorizableFigura = value; }
        }
        private string tipoAutorizacionFigura;

        public string TipoAutorizacionFigura
        {
            get { return tipoAutorizacionFigura; }
            set { tipoAutorizacionFigura = value; }
        }
        private string inicialesFigura;

        public string InicialesFigura
        {
            get { return inicialesFigura; }
            set { inicialesFigura = value; }
        }
    }
}
