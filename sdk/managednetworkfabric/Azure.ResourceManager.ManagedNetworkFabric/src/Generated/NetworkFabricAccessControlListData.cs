// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkFabricAccessControlList data model.
    /// The Access Control List resource definition.
    /// </summary>
    public partial class NetworkFabricAccessControlListData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of NetworkFabricAccessControlListData. </summary>
        /// <param name="location"> The location. </param>
        public NetworkFabricAccessControlListData(AzureLocation location) : base(location)
        {
            MatchConfigurations = new ChangeTrackingList<AccessControlListMatchConfiguration>();
            DynamicMatchConfigurations = new ChangeTrackingList<CommonDynamicMatchConfiguration>();
        }

        /// <summary> Initializes a new instance of NetworkFabricAccessControlListData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="configurationType"> Input method to configure Access Control List. </param>
        /// <param name="aclsUri"> Access Control List file URL. </param>
        /// <param name="defaultAction"> Default action that needs to be applied when no condition is matched. Example: Permit | Deny. </param>
        /// <param name="matchConfigurations"> List of match configurations. </param>
        /// <param name="dynamicMatchConfigurations"> List of dynamic match configurations. </param>
        /// <param name="lastSyncedOn"> The last synced timestamp. </param>
        /// <param name="configurationState"> Configuration state of the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="administrativeState"> Administrative state of the resource. </param>
        internal NetworkFabricAccessControlListData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string annotation, NetworkFabricConfigurationType? configurationType, Uri aclsUri, CommunityActionType? defaultAction, IList<AccessControlListMatchConfiguration> matchConfigurations, IList<CommonDynamicMatchConfiguration> dynamicMatchConfigurations, DateTimeOffset? lastSyncedOn, NetworkFabricConfigurationState? configurationState, NetworkFabricProvisioningState? provisioningState, NetworkFabricAdministrativeState? administrativeState) : base(id, name, resourceType, systemData, tags, location)
        {
            Annotation = annotation;
            ConfigurationType = configurationType;
            AclsUri = aclsUri;
            DefaultAction = defaultAction;
            MatchConfigurations = matchConfigurations;
            DynamicMatchConfigurations = dynamicMatchConfigurations;
            LastSyncedOn = lastSyncedOn;
            ConfigurationState = configurationState;
            ProvisioningState = provisioningState;
            AdministrativeState = administrativeState;
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> Input method to configure Access Control List. </summary>
        public NetworkFabricConfigurationType? ConfigurationType { get; set; }
        /// <summary> Access Control List file URL. </summary>
        public Uri AclsUri { get; set; }
        /// <summary> Default action that needs to be applied when no condition is matched. Example: Permit | Deny. </summary>
        public CommunityActionType? DefaultAction { get; set; }
        /// <summary> List of match configurations. </summary>
        public IList<AccessControlListMatchConfiguration> MatchConfigurations { get; }
        /// <summary> List of dynamic match configurations. </summary>
        public IList<CommonDynamicMatchConfiguration> DynamicMatchConfigurations { get; }
        /// <summary> The last synced timestamp. </summary>
        public DateTimeOffset? LastSyncedOn { get; }
        /// <summary> Configuration state of the resource. </summary>
        public NetworkFabricConfigurationState? ConfigurationState { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
        /// <summary> Administrative state of the resource. </summary>
        public NetworkFabricAdministrativeState? AdministrativeState { get; }
    }
}
