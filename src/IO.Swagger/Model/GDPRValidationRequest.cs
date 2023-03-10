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
    /// A request containing a set of release ids to validate
    /// </summary>
    [DataContract]
        public partial class GDPRValidationRequest :  IEquatable<GDPRValidationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GDPRValidationRequest" /> class.
        /// </summary>
        /// <param name="releaseIds">a list of release ids to validate (AC flow) (required).</param>
        /// <param name="hockeyappReleaseIds">a list of release ids to validate (HA flow).</param>
        /// <param name="releaseUploadIds">a list of release uploads ids to validate.</param>
        public GDPRValidationRequest(List<int?> releaseIds = default(List<int?>), List<int?> hockeyappReleaseIds = default(List<int?>), List<string> releaseUploadIds = default(List<string>))
        {
            // to ensure "releaseIds" is required (not null)
            if (releaseIds == null)
            {
                throw new InvalidDataException("releaseIds is a required property for GDPRValidationRequest and cannot be null");
            }
            else
            {
                this.ReleaseIds = releaseIds;
            }
            this.HockeyappReleaseIds = hockeyappReleaseIds;
            this.ReleaseUploadIds = releaseUploadIds;
        }
        
        /// <summary>
        /// a list of release ids to validate (AC flow)
        /// </summary>
        /// <value>a list of release ids to validate (AC flow)</value>
        [DataMember(Name="release_ids", EmitDefaultValue=false)]
        public List<int?> ReleaseIds { get; set; }

        /// <summary>
        /// a list of release ids to validate (HA flow)
        /// </summary>
        /// <value>a list of release ids to validate (HA flow)</value>
        [DataMember(Name="hockeyapp_release_ids", EmitDefaultValue=false)]
        public List<int?> HockeyappReleaseIds { get; set; }

        /// <summary>
        /// a list of release uploads ids to validate
        /// </summary>
        /// <value>a list of release uploads ids to validate</value>
        [DataMember(Name="release_upload_ids", EmitDefaultValue=false)]
        public List<string> ReleaseUploadIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GDPRValidationRequest {\n");
            sb.Append("  ReleaseIds: ").Append(ReleaseIds).Append("\n");
            sb.Append("  HockeyappReleaseIds: ").Append(HockeyappReleaseIds).Append("\n");
            sb.Append("  ReleaseUploadIds: ").Append(ReleaseUploadIds).Append("\n");
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
            return this.Equals(input as GDPRValidationRequest);
        }

        /// <summary>
        /// Returns true if GDPRValidationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GDPRValidationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GDPRValidationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReleaseIds == input.ReleaseIds ||
                    this.ReleaseIds != null &&
                    input.ReleaseIds != null &&
                    this.ReleaseIds.SequenceEqual(input.ReleaseIds)
                ) && 
                (
                    this.HockeyappReleaseIds == input.HockeyappReleaseIds ||
                    this.HockeyappReleaseIds != null &&
                    input.HockeyappReleaseIds != null &&
                    this.HockeyappReleaseIds.SequenceEqual(input.HockeyappReleaseIds)
                ) && 
                (
                    this.ReleaseUploadIds == input.ReleaseUploadIds ||
                    this.ReleaseUploadIds != null &&
                    input.ReleaseUploadIds != null &&
                    this.ReleaseUploadIds.SequenceEqual(input.ReleaseUploadIds)
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
                if (this.ReleaseIds != null)
                    hashCode = hashCode * 59 + this.ReleaseIds.GetHashCode();
                if (this.HockeyappReleaseIds != null)
                    hashCode = hashCode * 59 + this.HockeyappReleaseIds.GetHashCode();
                if (this.ReleaseUploadIds != null)
                    hashCode = hashCode * 59 + this.ReleaseUploadIds.GetHashCode();
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
