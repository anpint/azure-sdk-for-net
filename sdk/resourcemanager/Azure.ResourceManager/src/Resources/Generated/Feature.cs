// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A Class representing a Feature along with the instance operations that can be performed on it. </summary>
    public partial class Feature : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="Feature"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceProviderNamespace, string featureName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _featureClientDiagnostics;
        private readonly FeaturesRestOperations _featureRestClient;
        private readonly FeatureData _data;

        /// <summary> Initializes a new instance of the <see cref="Feature"/> class for mocking. </summary>
        protected Feature()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "Feature"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal Feature(ArmClient client, FeatureData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="Feature"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal Feature(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _featureClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string featureApiVersion);
            _featureRestClient = new FeaturesRestOperations(_featureClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, featureApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Resources/features";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FeatureData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}
        /// OperationId: Features_Get
        /// <summary> Gets the preview feature with the specified name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<Feature>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _featureClientDiagnostics.CreateScope("Feature.Get");
            scope.Start();
            try
            {
                var response = await _featureRestClient.GetAsync(Id.SubscriptionId, Id.ResourceType.Namespace, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _featureClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Feature(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}
        /// OperationId: Features_Get
        /// <summary> Gets the preview feature with the specified name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Feature> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _featureClientDiagnostics.CreateScope("Feature.Get");
            scope.Start();
            try
            {
                var response = _featureRestClient.Get(Id.SubscriptionId, Id.ResourceType.Namespace, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _featureClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Feature(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}/register
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}
        /// OperationId: Features_Register
        /// <summary> Registers the preview feature for the subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<Feature>> RegisterAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _featureClientDiagnostics.CreateScope("Feature.Register");
            scope.Start();
            try
            {
                var response = await _featureRestClient.RegisterAsync(Id.SubscriptionId, Id.ResourceType.Namespace, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Feature(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}/register
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}
        /// OperationId: Features_Register
        /// <summary> Registers the preview feature for the subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Feature> Register(CancellationToken cancellationToken = default)
        {
            using var scope = _featureClientDiagnostics.CreateScope("Feature.Register");
            scope.Start();
            try
            {
                var response = _featureRestClient.Register(Id.SubscriptionId, Id.ResourceType.Namespace, Id.Name, cancellationToken);
                return Response.FromValue(new Feature(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}/unregister
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}
        /// OperationId: Features_Unregister
        /// <summary> Unregisters the preview feature for the subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<Feature>> UnregisterAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _featureClientDiagnostics.CreateScope("Feature.Unregister");
            scope.Start();
            try
            {
                var response = await _featureRestClient.UnregisterAsync(Id.SubscriptionId, Id.ResourceType.Namespace, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Feature(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}/unregister
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}
        /// OperationId: Features_Unregister
        /// <summary> Unregisters the preview feature for the subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Feature> Unregister(CancellationToken cancellationToken = default)
        {
            using var scope = _featureClientDiagnostics.CreateScope("Feature.Unregister");
            scope.Start();
            try
            {
                var response = _featureRestClient.Unregister(Id.SubscriptionId, Id.ResourceType.Namespace, Id.Name, cancellationToken);
                return Response.FromValue(new Feature(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
