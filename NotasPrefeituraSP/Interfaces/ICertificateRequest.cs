using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NotasPrefeituraSP.Interfaces
{
    public interface ICertificateRequest
    {
        public X509Certificate2 Request();
    }
}
