// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> VMwareToAzStackHCI NIC properties. </summary>
    public partial class VMwareToAzStackHciNicInput
    {
        /// <summary> Initializes a new instance of VMwareToAzStackHciNicInput. </summary>
        /// <param name="nicId"> Gets or sets the NIC Id. </param>
        /// <param name="label"> Gets or sets the NIC label. </param>
        /// <param name="targetNetworkId"> Gets or sets the target network Id within AzStackHCI Cluster. </param>
        /// <param name="testNetworkId"> Gets or sets the target test network Id within AzStackHCI Cluster. </param>
        /// <param name="selectionTypeForFailover"> Gets or sets the selection type of the NIC. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nicId"/>, <paramref name="label"/>, <paramref name="targetNetworkId"/> or <paramref name="testNetworkId"/> is null. </exception>
        public VMwareToAzStackHciNicInput(string nicId, string label, string targetNetworkId, string testNetworkId, VmNicSelection selectionTypeForFailover)
        {
            Argument.AssertNotNull(nicId, nameof(nicId));
            Argument.AssertNotNull(label, nameof(label));
            Argument.AssertNotNull(targetNetworkId, nameof(targetNetworkId));
            Argument.AssertNotNull(testNetworkId, nameof(testNetworkId));

            NicId = nicId;
            Label = label;
            TargetNetworkId = targetNetworkId;
            TestNetworkId = testNetworkId;
            SelectionTypeForFailover = selectionTypeForFailover;
        }

        /// <summary> Initializes a new instance of VMwareToAzStackHciNicInput. </summary>
        /// <param name="nicId"> Gets or sets the NIC Id. </param>
        /// <param name="label"> Gets or sets the NIC label. </param>
        /// <param name="networkName"> Gets or sets the network name. </param>
        /// <param name="targetNetworkId"> Gets or sets the target network Id within AzStackHCI Cluster. </param>
        /// <param name="testNetworkId"> Gets or sets the target test network Id within AzStackHCI Cluster. </param>
        /// <param name="selectionTypeForFailover"> Gets or sets the selection type of the NIC. </param>
        internal VMwareToAzStackHciNicInput(string nicId, string label, string networkName, string targetNetworkId, string testNetworkId, VmNicSelection selectionTypeForFailover)
        {
            NicId = nicId;
            Label = label;
            NetworkName = networkName;
            TargetNetworkId = targetNetworkId;
            TestNetworkId = testNetworkId;
            SelectionTypeForFailover = selectionTypeForFailover;
        }

        /// <summary> Gets or sets the NIC Id. </summary>
        public string NicId { get; set; }
        /// <summary> Gets or sets the NIC label. </summary>
        public string Label { get; set; }
        /// <summary> Gets or sets the network name. </summary>
        public string NetworkName { get; }
        /// <summary> Gets or sets the target network Id within AzStackHCI Cluster. </summary>
        public string TargetNetworkId { get; set; }
        /// <summary> Gets or sets the target test network Id within AzStackHCI Cluster. </summary>
        public string TestNetworkId { get; set; }
        /// <summary> Gets or sets the selection type of the NIC. </summary>
        public VmNicSelection SelectionTypeForFailover { get; set; }
    }
}
