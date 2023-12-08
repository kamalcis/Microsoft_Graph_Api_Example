using Azure.Identity;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_Graph_Api_Example
{
    public class GraphApiHandler
    {
        private GraphServiceClient graphServiceCleint { get; set; }
        public GraphApiHandler(string tenantId, string clientId, string clientSecret)
        {
            graphServiceCleint = CreateGraphClient(tenantId, clientId, clientSecret);
        }

        public GraphServiceClient CreateGraphClient(string tenantId, string clientId, string clientSecret)
        {
            var options = new TokenCredentialOptions
            {
                AuthorityHost = AzureAuthorityHosts.AzurePublicCloud

            };

            var clientSecretCredential = new ClientSecretCredential(
                tenantId, clientId, clientSecret, options);

            var scopes = new[] { "https://graph.microsoft.com/.default" };

            return new GraphServiceClient(clientSecretCredential, scopes);

        }

        public GraphServiceClient getGraphClient()
        {
            return this.graphServiceCleint;
        }


    }
}
