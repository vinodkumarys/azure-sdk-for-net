// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> Properties of the vault access policy. </summary>
    public partial class KeyVaultAccessPolicyProperties
    {
        /// <summary> Initializes a new instance of KeyVaultAccessPolicyProperties. </summary>
        /// <param name="accessPolicies"> An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant ID as the key vault's tenant ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accessPolicies"/> is null. </exception>
        public KeyVaultAccessPolicyProperties(IEnumerable<KeyVaultAccessPolicy> accessPolicies)
        {
            Argument.AssertNotNull(accessPolicies, nameof(accessPolicies));

            AccessPolicies = accessPolicies.ToList();
        }

        /// <summary> Initializes a new instance of KeyVaultAccessPolicyProperties. </summary>
        /// <param name="accessPolicies"> An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant ID as the key vault's tenant ID. </param>
        internal KeyVaultAccessPolicyProperties(IList<KeyVaultAccessPolicy> accessPolicies)
        {
            AccessPolicies = accessPolicies;
        }

        /// <summary> An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant ID as the key vault's tenant ID. </summary>
        public IList<KeyVaultAccessPolicy> AccessPolicies { get; }
    }
}
