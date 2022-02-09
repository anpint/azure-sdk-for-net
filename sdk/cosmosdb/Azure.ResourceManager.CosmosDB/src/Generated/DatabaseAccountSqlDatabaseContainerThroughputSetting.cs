// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A Class representing a DatabaseAccountSqlDatabaseContainerThroughputSetting along with the instance operations that can be performed on it. </summary>
    public partial class DatabaseAccountSqlDatabaseContainerThroughputSetting : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DatabaseAccountSqlDatabaseContainerThroughputSetting"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string databaseName, string containerName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/throughputSettings/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics;
        private readonly SqlResourcesRestOperations _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient;
        private readonly ThroughputSettingsData _data;

        /// <summary> Initializes a new instance of the <see cref="DatabaseAccountSqlDatabaseContainerThroughputSetting"/> class for mocking. </summary>
        protected DatabaseAccountSqlDatabaseContainerThroughputSetting()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DatabaseAccountSqlDatabaseContainerThroughputSetting"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DatabaseAccountSqlDatabaseContainerThroughputSetting(ArmClient client, ThroughputSettingsData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DatabaseAccountSqlDatabaseContainerThroughputSetting"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DatabaseAccountSqlDatabaseContainerThroughputSetting(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesApiVersion);
            _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient = new SqlResourcesRestOperations(_databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers/throughputSettings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ThroughputSettingsData Data
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

        /// <summary> Gets the RUs per second of the SQL container under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DatabaseAccountSqlDatabaseContainerThroughputSetting>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseContainerThroughputSetting.Get");
            scope.Start();
            try
            {
                var response = await _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.GetSqlContainerThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountSqlDatabaseContainerThroughputSetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the RUs per second of the SQL container under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DatabaseAccountSqlDatabaseContainerThroughputSetting> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseContainerThroughputSetting.Get");
            scope.Start();
            try
            {
                var response = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.GetSqlContainerThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseAccountSqlDatabaseContainerThroughputSetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update RUs per second of an Azure Cosmos DB SQL container. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="updateThroughputParameters"> The parameters to provide for the RUs per second of the current SQL container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateThroughputParameters"/> is null. </exception>
        public async virtual Task<DatabaseAccountSqlDatabaseContainerThroughputSettingCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, ThroughputSettingsUpdateOptions updateThroughputParameters, CancellationToken cancellationToken = default)
        {
            if (updateThroughputParameters == null)
            {
                throw new ArgumentNullException(nameof(updateThroughputParameters));
            }

            using var scope = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseContainerThroughputSetting.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.UpdateSqlContainerThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters, cancellationToken).ConfigureAwait(false);
                var operation = new DatabaseAccountSqlDatabaseContainerThroughputSettingCreateOrUpdateOperation(Client, _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics, Pipeline, _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.CreateUpdateSqlContainerThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update RUs per second of an Azure Cosmos DB SQL container. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="updateThroughputParameters"> The parameters to provide for the RUs per second of the current SQL container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateThroughputParameters"/> is null. </exception>
        public virtual DatabaseAccountSqlDatabaseContainerThroughputSettingCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, ThroughputSettingsUpdateOptions updateThroughputParameters, CancellationToken cancellationToken = default)
        {
            if (updateThroughputParameters == null)
            {
                throw new ArgumentNullException(nameof(updateThroughputParameters));
            }

            using var scope = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseContainerThroughputSetting.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.UpdateSqlContainerThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters, cancellationToken);
                var operation = new DatabaseAccountSqlDatabaseContainerThroughputSettingCreateOrUpdateOperation(Client, _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics, Pipeline, _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.CreateUpdateSqlContainerThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Migrate an Azure Cosmos DB SQL container from manual throughput to autoscale. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<DatabaseAccountSqlDatabaseContainerThroughputSettingMigrateSqlContainerToAutoscaleOperation> MigrateSqlContainerToAutoscaleAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseContainerThroughputSetting.MigrateSqlContainerToAutoscale");
            scope.Start();
            try
            {
                var response = await _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.MigrateSqlContainerToAutoscaleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DatabaseAccountSqlDatabaseContainerThroughputSettingMigrateSqlContainerToAutoscaleOperation(_databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics, Pipeline, _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.CreateMigrateSqlContainerToAutoscaleRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Migrate an Azure Cosmos DB SQL container from manual throughput to autoscale. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual DatabaseAccountSqlDatabaseContainerThroughputSettingMigrateSqlContainerToAutoscaleOperation MigrateSqlContainerToAutoscale(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseContainerThroughputSetting.MigrateSqlContainerToAutoscale");
            scope.Start();
            try
            {
                var response = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.MigrateSqlContainerToAutoscale(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                var operation = new DatabaseAccountSqlDatabaseContainerThroughputSettingMigrateSqlContainerToAutoscaleOperation(_databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics, Pipeline, _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.CreateMigrateSqlContainerToAutoscaleRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Migrate an Azure Cosmos DB SQL container from autoscale to manual throughput. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<DatabaseAccountSqlDatabaseContainerThroughputSettingMigrateSqlContainerToManualThroughputOperation> MigrateSqlContainerToManualThroughputAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseContainerThroughputSetting.MigrateSqlContainerToManualThroughput");
            scope.Start();
            try
            {
                var response = await _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.MigrateSqlContainerToManualThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DatabaseAccountSqlDatabaseContainerThroughputSettingMigrateSqlContainerToManualThroughputOperation(_databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics, Pipeline, _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.CreateMigrateSqlContainerToManualThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Migrate an Azure Cosmos DB SQL container from autoscale to manual throughput. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual DatabaseAccountSqlDatabaseContainerThroughputSettingMigrateSqlContainerToManualThroughputOperation MigrateSqlContainerToManualThroughput(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseContainerThroughputSetting.MigrateSqlContainerToManualThroughput");
            scope.Start();
            try
            {
                var response = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.MigrateSqlContainerToManualThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                var operation = new DatabaseAccountSqlDatabaseContainerThroughputSettingMigrateSqlContainerToManualThroughputOperation(_databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics, Pipeline, _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.CreateMigrateSqlContainerToManualThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<DatabaseAccountSqlDatabaseContainerThroughputSetting>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseContainerThroughputSetting.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.GetSqlContainerThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountSqlDatabaseContainerThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<DatabaseAccountSqlDatabaseContainerThroughputSetting> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseContainerThroughputSetting.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.GetSqlContainerThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new DatabaseAccountSqlDatabaseContainerThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<DatabaseAccountSqlDatabaseContainerThroughputSetting>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseContainerThroughputSetting.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.GetSqlContainerThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountSqlDatabaseContainerThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<DatabaseAccountSqlDatabaseContainerThroughputSetting> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseContainerThroughputSetting.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.GetSqlContainerThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new DatabaseAccountSqlDatabaseContainerThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<DatabaseAccountSqlDatabaseContainerThroughputSetting>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseContainerThroughputSetting.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.GetSqlContainerThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountSqlDatabaseContainerThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<DatabaseAccountSqlDatabaseContainerThroughputSetting> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseContainerThroughputSetting.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _databaseAccountSqlDatabaseContainerThroughputSettingSqlResourcesRestClient.GetSqlContainerThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new DatabaseAccountSqlDatabaseContainerThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
