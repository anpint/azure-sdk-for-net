// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearningServices;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> A paginated list of LabelingJob entities. </summary>
    internal partial class LabelingJobResourceArmPaginatedResult
    {
        /// <summary> Initializes a new instance of LabelingJobResourceArmPaginatedResult. </summary>
        internal LabelingJobResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<LabelingJobResourceData>();
        }

        /// <summary> Initializes a new instance of LabelingJobResourceArmPaginatedResult. </summary>
        /// <param name="nextLink"></param>
        /// <param name="value"> An array of objects of type LabelingJob. </param>
        internal LabelingJobResourceArmPaginatedResult(string nextLink, IReadOnlyList<LabelingJobResourceData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        public string NextLink { get; }
        /// <summary> An array of objects of type LabelingJob. </summary>
        public IReadOnlyList<LabelingJobResourceData> Value { get; }
    }
}
