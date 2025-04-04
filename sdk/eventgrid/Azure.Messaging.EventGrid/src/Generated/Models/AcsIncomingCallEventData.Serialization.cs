// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsIncomingCallEventDataConverter))]
    public partial class AcsIncomingCallEventData
    {
        internal static AcsIncomingCallEventData DeserializeAcsIncomingCallEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CommunicationIdentifierModel to = default;
            CommunicationIdentifierModel @from = default;
            string serverCallId = default;
            string callerDisplayName = default;
            AcsIncomingCallCustomContext customContext = default;
            string incomingCallContext = default;
            CommunicationIdentifierModel onBehalfOfCallee = default;
            string correlationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("to"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    to = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("from"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @from = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("serverCallId"u8))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callerDisplayName"u8))
                {
                    callerDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customContext"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customContext = AcsIncomingCallCustomContext.DeserializeAcsIncomingCallCustomContext(property.Value);
                    continue;
                }
                if (property.NameEquals("incomingCallContext"u8))
                {
                    incomingCallContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("onBehalfOfCallee"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onBehalfOfCallee = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
            }
            return new AcsIncomingCallEventData(
                to,
                @from,
                serverCallId,
                callerDisplayName,
                customContext,
                incomingCallContext,
                onBehalfOfCallee,
                correlationId);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AcsIncomingCallEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAcsIncomingCallEventData(document.RootElement);
        }

        internal partial class AcsIncomingCallEventDataConverter : JsonConverter<AcsIncomingCallEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsIncomingCallEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override AcsIncomingCallEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsIncomingCallEventData(document.RootElement);
            }
        }
    }
}
