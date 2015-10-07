using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using Mx.Amib.Sistemas.External.Resources;
using Mx.Amib.Sistemas.External.Utils;

namespace Mx.Amib.Sistemas.External.Documentos.Service
{
    public class DocumentoRepositorioService
    {
        private static readonly object syncLock = new object();
        private static DocumentoRepositorioService _instance;

        public string BaseUrl { get; set; }
        public string DescargarArchivoDocumentoUuid { get; set; }

        private static DocumentoRepositorioService()
        {
        }

        public static DocumentoRepositorioService GetInstance()
        {
            lock (syncLock)
            {
                if (DocumentoRepositorioService._instance == null)
                    DocumentoRepositorioService._instance = new DocumentoRepositorioService();

                return DocumentoRepositorioService._instance;
            }
        }

        public byte[] DescargarArchivo(string uuid){
            /*ResourceManager appUrlsRm = new ResourceManager("Mx.Amib.Sistemas.External.Resources.ApplicationUrls", typeof(ApplicationUrls).Assembly);
            string curEnv = appUrlsRm.GetString("CurrentEnvironment");
            string baseUrl = appUrlsRm.GetString("Documentos" + curEnv);
            string requestUrl = DocumentosUrls.Documentos_Archivo_DescargarArchivoDocumentoUuid;
            */
            return HttpFileClientHelper.Get(BaseUrl + DescargarArchivoDocumentoUuid + uuid);
        }
    }
}
