// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearningServices;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> A paginated list of DataVersion entities. </summary>
    internal partial class DataVersionResourceArmPaginatedResult
    {
        /// <summary> Initializes a new instance of DataVersionResourceArmPaginatedResult. </summary>
        internal DataVersionResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<DataVersionResourceData>();
        }

        /// <summary> Initializes a new instance of DataVersionResourceArmPaginatedResult. </summary>
        /// <param name="nextLink"></param>
        /// <param name="value"> An array of objects of type DataVersion. </param>
        internal DataVersionResourceArmPaginatedResult(string nextLink, IReadOnlyList<DataVersionResourceData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        public string NextLink { get; }
        /// <summary> An array of objects of type DataVersion. </summary>
        public IReadOnlyList<DataVersionResourceData> Value { get; }
    }
}
