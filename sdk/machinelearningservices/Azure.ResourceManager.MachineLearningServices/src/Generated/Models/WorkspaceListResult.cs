// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearningServices;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The result of a request to list machine learning workspaces. </summary>
    internal partial class WorkspaceListResult
    {
        /// <summary> Initializes a new instance of WorkspaceListResult. </summary>
        internal WorkspaceListResult()
        {
            Value = new ChangeTrackingList<WorkspaceData>();
        }

        /// <summary> Initializes a new instance of WorkspaceListResult. </summary>
        /// <param name="value"> The list of machine learning workspaces. Since this list may be incomplete, the nextLink field should be used to request the next list of machine learning workspaces. </param>
        /// <param name="nextLink"> The URI that can be used to request the next list of machine learning workspaces. </param>
        internal WorkspaceListResult(IReadOnlyList<WorkspaceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of machine learning workspaces. Since this list may be incomplete, the nextLink field should be used to request the next list of machine learning workspaces. </summary>
        public IReadOnlyList<WorkspaceData> Value { get; }
        /// <summary> The URI that can be used to request the next list of machine learning workspaces. </summary>
        public string NextLink { get; }
    }
}
