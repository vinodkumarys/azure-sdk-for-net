// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> IP Community Properties. </summary>
    public partial class ActionIPCommunityProperties : IPCommunityAddOperationProperties
    {
        /// <summary> Initializes a new instance of ActionIPCommunityProperties. </summary>
        public ActionIPCommunityProperties()
        {
        }

        /// <summary> Initializes a new instance of ActionIPCommunityProperties. </summary>
        /// <param name="add"> List of IP Community IDs. </param>
        /// <param name="delete"> List of IP Community IDs. </param>
        /// <param name="set"> List of IP Community IDs. </param>
        internal ActionIPCommunityProperties(IPCommunityIdList @add, IPCommunityIdList delete, IPCommunityIdList @set) : base(@add)
        {
            Delete = delete;
            Set = @set;
        }

        /// <summary> List of IP Community IDs. </summary>
        internal IPCommunityIdList Delete { get; set; }
        /// <summary> List of IP Community resource IDs. </summary>
        public IList<ResourceIdentifier> DeleteIPCommunityIds
        {
            get
            {
                if (Delete is null)
                    Delete = new IPCommunityIdList();
                return Delete.IPCommunityIds;
            }
        }

        /// <summary> List of IP Community IDs. </summary>
        internal IPCommunityIdList Set { get; set; }
        /// <summary> List of IP Community resource IDs. </summary>
        public IList<ResourceIdentifier> SetIPCommunityIds
        {
            get
            {
                if (Set is null)
                    Set = new IPCommunityIdList();
                return Set.IPCommunityIds;
            }
        }
    }
}
