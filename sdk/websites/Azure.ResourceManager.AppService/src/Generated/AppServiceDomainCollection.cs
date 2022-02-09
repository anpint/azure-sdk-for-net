// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of AppServiceDomain and their operations over its parent. </summary>
    public partial class AppServiceDomainCollection : ArmCollection, IEnumerable<AppServiceDomain>, IAsyncEnumerable<AppServiceDomain>
    {
        private readonly ClientDiagnostics _appServiceDomainDomainsClientDiagnostics;
        private readonly DomainsRestOperations _appServiceDomainDomainsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppServiceDomainCollection"/> class for mocking. </summary>
        protected AppServiceDomainCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppServiceDomainCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppServiceDomainCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appServiceDomainDomainsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", AppServiceDomain.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(AppServiceDomain.ResourceType, out string appServiceDomainDomainsApiVersion);
            _appServiceDomainDomainsRestClient = new DomainsRestOperations(_appServiceDomainDomainsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, appServiceDomainDomainsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Domains_CreateOrUpdate
        /// <summary> Description for Creates or updates a domain. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="domain"> Domain registration information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="domain"/> is null. </exception>
        public async virtual Task<AppServiceDomainCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string domainName, AppServiceDomainData domain, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            if (domain == null)
            {
                throw new ArgumentNullException(nameof(domain));
            }

            using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appServiceDomainDomainsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, domainName, domain, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceDomainCreateOrUpdateOperation(Client, _appServiceDomainDomainsClientDiagnostics, Pipeline, _appServiceDomainDomainsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, domainName, domain).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Domains_CreateOrUpdate
        /// <summary> Description for Creates or updates a domain. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="domain"> Domain registration information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="domain"/> is null. </exception>
        public virtual AppServiceDomainCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string domainName, AppServiceDomainData domain, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            if (domain == null)
            {
                throw new ArgumentNullException(nameof(domain));
            }

            using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appServiceDomainDomainsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, domainName, domain, cancellationToken);
                var operation = new AppServiceDomainCreateOrUpdateOperation(Client, _appServiceDomainDomainsClientDiagnostics, Pipeline, _appServiceDomainDomainsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, domainName, domain).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Domains_Get
        /// <summary> Description for Get a domain. </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public async virtual Task<Response<AppServiceDomain>> GetAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.Get");
            scope.Start();
            try
            {
                var response = await _appServiceDomainDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, domainName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _appServiceDomainDomainsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AppServiceDomain(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Domains_Get
        /// <summary> Description for Get a domain. </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<AppServiceDomain> Get(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.Get");
            scope.Start();
            try
            {
                var response = _appServiceDomainDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, domainName, cancellationToken);
                if (response.Value == null)
                    throw _appServiceDomainDomainsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceDomain(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Domains_ListByResourceGroup
        /// <summary> Description for Get all domains in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppServiceDomain" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppServiceDomain> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AppServiceDomain>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServiceDomainDomainsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceDomain(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AppServiceDomain>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServiceDomainDomainsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceDomain(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Domains_ListByResourceGroup
        /// <summary> Description for Get all domains in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppServiceDomain" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppServiceDomain> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AppServiceDomain> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServiceDomainDomainsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceDomain(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AppServiceDomain> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServiceDomainDomainsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceDomain(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Domains_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(domainName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Domains_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<bool> Exists(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(domainName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Domains_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public async virtual Task<Response<AppServiceDomain>> GetIfExistsAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _appServiceDomainDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, domainName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AppServiceDomain>(null, response.GetRawResponse());
                return Response.FromValue(new AppServiceDomain(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Domains_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<AppServiceDomain> GetIfExists(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appServiceDomainDomainsClientDiagnostics.CreateScope("AppServiceDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appServiceDomainDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, domainName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AppServiceDomain>(null, response.GetRawResponse());
                return Response.FromValue(new AppServiceDomain(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppServiceDomain> IEnumerable<AppServiceDomain>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppServiceDomain> IAsyncEnumerable<AppServiceDomain>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
