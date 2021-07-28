// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.MachineLearningServices.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing collection of ModelVersionResource and their operations over a ModelContainerResource. </summary>
    public partial class ModelVersionResourceContainer : ResourceContainerBase<ModelVersionResource, ModelVersionResourceData>
    {
        /// <summary> Initializes a new instance of the <see cref="ModelVersionResourceContainer"/> class for mocking. </summary>
        protected ModelVersionResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of ModelVersionResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ModelVersionResourceContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private ModelVersionsRestOperations _restClient => new ModelVersionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ModelContainerResourceOperations.ResourceType;

        // Container level operations.

        /// <summary> Create or update version. </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="properties"/> is null. </exception>
        public virtual Response<ModelVersionResource> CreateOrUpdate(string version, ModelVersion properties, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("ModelVersionResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(version, properties, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update version. </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="properties"/> is null. </exception>
        public async virtual Task<Response<ModelVersionResource>> CreateOrUpdateAsync(string version, ModelVersion properties, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("ModelVersionResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(version, properties, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update version. </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="properties"/> is null. </exception>
        public virtual ModelVersionsCreateOrUpdateOperation StartCreateOrUpdate(string version, ModelVersion properties, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("ModelVersionResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, properties, cancellationToken);
                return new ModelVersionsCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update version. </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="properties"/> is null. </exception>
        public async virtual Task<ModelVersionsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string version, ModelVersion properties, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("ModelVersionResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, properties, cancellationToken).ConfigureAwait(false);
                return new ModelVersionsCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<ModelVersionResource> Get(string version, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ModelVersionResourceContainer.Get");
            scope.Start();
            try
            {
                if (version == null)
                {
                    throw new ArgumentNullException(nameof(version));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
                return Response.FromValue(new ModelVersionResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<ModelVersionResource>> GetAsync(string version, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ModelVersionResourceContainer.Get");
            scope.Start();
            try
            {
                if (version == null)
                {
                    throw new ArgumentNullException(nameof(version));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ModelVersionResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual ModelVersionResource TryGet(string version, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ModelVersionResourceContainer.TryGet");
            scope.Start();
            try
            {
                if (version == null)
                {
                    throw new ArgumentNullException(nameof(version));
                }

                return Get(version, cancellationToken: cancellationToken).Value;
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<ModelVersionResource> TryGetAsync(string version, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ModelVersionResourceContainer.TryGet");
            scope.Start();
            try
            {
                if (version == null)
                {
                    throw new ArgumentNullException(nameof(version));
                }

                return await GetAsync(version, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool CheckIfExists(string version, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ModelVersionResourceContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (version == null)
                {
                    throw new ArgumentNullException(nameof(version));
                }

                return TryGet(version, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> CheckIfExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ModelVersionResourceContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (version == null)
                {
                    throw new ArgumentNullException(nameof(version));
                }

                return await TryGetAsync(version, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List model versions. </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="orderBy"> Ordering of list. </param>
        /// <param name="top"> Maximum number of records to return. </param>
        /// <param name="version"> Model version. </param>
        /// <param name="description"> Model description. </param>
        /// <param name="offset"> Number of initial results to skip. </param>
        /// <param name="tags"> Comma-separated list of tag names (and optionally values). Example: tag1,tag2=value2. </param>
        /// <param name="properties"> Comma-separated list of property names (and optionally values). Example: prop1,prop2=value2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ModelVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<ModelVersionResource> GetAll(string skip = null, string orderBy = null, int? top = null, string version = null, string description = null, int? offset = null, string tags = null, string properties = null, CancellationToken cancellationToken = default)
        {
            Page<ModelVersionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ModelVersionResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, orderBy, top, version, description, offset, tags, properties, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ModelVersionResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ModelVersionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ModelVersionResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, orderBy, top, version, description, offset, tags, properties, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ModelVersionResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List model versions. </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="orderBy"> Ordering of list. </param>
        /// <param name="top"> Maximum number of records to return. </param>
        /// <param name="version"> Model version. </param>
        /// <param name="description"> Model description. </param>
        /// <param name="offset"> Number of initial results to skip. </param>
        /// <param name="tags"> Comma-separated list of tag names (and optionally values). Example: tag1,tag2=value2. </param>
        /// <param name="properties"> Comma-separated list of property names (and optionally values). Example: prop1,prop2=value2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ModelVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<ModelVersionResource> GetAllAsync(string skip = null, string orderBy = null, int? top = null, string version = null, string description = null, int? offset = null, string tags = null, string properties = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ModelVersionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ModelVersionResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, orderBy, top, version, description, offset, tags, properties, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ModelVersionResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ModelVersionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ModelVersionResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, orderBy, top, version, description, offset, tags, properties, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ModelVersionResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="ModelVersionResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ModelVersionResourceContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ModelVersionResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ModelVersionResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ModelVersionResourceContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ModelVersionResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, ModelVersionResource, ModelVersionResourceData> Construct() { }
    }
}
