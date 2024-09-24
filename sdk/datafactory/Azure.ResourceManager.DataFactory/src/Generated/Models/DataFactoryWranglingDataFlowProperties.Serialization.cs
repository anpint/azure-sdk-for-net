// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryWranglingDataFlowProperties : IUtf8JsonSerializable, IJsonModel<DataFactoryWranglingDataFlowProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryWranglingDataFlowProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataFactoryWranglingDataFlowProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryWranglingDataFlowProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryWranglingDataFlowProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Sources))
            {
                writer.WritePropertyName("sources"u8);
                writer.WriteStartArray();
                foreach (var item in Sources)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Script))
            {
                writer.WritePropertyName("script"u8);
                writer.WriteStringValue(Script);
            }
            if (Optional.IsDefined(DocumentLocale))
            {
                writer.WritePropertyName("documentLocale"u8);
                writer.WriteStringValue(DocumentLocale);
            }
            writer.WriteEndObject();
        }

        DataFactoryWranglingDataFlowProperties IJsonModel<DataFactoryWranglingDataFlowProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryWranglingDataFlowProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryWranglingDataFlowProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryWranglingDataFlowProperties(document.RootElement, options);
        }

        internal static DataFactoryWranglingDataFlowProperties DeserializeDataFactoryWranglingDataFlowProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string description = default;
            IList<BinaryData> annotations = default;
            DataFlowFolder folder = default;
            IList<PowerQuerySource> sources = default;
            string script = default;
            string documentLocale = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("folder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    folder = DataFlowFolder.DeserializeDataFlowFolder(property.Value, options);
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PowerQuerySource> array = new List<PowerQuerySource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PowerQuerySource.DeserializePowerQuerySource(item, options));
                            }
                            sources = array;
                            continue;
                        }
                        if (property0.NameEquals("script"u8))
                        {
                            script = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("documentLocale"u8))
                        {
                            documentLocale = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataFactoryWranglingDataFlowProperties(
                type,
                description,
                annotations ?? new ChangeTrackingList<BinaryData>(),
                folder,
                serializedAdditionalRawData,
                sources ?? new ChangeTrackingList<PowerQuerySource>(),
                script,
                documentLocale);
        }

        BinaryData IPersistableModel<DataFactoryWranglingDataFlowProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryWranglingDataFlowProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryWranglingDataFlowProperties)} does not support writing '{options.Format}' format.");
            }
        }

        DataFactoryWranglingDataFlowProperties IPersistableModel<DataFactoryWranglingDataFlowProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryWranglingDataFlowProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryWranglingDataFlowProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryWranglingDataFlowProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryWranglingDataFlowProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
