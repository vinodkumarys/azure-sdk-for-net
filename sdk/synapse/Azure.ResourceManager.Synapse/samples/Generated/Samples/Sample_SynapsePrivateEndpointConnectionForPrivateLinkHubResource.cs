// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapsePrivateEndpointConnectionForPrivateLinkHubResource
    {
        // Get a privateLinkHub
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAPrivateLinkHub()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/PrivateEndpointConnectionsPrivateLinkHub_Get.json
            // this example is just showing the usage of "PrivateEndpointConnectionsPrivateLinkHub_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapsePrivateEndpointConnectionForPrivateLinkHubResource created on azure
            // for more information of creating SynapsePrivateEndpointConnectionForPrivateLinkHubResource, please refer to the document of SynapsePrivateEndpointConnectionForPrivateLinkHubResource
            string subscriptionId = "48b08652-d7a1-4d52-b13f-5a2471dce57b";
            string resourceGroupName = "gh-res-grp";
            string privateLinkHubName = "pe0";
            string privateEndpointConnectionName = "pe0-f3ed30f5-338c-4855-a542-24a403694ad2";
            ResourceIdentifier synapsePrivateEndpointConnectionForPrivateLinkHubResourceId = SynapsePrivateEndpointConnectionForPrivateLinkHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateLinkHubName, privateEndpointConnectionName);
            SynapsePrivateEndpointConnectionForPrivateLinkHubResource synapsePrivateEndpointConnectionForPrivateLinkHub = client.GetSynapsePrivateEndpointConnectionForPrivateLinkHubResource(synapsePrivateEndpointConnectionForPrivateLinkHubResourceId);

            // invoke the operation
            SynapsePrivateEndpointConnectionForPrivateLinkHubResource result = await synapsePrivateEndpointConnectionForPrivateLinkHub.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapsePrivateEndpointConnectionForPrivateLinkHubData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
