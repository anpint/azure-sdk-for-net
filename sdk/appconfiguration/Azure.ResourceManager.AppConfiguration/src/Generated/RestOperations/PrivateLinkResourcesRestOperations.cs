// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppConfiguration.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppConfiguration
{
    internal partial class PrivateLinkResourcesRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of PrivateLinkResourcesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public PrivateLinkResourcesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2020-06-01";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = Core.HttpMessageUtilities.GetUserAgentName(this, applicationId);
        }

        internal HttpMessage CreateListByConfigurationStoreRequest(string subscriptionId, string resourceGroupName, string configStoreName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AppConfiguration/configurationStores/", false);
            uri.AppendPath(configStoreName, true);
            uri.AppendPath("/privateLinkResources", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Gets the private link resources that need to be created for a configuration store. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="configStoreName"/> is null. </exception>
        public async Task<Response<PrivateLinkResourceListResult>> ListByConfigurationStoreAsync(string subscriptionId, string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var message = CreateListByConfigurationStoreRequest(subscriptionId, resourceGroupName, configStoreName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateLinkResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PrivateLinkResourceListResult.DeserializePrivateLinkResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the private link resources that need to be created for a configuration store. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="configStoreName"/> is null. </exception>
        public Response<PrivateLinkResourceListResult> ListByConfigurationStore(string subscriptionId, string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var message = CreateListByConfigurationStoreRequest(subscriptionId, resourceGroupName, configStoreName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateLinkResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PrivateLinkResourceListResult.DeserializePrivateLinkResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string configStoreName, string groupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AppConfiguration/configurationStores/", false);
            uri.AppendPath(configStoreName, true);
            uri.AppendPath("/privateLinkResources/", false);
            uri.AppendPath(groupName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Gets a private link resource that need to be created for a configuration store. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="groupName"> The name of the private link resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="configStoreName"/>, or <paramref name="groupName"/> is null. </exception>
        public async Task<Response<PrivateLinkResourceData>> GetAsync(string subscriptionId, string resourceGroupName, string configStoreName, string groupName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, configStoreName, groupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateLinkResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PrivateLinkResourceData.DeserializePrivateLinkResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PrivateLinkResourceData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a private link resource that need to be created for a configuration store. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="groupName"> The name of the private link resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="configStoreName"/>, or <paramref name="groupName"/> is null. </exception>
        public Response<PrivateLinkResourceData> Get(string subscriptionId, string resourceGroupName, string configStoreName, string groupName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, configStoreName, groupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateLinkResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PrivateLinkResourceData.DeserializePrivateLinkResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PrivateLinkResourceData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByConfigurationStoreNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string configStoreName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Gets the private link resources that need to be created for a configuration store. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="configStoreName"/> is null. </exception>
        public async Task<Response<PrivateLinkResourceListResult>> ListByConfigurationStoreNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var message = CreateListByConfigurationStoreNextPageRequest(nextLink, subscriptionId, resourceGroupName, configStoreName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateLinkResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PrivateLinkResourceListResult.DeserializePrivateLinkResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the private link resources that need to be created for a configuration store. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="configStoreName"/> is null. </exception>
        public Response<PrivateLinkResourceListResult> ListByConfigurationStoreNextPage(string nextLink, string subscriptionId, string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var message = CreateListByConfigurationStoreNextPageRequest(nextLink, subscriptionId, resourceGroupName, configStoreName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateLinkResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PrivateLinkResourceListResult.DeserializePrivateLinkResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
