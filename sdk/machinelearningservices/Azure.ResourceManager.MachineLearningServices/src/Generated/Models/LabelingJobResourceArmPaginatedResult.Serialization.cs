// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearningServices;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    internal partial class LabelingJobResourceArmPaginatedResult
    {
        internal static LabelingJobResourceArmPaginatedResult DeserializeLabelingJobResourceArmPaginatedResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<LabelingJobResourceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LabelingJobResourceData> array = new List<LabelingJobResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LabelingJobResourceData.DeserializeLabelingJobResourceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new LabelingJobResourceArmPaginatedResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
