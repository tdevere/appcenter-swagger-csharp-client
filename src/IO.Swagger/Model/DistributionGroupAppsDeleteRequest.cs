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
    /// DistributionGroupAppsDeleteRequest
    /// </summary>
    [DataContract]
        public partial class DistributionGroupAppsDeleteRequest :  IEquatable<DistributionGroupAppsDeleteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionGroupAppsDeleteRequest" /> class.
        /// </summary>
        /// <param name="apps">The list of apps to delete from the distribution group.</param>
        public DistributionGroupAppsDeleteRequest(List<V01orgsorgNamedistributionGroupsdistributionGroupNameappsbulkDeleteApps> apps = default(List<V01orgsorgNamedistributionGroupsdistributionGroupNameappsbulkDeleteApps>))
        {
            this.Apps = apps;
        }
        
        /// <summary>
        /// The list of apps to delete from the distribution group
        /// </summary>
        /// <value>The list of apps to delete from the distribution group</value>
        [DataMember(Name="apps", EmitDefaultValue=false)]
        public List<V01orgsorgNamedistributionGroupsdistributionGroupNameappsbulkDeleteApps> Apps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DistributionGroupAppsDeleteRequest {\n");
            sb.Append("  Apps: ").Append(Apps).Append("\n");
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
            return this.Equals(input as DistributionGroupAppsDeleteRequest);
        }

        /// <summary>
        /// Returns true if DistributionGroupAppsDeleteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DistributionGroupAppsDeleteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistributionGroupAppsDeleteRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Apps == input.Apps ||
                    this.Apps != null &&
                    input.Apps != null &&
                    this.Apps.SequenceEqual(input.Apps)
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
                if (this.Apps != null)
                    hashCode = hashCode * 59 + this.Apps.GetHashCode();
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
