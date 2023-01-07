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
    /// CrashGroupModels
    /// </summary>
    [DataContract]
        public partial class CrashGroupModels :  IEquatable<CrashGroupModels>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrashGroupModels" /> class.
        /// </summary>
        /// <param name="crashCount">crashCount.</param>
        /// <param name="models">models.</param>
        public CrashGroupModels(long? crashCount = default(long?), List<CrashGroupModelsModels> models = default(List<CrashGroupModelsModels>))
        {
            this.CrashCount = crashCount;
            this.Models = models;
        }
        
        /// <summary>
        /// Gets or Sets CrashCount
        /// </summary>
        [DataMember(Name="crash_count", EmitDefaultValue=false)]
        public long? CrashCount { get; set; }

        /// <summary>
        /// Gets or Sets Models
        /// </summary>
        [DataMember(Name="models", EmitDefaultValue=false)]
        public List<CrashGroupModelsModels> Models { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrashGroupModels {\n");
            sb.Append("  CrashCount: ").Append(CrashCount).Append("\n");
            sb.Append("  Models: ").Append(Models).Append("\n");
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
            return this.Equals(input as CrashGroupModels);
        }

        /// <summary>
        /// Returns true if CrashGroupModels instances are equal
        /// </summary>
        /// <param name="input">Instance of CrashGroupModels to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrashGroupModels input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CrashCount == input.CrashCount ||
                    (this.CrashCount != null &&
                    this.CrashCount.Equals(input.CrashCount))
                ) && 
                (
                    this.Models == input.Models ||
                    this.Models != null &&
                    input.Models != null &&
                    this.Models.SequenceEqual(input.Models)
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
                if (this.CrashCount != null)
                    hashCode = hashCode * 59 + this.CrashCount.GetHashCode();
                if (this.Models != null)
                    hashCode = hashCode * 59 + this.Models.GetHashCode();
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
