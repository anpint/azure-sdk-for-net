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

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a LogicalDatabaseTransparentDataEncryption along with the instance operations that can be performed on it. </summary>
    public partial class LogicalDatabaseTransparentDataEncryption : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LogicalDatabaseTransparentDataEncryption"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string tdeName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/transparentDataEncryption/{tdeName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics;
        private readonly TransparentDataEncryptionsRestOperations _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient;
        private readonly LogicalDatabaseTransparentDataEncryptionData _data;

        /// <summary> Initializes a new instance of the <see cref="LogicalDatabaseTransparentDataEncryption"/> class for mocking. </summary>
        protected LogicalDatabaseTransparentDataEncryption()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "LogicalDatabaseTransparentDataEncryption"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LogicalDatabaseTransparentDataEncryption(ArmClient armClient, LogicalDatabaseTransparentDataEncryptionData data) : this(armClient, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="LogicalDatabaseTransparentDataEncryption"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LogicalDatabaseTransparentDataEncryption(ArmClient armClient, ResourceIdentifier id) : base(armClient, id)
        {
            _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(ResourceType, out string logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsApiVersion);
            _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient = new TransparentDataEncryptionsRestOperations(_logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/transparentDataEncryption";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LogicalDatabaseTransparentDataEncryptionData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/transparentDataEncryption/{tdeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/transparentDataEncryption/{tdeName}
        /// OperationId: TransparentDataEncryptions_Get
        /// <summary> Gets a logical database&apos;s transparent data encryption. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<LogicalDatabaseTransparentDataEncryption>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics.CreateScope("LogicalDatabaseTransparentDataEncryption.Get");
            scope.Start();
            try
            {
                var response = await _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new LogicalDatabaseTransparentDataEncryption(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/transparentDataEncryption/{tdeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/transparentDataEncryption/{tdeName}
        /// OperationId: TransparentDataEncryptions_Get
        /// <summary> Gets a logical database&apos;s transparent data encryption. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LogicalDatabaseTransparentDataEncryption> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics.CreateScope("LogicalDatabaseTransparentDataEncryption.Get");
            scope.Start();
            try
            {
                var response = _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicalDatabaseTransparentDataEncryption(ArmClient, response.Value), response.GetRawResponse());
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
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics.CreateScope("LogicalDatabaseTransparentDataEncryption.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
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
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _logicalDatabaseTransparentDataEncryptionTransparentDataEncryptionsClientDiagnostics.CreateScope("LogicalDatabaseTransparentDataEncryption.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
