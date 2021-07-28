// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A Class representing a ModelContainerResource along with the instance operations that can be performed on it. </summary>
    public class ModelContainerResource : ModelContainerResourceOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "ModelContainerResource"/> class for mocking. </summary>
        protected ModelContainerResource() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ModelContainerResource"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ModelContainerResource(OperationsBase options, ModelContainerResourceData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the ModelContainerResourceData. </summary>
        public virtual ModelContainerResourceData Data { get; private set; }
    }
}
