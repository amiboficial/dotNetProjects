using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mx.Amib.Sistemas.External.Documentos.Service;

namespace Mx.Amib.Sistemas.External.Documentos.Service.Test
{
    [TestClass]
    public class DocumentoRepositorioServiceTest
    {
        [TestMethod]
        public void DescargarArchivoTest()
        {
            //given
            DocumentoRepositorioService documentoRepositorioService = new DocumentoRepositorioService();
            byte[] downloadFile;
            //when
            downloadFile = documentoRepositorioService.DescargarArchivo("c6e969a8-e1e7-4dfe-8a84-6348a9713685");
            //then
            Assert.AreEqual(downloadFile.Length, 46310);
        }
    }
}
