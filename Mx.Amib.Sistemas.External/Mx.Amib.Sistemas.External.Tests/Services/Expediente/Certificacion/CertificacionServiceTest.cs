using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mx.Amib.Sistemas.External.Expediente.Certificacion.Service;

namespace Mx.Amib.Sistemas.External.Expediente.Certificacion.Service.Test
{
    [TestClass]
    public class CertificacionServiceTest
    {
        [TestMethod]
        public void FindAllCandidatoCredencialTest()
        {
            //GIVEN
            CertificacionService certificacionService = new CertificacionService();
            CertificacionServiceResult result;

            //WHEN
            result = certificacionService.FindAllCandidatoCredencial(10, 0, "id", "asc", String.Empty, String.Empty, String.Empty,-1,-1);

            //THEN
            Assert.AreNotEqual(result.Count, 0);
        }

        [TestMethod]
        public void FindAllCandidatoCredencialByFolioTest()
        {
            //GIVEN
            CertificacionService certificacionService = new CertificacionService();
            CertificacionServiceResult result;
            long idSustentante = 63479;

            //WHEN
            result = certificacionService.FindAllCandidatoCredencialByFolio(idSustentante);

            //THEN
            Assert.AreNotEqual(result.Count, 0);
        }

        [TestMethod]
        public void FindAllCandidatoCredencialByMatriculaTest()
        {
            //GIVEN
            CertificacionService certificacionService = new CertificacionService();
            CertificacionServiceResult result;
            int numeroMatricula = 72526;

            //WHEN
            result = certificacionService.FindAllCandidatoCredencialByMatricula(numeroMatricula);

            //THEN
            Assert.AreNotEqual(result.Count, 0);
        }
    }
}
