/* 
 * App Center Client
 *
 * Microsoft Visual Studio App Center API
 *
 * OpenAPI spec version: v0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Audience Query definition.
    /// </summary>
    [DataContract]
        public partial class AudienceQueryDefinition :  IEquatable<AudienceQueryDefinition>, IValidatableObject
    {
        /// <summary>
        /// Audience Query Type
        /// </summary>
        /// <value>Audience Query Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum QueryTypeEnum
        {
            /// <summary>
            /// Enum Broadcast for value: broadcast
            /// </summary>
            [EnumMember(Value = "broadcast")]
            Broadcast = 1,
            /// <summary>
            /// Enum Userids for value: user_ids
            /// </summary>
            [EnumMember(Value = "user_ids")]
            Userids = 2,
            /// <summary>
            /// Enum Accountids for value: account_ids
            /// </summary>
            [EnumMember(Value = "account_ids")]
            Accountids = 3,
            /// <summary>
            /// Enum Installids for value: install_ids
            /// </summary>
            [EnumMember(Value = "install_ids")]
            Installids = 4        }
        /// <summary>
        /// Audience Query Type
        /// </summary>
        /// <value>Audience Query Type</value>
        [DataMember(Name="queryType", EmitDefaultValue=false)]
        public QueryTypeEnum QueryType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AudienceQueryDefinition" /> class.
        /// </summary>
        /// <param name="queryType">Audience Query Type (required).</param>
        /// <param name="identifiers">List of identifiers..</param>
        public AudienceQueryDefinition(QueryTypeEnum queryType = default(QueryTypeEnum), List<string> identifiers = default(List<string>))
        {
            // to ensure "queryType" is required (not null)
            if (queryType == null)
            {
                throw new InvalidDataException("queryType is a required property for AudienceQueryDefinition and cannot be null");
            }
            else
            {
                this.QueryType = queryType;
            }
            this.Identifiers = identifiers;
        }
        

        /// <summary>
        /// List of identifiers.
        /// </summary>
        /// <value>List of identifiers.</value>
        [DataMember(Name="identifiers", EmitDefaultValue=false)]
        public List<string> Identifiers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudienceQueryDefinition {\n");
            sb.Append("  QueryType: ").Append(QueryType).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudienceQueryDefinition);
        }

        /// <summary>
        /// Returns true if AudienceQueryDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of AudienceQueryDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AudienceQueryDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QueryType == input.QueryType ||
                    (this.QueryType != null &&
                    this.QueryType.Equals(input.QueryType))
                ) && 
                (
                    this.Identifiers == input.Identifiers ||
                    this.Identifiers != null &&
                    input.Identifiers != null &&
                    this.Identifiers.SequenceEqual(input.Identifiers)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.QueryType != null)
                    hashCode = hashCode * 59 + this.QueryType.GetHashCode();
                if (this.Identifiers != null)
                    hashCode = hashCode * 59 + this.Identifiers.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
