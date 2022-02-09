// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetInstanceView
    {
        internal static VirtualMachineScaleSetInstanceView DeserializeVirtualMachineScaleSetInstanceView(JsonElement element)
        {
            Optional<VirtualMachineScaleSetInstanceViewStatusesSummary> virtualMachine = default;
            Optional<IReadOnlyList<VirtualMachineScaleSetVmExtensionsSummary>> extensions = default;
            Optional<IReadOnlyList<InstanceViewStatus>> statuses = default;
            Optional<IReadOnlyList<OrchestrationServiceSummary>> orchestrationServices = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualMachine"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    virtualMachine = VirtualMachineScaleSetInstanceViewStatusesSummary.DeserializeVirtualMachineScaleSetInstanceViewStatusesSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("extensions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VirtualMachineScaleSetVmExtensionsSummary> array = new List<VirtualMachineScaleSetVmExtensionsSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineScaleSetVmExtensionsSummary.DeserializeVirtualMachineScaleSetVmExtensionsSummary(item));
                    }
                    extensions = array;
                    continue;
                }
                if (property.NameEquals("statuses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<InstanceViewStatus> array = new List<InstanceViewStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InstanceViewStatus.DeserializeInstanceViewStatus(item));
                    }
                    statuses = array;
                    continue;
                }
                if (property.NameEquals("orchestrationServices"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<OrchestrationServiceSummary> array = new List<OrchestrationServiceSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OrchestrationServiceSummary.DeserializeOrchestrationServiceSummary(item));
                    }
                    orchestrationServices = array;
                    continue;
                }
            }
            return new VirtualMachineScaleSetInstanceView(virtualMachine.Value, Optional.ToList(extensions), Optional.ToList(statuses), Optional.ToList(orchestrationServices));
        }
    }
}
