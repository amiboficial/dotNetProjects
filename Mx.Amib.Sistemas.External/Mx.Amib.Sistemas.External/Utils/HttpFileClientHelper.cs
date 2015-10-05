using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;

namespace Mx.Amib.Sistemas.External.Utils
{
    public class HttpFileClientHelper
    {
        public static byte[] Get(string url)
        {
            byte[] result = null;
            using (WebClient myWebClient = new WebClient())
            {
                result = myWebClient.DownloadData(url);
            }
            return result;
        }
    }
}
