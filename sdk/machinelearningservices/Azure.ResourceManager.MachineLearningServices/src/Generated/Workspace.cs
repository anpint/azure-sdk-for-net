// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A Class representing a Workspace along with the instance operations that can be performed on it. </summary>
    public class Workspace : WorkspaceOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "Workspace"/> class for mocking. </summary>
        protected Workspace() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "Workspace"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal Workspace(OperationsBase options, WorkspaceData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the WorkspaceData. </summary>
        public virtual WorkspaceData Data { get; private set; }
    }
}
