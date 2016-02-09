using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ingles_Sem_Mestre
{
    public class WebClientX : WebClient
    {
        CookieContainer cookies = new CookieContainer();
        public CookieContainer Cookies { get { return cookies; } }
        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest request = base.GetWebRequest(address);

            if (request.GetType() == typeof(HttpWebRequest))
                ((HttpWebRequest)request).CookieContainer = cookies;
            return request;

        }

    }
}
