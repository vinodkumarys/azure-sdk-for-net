// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownPolicyProviderSpecificDetails. </summary>
    internal partial class UnknownPolicyProviderSpecificDetails : PolicyProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of UnknownPolicyProviderSpecificDetails. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        internal UnknownPolicyProviderSpecificDetails(string instanceType) : base(instanceType)
        {
            InstanceType = instanceType ?? "Unknown";
        }
    }
}
