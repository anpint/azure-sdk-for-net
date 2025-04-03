// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Routing rules for ramp up testing. This rule allows to redirect static traffic % to a slot or to gradually change routing % based on performance. </summary>
    public partial class RampUpRule
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

        /// <summary> Initializes a new instance of <see cref="RampUpRule"/>. </summary>
        public RampUpRule()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RampUpRule"/>. </summary>
        /// <param name="actionHostName"> Hostname of a slot to which the traffic will be redirected if decided to. E.g. myapp-stage.azurewebsites.net. </param>
        /// <param name="reroutePercentage"> Percentage of the traffic which will be redirected to &lt;code&gt;ActionHostName&lt;/code&gt;. </param>
        /// <param name="changeStep">
        /// In auto ramp up scenario this is the step to add/remove from &lt;code&gt;ReroutePercentage&lt;/code&gt; until it reaches \n&lt;code&gt;MinReroutePercentage&lt;/code&gt; or
        /// &lt;code&gt;MaxReroutePercentage&lt;/code&gt;. Site metrics are checked every N minutes specified in &lt;code&gt;ChangeIntervalInMinutes&lt;/code&gt;.\nCustom decision algorithm
        /// can be provided in TiPCallback site extension which URL can be specified in &lt;code&gt;ChangeDecisionCallbackUrl&lt;/code&gt;.
        /// </param>
        /// <param name="changeIntervalInMinutes"> Specifies interval in minutes to reevaluate ReroutePercentage. </param>
        /// <param name="minReroutePercentage"> Specifies lower boundary above which ReroutePercentage will stay. </param>
        /// <param name="maxReroutePercentage"> Specifies upper boundary below which ReroutePercentage will stay. </param>
        /// <param name="changeDecisionCallbackUri"> Custom decision algorithm can be provided in TiPCallback site extension which URL can be specified. </param>
        /// <param name="name"> Name of the routing rule. The recommended name would be to point to the slot which will receive the traffic in the experiment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RampUpRule(string actionHostName, double? reroutePercentage, double? changeStep, int? changeIntervalInMinutes, double? minReroutePercentage, double? maxReroutePercentage, Uri changeDecisionCallbackUri, string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ActionHostName = actionHostName;
            ReroutePercentage = reroutePercentage;
            ChangeStep = changeStep;
            ChangeIntervalInMinutes = changeIntervalInMinutes;
            MinReroutePercentage = minReroutePercentage;
            MaxReroutePercentage = maxReroutePercentage;
            ChangeDecisionCallbackUri = changeDecisionCallbackUri;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Hostname of a slot to which the traffic will be redirected if decided to. E.g. myapp-stage.azurewebsites.net. </summary>
        [WirePath("actionHostName")]
        public string ActionHostName { get; set; }
        /// <summary> Percentage of the traffic which will be redirected to &lt;code&gt;ActionHostName&lt;/code&gt;. </summary>
        [WirePath("reroutePercentage")]
        public double? ReroutePercentage { get; set; }
        /// <summary>
        /// In auto ramp up scenario this is the step to add/remove from &lt;code&gt;ReroutePercentage&lt;/code&gt; until it reaches \n&lt;code&gt;MinReroutePercentage&lt;/code&gt; or
        /// &lt;code&gt;MaxReroutePercentage&lt;/code&gt;. Site metrics are checked every N minutes specified in &lt;code&gt;ChangeIntervalInMinutes&lt;/code&gt;.\nCustom decision algorithm
        /// can be provided in TiPCallback site extension which URL can be specified in &lt;code&gt;ChangeDecisionCallbackUrl&lt;/code&gt;.
        /// </summary>
        [WirePath("changeStep")]
        public double? ChangeStep { get; set; }
        /// <summary> Specifies interval in minutes to reevaluate ReroutePercentage. </summary>
        [WirePath("changeIntervalInMinutes")]
        public int? ChangeIntervalInMinutes { get; set; }
        /// <summary> Specifies lower boundary above which ReroutePercentage will stay. </summary>
        [WirePath("minReroutePercentage")]
        public double? MinReroutePercentage { get; set; }
        /// <summary> Specifies upper boundary below which ReroutePercentage will stay. </summary>
        [WirePath("maxReroutePercentage")]
        public double? MaxReroutePercentage { get; set; }
        /// <summary> Custom decision algorithm can be provided in TiPCallback site extension which URL can be specified. </summary>
        [WirePath("changeDecisionCallbackUrl")]
        public Uri ChangeDecisionCallbackUri { get; set; }
        /// <summary> Name of the routing rule. The recommended name would be to point to the slot which will receive the traffic in the experiment. </summary>
        [WirePath("name")]
        public string Name { get; set; }
    }
}
