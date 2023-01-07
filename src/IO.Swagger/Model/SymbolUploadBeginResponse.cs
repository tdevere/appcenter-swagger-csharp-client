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
    /// A response containing information pertaining to starting a symbol upload process
    /// </summary>
    [DataContract]
        public partial class SymbolUploadBeginResponse :  IEquatable<SymbolUploadBeginResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SymbolUploadBeginResponse" /> class.
        /// </summary>
        /// <param name="symbolUploadId">The id for the current upload (required).</param>
        /// <param name="uploadUrl">The URL where the client needs to upload the symbol blob to (required).</param>
        /// <param name="expirationDate">Describes how long the upload_url is valid (required).</param>
        public SymbolUploadBeginResponse(string symbolUploadId = default(string), string uploadUrl = default(string), DateTime? expirationDate = default(DateTime?))
        {
            // to ensure "symbolUploadId" is required (not null)
            if (symbolUploadId == null)
            {
                throw new InvalidDataException("symbolUploadId is a required property for SymbolUploadBeginResponse and cannot be null");
            }
            else
            {
                this.SymbolUploadId = symbolUploadId;
            }
            // to ensure "uploadUrl" is required (not null)
            if (uploadUrl == null)
            {
                throw new InvalidDataException("uploadUrl is a required property for SymbolUploadBeginResponse and cannot be null");
            }
            else
            {
                this.UploadUrl = uploadUrl;
            }
            // to ensure "expirationDate" is required (not null)
            if (expirationDate == null)
            {
                throw new InvalidDataException("expirationDate is a required property for SymbolUploadBeginResponse and cannot be null");
            }
            else
            {
                this.ExpirationDate = expirationDate;
            }
        }
        
        /// <summary>
        /// The id for the current upload
        /// </summary>
        /// <value>The id for the current upload</value>
        [DataMember(Name="symbol_upload_id", EmitDefaultValue=false)]
        public string SymbolUploadId { get; set; }

        /// <summary>
        /// The URL where the client needs to upload the symbol blob to
        /// </summary>
        /// <value>The URL where the client needs to upload the symbol blob to</value>
        [DataMember(Name="upload_url", EmitDefaultValue=false)]
        public string UploadUrl { get; set; }

        /// <summary>
        /// Describes how long the upload_url is valid
        /// </summary>
        /// <value>Describes how long the upload_url is valid</value>
        [DataMember(Name="expiration_date", EmitDefaultValue=false)]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SymbolUploadBeginResponse {\n");
            sb.Append("  SymbolUploadId: ").Append(SymbolUploadId).Append("\n");
            sb.Append("  UploadUrl: ").Append(UploadUrl).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
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
            return this.Equals(input as SymbolUploadBeginResponse);
        }

        /// <summary>
        /// Returns true if SymbolUploadBeginResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SymbolUploadBeginResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SymbolUploadBeginResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SymbolUploadId == input.SymbolUploadId ||
                    (this.SymbolUploadId != null &&
                    this.SymbolUploadId.Equals(input.SymbolUploadId))
                ) && 
                (
                    this.UploadUrl == input.UploadUrl ||
                    (this.UploadUrl != null &&
                    this.UploadUrl.Equals(input.UploadUrl))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
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
                if (this.SymbolUploadId != null)
                    hashCode = hashCode * 59 + this.SymbolUploadId.GetHashCode();
                if (this.UploadUrl != null)
                    hashCode = hashCode * 59 + this.UploadUrl.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
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
