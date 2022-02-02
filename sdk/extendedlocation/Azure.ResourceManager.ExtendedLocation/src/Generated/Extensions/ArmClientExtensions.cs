// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ExtendedLocation
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region CustomLocation
        /// <summary> Gets an object representing a CustomLocation along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CustomLocation" /> object. </returns>
        public static CustomLocation GetCustomLocation(this ArmClient armClient, ResourceIdentifier id)
        {
            CustomLocation.ValidateResourceId(id);
            return new CustomLocation(armClient, id);
        }
        #endregion
    }
}
