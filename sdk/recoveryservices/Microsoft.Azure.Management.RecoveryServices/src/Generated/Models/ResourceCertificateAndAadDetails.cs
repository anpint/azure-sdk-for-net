// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Certificate details representing the Vault credentials for AAD.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureActiveDirectory")]
    public partial class ResourceCertificateAndAadDetails : ResourceCertificateDetails
    {
        /// <summary>
        /// Initializes a new instance of the ResourceCertificateAndAadDetails
        /// class.
        /// </summary>
        public ResourceCertificateAndAadDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceCertificateAndAadDetails
        /// class.
        /// </summary>
        /// <param name="aadAuthority">AAD tenant authority.</param>
        /// <param name="aadTenantId">AAD tenant Id.</param>
        /// <param name="servicePrincipalClientId">AAD service principal
        /// clientId.</param>
        /// <param name="servicePrincipalObjectId">AAD service principal
        /// ObjectId.</param>
        /// <param name="azureManagementEndpointAudience">Azure Management
        /// Endpoint Audience.</param>
        /// <param name="certificate">The base64 encoded certificate raw data
        /// string.</param>
        /// <param name="friendlyName">Certificate friendly name.</param>
        /// <param name="issuer">Certificate issuer.</param>
        /// <param name="resourceId">Resource ID of the vault.</param>
        /// <param name="subject">Certificate Subject Name.</param>
        /// <param name="thumbprint">Certificate thumbprint.</param>
        /// <param name="validFrom">Certificate Validity start Date
        /// time.</param>
        /// <param name="validTo">Certificate Validity End Date time.</param>
        /// <param name="serviceResourceId">Service Resource Id.</param>
        public ResourceCertificateAndAadDetails(string aadAuthority, string aadTenantId, string servicePrincipalClientId, string servicePrincipalObjectId, string azureManagementEndpointAudience, byte[] certificate = default(byte[]), string friendlyName = default(string), string issuer = default(string), long? resourceId = default(long?), string subject = default(string), string thumbprint = default(string), System.DateTime? validFrom = default(System.DateTime?), System.DateTime? validTo = default(System.DateTime?), string serviceResourceId = default(string))
            : base(certificate, friendlyName, issuer, resourceId, subject, thumbprint, validFrom, validTo)
        {
            AadAuthority = aadAuthority;
            AadTenantId = aadTenantId;
            ServicePrincipalClientId = servicePrincipalClientId;
            ServicePrincipalObjectId = servicePrincipalObjectId;
            AzureManagementEndpointAudience = azureManagementEndpointAudience;
            ServiceResourceId = serviceResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets AAD tenant authority.
        /// </summary>
        [JsonProperty(PropertyName = "aadAuthority")]
        public string AadAuthority { get; set; }

        /// <summary>
        /// Gets or sets AAD tenant Id.
        /// </summary>
        [JsonProperty(PropertyName = "aadTenantId")]
        public string AadTenantId { get; set; }

        /// <summary>
        /// Gets or sets AAD service principal clientId.
        /// </summary>
        [JsonProperty(PropertyName = "servicePrincipalClientId")]
        public string ServicePrincipalClientId { get; set; }

        /// <summary>
        /// Gets or sets AAD service principal ObjectId.
        /// </summary>
        [JsonProperty(PropertyName = "servicePrincipalObjectId")]
        public string ServicePrincipalObjectId { get; set; }

        /// <summary>
        /// Gets or sets azure Management Endpoint Audience.
        /// </summary>
        [JsonProperty(PropertyName = "azureManagementEndpointAudience")]
        public string AzureManagementEndpointAudience { get; set; }

        /// <summary>
        /// Gets or sets service Resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "serviceResourceId")]
        public string ServiceResourceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AadAuthority == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AadAuthority");
            }
            if (AadTenantId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AadTenantId");
            }
            if (ServicePrincipalClientId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServicePrincipalClientId");
            }
            if (ServicePrincipalObjectId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServicePrincipalObjectId");
            }
            if (AzureManagementEndpointAudience == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AzureManagementEndpointAudience");
            }
        }
    }
}
