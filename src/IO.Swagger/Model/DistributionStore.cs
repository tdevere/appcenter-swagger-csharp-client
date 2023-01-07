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
    /// DistributionStore
    /// </summary>
    [DataContract]
        public partial class DistributionStore :  IEquatable<DistributionStore>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionStore" /> class.
        /// </summary>
        /// <param name="isLatest">Is the containing release the latest one in this distribution store..</param>
        public DistributionStore(bool? isLatest = default(bool?))
        {
            this.IsLatest = isLatest;
        }
        
        /// <summary>
        /// Is the containing release the latest one in this distribution store.
        /// </summary>
        /// <value>Is the containing release the latest one in this distribution store.</value>
        [DataMember(Name="is_latest", EmitDefaultValue=false)]
        public bool? IsLatest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DistributionStore {\n");
            sb.Append("  IsLatest: ").Append(IsLatest).Append("\n");
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
            return this.Equals(input as DistributionStore);
        }

        /// <summary>
        /// Returns true if DistributionStore instances are equal
        /// </summary>
        /// <param name="input">Instance of DistributionStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistributionStore input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsLatest == input.IsLatest ||
                    (this.IsLatest != null &&
                    this.IsLatest.Equals(input.IsLatest))
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
                if (this.IsLatest != null)
                    hashCode = hashCode * 59 + this.IsLatest.GetHashCode();
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