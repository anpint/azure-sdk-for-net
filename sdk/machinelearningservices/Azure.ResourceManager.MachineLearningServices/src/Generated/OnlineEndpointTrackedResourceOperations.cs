// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.MachineLearningServices.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing the operations that can be performed over a specific OnlineEndpointTrackedResource. </summary>
    public partial class OnlineEndpointTrackedResourceOperations : ResourceOperationsBase<OnlineEndpointTrackedResource>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private OnlineEndpointsRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="OnlineEndpointTrackedResourceOperations"/> class for mocking. </summary>
        protected OnlineEndpointTrackedResourceOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OnlineEndpointTrackedResourceOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal OnlineEndpointTrackedResourceOperations(OperationsBase options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new OnlineEndpointsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MachineLearningServices/workspaces/onlineEndpoints";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<OnlineEndpointTrackedResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new OnlineEndpointTrackedResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<OnlineEndpointTrackedResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new OnlineEndpointTrackedResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Delete Online Endpoint (asynchronous). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete Online Endpoint (asynchronous). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete Online Endpoint (asynchronous). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<OnlineEndpointsDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new OnlineEndpointsDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete Online Endpoint (asynchronous). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual OnlineEndpointsDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new OnlineEndpointsDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public async virtual Task<Response<OnlineEndpointTrackedResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResourceOperations.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagContainer.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new OnlineEndpointTrackedResource(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public virtual Response<OnlineEndpointTrackedResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResourceOperations.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagContainer.CreateOrUpdate(originalTags.Value.Data, cancellationToken);
                var originalResponse = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new OnlineEndpointTrackedResource(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public async virtual Task<Response<OnlineEndpointTrackedResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException($"{nameof(tags)} provided cannot be null.", nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.SetTags");
            scope.Start();
            try
            {
                await TagResourceOperations.DeleteAsync(cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResourceOperations.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagContainer.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new OnlineEndpointTrackedResource(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public virtual Response<OnlineEndpointTrackedResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException($"{nameof(tags)} provided cannot be null.", nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.SetTags");
            scope.Start();
            try
            {
                TagResourceOperations.Delete(cancellationToken);
                var originalTags = TagResourceOperations.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagContainer.CreateOrUpdate(originalTags.Value.Data, cancellationToken);
                var originalResponse = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new OnlineEndpointTrackedResource(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public async virtual Task<Response<OnlineEndpointTrackedResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResourceOperations.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagContainer.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new OnlineEndpointTrackedResource(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public virtual Response<OnlineEndpointTrackedResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResourceOperations.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagContainer.CreateOrUpdate(originalTags.Value.Data, cancellationToken);
                var originalResponse = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new OnlineEndpointTrackedResource(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> List EndpointAuthKeys for an Endpoint using Key-based authentication. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EndpointAuthKeys>> GetKeysAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.GetKeys");
            scope.Start();
            try
            {
                var response = await _restClient.GetKeysAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List EndpointAuthKeys for an Endpoint using Key-based authentication. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EndpointAuthKeys> GetKeys(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.GetKeys");
            scope.Start();
            try
            {
                var response = _restClient.GetKeys(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieve a valid AAD token for an Endpoint using AMLToken-based authentication. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EndpointAuthToken>> GetTokenAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.GetToken");
            scope.Start();
            try
            {
                var response = await _restClient.GetTokenAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieve a valid AAD token for an Endpoint using AMLToken-based authentication. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EndpointAuthToken> GetToken(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.GetToken");
            scope.Start();
            try
            {
                var response = _restClient.GetToken(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update Online Endpoint (asynchronous). </summary>
        /// <param name="body"> Online Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public async virtual Task<Response<OnlineEndpointTrackedResource>> UpdateAsync(PartialOnlineEndpointPartialTrackedResource body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.Update");
            scope.Start();
            try
            {
                var operation = await StartUpdateAsync(body, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update Online Endpoint (asynchronous). </summary>
        /// <param name="body"> Online Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual Response<OnlineEndpointTrackedResource> Update(PartialOnlineEndpointPartialTrackedResource body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.Update");
            scope.Start();
            try
            {
                var operation = StartUpdate(body, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update Online Endpoint (asynchronous). </summary>
        /// <param name="body"> Online Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public async virtual Task<OnlineEndpointsUpdateOperation> StartUpdateAsync(PartialOnlineEndpointPartialTrackedResource body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.StartUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, body, cancellationToken).ConfigureAwait(false);
                return new OnlineEndpointsUpdateOperation(this, _clientDiagnostics, Pipeline, _restClient.CreateUpdateRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, body).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update Online Endpoint (asynchronous). </summary>
        /// <param name="body"> Online Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual OnlineEndpointsUpdateOperation StartUpdate(PartialOnlineEndpointPartialTrackedResource body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.StartUpdate");
            scope.Start();
            try
            {
                var response = _restClient.Update(Id.ResourceGroupName, Id.Parent.Name, Id.Name, body, cancellationToken);
                return new OnlineEndpointsUpdateOperation(this, _clientDiagnostics, Pipeline, _restClient.CreateUpdateRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, body).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Regenerate EndpointAuthKeys for an Endpoint using Key-based authentication (asynchronous). </summary>
        /// <param name="keyValue"> The value the key is set to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> RegenerateKeysAsync(string keyValue = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.RegenerateKeys");
            scope.Start();
            try
            {
                var operation = await StartRegenerateKeysAsync(keyValue, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Regenerate EndpointAuthKeys for an Endpoint using Key-based authentication (asynchronous). </summary>
        /// <param name="keyValue"> The value the key is set to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RegenerateKeys(string keyValue = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.RegenerateKeys");
            scope.Start();
            try
            {
                var operation = StartRegenerateKeys(keyValue, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Regenerate EndpointAuthKeys for an Endpoint using Key-based authentication (asynchronous). </summary>
        /// <param name="keyValue"> The value the key is set to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<OnlineEndpointsRegenerateKeysOperation> StartRegenerateKeysAsync(string keyValue = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.StartRegenerateKeys");
            scope.Start();
            try
            {
                var response = await _restClient.RegenerateKeysAsync(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, keyValue, cancellationToken).ConfigureAwait(false);
                return new OnlineEndpointsRegenerateKeysOperation(_clientDiagnostics, Pipeline, _restClient.CreateRegenerateKeysRequest(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, keyValue).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Regenerate EndpointAuthKeys for an Endpoint using Key-based authentication (asynchronous). </summary>
        /// <param name="keyValue"> The value the key is set to. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual OnlineEndpointsRegenerateKeysOperation StartRegenerateKeys(string keyValue = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineEndpointTrackedResourceOperations.StartRegenerateKeys");
            scope.Start();
            try
            {
                var response = _restClient.RegenerateKeys(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, keyValue, cancellationToken);
                return new OnlineEndpointsRegenerateKeysOperation(_clientDiagnostics, Pipeline, _restClient.CreateRegenerateKeysRequest(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, keyValue).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of OnlineDeploymentTrackedResources in the OnlineEndpointTrackedResource. </summary>
        /// <returns> An object representing collection of OnlineDeploymentTrackedResources and their operations over a OnlineEndpointTrackedResource. </returns>
        public OnlineDeploymentTrackedResourceContainer GetOnlineDeploymentTrackedResources()
        {
            return new OnlineDeploymentTrackedResourceContainer(this);
        }
    }
}
