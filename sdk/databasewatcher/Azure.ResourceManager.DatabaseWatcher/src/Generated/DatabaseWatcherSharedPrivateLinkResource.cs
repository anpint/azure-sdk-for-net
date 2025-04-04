// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.DatabaseWatcher
{
    /// <summary>
    /// A Class representing a DatabaseWatcherSharedPrivateLinkResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DatabaseWatcherSharedPrivateLinkResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDatabaseWatcherSharedPrivateLinkResource method.
    /// Otherwise you can get one from its parent resource <see cref="DatabaseWatcherResource"/> using the GetDatabaseWatcherSharedPrivateLinkResource method.
    /// </summary>
    public partial class DatabaseWatcherSharedPrivateLinkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DatabaseWatcherSharedPrivateLinkResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="watcherName"> The watcherName. </param>
        /// <param name="sharedPrivateLinkResourceName"> The sharedPrivateLinkResourceName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string watcherName, string sharedPrivateLinkResourceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics;
        private readonly SharedPrivateLinkResourcesRestOperations _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesRestClient;
        private readonly DatabaseWatcherSharedPrivateLinkResourceData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DatabaseWatcher/watchers/sharedPrivateLinkResources";

        /// <summary> Initializes a new instance of the <see cref="DatabaseWatcherSharedPrivateLinkResource"/> class for mocking. </summary>
        protected DatabaseWatcherSharedPrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DatabaseWatcherSharedPrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DatabaseWatcherSharedPrivateLinkResource(ArmClient client, DatabaseWatcherSharedPrivateLinkResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DatabaseWatcherSharedPrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DatabaseWatcherSharedPrivateLinkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DatabaseWatcher", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesApiVersion);
            _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesRestClient = new SharedPrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DatabaseWatcherSharedPrivateLinkResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a SharedPrivateLinkResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DatabaseWatcherSharedPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DatabaseWatcherSharedPrivateLinkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics.CreateScope("DatabaseWatcherSharedPrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = await _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseWatcherSharedPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a SharedPrivateLinkResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DatabaseWatcherSharedPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DatabaseWatcherSharedPrivateLinkResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics.CreateScope("DatabaseWatcherSharedPrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseWatcherSharedPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a SharedPrivateLinkResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResource_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DatabaseWatcherSharedPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics.CreateScope("DatabaseWatcherSharedPrivateLinkResource.Delete");
            scope.Start();
            try
            {
                var response = await _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DatabaseWatcherArmOperation(_databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics, Pipeline, _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a SharedPrivateLinkResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResource_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DatabaseWatcherSharedPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics.CreateScope("DatabaseWatcherSharedPrivateLinkResource.Delete");
            scope.Start();
            try
            {
                var response = _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DatabaseWatcherArmOperation(_databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics, Pipeline, _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a SharedPrivateLinkResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResource_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DatabaseWatcherSharedPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DatabaseWatcherSharedPrivateLinkResource>> UpdateAsync(WaitUntil waitUntil, DatabaseWatcherSharedPrivateLinkResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics.CreateScope("DatabaseWatcherSharedPrivateLinkResource.Update");
            scope.Start();
            try
            {
                var response = await _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DatabaseWatcherArmOperation<DatabaseWatcherSharedPrivateLinkResource>(new DatabaseWatcherSharedPrivateLinkResourceOperationSource(Client), _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics, Pipeline, _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a SharedPrivateLinkResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedPrivateLinkResource_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DatabaseWatcherSharedPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DatabaseWatcherSharedPrivateLinkResource> Update(WaitUntil waitUntil, DatabaseWatcherSharedPrivateLinkResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics.CreateScope("DatabaseWatcherSharedPrivateLinkResource.Update");
            scope.Start();
            try
            {
                var response = _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new DatabaseWatcherArmOperation<DatabaseWatcherSharedPrivateLinkResource>(new DatabaseWatcherSharedPrivateLinkResourceOperationSource(Client), _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesClientDiagnostics, Pipeline, _databaseWatcherSharedPrivateLinkResourceSharedPrivateLinkResourcesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
    }
}
