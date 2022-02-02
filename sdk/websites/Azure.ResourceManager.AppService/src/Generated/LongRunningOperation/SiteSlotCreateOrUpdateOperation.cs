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
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Creates a new web, mobile, or API app in an existing resource group, or updates an existing app. </summary>
    public partial class SiteSlotCreateOrUpdateOperation : Operation<SiteSlot>, IOperationSource<SiteSlot>
    {
        private readonly OperationInternals<SiteSlot> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of SiteSlotCreateOrUpdateOperation for mocking. </summary>
        protected SiteSlotCreateOrUpdateOperation()
        {
        }

        internal SiteSlotCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<SiteSlot>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "SiteSlotCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SiteSlot Value => _operation.Value;

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
        public override ValueTask<Response<SiteSlot>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SiteSlot>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        SiteSlot IOperationSource<SiteSlot>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = WebSiteData.DeserializeWebSiteData(document.RootElement);
            return new SiteSlot(_armClient, data);
        }

        async ValueTask<SiteSlot> IOperationSource<SiteSlot>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = WebSiteData.DeserializeWebSiteData(document.RootElement);
            return new SiteSlot(_armClient, data);
        }
    }
}
