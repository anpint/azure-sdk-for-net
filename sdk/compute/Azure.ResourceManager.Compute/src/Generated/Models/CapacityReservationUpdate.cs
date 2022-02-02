// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the capacity reservation. Only tags and sku.capacity can be updated. </summary>
    public partial class CapacityReservationUpdate : UpdateResource
    {
        /// <summary> Initializes a new instance of CapacityReservationUpdate. </summary>
        public CapacityReservationUpdate()
        {
            VirtualMachinesAssociated = new ChangeTrackingList<Resources.Models.SubResource>();
        }

        /// <summary> SKU of the resource for which capacity needs be reserved. The SKU name and capacity is required to be set. Currently VM Skus with the capability called &apos;CapacityReservationSupported&apos; set to true are supported. Refer to List Microsoft.Compute SKUs in a region (https://docs.microsoft.com/rest/api/compute/resourceskus/list) for supported values. </summary>
        public Sku Sku { get; set; }
        /// <summary> A unique id generated and assigned to the capacity reservation by the platform which does not change throughout the lifetime of the resource. </summary>
        public string ReservationId { get; }
        /// <summary> A list of all virtual machine resource ids that are associated with the capacity reservation. </summary>
        public IReadOnlyList<Resources.Models.SubResource> VirtualMachinesAssociated { get; }
        /// <summary> The date time when the capacity reservation was last updated. </summary>
        public DateTimeOffset? ProvisioningTime { get; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The Capacity reservation instance view. </summary>
        public CapacityReservationInstanceView InstanceView { get; }
    }
}
