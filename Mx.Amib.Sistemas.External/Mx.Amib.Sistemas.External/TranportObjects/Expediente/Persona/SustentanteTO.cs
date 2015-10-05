using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mx.Amib.Sistemas.External.Expediente.Persona.Catalog;
using Mx.Amib.Sistemas.External.Expediente.Certificacion;

namespace Mx.Amib.Sistemas.External.Expediente.Persona
{
    public class SustentanteTO
    {
        long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        int numeroMatricula;

        public int NumeroMatricula
        {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string primerApellido;

        public string PrimerApellido
        {
            get { return primerApellido; }
            set { primerApellido = value; }
        }
        string segundoApellido;

        public string SegundoApellido
        {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }
        string genero;

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        string rfc;

        public string Rfc
        {
            get { return rfc; }
            set { rfc = value; }
        }
        string curp;

        public string Curp
        {
            get { return curp; }
            set { curp = value; }
        }
        DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        string correoElectronico;

        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }
        string calidadMigratoria;

        public string CalidadMigratoria
        {
            get { return calidadMigratoria; }
            set { calidadMigratoria = value; }
        }
        string profesion;

        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }

        string calle;

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }
        string numeroExterior;

        public string NumeroExterior
        {
            get { return numeroExterior; }
            set { numeroExterior = value; }
        }
        string numeroInterior;

        public string NumeroInterior
        {
            get { return numeroInterior; }
            set { numeroInterior = value; }
        }
        long idSepomex;

        public long IdSepomex
        {
            get { return idSepomex; }
            set { idSepomex = value; }
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

        NacionalidadTO nacionalidad;

        public NacionalidadTO Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
        NivelEstudiosTO nivelEstudios;

        public NivelEstudiosTO NivelEstudios
        {
            get { return nivelEstudios; }
            set { nivelEstudios = value; }
        }
        EstadoCivilTO estadoCivil;

        public EstadoCivilTO EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }
        long idNacionalidad;

        public long IdNacionalidad
        {
            get { return idNacionalidad; }
            set { idNacionalidad = value; }
        }
        long idNivelEstudios;

        public long IdNivelEstudios
        {
            get { return idNivelEstudios; }
            set { idNivelEstudios = value; }
        }
        long idEstadoCivil;

        public long IdEstadoCivil
        {
            get { return idEstadoCivil; }
            set { idEstadoCivil = value; }
        }

        List<TelefonoSustentanteTO> telefonos;

        public List<TelefonoSustentanteTO> Telefonos
        {
            get { return telefonos; }
            set { telefonos = value; }
        }
        List<DocumentoSustentanteTO> documentos;

        public List<DocumentoSustentanteTO> Documentos
        {
            get { return documentos; }
            set { documentos = value; }
        }
        List<PuestoTO> puestos;

        public List<PuestoTO> Puestos
        {
            get { return puestos; }
            set { puestos = value; }
        }

        List<CertificacionTO> certificaciones;

        public List<CertificacionTO> Certificaciones
        {
            get { return certificaciones; }
            set { certificaciones = value; }
        }
    }
}
