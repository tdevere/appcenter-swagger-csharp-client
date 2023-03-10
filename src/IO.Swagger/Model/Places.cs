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
    /// Places and count during the time range in descending order.
    /// </summary>
    [DataContract]
        public partial class Places :  IEquatable<Places>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Places" /> class.
        /// </summary>
        /// <param name="total">total.</param>
        /// <param name="places">places.</param>
        public Places(long? total = default(long?), List<PlacesPlaces> places = default(List<PlacesPlaces>))
        {
            this.Total = total;
            this._Places = places;
        }
        
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public long? Total { get; set; }

        /// <summary>
        /// Gets or Sets _Places
        /// </summary>
        [DataMember(Name="places", EmitDefaultValue=false)]
        public List<PlacesPlaces> _Places { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Places {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  _Places: ").Append(_Places).Append("\n");
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
            return this.Equals(input as Places);
        }

        /// <summary>
        /// Returns true if Places instances are equal
        /// </summary>
        /// <param name="input">Instance of Places to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Places input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this._Places == input._Places ||
                    this._Places != null &&
                    input._Places != null &&
                    this._Places.SequenceEqual(input._Places)
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this._Places != null)
                    hashCode = hashCode * 59 + this._Places.GetHashCode();
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
