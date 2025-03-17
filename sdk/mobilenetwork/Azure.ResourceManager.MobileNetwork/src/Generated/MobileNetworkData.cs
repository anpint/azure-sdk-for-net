// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing the MobileNetwork data model.
    /// Mobile network resource.
    /// </summary>
    public partial class MobileNetworkData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="publicLandMobileNetworkIdentifier"> The unique public land mobile network identifier for the network. If both 'publicLandMobileNetworks' and 'publicLandMobileNetworkIdentifier' are specified, then the 'publicLandMobileNetworks' will take precedence. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicLandMobileNetworkIdentifier"/> is null. </exception>
        public MobileNetworkData(AzureLocation location, MobileNetworkPlmnId publicLandMobileNetworkIdentifier) : base(location)
        {
            Argument.AssertNotNull(publicLandMobileNetworkIdentifier, nameof(publicLandMobileNetworkIdentifier));

            PublicLandMobileNetworkIdentifier = publicLandMobileNetworkIdentifier;
            PublicLandMobileNetworks = new ChangeTrackingList<PublicLandMobileNetwork>();
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The identity used to retrieve any private keys used for SUPI concealment from Azure key vault. </param>
        /// <param name="provisioningState"> The provisioning state of the mobile network resource. </param>
        /// <param name="publicLandMobileNetworkIdentifier"> The unique public land mobile network identifier for the network. If both 'publicLandMobileNetworks' and 'publicLandMobileNetworkIdentifier' are specified, then the 'publicLandMobileNetworks' will take precedence. </param>
        /// <param name="publicLandMobileNetworks"> A list of public land mobile networks including their identifiers. If both 'publicLandMobileNetworks' and 'publicLandMobileNetworkIdentifier' are specified, then the 'publicLandMobileNetworks' will take precedence. </param>
        /// <param name="serviceKey"> The mobile network resource identifier. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MobileNetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, MobileNetworkManagedServiceIdentity identity, MobileNetworkProvisioningState? provisioningState, MobileNetworkPlmnId publicLandMobileNetworkIdentifier, IList<PublicLandMobileNetwork> publicLandMobileNetworks, string serviceKey, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            ProvisioningState = provisioningState;
            PublicLandMobileNetworkIdentifier = publicLandMobileNetworkIdentifier;
            PublicLandMobileNetworks = publicLandMobileNetworks;
            ServiceKey = serviceKey;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkData"/> for deserialization. </summary>
        internal MobileNetworkData()
        {
        }

        /// <summary> The identity used to retrieve any private keys used for SUPI concealment from Azure key vault. </summary>
        [WirePath("identity")]
        public MobileNetworkManagedServiceIdentity Identity { get; set; }
        /// <summary> The provisioning state of the mobile network resource. </summary>
        [WirePath("properties.provisioningState")]
        public MobileNetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The unique public land mobile network identifier for the network. If both 'publicLandMobileNetworks' and 'publicLandMobileNetworkIdentifier' are specified, then the 'publicLandMobileNetworks' will take precedence. </summary>
        [WirePath("properties.publicLandMobileNetworkIdentifier")]
        public MobileNetworkPlmnId PublicLandMobileNetworkIdentifier { get; set; }
        /// <summary> A list of public land mobile networks including their identifiers. If both 'publicLandMobileNetworks' and 'publicLandMobileNetworkIdentifier' are specified, then the 'publicLandMobileNetworks' will take precedence. </summary>
        [WirePath("properties.publicLandMobileNetworks")]
        public IList<PublicLandMobileNetwork> PublicLandMobileNetworks { get; }
        /// <summary> The mobile network resource identifier. </summary>
        [WirePath("properties.serviceKey")]
        public string ServiceKey { get; }
    }
}
