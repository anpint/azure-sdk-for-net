// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.DataMap
{
    /// <summary> The value item of the search result. </summary>
    public partial class SearchResultValue
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

        /// <summary> Initializes a new instance of <see cref="SearchResultValue"/>. </summary>
        internal SearchResultValue()
        {
            Endorsement = new ChangeTrackingList<string>();
            Classification = new ChangeTrackingList<string>();
            Label = new ChangeTrackingList<string>();
            Term = new ChangeTrackingList<TermSearchResultValue>();
            Contact = new ChangeTrackingList<ContactSearchResultValue>();
            AssetType = new ChangeTrackingList<string>();
            TermTemplate = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SearchResultValue"/>. </summary>
        /// <param name="searchScore">
        /// The search score calculated by the search engine. The results are ordered by
        /// search score by default.
        /// </param>
        /// <param name="searchHighlights">
        /// A highlight list that consists of index fields id ,qualifiedName, name,
        /// description, entityType. When the keyword appears in those fields, the value of
        /// the field, attached with emphasis mark, is returned as an element of
        /// @search.highlights.
        /// </param>
        /// <param name="objectType">
        /// The object type of the record. Object type is the top-level property to
        /// distinguish whether a record is an asset or a term.
        /// </param>
        /// <param name="createTime"> The create time of the record. The Unix epoch format. </param>
        /// <param name="updateTime"> The last update time of the record. The Unix epoch format. </param>
        /// <param name="id"> The GUID of the record. </param>
        /// <param name="name"> The name of the record. </param>
        /// <param name="qualifiedName"> The qualified name of the record. </param>
        /// <param name="entityType"> The type name of the asset. </param>
        /// <param name="description"> The description of the asset. </param>
        /// <param name="endorsement"> The endorsement of the asset. </param>
        /// <param name="owner"> The owner of the record. </param>
        /// <param name="classification"> The classifications of the record. </param>
        /// <param name="label"> The labels of the asset. </param>
        /// <param name="term"> The terms assigned to the asset. </param>
        /// <param name="contact"> The contacts of the asset. </param>
        /// <param name="assetType"> The asset types of the asset. </param>
        /// <param name="glossaryType">
        /// The type name of the term. Could be AtlasGlossary, AtlasGlossaryTerm or
        /// AtlasGlossaryCategory.
        /// </param>
        /// <param name="glossary"> The glossary name of the term. </param>
        /// <param name="termStatus"> The status of the term. </param>
        /// <param name="termTemplate"> The term template names used by the term. </param>
        /// <param name="longDescription"> The definition of the term. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchResultValue(float? searchScore, SearchHighlights searchHighlights, string objectType, long? createTime, long? updateTime, string id, string name, string qualifiedName, string entityType, string description, IReadOnlyList<string> endorsement, string owner, IReadOnlyList<string> classification, IReadOnlyList<string> label, IReadOnlyList<TermSearchResultValue> term, IReadOnlyList<ContactSearchResultValue> contact, IReadOnlyList<string> assetType, string glossaryType, string glossary, string termStatus, IReadOnlyList<string> termTemplate, string longDescription, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SearchScore = searchScore;
            SearchHighlights = searchHighlights;
            ObjectType = objectType;
            CreateTime = createTime;
            UpdateTime = updateTime;
            Id = id;
            Name = name;
            QualifiedName = qualifiedName;
            EntityType = entityType;
            Description = description;
            Endorsement = endorsement;
            Owner = owner;
            Classification = classification;
            Label = label;
            Term = term;
            Contact = contact;
            AssetType = assetType;
            GlossaryType = glossaryType;
            Glossary = glossary;
            TermStatus = termStatus;
            TermTemplate = termTemplate;
            LongDescription = longDescription;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The search score calculated by the search engine. The results are ordered by
        /// search score by default.
        /// </summary>
        public float? SearchScore { get; }
        /// <summary>
        /// A highlight list that consists of index fields id ,qualifiedName, name,
        /// description, entityType. When the keyword appears in those fields, the value of
        /// the field, attached with emphasis mark, is returned as an element of
        /// @search.highlights.
        /// </summary>
        public SearchHighlights SearchHighlights { get; }
        /// <summary>
        /// The object type of the record. Object type is the top-level property to
        /// distinguish whether a record is an asset or a term.
        /// </summary>
        public string ObjectType { get; }
        /// <summary> The create time of the record. The Unix epoch format. </summary>
        public long? CreateTime { get; }
        /// <summary> The last update time of the record. The Unix epoch format. </summary>
        public long? UpdateTime { get; }
        /// <summary> The GUID of the record. </summary>
        public string Id { get; }
        /// <summary> The name of the record. </summary>
        public string Name { get; }
        /// <summary> The qualified name of the record. </summary>
        public string QualifiedName { get; }
        /// <summary> The type name of the asset. </summary>
        public string EntityType { get; }
        /// <summary> The description of the asset. </summary>
        public string Description { get; }
        /// <summary> The endorsement of the asset. </summary>
        public IReadOnlyList<string> Endorsement { get; }
        /// <summary> The owner of the record. </summary>
        public string Owner { get; }
        /// <summary> The classifications of the record. </summary>
        public IReadOnlyList<string> Classification { get; }
        /// <summary> The labels of the asset. </summary>
        public IReadOnlyList<string> Label { get; }
        /// <summary> The terms assigned to the asset. </summary>
        public IReadOnlyList<TermSearchResultValue> Term { get; }
        /// <summary> The contacts of the asset. </summary>
        public IReadOnlyList<ContactSearchResultValue> Contact { get; }
        /// <summary> The asset types of the asset. </summary>
        public IReadOnlyList<string> AssetType { get; }
        /// <summary>
        /// The type name of the term. Could be AtlasGlossary, AtlasGlossaryTerm or
        /// AtlasGlossaryCategory.
        /// </summary>
        public string GlossaryType { get; }
        /// <summary> The glossary name of the term. </summary>
        public string Glossary { get; }
        /// <summary> The status of the term. </summary>
        public string TermStatus { get; }
        /// <summary> The term template names used by the term. </summary>
        public IReadOnlyList<string> TermTemplate { get; }
        /// <summary> The definition of the term. </summary>
        public string LongDescription { get; }
    }
}
