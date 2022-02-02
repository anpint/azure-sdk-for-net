// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Operation request/response representation details.
    /// </summary>
    public partial class RepresentationContract
    {
        /// <summary>
        /// Initializes a new instance of the RepresentationContract class.
        /// </summary>
        public RepresentationContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RepresentationContract class.
        /// </summary>
        /// <param name="contentType">Specifies a registered or custom content
        /// type for this representation, e.g. application/xml.</param>
        /// <param name="schemaId">Schema identifier. Applicable only if
        /// 'contentType' value is neither 'application/x-www-form-urlencoded'
        /// nor 'multipart/form-data'.</param>
        /// <param name="typeName">Type name defined by the schema. Applicable
        /// only if 'contentType' value is neither
        /// 'application/x-www-form-urlencoded' nor
        /// 'multipart/form-data'.</param>
        /// <param name="formParameters">Collection of form parameters.
        /// Required if 'contentType' value is either
        /// 'application/x-www-form-urlencoded' or
        /// 'multipart/form-data'..</param>
        /// <param name="examples">Exampled defined for the
        /// representation.</param>
        public RepresentationContract(string contentType, string schemaId = default(string), string typeName = default(string), IList<ParameterContract> formParameters = default(IList<ParameterContract>), IDictionary<string, ParameterExampleContract> examples = default(IDictionary<string, ParameterExampleContract>))
        {
            ContentType = contentType;
            SchemaId = schemaId;
            TypeName = typeName;
            FormParameters = formParameters;
            Examples = examples;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies a registered or custom content type for this
        /// representation, e.g. application/xml.
        /// </summary>
        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets schema identifier. Applicable only if 'contentType'
        /// value is neither 'application/x-www-form-urlencoded' nor
        /// 'multipart/form-data'.
        /// </summary>
        [JsonProperty(PropertyName = "schemaId")]
        public string SchemaId { get; set; }

        /// <summary>
        /// Gets or sets type name defined by the schema. Applicable only if
        /// 'contentType' value is neither 'application/x-www-form-urlencoded'
        /// nor 'multipart/form-data'.
        /// </summary>
        [JsonProperty(PropertyName = "typeName")]
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets collection of form parameters. Required if
        /// 'contentType' value is either 'application/x-www-form-urlencoded'
        /// or 'multipart/form-data'..
        /// </summary>
        [JsonProperty(PropertyName = "formParameters")]
        public IList<ParameterContract> FormParameters { get; set; }

        /// <summary>
        /// Gets or sets exampled defined for the representation.
        /// </summary>
        [JsonProperty(PropertyName = "examples")]
        public IDictionary<string, ParameterExampleContract> Examples { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ContentType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContentType");
            }
            if (FormParameters != null)
            {
                foreach (var element in FormParameters)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
