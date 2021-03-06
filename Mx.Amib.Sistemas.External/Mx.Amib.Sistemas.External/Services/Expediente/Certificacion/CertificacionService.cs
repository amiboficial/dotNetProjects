﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using Mx.Amib.Sistemas.External.Resources;
using Mx.Amib.Sistemas.External.Expediente.Persona;
using Mx.Amib.Sistemas.External.Utils;

namespace Mx.Amib.Sistemas.External.Expediente.Certificacion.Service
{
    public class CertificacionService
    {
        private static readonly object syncLock = new object();
        private static CertificacionService _instance;

        public string BaseUrl { get; set; }
        public string FindAllCandidatoCredencialUrl { get; set; }
        public string FindAllCandidatoCredencialByFolioUrl { get; set; }
        public string FindAllCandidatoCredencialByMatriculaUrl { get; set; }

        private static CertificacionService()
        {
        }

        public static CertificacionService GetInstance(){
            lock (syncLock)
            {
                if(CertificacionService._instance == null)
                    CertificacionService._instance = new CertificacionService();
            
                return CertificacionService._instance;
            }
        }

        public CertificacionServiceResult FindAllCandidatoCredencial(int max, int offset, string sort, string order, string nom, string ap1, string ap2, long idfig, long idvarfig)
        {
            /*
            ResourceManager appUrlsRm = new ResourceManager("Mx.Amib.Sistemas.External.Resources.ApplicationUrls", typeof(ApplicationUrls).Assembly);
            string curEnv = appUrlsRm.GetString("CurrentEnvironment");
            string baseUrl = appUrlsRm.GetString("Expediente"+curEnv);
            string requestUrl = ExpedienteUrls.Certificacion_Certificacion_FindAllCandidatoCredencial;
            string queryStr = String.Format("?max={0}&offset={1}&sort={2}&order={3}&nom={4}&ap1={5}&ap2={6}&idfig={7}&idvarfig={8}", max, offset, sort, order, nom, ap1, ap2, idfig, idvarfig);
            return JsonRestClientHelper.Get<CertificacionServiceResult>(baseUrl, requestUrl + queryStr);
            */

            return JsonRestClientHelper.Get<CertificacionServiceResult>(BaseUrl, FindAllCandidatoCredencialUrl);
        }
        public CertificacionServiceResult FindAllCandidatoCredencialByFolio(long idSustentante)
        {
            return JsonRestClientHelper.Get<CertificacionServiceResult>(BaseUrl, FindAllCandidatoCredencialByFolioUrl);
        }
        public CertificacionServiceResult FindAllCandidatoCredencialByMatricula(int numeroMatricula)
        {
            return JsonRestClientHelper.Get<CertificacionServiceResult>(BaseUrl, FindAllCandidatoCredencialByMatriculaUrl);
        }
    }

    public class CertificacionServiceResult
    {
        private List<CertificacionTO> list;
        private List<SustentanteTO> sustentantes;
        private List<long> idsCertLoteEnvioAutorizacion;
        private long count;
        private bool error;
        private string errorDetails;

        public List<CertificacionTO> List
        {
            get { return list; }
            set { list = value; }
        }
        public List<SustentanteTO> Sustentantes
        {
            get { return sustentantes; }
            set { sustentantes = value; }
        }
        public List<long> IdsCertLoteEnvioAutorizacion
        {
            get { return idsCertLoteEnvioAutorizacion; }
            set { idsCertLoteEnvioAutorizacion = value; }
        }
        public long Count
        {
            get { return count; }
            set { count = value; }
        }
        public bool Error
        {
            get { return error; }
            set { error = value; }
        }
        public string ErrorDetails
        {
            get { return errorDetails; }
            set { errorDetails = value; }
        }
	}
}
