// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RestorePointSourceVmStorageProfile
    {
        internal static RestorePointSourceVmStorageProfile DeserializeRestorePointSourceVmStorageProfile(JsonElement element)
        {
            Optional<RestorePointSourceVmOSDisk> osDisk = default;
            Optional<IReadOnlyList<RestorePointSourceVmDataDisk>> dataDisks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osDisk"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    osDisk = RestorePointSourceVmOSDisk.DeserializeRestorePointSourceVmOSDisk(property.Value);
                    continue;
                }
                if (property.NameEquals("dataDisks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RestorePointSourceVmDataDisk> array = new List<RestorePointSourceVmDataDisk>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RestorePointSourceVmDataDisk.DeserializeRestorePointSourceVmDataDisk(item));
                    }
                    dataDisks = array;
                    continue;
                }
            }
            return new RestorePointSourceVmStorageProfile(osDisk.Value, Optional.ToList(dataDisks));
        }
    }
}
