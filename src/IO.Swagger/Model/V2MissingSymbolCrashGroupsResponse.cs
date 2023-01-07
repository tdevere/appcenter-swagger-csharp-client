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
    /// grouped by missing symbols crashes response object
    /// </summary>
    [DataContract]
        public partial class V2MissingSymbolCrashGroupsResponse :  IEquatable<V2MissingSymbolCrashGroupsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2MissingSymbolCrashGroupsResponse" /> class.
        /// </summary>
        /// <param name="totalCrashCount">total number of crashes for all the groups (required).</param>
        /// <param name="groups">list of crash groups formed by missing symbols combination (required).</param>
        public V2MissingSymbolCrashGroupsResponse(int? totalCrashCount = default(int?), List<V2MissingSymbolCrashGroupsResponseGroups> groups = default(List<V2MissingSymbolCrashGroupsResponseGroups>))
        {
            // to ensure "totalCrashCount" is required (not null)
            if (totalCrashCount == null)
            {
                throw new InvalidDataException("totalCrashCount is a required property for V2MissingSymbolCrashGroupsResponse and cannot be null");
            }
            else
            {
                this.TotalCrashCount = totalCrashCount;
            }
            // to ensure "groups" is required (not null)
            if (groups == null)
            {
                throw new InvalidDataException("groups is a required property for V2MissingSymbolCrashGroupsResponse and cannot be null");
            }
            else
            {
                this.Groups = groups;
            }
        }
        
        /// <summary>
        /// total number of crashes for all the groups
        /// </summary>
        /// <value>total number of crashes for all the groups</value>
        [DataMember(Name="total_crash_count", EmitDefaultValue=false)]
        public int? TotalCrashCount { get; set; }

        /// <summary>
        /// list of crash groups formed by missing symbols combination
        /// </summary>
        /// <value>list of crash groups formed by missing symbols combination</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<V2MissingSymbolCrashGroupsResponseGroups> Groups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2MissingSymbolCrashGroupsResponse {\n");
            sb.Append("  TotalCrashCount: ").Append(TotalCrashCount).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
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
            return this.Equals(input as V2MissingSymbolCrashGroupsResponse);
        }

        /// <summary>
        /// Returns true if V2MissingSymbolCrashGroupsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of V2MissingSymbolCrashGroupsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2MissingSymbolCrashGroupsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalCrashCount == input.TotalCrashCount ||
                    (this.TotalCrashCount != null &&
                    this.TotalCrashCount.Equals(input.TotalCrashCount))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
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
                if (this.TotalCrashCount != null)
                    hashCode = hashCode * 59 + this.TotalCrashCount.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
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