using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mx.Amib.Sistemas.External.Expediente.Persona.Catalog;

namespace Mx.Amib.Sistemas.External.Expediente.Persona
{
    public class DocumentoSustentanteTO
    {
        private string uuid;

        public string Uuid
        {
            get { return uuid; }
            set { uuid = value; }
        }
        private bool vigente;

        public bool Vigente
        {
            get { return vigente; }
            set { vigente = value; }
        }

        private SustentanteTO sustentante;

        public SustentanteTO Sustentante
        {
            get { return sustentante; }
            set { sustentante = value; }
        }

        private TipoDocumentoTO tipoDocumentoSustentate;

        public TipoDocumentoTO TipoDocumentoSustentate
        {
            get { return tipoDocumentoSustentate; }
            set { tipoDocumentoSustentate = value; }
        }
        private long idTipoDocumentoSustentate;

        public long IdTipoDocumentoSustentate
        {
            get { return idTipoDocumentoSustentate; }
            set { idTipoDocumentoSustentate = value; }
        }
    }
}
