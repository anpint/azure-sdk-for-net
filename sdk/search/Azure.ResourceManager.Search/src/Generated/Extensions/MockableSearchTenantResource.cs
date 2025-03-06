// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Search.Models;

namespace Azure.ResourceManager.Search.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class MockableSearchTenantResource : ArmResource
    {
        private ClientDiagnostics _offeringsClientDiagnostics;
        private OfferingsRestOperations _offeringsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableSearchTenantResource"/> class for mocking. </summary>
        protected MockableSearchTenantResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableSearchTenantResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableSearchTenantResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics OfferingsClientDiagnostics => _offeringsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Search", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private OfferingsRestOperations OfferingsRestClient => _offeringsRestClient ??= new OfferingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all of the features and SKUs offered by the Azure AI Search service in each region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Search/offerings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Offerings_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SearchServiceOfferingsByRegion"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SearchServiceOfferingsByRegion> GetOfferingsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OfferingsRestClient.CreateListRequest();
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => SearchServiceOfferingsByRegion.DeserializeSearchServiceOfferingsByRegion(e), OfferingsClientDiagnostics, Pipeline, "MockableSearchTenantResource.GetOfferings", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all of the features and SKUs offered by the Azure AI Search service in each region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Search/offerings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Offerings_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SearchServiceOfferingsByRegion"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SearchServiceOfferingsByRegion> GetOfferings(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OfferingsRestClient.CreateListRequest();
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => SearchServiceOfferingsByRegion.DeserializeSearchServiceOfferingsByRegion(e), OfferingsClientDiagnostics, Pipeline, "MockableSearchTenantResource.GetOfferings", "value", null, cancellationToken);
        }
    }
}
