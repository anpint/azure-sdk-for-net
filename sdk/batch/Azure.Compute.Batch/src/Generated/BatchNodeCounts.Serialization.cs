// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class BatchNodeCounts : IUtf8JsonSerializable, IJsonModel<BatchNodeCounts>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchNodeCounts>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchNodeCounts>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNodeCounts>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchNodeCounts)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("creating"u8);
            writer.WriteNumberValue(Creating);
            writer.WritePropertyName("idle"u8);
            writer.WriteNumberValue(Idle);
            writer.WritePropertyName("offline"u8);
            writer.WriteNumberValue(Offline);
            writer.WritePropertyName("preempted"u8);
            writer.WriteNumberValue(Preempted);
            writer.WritePropertyName("rebooting"u8);
            writer.WriteNumberValue(Rebooting);
            writer.WritePropertyName("reimaging"u8);
            writer.WriteNumberValue(Reimaging);
            writer.WritePropertyName("running"u8);
            writer.WriteNumberValue(Running);
            writer.WritePropertyName("starting"u8);
            writer.WriteNumberValue(Starting);
            writer.WritePropertyName("startTaskFailed"u8);
            writer.WriteNumberValue(StartTaskFailed);
            writer.WritePropertyName("leavingPool"u8);
            writer.WriteNumberValue(LeavingPool);
            writer.WritePropertyName("unknown"u8);
            writer.WriteNumberValue(Unknown);
            writer.WritePropertyName("unusable"u8);
            writer.WriteNumberValue(Unusable);
            writer.WritePropertyName("waitingForStartTask"u8);
            writer.WriteNumberValue(WaitingForStartTask);
            writer.WritePropertyName("deallocated"u8);
            writer.WriteNumberValue(Deallocated);
            writer.WritePropertyName("deallocating"u8);
            writer.WriteNumberValue(Deallocating);
            writer.WritePropertyName("total"u8);
            writer.WriteNumberValue(Total);
            writer.WritePropertyName("upgradingOS"u8);
            writer.WriteNumberValue(UpgradingOs);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        BatchNodeCounts IJsonModel<BatchNodeCounts>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNodeCounts>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchNodeCounts)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchNodeCounts(document.RootElement, options);
        }

        internal static BatchNodeCounts DeserializeBatchNodeCounts(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int creating = default;
            int idle = default;
            int offline = default;
            int preempted = default;
            int rebooting = default;
            int reimaging = default;
            int running = default;
            int starting = default;
            int startTaskFailed = default;
            int leavingPool = default;
            int unknown = default;
            int unusable = default;
            int waitingForStartTask = default;
            int deallocated = default;
            int deallocating = default;
            int total = default;
            int upgradingOS = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("creating"u8))
                {
                    creating = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("idle"u8))
                {
                    idle = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("offline"u8))
                {
                    offline = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("preempted"u8))
                {
                    preempted = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rebooting"u8))
                {
                    rebooting = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("reimaging"u8))
                {
                    reimaging = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("running"u8))
                {
                    running = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("starting"u8))
                {
                    starting = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startTaskFailed"u8))
                {
                    startTaskFailed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("leavingPool"u8))
                {
                    leavingPool = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unknown"u8))
                {
                    unknown = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unusable"u8))
                {
                    unusable = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("waitingForStartTask"u8))
                {
                    waitingForStartTask = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("deallocated"u8))
                {
                    deallocated = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("deallocating"u8))
                {
                    deallocating = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("total"u8))
                {
                    total = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("upgradingOS"u8))
                {
                    upgradingOS = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchNodeCounts(
                creating,
                idle,
                offline,
                preempted,
                rebooting,
                reimaging,
                running,
                starting,
                startTaskFailed,
                leavingPool,
                unknown,
                unusable,
                waitingForStartTask,
                deallocated,
                deallocating,
                total,
                upgradingOS,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchNodeCounts>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNodeCounts>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchNodeCounts)} does not support writing '{options.Format}' format.");
            }
        }

        BatchNodeCounts IPersistableModel<BatchNodeCounts>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNodeCounts>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBatchNodeCounts(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchNodeCounts)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchNodeCounts>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BatchNodeCounts FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeBatchNodeCounts(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
