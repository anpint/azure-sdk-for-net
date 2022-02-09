// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class ServerCommunicationLinkData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PartnerServer))
            {
                writer.WritePropertyName("partnerServer");
                writer.WriteStringValue(PartnerServer);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ServerCommunicationLinkData DeserializeServerCommunicationLinkData(JsonElement element)
        {
            Optional<string> location = default;
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> state = default;
            Optional<string> partnerServer = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("state"))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerServer"))
                        {
                            partnerServer = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ServerCommunicationLinkData(id, name, type, systemData, location.Value, kind.Value, state.Value, partnerServer.Value);
        }
    }
}
