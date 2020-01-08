﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.Testing;
using NUnit.Framework;

namespace Azure.AI.TextAnalytics.Samples
{
    [LiveOnly]
    public partial class TextAnalyticsSamples
    {
        [Test]
        public void DetectLanguage()
        {
            string endpoint = Environment.GetEnvironmentVariable("TEXT_ANALYTICS_ENDPOINT");
            string subscriptionKey = Environment.GetEnvironmentVariable("TEXT_ANALYTICS_SUBSCRIPTION_KEY");

            // Instantiate a client that will be used to call the service.
            var client = new TextAnalyticsClient(new Uri(endpoint), subscriptionKey);

            #region Snippet:DetectLanguage
            string input = "Este documento está en español.";

            // Detect the language the input text is written in
            DetectLanguageResult result = client.DetectLanguage(input);
            DetectedLanguage language = result.PrimaryLanguage;

            Console.WriteLine($"Detected language {language.Name} with confidence {language.Score:0.00}.");
            #endregion
        }
    }
}
