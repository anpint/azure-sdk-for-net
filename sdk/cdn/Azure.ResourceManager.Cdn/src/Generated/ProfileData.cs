// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing the Profile data model. </summary>
    public partial class ProfileData : TrackedResource
    {
        /// <summary> Initializes a new instance of ProfileData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The pricing tier (defines a CDN provider, feature list and rate) of the CDN profile. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public ProfileData(AzureLocation location, Models.Sku sku) : base(location)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }

            Sku = sku;
        }

        /// <summary> Initializes a new instance of ProfileData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The pricing tier (defines a CDN provider, feature list and rate) of the CDN profile. </param>
        /// <param name="resourceState"> Resource status of the profile. </param>
        /// <param name="provisioningState"> Provisioning status of the profile. </param>
        /// <param name="frontdoorId"> The Id of the frontdoor. </param>
        internal ProfileData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, Models.Sku sku, ProfileResourceState? resourceState, string provisioningState, string frontdoorId) : base(id, name, type, systemData, tags, location)
        {
            Sku = sku;
            ResourceState = resourceState;
            ProvisioningState = provisioningState;
            FrontdoorId = frontdoorId;
        }

        /// <summary> The pricing tier (defines a CDN provider, feature list and rate) of the CDN profile. </summary>
        public Models.Sku Sku { get; set; }
        /// <summary> Resource status of the profile. </summary>
        public ProfileResourceState? ResourceState { get; }
        /// <summary> Provisioning status of the profile. </summary>
        public string ProvisioningState { get; }
        /// <summary> The Id of the frontdoor. </summary>
        public string FrontdoorId { get; }
    }
}
