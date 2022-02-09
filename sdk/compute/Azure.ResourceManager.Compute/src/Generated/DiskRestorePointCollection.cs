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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of DiskRestorePoint and their operations over its parent. </summary>
    public partial class DiskRestorePointCollection : ArmCollection, IEnumerable<DiskRestorePoint>, IAsyncEnumerable<DiskRestorePoint>
    {
        private readonly ClientDiagnostics _diskRestorePointClientDiagnostics;
        private readonly DiskRestorePointRestOperations _diskRestorePointRestClient;

        /// <summary> Initializes a new instance of the <see cref="DiskRestorePointCollection"/> class for mocking. </summary>
        protected DiskRestorePointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DiskRestorePointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DiskRestorePointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _diskRestorePointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", DiskRestorePoint.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(DiskRestorePoint.ResourceType, out string diskRestorePointApiVersion);
            _diskRestorePointRestClient = new DiskRestorePointRestOperations(_diskRestorePointClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, diskRestorePointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != RestorePoint.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, RestorePoint.ResourceType), nameof(id));
        }

        /// <summary> Get disk restorePoint resource. </summary>
        /// <param name="diskRestorePointName"> The name of the disk restore point created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskRestorePointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskRestorePointName"/> is null. </exception>
        public async virtual Task<Response<DiskRestorePoint>> GetAsync(string diskRestorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskRestorePointName, nameof(diskRestorePointName));

            using var scope = _diskRestorePointClientDiagnostics.CreateScope("DiskRestorePointCollection.Get");
            scope.Start();
            try
            {
                var response = await _diskRestorePointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diskRestorePointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _diskRestorePointClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DiskRestorePoint(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get disk restorePoint resource. </summary>
        /// <param name="diskRestorePointName"> The name of the disk restore point created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskRestorePointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskRestorePointName"/> is null. </exception>
        public virtual Response<DiskRestorePoint> Get(string diskRestorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskRestorePointName, nameof(diskRestorePointName));

            using var scope = _diskRestorePointClientDiagnostics.CreateScope("DiskRestorePointCollection.Get");
            scope.Start();
            try
            {
                var response = _diskRestorePointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diskRestorePointName, cancellationToken);
                if (response.Value == null)
                    throw _diskRestorePointClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskRestorePoint(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists diskRestorePoints under a vmRestorePoint. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiskRestorePoint" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiskRestorePoint> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DiskRestorePoint>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _diskRestorePointClientDiagnostics.CreateScope("DiskRestorePointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diskRestorePointRestClient.ListByRestorePointAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskRestorePoint(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DiskRestorePoint>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _diskRestorePointClientDiagnostics.CreateScope("DiskRestorePointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diskRestorePointRestClient.ListByRestorePointNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskRestorePoint(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists diskRestorePoints under a vmRestorePoint. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiskRestorePoint" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiskRestorePoint> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DiskRestorePoint> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _diskRestorePointClientDiagnostics.CreateScope("DiskRestorePointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diskRestorePointRestClient.ListByRestorePoint(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskRestorePoint(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DiskRestorePoint> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _diskRestorePointClientDiagnostics.CreateScope("DiskRestorePointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diskRestorePointRestClient.ListByRestorePointNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskRestorePoint(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="diskRestorePointName"> The name of the disk restore point created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskRestorePointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskRestorePointName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string diskRestorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskRestorePointName, nameof(diskRestorePointName));

            using var scope = _diskRestorePointClientDiagnostics.CreateScope("DiskRestorePointCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(diskRestorePointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="diskRestorePointName"> The name of the disk restore point created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskRestorePointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskRestorePointName"/> is null. </exception>
        public virtual Response<bool> Exists(string diskRestorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskRestorePointName, nameof(diskRestorePointName));

            using var scope = _diskRestorePointClientDiagnostics.CreateScope("DiskRestorePointCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(diskRestorePointName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diskRestorePointName"> The name of the disk restore point created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskRestorePointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskRestorePointName"/> is null. </exception>
        public async virtual Task<Response<DiskRestorePoint>> GetIfExistsAsync(string diskRestorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskRestorePointName, nameof(diskRestorePointName));

            using var scope = _diskRestorePointClientDiagnostics.CreateScope("DiskRestorePointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _diskRestorePointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diskRestorePointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DiskRestorePoint>(null, response.GetRawResponse());
                return Response.FromValue(new DiskRestorePoint(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diskRestorePointName"> The name of the disk restore point created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskRestorePointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskRestorePointName"/> is null. </exception>
        public virtual Response<DiskRestorePoint> GetIfExists(string diskRestorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskRestorePointName, nameof(diskRestorePointName));

            using var scope = _diskRestorePointClientDiagnostics.CreateScope("DiskRestorePointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _diskRestorePointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diskRestorePointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DiskRestorePoint>(null, response.GetRawResponse());
                return Response.FromValue(new DiskRestorePoint(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DiskRestorePoint> IEnumerable<DiskRestorePoint>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DiskRestorePoint> IAsyncEnumerable<DiskRestorePoint>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
