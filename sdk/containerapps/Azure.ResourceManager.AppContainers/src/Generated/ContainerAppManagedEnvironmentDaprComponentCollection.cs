// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerAppManagedEnvironmentDaprComponentResource"/> and their operations.
    /// Each <see cref="ContainerAppManagedEnvironmentDaprComponentResource"/> in the collection will belong to the same instance of <see cref="ContainerAppManagedEnvironmentResource"/>.
    /// To get a <see cref="ContainerAppManagedEnvironmentDaprComponentCollection"/> instance call the GetContainerAppManagedEnvironmentDaprComponents method from an instance of <see cref="ContainerAppManagedEnvironmentResource"/>.
    /// </summary>
    public partial class ContainerAppManagedEnvironmentDaprComponentCollection : ArmCollection, IEnumerable<ContainerAppManagedEnvironmentDaprComponentResource>, IAsyncEnumerable<ContainerAppManagedEnvironmentDaprComponentResource>
    {
        private readonly ClientDiagnostics _containerAppManagedEnvironmentDaprComponentDaprComponentsClientDiagnostics;
        private readonly DaprComponentsRestOperations _containerAppManagedEnvironmentDaprComponentDaprComponentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppManagedEnvironmentDaprComponentCollection"/> class for mocking. </summary>
        protected ContainerAppManagedEnvironmentDaprComponentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppManagedEnvironmentDaprComponentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerAppManagedEnvironmentDaprComponentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppManagedEnvironmentDaprComponentDaprComponentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppManagedEnvironmentDaprComponentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerAppManagedEnvironmentDaprComponentResource.ResourceType, out string containerAppManagedEnvironmentDaprComponentDaprComponentsApiVersion);
            _containerAppManagedEnvironmentDaprComponentDaprComponentsRestClient = new DaprComponentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppManagedEnvironmentDaprComponentDaprComponentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerAppManagedEnvironmentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerAppManagedEnvironmentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a Dapr Component in a Managed Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DaprComponents_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="componentName"> Name of the Dapr Component. </param>
        /// <param name="data"> Configuration details of the Dapr Component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerAppManagedEnvironmentDaprComponentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string componentName, ContainerAppDaprComponentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppManagedEnvironmentDaprComponentDaprComponentsClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentDaprComponentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerAppManagedEnvironmentDaprComponentDaprComponentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, data, cancellationToken).ConfigureAwait(false);
                var uri = _containerAppManagedEnvironmentDaprComponentDaprComponentsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AppContainersArmOperation<ContainerAppManagedEnvironmentDaprComponentResource>(Response.FromValue(new ContainerAppManagedEnvironmentDaprComponentResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a Dapr Component in a Managed Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DaprComponents_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="componentName"> Name of the Dapr Component. </param>
        /// <param name="data"> Configuration details of the Dapr Component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerAppManagedEnvironmentDaprComponentResource> CreateOrUpdate(WaitUntil waitUntil, string componentName, ContainerAppDaprComponentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppManagedEnvironmentDaprComponentDaprComponentsClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentDaprComponentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerAppManagedEnvironmentDaprComponentDaprComponentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, data, cancellationToken);
                var uri = _containerAppManagedEnvironmentDaprComponentDaprComponentsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AppContainersArmOperation<ContainerAppManagedEnvironmentDaprComponentResource>(Response.FromValue(new ContainerAppManagedEnvironmentDaprComponentResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a dapr component.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DaprComponents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="componentName"> Name of the Dapr Component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public virtual async Task<Response<ContainerAppManagedEnvironmentDaprComponentResource>> GetAsync(string componentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));

            using var scope = _containerAppManagedEnvironmentDaprComponentDaprComponentsClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentDaprComponentCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerAppManagedEnvironmentDaprComponentDaprComponentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedEnvironmentDaprComponentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a dapr component.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DaprComponents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="componentName"> Name of the Dapr Component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public virtual Response<ContainerAppManagedEnvironmentDaprComponentResource> Get(string componentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));

            using var scope = _containerAppManagedEnvironmentDaprComponentDaprComponentsClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentDaprComponentCollection.Get");
            scope.Start();
            try
            {
                var response = _containerAppManagedEnvironmentDaprComponentDaprComponentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedEnvironmentDaprComponentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Dapr Components for a managed environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/daprComponents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DaprComponents_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppManagedEnvironmentDaprComponentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppManagedEnvironmentDaprComponentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppManagedEnvironmentDaprComponentDaprComponentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppManagedEnvironmentDaprComponentDaprComponentsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerAppManagedEnvironmentDaprComponentResource(Client, ContainerAppDaprComponentData.DeserializeContainerAppDaprComponentData(e)), _containerAppManagedEnvironmentDaprComponentDaprComponentsClientDiagnostics, Pipeline, "ContainerAppManagedEnvironmentDaprComponentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the Dapr Components for a managed environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/daprComponents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DaprComponents_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppManagedEnvironmentDaprComponentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppManagedEnvironmentDaprComponentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppManagedEnvironmentDaprComponentDaprComponentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppManagedEnvironmentDaprComponentDaprComponentsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerAppManagedEnvironmentDaprComponentResource(Client, ContainerAppDaprComponentData.DeserializeContainerAppDaprComponentData(e)), _containerAppManagedEnvironmentDaprComponentDaprComponentsClientDiagnostics, Pipeline, "ContainerAppManagedEnvironmentDaprComponentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DaprComponents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="componentName"> Name of the Dapr Component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string componentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));

            using var scope = _containerAppManagedEnvironmentDaprComponentDaprComponentsClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentDaprComponentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerAppManagedEnvironmentDaprComponentDaprComponentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DaprComponents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="componentName"> Name of the Dapr Component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public virtual Response<bool> Exists(string componentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));

            using var scope = _containerAppManagedEnvironmentDaprComponentDaprComponentsClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentDaprComponentCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerAppManagedEnvironmentDaprComponentDaprComponentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DaprComponents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="componentName"> Name of the Dapr Component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerAppManagedEnvironmentDaprComponentResource>> GetIfExistsAsync(string componentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));

            using var scope = _containerAppManagedEnvironmentDaprComponentDaprComponentsClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentDaprComponentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerAppManagedEnvironmentDaprComponentDaprComponentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppManagedEnvironmentDaprComponentResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedEnvironmentDaprComponentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/daprComponents/{componentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DaprComponents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentDaprComponentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="componentName"> Name of the Dapr Component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public virtual NullableResponse<ContainerAppManagedEnvironmentDaprComponentResource> GetIfExists(string componentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));

            using var scope = _containerAppManagedEnvironmentDaprComponentDaprComponentsClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentDaprComponentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerAppManagedEnvironmentDaprComponentDaprComponentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, componentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppManagedEnvironmentDaprComponentResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedEnvironmentDaprComponentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerAppManagedEnvironmentDaprComponentResource> IEnumerable<ContainerAppManagedEnvironmentDaprComponentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerAppManagedEnvironmentDaprComponentResource> IAsyncEnumerable<ContainerAppManagedEnvironmentDaprComponentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
