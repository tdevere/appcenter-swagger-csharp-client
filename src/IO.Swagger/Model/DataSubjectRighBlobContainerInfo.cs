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
    /// DataSubjectRighBlobContainerInfo
    /// </summary>
    [DataContract]
        public partial class DataSubjectRighBlobContainerInfo :  IEquatable<DataSubjectRighBlobContainerInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSubjectRighBlobContainerInfo" /> class.
        /// </summary>
        /// <param name="sasUri">sasUri (required).</param>
        /// <param name="blobPath">blobPath (required).</param>
        public DataSubjectRighBlobContainerInfo(string sasUri = default(string), string blobPath = default(string))
        {
            // to ensure "sasUri" is required (not null)
            if (sasUri == null)
            {
                throw new InvalidDataException("sasUri is a required property for DataSubjectRighBlobContainerInfo and cannot be null");
            }
            else
            {
                this.SasUri = sasUri;
            }
            // to ensure "blobPath" is required (not null)
            if (blobPath == null)
            {
                throw new InvalidDataException("blobPath is a required property for DataSubjectRighBlobContainerInfo and cannot be null");
            }
            else
            {
                this.BlobPath = blobPath;
            }
        }
        
        /// <summary>
        /// Gets or Sets SasUri
        /// </summary>
        [DataMember(Name="sasUri", EmitDefaultValue=false)]
        public string SasUri { get; set; }

        /// <summary>
        /// Gets or Sets BlobPath
        /// </summary>
        [DataMember(Name="blobPath", EmitDefaultValue=false)]
        public string BlobPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataSubjectRighBlobContainerInfo {\n");
            sb.Append("  SasUri: ").Append(SasUri).Append("\n");
            sb.Append("  BlobPath: ").Append(BlobPath).Append("\n");
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
            return this.Equals(input as DataSubjectRighBlobContainerInfo);
        }

        /// <summary>
        /// Returns true if DataSubjectRighBlobContainerInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DataSubjectRighBlobContainerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSubjectRighBlobContainerInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SasUri == input.SasUri ||
                    (this.SasUri != null &&
                    this.SasUri.Equals(input.SasUri))
                ) && 
                (
                    this.BlobPath == input.BlobPath ||
                    (this.BlobPath != null &&
                    this.BlobPath.Equals(input.BlobPath))
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
                if (this.SasUri != null)
                    hashCode = hashCode * 59 + this.SasUri.GetHashCode();
                if (this.BlobPath != null)
                    hashCode = hashCode * 59 + this.BlobPath.GetHashCode();
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