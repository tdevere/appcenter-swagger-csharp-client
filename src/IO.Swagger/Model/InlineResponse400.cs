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
    /// InlineResponse400
    /// </summary>
    [DataContract]
        public partial class InlineResponse400 :  IEquatable<InlineResponse400>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse400" /> class.
        /// </summary>
        /// <param name="destinations">destinations.</param>
        /// <param name="mandatoryUpdate">mandatoryUpdate.</param>
        /// <param name="releaseNotes">releaseNotes.</param>
        public InlineResponse400(List<ReleaseUpdateErrorDestinations> destinations = default(List<ReleaseUpdateErrorDestinations>), bool? mandatoryUpdate = default(bool?), string releaseNotes = default(string))
        {
            this.Destinations = destinations;
            this.MandatoryUpdate = mandatoryUpdate;
            this.ReleaseNotes = releaseNotes;
        }
        
        /// <summary>
        /// Gets or Sets Destinations
        /// </summary>
        [DataMember(Name="destinations", EmitDefaultValue=false)]
        public List<ReleaseUpdateErrorDestinations> Destinations { get; set; }

        /// <summary>
        /// Gets or Sets MandatoryUpdate
        /// </summary>
        [DataMember(Name="mandatory_update", EmitDefaultValue=false)]
        public bool? MandatoryUpdate { get; set; }

        /// <summary>
        /// Gets or Sets ReleaseNotes
        /// </summary>
        [DataMember(Name="release_notes", EmitDefaultValue=false)]
        public string ReleaseNotes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse400 {\n");
            sb.Append("  Destinations: ").Append(Destinations).Append("\n");
            sb.Append("  MandatoryUpdate: ").Append(MandatoryUpdate).Append("\n");
            sb.Append("  ReleaseNotes: ").Append(ReleaseNotes).Append("\n");
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
            return this.Equals(input as InlineResponse400);
        }

        /// <summary>
        /// Returns true if InlineResponse400 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse400 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse400 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Destinations == input.Destinations ||
                    this.Destinations != null &&
                    input.Destinations != null &&
                    this.Destinations.SequenceEqual(input.Destinations)
                ) && 
                (
                    this.MandatoryUpdate == input.MandatoryUpdate ||
                    (this.MandatoryUpdate != null &&
                    this.MandatoryUpdate.Equals(input.MandatoryUpdate))
                ) && 
                (
                    this.ReleaseNotes == input.ReleaseNotes ||
                    (this.ReleaseNotes != null &&
                    this.ReleaseNotes.Equals(input.ReleaseNotes))
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
                if (this.Destinations != null)
                    hashCode = hashCode * 59 + this.Destinations.GetHashCode();
                if (this.MandatoryUpdate != null)
                    hashCode = hashCode * 59 + this.MandatoryUpdate.GetHashCode();
                if (this.ReleaseNotes != null)
                    hashCode = hashCode * 59 + this.ReleaseNotes.GetHashCode();
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
