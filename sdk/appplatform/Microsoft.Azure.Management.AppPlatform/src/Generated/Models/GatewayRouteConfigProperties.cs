// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// API route config of the Spring Cloud Gateway
    /// </summary>
    public partial class GatewayRouteConfigProperties
    {
        /// <summary>
        /// Initializes a new instance of the GatewayRouteConfigProperties
        /// class.
        /// </summary>
        public GatewayRouteConfigProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GatewayRouteConfigProperties
        /// class.
        /// </summary>
        /// <param name="provisioningState">State of the Spring Cloud Gateway
        /// route config. Possible values include: 'Creating', 'Updating',
        /// 'Succeeded', 'Failed', 'Deleting'</param>
        /// <param name="appResourceId">The resource Id of the Azure Spring
        /// Cloud app, required unless route defines `uri`.</param>
        /// <param name="routes">Array of API routes, each route contains
        /// properties such as `title`, `uri`, `ssoEnabled`, `predicates`,
        /// `filters`.</param>
        public GatewayRouteConfigProperties(string provisioningState = default(string), string appResourceId = default(string), IList<GatewayApiRoute> routes = default(IList<GatewayApiRoute>))
        {
            ProvisioningState = provisioningState;
            AppResourceId = appResourceId;
            Routes = routes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets state of the Spring Cloud Gateway route config. Possible
        /// values include: 'Creating', 'Updating', 'Succeeded', 'Failed',
        /// 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the resource Id of the Azure Spring Cloud app,
        /// required unless route defines `uri`.
        /// </summary>
        [JsonProperty(PropertyName = "appResourceId")]
        public string AppResourceId { get; set; }

        /// <summary>
        /// Gets or sets array of API routes, each route contains properties
        /// such as `title`, `uri`, `ssoEnabled`, `predicates`, `filters`.
        /// </summary>
        [JsonProperty(PropertyName = "routes")]
        public IList<GatewayApiRoute> Routes { get; set; }

    }
}
