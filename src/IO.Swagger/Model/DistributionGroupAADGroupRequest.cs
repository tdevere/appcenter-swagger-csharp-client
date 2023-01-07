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
    /// DistributionGroupAADGroupRequest
    /// </summary>
    [DataContract]
        public partial class DistributionGroupAADGroupRequest :  IEquatable<DistributionGroupAADGroupRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionGroupAADGroupRequest" /> class.
        /// </summary>
        /// <param name="aadGroups">The list of aad group ids and names to add.</param>
        public DistributionGroupAADGroupRequest(List<DistributionGroupAADGroupRequestAadGroups> aadGroups = default(List<DistributionGroupAADGroupRequestAadGroups>))
        {
            this.AadGroups = aadGroups;
        }
        
        /// <summary>
        /// The list of aad group ids and names to add
        /// </summary>
        /// <value>The list of aad group ids and names to add</value>
        [DataMember(Name="aad_groups", EmitDefaultValue=false)]
        public List<DistributionGroupAADGroupRequestAadGroups> AadGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DistributionGroupAADGroupRequest {\n");
            sb.Append("  AadGroups: ").Append(AadGroups).Append("\n");
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
            return this.Equals(input as DistributionGroupAADGroupRequest);
        }

        /// <summary>
        /// Returns true if DistributionGroupAADGroupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DistributionGroupAADGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistributionGroupAADGroupRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AadGroups == input.AadGroups ||
                    this.AadGroups != null &&
                    input.AadGroups != null &&
                    this.AadGroups.SequenceEqual(input.AadGroups)
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
                if (this.AadGroups != null)
                    hashCode = hashCode * 59 + this.AadGroups.GetHashCode();
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
