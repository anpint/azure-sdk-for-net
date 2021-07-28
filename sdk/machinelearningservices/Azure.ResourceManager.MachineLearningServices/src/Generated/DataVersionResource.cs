// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A Class representing a DataVersionResource along with the instance operations that can be performed on it. </summary>
    public class DataVersionResource : DataVersionResourceOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "DataVersionResource"/> class for mocking. </summary>
        protected DataVersionResource() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DataVersionResource"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal DataVersionResource(OperationsBase options, DataVersionResourceData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the DataVersionResourceData. </summary>
        public virtual DataVersionResourceData Data { get; private set; }
    }
}
