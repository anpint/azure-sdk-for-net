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
using Azure.ResourceManager;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Creates or updates a DDoS custom policy. </summary>
    public partial class DdosCustomPolicyCreateOrUpdateOperation : Operation<DdosCustomPolicy>, IOperationSource<DdosCustomPolicy>
    {
        private readonly OperationInternals<DdosCustomPolicy> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of DdosCustomPolicyCreateOrUpdateOperation for mocking. </summary>
        protected DdosCustomPolicyCreateOrUpdateOperation()
        {
        }

        internal DdosCustomPolicyCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<DdosCustomPolicy>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "DdosCustomPolicyCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DdosCustomPolicy Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DdosCustomPolicy>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DdosCustomPolicy>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DdosCustomPolicy IOperationSource<DdosCustomPolicy>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DdosCustomPolicyData.DeserializeDdosCustomPolicyData(document.RootElement);
            return new DdosCustomPolicy(_armClient, data);
        }

        async ValueTask<DdosCustomPolicy> IOperationSource<DdosCustomPolicy>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DdosCustomPolicyData.DeserializeDdosCustomPolicyData(document.RootElement);
            return new DdosCustomPolicy(_armClient, data);
        }
    }
}
