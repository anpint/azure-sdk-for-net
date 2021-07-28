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
    /// <summary> A class representing the operations that can be performed over a specific ComputeResource. </summary>
    public partial class ComputeResourceOperations : ResourceOperationsBase<ComputeResource>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private ComputeRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="ComputeResourceOperations"/> class for mocking. </summary>
        protected ComputeResourceOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ComputeResourceOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal ComputeResourceOperations(OperationsBase options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new ComputeRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MachineLearningServices/workspaces/computes";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<ComputeResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ComputeResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<ComputeResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new ComputeResource(this, response.Value), response.GetRawResponse());
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

        /// <summary> Deletes specified Machine Learning compute. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.Delete");
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

        /// <summary> Deletes specified Machine Learning compute. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.Delete");
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

        /// <summary> Deletes specified Machine Learning compute. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ComputeDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new ComputeDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes specified Machine Learning compute. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ComputeDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return new ComputeDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Gets secrets related to Machine Learning compute (storage keys, service credentials, etc). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ComputeSecrets>> GetKeysAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.GetKeys");
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

        /// <summary> Gets secrets related to Machine Learning compute (storage keys, service credentials, etc). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ComputeSecrets> GetKeys(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.GetKeys");
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

        /// <summary> Posts a restart action to a compute instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RestartAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.Restart");
            scope.Start();
            try
            {
                var response = await _restClient.RestartAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Posts a restart action to a compute instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Restart(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.Restart");
            scope.Start();
            try
            {
                var response = _restClient.Restart(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates schedules of a compute instance. </summary>
        /// <param name="computeStartStop"> The list of compute start stop schedules to be applied. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UpdateSchedulesAsync(IEnumerable<ComputeStartStopSchedule> computeStartStop = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.UpdateSchedules");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateSchedulesAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, computeStartStop, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates schedules of a compute instance. </summary>
        /// <param name="computeStartStop"> The list of compute start stop schedules to be applied. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response UpdateSchedules(IEnumerable<ComputeStartStopSchedule> computeStartStop = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.UpdateSchedules");
            scope.Start();
            try
            {
                var response = _restClient.UpdateSchedules(Id.ResourceGroupName, Id.Parent.Name, Id.Name, computeStartStop, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates properties of a compute. This call will overwrite a compute if it exists. This is a nonrecoverable operation. </summary>
        /// <param name="scaleSettings"> Desired scale settings for the amlCompute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ComputeResource>> UpdateAsync(ScaleSettings scaleSettings = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.Update");
            scope.Start();
            try
            {
                var operation = await StartUpdateAsync(scaleSettings, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates properties of a compute. This call will overwrite a compute if it exists. This is a nonrecoverable operation. </summary>
        /// <param name="scaleSettings"> Desired scale settings for the amlCompute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ComputeResource> Update(ScaleSettings scaleSettings = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.Update");
            scope.Start();
            try
            {
                var operation = StartUpdate(scaleSettings, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates properties of a compute. This call will overwrite a compute if it exists. This is a nonrecoverable operation. </summary>
        /// <param name="scaleSettings"> Desired scale settings for the amlCompute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ComputeUpdateOperation> StartUpdateAsync(ScaleSettings scaleSettings = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.StartUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, scaleSettings, cancellationToken).ConfigureAwait(false);
                return new ComputeUpdateOperation(this, _clientDiagnostics, Pipeline, _restClient.CreateUpdateRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, scaleSettings).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates properties of a compute. This call will overwrite a compute if it exists. This is a nonrecoverable operation. </summary>
        /// <param name="scaleSettings"> Desired scale settings for the amlCompute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ComputeUpdateOperation StartUpdate(ScaleSettings scaleSettings = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.StartUpdate");
            scope.Start();
            try
            {
                var response = _restClient.Update(Id.ResourceGroupName, Id.Parent.Name, Id.Name, scaleSettings, cancellationToken);
                return new ComputeUpdateOperation(this, _clientDiagnostics, Pipeline, _restClient.CreateUpdateRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, scaleSettings).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Posts a start action to a compute instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> StartAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.Start");
            scope.Start();
            try
            {
                var operation = await StartStartAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Posts a start action to a compute instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Start(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.Start");
            scope.Start();
            try
            {
                var operation = StartStart(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Posts a start action to a compute instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ComputeStartOperation> StartStartAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.StartStart");
            scope.Start();
            try
            {
                var response = await _restClient.StartAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new ComputeStartOperation(_clientDiagnostics, Pipeline, _restClient.CreateStartRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Posts a start action to a compute instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ComputeStartOperation StartStart(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.StartStart");
            scope.Start();
            try
            {
                var response = _restClient.Start(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new ComputeStartOperation(_clientDiagnostics, Pipeline, _restClient.CreateStartRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Posts a stop action to a compute instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> StopAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.Stop");
            scope.Start();
            try
            {
                var operation = await StartStopAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Posts a stop action to a compute instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Stop(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.Stop");
            scope.Start();
            try
            {
                var operation = StartStop(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Posts a stop action to a compute instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ComputeStopOperation> StartStopAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.StartStop");
            scope.Start();
            try
            {
                var response = await _restClient.StopAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new ComputeStopOperation(_clientDiagnostics, Pipeline, _restClient.CreateStopRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Posts a stop action to a compute instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ComputeStopOperation StartStop(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceOperations.StartStop");
            scope.Start();
            try
            {
                var response = _restClient.Stop(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new ComputeStopOperation(_clientDiagnostics, Pipeline, _restClient.CreateStopRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
