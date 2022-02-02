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

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Copy an existing long term retention backup to a different server. </summary>
    public partial class ResourceGroupLongTermRetentionBackupCopyByResourceGroupOperation : Operation<LongTermRetentionBackupOperationResult>, IOperationSource<LongTermRetentionBackupOperationResult>
    {
        private readonly OperationInternals<LongTermRetentionBackupOperationResult> _operation;

        /// <summary> Initializes a new instance of ResourceGroupLongTermRetentionBackupCopyByResourceGroupOperation for mocking. </summary>
        protected ResourceGroupLongTermRetentionBackupCopyByResourceGroupOperation()
        {
        }

        internal ResourceGroupLongTermRetentionBackupCopyByResourceGroupOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<LongTermRetentionBackupOperationResult>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ResourceGroupLongTermRetentionBackupCopyByResourceGroupOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override LongTermRetentionBackupOperationResult Value => _operation.Value;

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
        public override ValueTask<Response<LongTermRetentionBackupOperationResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<LongTermRetentionBackupOperationResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        LongTermRetentionBackupOperationResult IOperationSource<LongTermRetentionBackupOperationResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return LongTermRetentionBackupOperationResult.DeserializeLongTermRetentionBackupOperationResult(document.RootElement);
        }

        async ValueTask<LongTermRetentionBackupOperationResult> IOperationSource<LongTermRetentionBackupOperationResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return LongTermRetentionBackupOperationResult.DeserializeLongTermRetentionBackupOperationResult(document.RootElement);
        }
    }
}
