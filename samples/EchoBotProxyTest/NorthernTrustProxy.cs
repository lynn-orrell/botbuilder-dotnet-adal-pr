using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EchoBotProxyTest
{
    public class NorthernTrustProxy : IWebProxy
    {

        public NorthernTrustProxy(string proxyUri)
        {
            //here you can load it from your custom config settings 
            this.ProxyUri = new Uri(proxyUri);
        }

        public Uri ProxyUri { get; set; }

        public ICredentials Credentials { get; set; }

        public Uri GetProxy(Uri destination)
        {
            return this.ProxyUri;
        }

        public bool IsBypassed(Uri host)
        {
            //you can proxy all requests or implement bypass urls based on config settings
            return false;

        }
    }

}
