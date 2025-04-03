// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Scale configuration. </summary>
    public partial class SessionPoolScaleConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SessionPoolScaleConfiguration"/>. </summary>
        public SessionPoolScaleConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SessionPoolScaleConfiguration"/>. </summary>
        /// <param name="maxConcurrentSessions"> The maximum count of sessions at the same time. </param>
        /// <param name="readySessionInstances"> The minimum count of ready session instances. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SessionPoolScaleConfiguration(int? maxConcurrentSessions, int? readySessionInstances, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MaxConcurrentSessions = maxConcurrentSessions;
            ReadySessionInstances = readySessionInstances;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The maximum count of sessions at the same time. </summary>
        [WirePath("maxConcurrentSessions")]
        public int? MaxConcurrentSessions { get; set; }
        /// <summary> The minimum count of ready session instances. </summary>
        [WirePath("readySessionInstances")]
        public int? ReadySessionInstances { get; set; }
    }
}
