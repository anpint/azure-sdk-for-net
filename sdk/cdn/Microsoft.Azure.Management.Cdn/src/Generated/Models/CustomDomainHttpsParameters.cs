// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The JSON object that contains the properties to secure a custom domain.
    /// </summary>
    public partial class CustomDomainHttpsParameters
    {
        /// <summary>
        /// Initializes a new instance of the CustomDomainHttpsParameters
        /// class.
        /// </summary>
        public CustomDomainHttpsParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomDomainHttpsParameters
        /// class.
        /// </summary>
        /// <param name="protocolType">Defines the TLS extension protocol that
        /// is used for secure delivery. Possible values include:
        /// 'ServerNameIndication', 'IPBased'</param>
        /// <param name="minimumTlsVersion">TLS protocol version that will be
        /// used for Https. Possible values include: 'None', 'TLS10',
        /// 'TLS12'</param>
        public CustomDomainHttpsParameters(string protocolType, MinimumTlsVersion? minimumTlsVersion = default(MinimumTlsVersion?))
        {
            ProtocolType = protocolType;
            MinimumTlsVersion = minimumTlsVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets defines the TLS extension protocol that is used for
        /// secure delivery. Possible values include: 'ServerNameIndication',
        /// 'IPBased'
        /// </summary>
        [JsonProperty(PropertyName = "protocolType")]
        public string ProtocolType { get; set; }

        /// <summary>
        /// Gets or sets TLS protocol version that will be used for Https.
        /// Possible values include: 'None', 'TLS10', 'TLS12'
        /// </summary>
        [JsonProperty(PropertyName = "minimumTlsVersion")]
        public MinimumTlsVersion? MinimumTlsVersion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ProtocolType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProtocolType");
            }
        }
    }
}
