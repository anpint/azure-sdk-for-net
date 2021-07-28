// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearningServices;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> A paginated list of BatchDeployment entities. </summary>
    internal partial class BatchDeploymentTrackedResourceArmPaginatedResult
    {
        /// <summary> Initializes a new instance of BatchDeploymentTrackedResourceArmPaginatedResult. </summary>
        internal BatchDeploymentTrackedResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<BatchDeploymentTrackedResourceData>();
        }

        /// <summary> Initializes a new instance of BatchDeploymentTrackedResourceArmPaginatedResult. </summary>
        /// <param name="nextLink"></param>
        /// <param name="value"> An array of objects of type BatchDeployment. </param>
        internal BatchDeploymentTrackedResourceArmPaginatedResult(string nextLink, IReadOnlyList<BatchDeploymentTrackedResourceData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        public string NextLink { get; }
        /// <summary> An array of objects of type BatchDeployment. </summary>
        public IReadOnlyList<BatchDeploymentTrackedResourceData> Value { get; }
    }
}
