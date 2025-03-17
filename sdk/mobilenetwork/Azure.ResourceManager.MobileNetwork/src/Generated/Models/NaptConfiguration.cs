// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> The network address and port translation settings to use for the attached data network. </summary>
    public partial class NaptConfiguration
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

        /// <summary> Initializes a new instance of <see cref="NaptConfiguration"/>. </summary>
        public NaptConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NaptConfiguration"/>. </summary>
        /// <param name="enabled"> Whether NAPT is enabled for connections to this attached data network. </param>
        /// <param name="portRange">
        /// Range of port numbers to use as translated ports on each translated address.
        /// If not specified and NAPT is enabled, this range defaults to 1,024 - 49,999.
        /// (Ports under 1,024 should not be used because these are special purpose ports reserved by IANA. Ports 50,000 and above are reserved for non-NAPT use.)
        /// </param>
        /// <param name="portReuseHoldTime"> The minimum time (in seconds) that will pass before a port that was used by a closed pinhole can be recycled for use by another pinhole. All hold times must be at least 1 second. </param>
        /// <param name="pinholeLimits"> Maximum number of UDP and TCP pinholes that can be open simultaneously on the core interface. For 5G networks, this is the N6 interface. For 4G networks, this is the SGi interface. </param>
        /// <param name="pinholeTimeouts"> Expiry times of inactive NAPT pinholes, in seconds. All timers must be at least 1 second. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NaptConfiguration(NaptState? enabled, MobileNetworkPortRange portRange, MobileNetworkPortReuseHoldTimes portReuseHoldTime, int? pinholeLimits, PinholeTimeouts pinholeTimeouts, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Enabled = enabled;
            PortRange = portRange;
            PortReuseHoldTime = portReuseHoldTime;
            PinholeLimits = pinholeLimits;
            PinholeTimeouts = pinholeTimeouts;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Whether NAPT is enabled for connections to this attached data network. </summary>
        [WirePath("enabled")]
        public NaptState? Enabled { get; set; }
        /// <summary>
        /// Range of port numbers to use as translated ports on each translated address.
        /// If not specified and NAPT is enabled, this range defaults to 1,024 - 49,999.
        /// (Ports under 1,024 should not be used because these are special purpose ports reserved by IANA. Ports 50,000 and above are reserved for non-NAPT use.)
        /// </summary>
        [WirePath("portRange")]
        public MobileNetworkPortRange PortRange { get; set; }
        /// <summary> The minimum time (in seconds) that will pass before a port that was used by a closed pinhole can be recycled for use by another pinhole. All hold times must be at least 1 second. </summary>
        [WirePath("portReuseHoldTime")]
        public MobileNetworkPortReuseHoldTimes PortReuseHoldTime { get; set; }
        /// <summary> Maximum number of UDP and TCP pinholes that can be open simultaneously on the core interface. For 5G networks, this is the N6 interface. For 4G networks, this is the SGi interface. </summary>
        [WirePath("pinholeLimits")]
        public int? PinholeLimits { get; set; }
        /// <summary> Expiry times of inactive NAPT pinholes, in seconds. All timers must be at least 1 second. </summary>
        [WirePath("pinholeTimeouts")]
        public PinholeTimeouts PinholeTimeouts { get; set; }
    }
}
