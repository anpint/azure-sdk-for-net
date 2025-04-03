// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing the ContainerAppManagedEnvironment data model.
    /// An environment for hosting container apps
    /// </summary>
    public partial class ContainerAppManagedEnvironmentData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppManagedEnvironmentData"/>. </summary>
        /// <param name="location"> The location. </param>
        public ContainerAppManagedEnvironmentData(AzureLocation location) : base(location)
        {
            WorkloadProfiles = new ChangeTrackingList<ContainerAppWorkloadProfile>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppManagedEnvironmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="kind"> Kind of the Environment. </param>
        /// <param name="identity"> Managed identities for the Managed Environment to interact with other Azure services without maintaining any secrets or credentials in code. </param>
        /// <param name="provisioningState"> Provisioning state of the Environment. </param>
        /// <param name="daprAIInstrumentationKey"> Azure Monitor instrumentation key used by Dapr to export Service to Service communication telemetry. </param>
        /// <param name="daprAIConnectionString"> Application Insights connection string used by Dapr to export Service to Service communication telemetry. </param>
        /// <param name="vnetConfiguration"> Vnet configuration for the environment. </param>
        /// <param name="deploymentErrors"> Any errors that occurred during deployment or deployment validation. </param>
        /// <param name="defaultDomain"> Default Domain Name for the cluster. </param>
        /// <param name="staticIP"> Static IP of the Environment. </param>
        /// <param name="appLogsConfiguration"> Cluster configuration which enables the log daemon to export app logs to configured destination. </param>
        /// <param name="isZoneRedundant"> Whether or not this Managed Environment is zone-redundant. </param>
        /// <param name="customDomainConfiguration"> Custom domain configuration for the environment. </param>
        /// <param name="eventStreamEndpoint"> The endpoint of the eventstream of the Environment. </param>
        /// <param name="workloadProfiles"> Workload profiles configured for the Managed Environment. </param>
        /// <param name="kedaConfiguration"> The configuration of Keda component. </param>
        /// <param name="daprConfiguration"> The configuration of Dapr component. </param>
        /// <param name="infrastructureResourceGroup"> Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. If a subnet ID is provided, this resource group will be created in the same subscription as the subnet. </param>
        /// <param name="peerAuthentication"> Peer authentication settings for the Managed Environment. </param>
        /// <param name="peerTrafficConfiguration"> Peer traffic settings for the Managed Environment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppManagedEnvironmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string kind, ManagedServiceIdentity identity, ContainerAppEnvironmentProvisioningState? provisioningState, string daprAIInstrumentationKey, string daprAIConnectionString, ContainerAppVnetConfiguration vnetConfiguration, string deploymentErrors, string defaultDomain, IPAddress staticIP, ContainerAppLogsConfiguration appLogsConfiguration, bool? isZoneRedundant, ContainerAppCustomDomainConfiguration customDomainConfiguration, string eventStreamEndpoint, IList<ContainerAppWorkloadProfile> workloadProfiles, KedaConfiguration kedaConfiguration, DaprConfiguration daprConfiguration, string infrastructureResourceGroup, ManagedEnvironmentPropertiesPeerAuthentication peerAuthentication, ManagedEnvironmentPropertiesPeerTrafficConfiguration peerTrafficConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Kind = kind;
            Identity = identity;
            ProvisioningState = provisioningState;
            DaprAIInstrumentationKey = daprAIInstrumentationKey;
            DaprAIConnectionString = daprAIConnectionString;
            VnetConfiguration = vnetConfiguration;
            DeploymentErrors = deploymentErrors;
            DefaultDomain = defaultDomain;
            StaticIP = staticIP;
            AppLogsConfiguration = appLogsConfiguration;
            IsZoneRedundant = isZoneRedundant;
            CustomDomainConfiguration = customDomainConfiguration;
            EventStreamEndpoint = eventStreamEndpoint;
            WorkloadProfiles = workloadProfiles;
            KedaConfiguration = kedaConfiguration;
            DaprConfiguration = daprConfiguration;
            InfrastructureResourceGroup = infrastructureResourceGroup;
            PeerAuthentication = peerAuthentication;
            PeerTrafficConfiguration = peerTrafficConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppManagedEnvironmentData"/> for deserialization. </summary>
        internal ContainerAppManagedEnvironmentData()
        {
        }

        /// <summary> Kind of the Environment. </summary>
        [WirePath("kind")]
        public string Kind { get; set; }
        /// <summary> Managed identities for the Managed Environment to interact with other Azure services without maintaining any secrets or credentials in code. </summary>
        [WirePath("identity")]
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Provisioning state of the Environment. </summary>
        [WirePath("properties.provisioningState")]
        public ContainerAppEnvironmentProvisioningState? ProvisioningState { get; }
        /// <summary> Azure Monitor instrumentation key used by Dapr to export Service to Service communication telemetry. </summary>
        [WirePath("properties.daprAIInstrumentationKey")]
        public string DaprAIInstrumentationKey { get; set; }
        /// <summary> Application Insights connection string used by Dapr to export Service to Service communication telemetry. </summary>
        [WirePath("properties.daprAIConnectionString")]
        public string DaprAIConnectionString { get; set; }
        /// <summary> Vnet configuration for the environment. </summary>
        [WirePath("properties.vnetConfiguration")]
        public ContainerAppVnetConfiguration VnetConfiguration { get; set; }
        /// <summary> Any errors that occurred during deployment or deployment validation. </summary>
        [WirePath("properties.deploymentErrors")]
        public string DeploymentErrors { get; }
        /// <summary> Default Domain Name for the cluster. </summary>
        [WirePath("properties.defaultDomain")]
        public string DefaultDomain { get; }
        /// <summary> Static IP of the Environment. </summary>
        [WirePath("properties.staticIp")]
        public IPAddress StaticIP { get; }
        /// <summary> Cluster configuration which enables the log daemon to export app logs to configured destination. </summary>
        [WirePath("properties.appLogsConfiguration")]
        public ContainerAppLogsConfiguration AppLogsConfiguration { get; set; }
        /// <summary> Whether or not this Managed Environment is zone-redundant. </summary>
        [WirePath("properties.zoneRedundant")]
        public bool? IsZoneRedundant { get; set; }
        /// <summary> Custom domain configuration for the environment. </summary>
        [WirePath("properties.customDomainConfiguration")]
        public ContainerAppCustomDomainConfiguration CustomDomainConfiguration { get; set; }
        /// <summary> The endpoint of the eventstream of the Environment. </summary>
        [WirePath("properties.eventStreamEndpoint")]
        public string EventStreamEndpoint { get; }
        /// <summary> Workload profiles configured for the Managed Environment. </summary>
        [WirePath("properties.workloadProfiles")]
        public IList<ContainerAppWorkloadProfile> WorkloadProfiles { get; }
        /// <summary> The configuration of Keda component. </summary>
        internal KedaConfiguration KedaConfiguration { get; set; }
        /// <summary> The version of Keda. </summary>
        [WirePath("properties.kedaConfiguration.version")]
        public string KedaVersion
        {
            get => KedaConfiguration is null ? default : KedaConfiguration.Version;
        }

        /// <summary> The configuration of Dapr component. </summary>
        internal DaprConfiguration DaprConfiguration { get; set; }
        /// <summary> The version of Dapr. </summary>
        [WirePath("properties.daprConfiguration.version")]
        public string DaprVersion
        {
            get => DaprConfiguration is null ? default : DaprConfiguration.Version;
        }

        /// <summary> Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. If a subnet ID is provided, this resource group will be created in the same subscription as the subnet. </summary>
        [WirePath("properties.infrastructureResourceGroup")]
        public string InfrastructureResourceGroup { get; set; }
        /// <summary> Peer authentication settings for the Managed Environment. </summary>
        internal ManagedEnvironmentPropertiesPeerAuthentication PeerAuthentication { get; set; }
        /// <summary> Boolean indicating whether the mutual TLS authentication is enabled. </summary>
        [WirePath("properties.peerAuthentication.mtls.enabled")]
        public bool? IsMtlsEnabled
        {
            get => PeerAuthentication is null ? default : PeerAuthentication.IsMtlsEnabled;
            set
            {
                if (PeerAuthentication is null)
                    PeerAuthentication = new ManagedEnvironmentPropertiesPeerAuthentication();
                PeerAuthentication.IsMtlsEnabled = value;
            }
        }

        /// <summary> Peer traffic settings for the Managed Environment. </summary>
        internal ManagedEnvironmentPropertiesPeerTrafficConfiguration PeerTrafficConfiguration { get; set; }
        /// <summary> Boolean indicating whether the peer traffic encryption is enabled. </summary>
        [WirePath("properties.peerTrafficConfiguration.encryption.enabled")]
        public bool? IsEnabled
        {
            get => PeerTrafficConfiguration is null ? default : PeerTrafficConfiguration.IsEnabled;
            set
            {
                if (PeerTrafficConfiguration is null)
                    PeerTrafficConfiguration = new ManagedEnvironmentPropertiesPeerTrafficConfiguration();
                PeerTrafficConfiguration.IsEnabled = value;
            }
        }
    }
}
