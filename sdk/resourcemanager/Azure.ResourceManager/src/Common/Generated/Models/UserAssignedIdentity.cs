// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Models
{
    /// <summary> User assigned identity properties. </summary>
    [PropertyReferenceType]
    public partial class UserAssignedIdentity
    {
        /// <summary> Initializes a new instance of UserAssignedIdentity. </summary>
        [InitializationConstructor]
        public UserAssignedIdentity()
        {
        }

        /// <summary> Initializes a new instance of UserAssignedIdentity. </summary>
        /// <param name="principalId"> The principal ID of the assigned identity. </param>
        /// <param name="clientId"> The client ID of the assigned identity. </param>
        [SerializationConstructor]
        internal UserAssignedIdentity(Guid? principalId, Guid? clientId)
        {
            PrincipalId = principalId;
            ClientId = clientId;
        }

        /// <summary> The principal ID of the assigned identity. </summary>
        public Guid? PrincipalId { get; }
        /// <summary> The client ID of the assigned identity. </summary>
        public Guid? ClientId { get; }
    }
}
