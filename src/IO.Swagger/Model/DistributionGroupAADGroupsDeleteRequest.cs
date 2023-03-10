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
    /// DistributionGroupAADGroupsDeleteRequest
    /// </summary>
    [DataContract]
        public partial class DistributionGroupAADGroupsDeleteRequest :  IEquatable<DistributionGroupAADGroupsDeleteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionGroupAADGroupsDeleteRequest" /> class.
        /// </summary>
        /// <param name="aadGroupIds">The list of aad group ids.</param>
        public DistributionGroupAADGroupsDeleteRequest(List<string> aadGroupIds = default(List<string>))
        {
            this.AadGroupIds = aadGroupIds;
        }
        
        /// <summary>
        /// The list of aad group ids
        /// </summary>
        /// <value>The list of aad group ids</value>
        [DataMember(Name="aad_group_ids", EmitDefaultValue=false)]
        public List<string> AadGroupIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DistributionGroupAADGroupsDeleteRequest {\n");
            sb.Append("  AadGroupIds: ").Append(AadGroupIds).Append("\n");
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
            return this.Equals(input as DistributionGroupAADGroupsDeleteRequest);
        }

        /// <summary>
        /// Returns true if DistributionGroupAADGroupsDeleteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DistributionGroupAADGroupsDeleteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistributionGroupAADGroupsDeleteRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AadGroupIds == input.AadGroupIds ||
                    this.AadGroupIds != null &&
                    input.AadGroupIds != null &&
                    this.AadGroupIds.SequenceEqual(input.AadGroupIds)
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
                if (this.AadGroupIds != null)
                    hashCode = hashCode * 59 + this.AadGroupIds.GetHashCode();
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
