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
    /// SessionDurationsDistributionDistribution
    /// </summary>
    [DataContract]
        public partial class SessionDurationsDistributionDistribution :  IEquatable<SessionDurationsDistributionDistribution>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionDurationsDistributionDistribution" /> class.
        /// </summary>
        /// <param name="bucket">The bucket name..</param>
        /// <param name="count">The count of sessions in current bucket..</param>
        public SessionDurationsDistributionDistribution(string bucket = default(string), long? count = default(long?))
        {
            this.Bucket = bucket;
            this.Count = count;
        }
        
        /// <summary>
        /// The bucket name.
        /// </summary>
        /// <value>The bucket name.</value>
        [DataMember(Name="bucket", EmitDefaultValue=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// The count of sessions in current bucket.
        /// </summary>
        /// <value>The count of sessions in current bucket.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionDurationsDistributionDistribution {\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as SessionDurationsDistributionDistribution);
        }

        /// <summary>
        /// Returns true if SessionDurationsDistributionDistribution instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionDurationsDistributionDistribution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionDurationsDistributionDistribution input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bucket == input.Bucket ||
                    (this.Bucket != null &&
                    this.Bucket.Equals(input.Bucket))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.Bucket != null)
                    hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
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