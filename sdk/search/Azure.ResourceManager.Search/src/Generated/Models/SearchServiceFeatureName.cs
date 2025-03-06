// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> The name of the feature offered in this region. </summary>
    public readonly partial struct SearchServiceFeatureName : IEquatable<SearchServiceFeatureName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SearchServiceFeatureName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SearchServiceFeatureName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GrokValue = "Grok";
        private const string ImageVectorizationValue = "ImageVectorization";
        private const string DocumentIntelligenceValue = "DocumentIntelligence";
        private const string QueryRewriteValue = "QueryRewrite";
        private const string S3Value = "S3";
        private const string StorageOptimizedValue = "StorageOptimized";
        private const string SemanticSearchValue = "SemanticSearch";
        private const string MegaStoreValue = "MegaStore";
        private const string AvailabilityZonesValue = "AvailabilityZones";

        /// <summary> Supports Grok feature. </summary>
        public static SearchServiceFeatureName Grok { get; } = new SearchServiceFeatureName(GrokValue);
        /// <summary> Supports Image Vectorization feature. </summary>
        public static SearchServiceFeatureName ImageVectorization { get; } = new SearchServiceFeatureName(ImageVectorizationValue);
        /// <summary> Supports Document Intelligence feature. </summary>
        public static SearchServiceFeatureName DocumentIntelligence { get; } = new SearchServiceFeatureName(DocumentIntelligenceValue);
        /// <summary> Supports Query Rewrite feature. </summary>
        public static SearchServiceFeatureName QueryRewrite { get; } = new SearchServiceFeatureName(QueryRewriteValue);
        /// <summary> Supports S3 feature. </summary>
        public static SearchServiceFeatureName S3 { get; } = new SearchServiceFeatureName(S3Value);
        /// <summary> Supports Storage Optimized feature. </summary>
        public static SearchServiceFeatureName StorageOptimized { get; } = new SearchServiceFeatureName(StorageOptimizedValue);
        /// <summary> Supports Semantic Search feature. </summary>
        public static SearchServiceFeatureName SemanticSearch { get; } = new SearchServiceFeatureName(SemanticSearchValue);
        /// <summary> Supports Mega Store feature. </summary>
        public static SearchServiceFeatureName MegaStore { get; } = new SearchServiceFeatureName(MegaStoreValue);
        /// <summary> Supports Availability Zones feature. </summary>
        public static SearchServiceFeatureName AvailabilityZones { get; } = new SearchServiceFeatureName(AvailabilityZonesValue);
        /// <summary> Determines if two <see cref="SearchServiceFeatureName"/> values are the same. </summary>
        public static bool operator ==(SearchServiceFeatureName left, SearchServiceFeatureName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SearchServiceFeatureName"/> values are not the same. </summary>
        public static bool operator !=(SearchServiceFeatureName left, SearchServiceFeatureName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SearchServiceFeatureName"/>. </summary>
        public static implicit operator SearchServiceFeatureName(string value) => new SearchServiceFeatureName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SearchServiceFeatureName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SearchServiceFeatureName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
