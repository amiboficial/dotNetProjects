using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mx.Amib.Sistemas.External.TranportObjects.Expediente.Persona.Catalog;

namespace Mx.Amib.Sistemas.External.Expediente.Persona
{
    public class TelefonoSustentanteTO
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private string lada;

        public string Lada
        {
            get { return lada; }
            set { lada = value; }
        }
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private string extension;

        public string Extension
        {
            get { return extension; }
            set { extension = value; }
        }
        private TipoTelefonoTO tipoTelefonoSustentante;

        public TipoTelefonoTO TipoTelefonoSustentante
        {
            get { return tipoTelefonoSustentante; }
            set { tipoTelefonoSustentante = value; }
        }
        private long idTipoTelefonoSustentante;

        public long IdTipoTelefonoSustentante
        {
            get { return idTipoTelefonoSustentante; }
            set { idTipoTelefonoSustentante = value; }
        }
        private SustentanteTO sustentante;

        public SustentanteTO Sustentante
        {
            get { return sustentante; }
            set { sustentante = value; }
        }
    }
}
