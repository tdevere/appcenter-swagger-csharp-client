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
    /// PatchReleaseUploadStatusResponse
    /// </summary>
    [DataContract]
        public partial class PatchReleaseUploadStatusResponse :  IEquatable<PatchReleaseUploadStatusResponse>, IValidatableObject
    {
        /// <summary>
        /// The current upload status.
        /// </summary>
        /// <value>The current upload status.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum UploadStatusEnum
        {
            /// <summary>
            /// Enum UploadStarted for value: uploadStarted
            /// </summary>
            [EnumMember(Value = "uploadStarted")]
            UploadStarted = 1,
            /// <summary>
            /// Enum UploadFinished for value: uploadFinished
            /// </summary>
            [EnumMember(Value = "uploadFinished")]
            UploadFinished = 2,
            /// <summary>
            /// Enum UploadCanceled for value: uploadCanceled
            /// </summary>
            [EnumMember(Value = "uploadCanceled")]
            UploadCanceled = 3,
            /// <summary>
            /// Enum ReadyToBePublished for value: readyToBePublished
            /// </summary>
            [EnumMember(Value = "readyToBePublished")]
            ReadyToBePublished = 4,
            /// <summary>
            /// Enum MalwareDetected for value: malwareDetected
            /// </summary>
            [EnumMember(Value = "malwareDetected")]
            MalwareDetected = 5,
            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 6        }
        /// <summary>
        /// The current upload status.
        /// </summary>
        /// <value>The current upload status.</value>
        [DataMember(Name="upload_status", EmitDefaultValue=false)]
        public UploadStatusEnum UploadStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchReleaseUploadStatusResponse" /> class.
        /// </summary>
        /// <param name="id">The ID for the upload. (required).</param>
        /// <param name="uploadStatus">The current upload status. (required).</param>
        public PatchReleaseUploadStatusResponse(Guid? id = default(Guid?), UploadStatusEnum uploadStatus = default(UploadStatusEnum))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for PatchReleaseUploadStatusResponse and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "uploadStatus" is required (not null)
            if (uploadStatus == null)
            {
                throw new InvalidDataException("uploadStatus is a required property for PatchReleaseUploadStatusResponse and cannot be null");
            }
            else
            {
                this.UploadStatus = uploadStatus;
            }
        }
        
        /// <summary>
        /// The ID for the upload.
        /// </summary>
        /// <value>The ID for the upload.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchReleaseUploadStatusResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UploadStatus: ").Append(UploadStatus).Append("\n");
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
            return this.Equals(input as PatchReleaseUploadStatusResponse);
        }

        /// <summary>
        /// Returns true if PatchReleaseUploadStatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchReleaseUploadStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchReleaseUploadStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UploadStatus == input.UploadStatus ||
                    (this.UploadStatus != null &&
                    this.UploadStatus.Equals(input.UploadStatus))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UploadStatus != null)
                    hashCode = hashCode * 59 + this.UploadStatus.GetHashCode();
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