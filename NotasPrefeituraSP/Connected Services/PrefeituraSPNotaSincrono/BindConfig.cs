using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;

namespace PrefeituraSPNotaSincrono
{
    public partial class LoteNFeSoapClient
    {
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials, X509Certificate2 certificate)
        {
            ((BasicHttpBinding)serviceEndpoint.Binding).Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;
            clientCredentials.ClientCertificate.Certificate = certificate;
        }
    }
}
