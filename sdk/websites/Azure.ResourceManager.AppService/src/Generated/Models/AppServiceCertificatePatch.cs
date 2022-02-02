// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Key Vault container ARM resource for a certificate that is purchased through Azure. </summary>
    public partial class AppServiceCertificatePatch : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of AppServiceCertificatePatch. </summary>
        public AppServiceCertificatePatch()
        {
        }

        /// <summary> Initializes a new instance of AppServiceCertificatePatch. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="keyVaultId"> Key Vault resource Id. </param>
        /// <param name="keyVaultSecretName"> Key Vault secret name. </param>
        /// <param name="provisioningState"> Status of the Key Vault secret. </param>
        internal AppServiceCertificatePatch(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string kind, string keyVaultId, string keyVaultSecretName, KeyVaultSecretStatus? provisioningState) : base(id, name, type, systemData, kind)
        {
            KeyVaultId = keyVaultId;
            KeyVaultSecretName = keyVaultSecretName;
            ProvisioningState = provisioningState;
        }

        /// <summary> Key Vault resource Id. </summary>
        public string KeyVaultId { get; set; }
        /// <summary> Key Vault secret name. </summary>
        public string KeyVaultSecretName { get; set; }
        /// <summary> Status of the Key Vault secret. </summary>
        public KeyVaultSecretStatus? ProvisioningState { get; }
    }
}
