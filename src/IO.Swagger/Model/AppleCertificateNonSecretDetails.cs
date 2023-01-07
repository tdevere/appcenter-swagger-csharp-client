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
    /// Apple Certificate Secret Details
    /// </summary>
    [DataContract]
        public partial class AppleCertificateNonSecretDetails :  IEquatable<AppleCertificateNonSecretDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppleCertificateNonSecretDetails" /> class.
        /// </summary>
        /// <param name="displayName">The display name (CN) of the certificate (required).</param>
        /// <param name="certificateValidityStartDate">The date-time from which the certificate is valid (required).</param>
        /// <param name="certificateValidityEndDate">The date-time till which the certificate is valid (required).</param>
        public AppleCertificateNonSecretDetails(string displayName = default(string), string certificateValidityStartDate = default(string), string certificateValidityEndDate = default(string))
        {
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for AppleCertificateNonSecretDetails and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            // to ensure "certificateValidityStartDate" is required (not null)
            if (certificateValidityStartDate == null)
            {
                throw new InvalidDataException("certificateValidityStartDate is a required property for AppleCertificateNonSecretDetails and cannot be null");
            }
            else
            {
                this.CertificateValidityStartDate = certificateValidityStartDate;
            }
            // to ensure "certificateValidityEndDate" is required (not null)
            if (certificateValidityEndDate == null)
            {
                throw new InvalidDataException("certificateValidityEndDate is a required property for AppleCertificateNonSecretDetails and cannot be null");
            }
            else
            {
                this.CertificateValidityEndDate = certificateValidityEndDate;
            }
        }
        
        /// <summary>
        /// The display name (CN) of the certificate
        /// </summary>
        /// <value>The display name (CN) of the certificate</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The date-time from which the certificate is valid
        /// </summary>
        /// <value>The date-time from which the certificate is valid</value>
        [DataMember(Name="certificateValidityStartDate", EmitDefaultValue=false)]
        public string CertificateValidityStartDate { get; set; }

        /// <summary>
        /// The date-time till which the certificate is valid
        /// </summary>
        /// <value>The date-time till which the certificate is valid</value>
        [DataMember(Name="certificateValidityEndDate", EmitDefaultValue=false)]
        public string CertificateValidityEndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppleCertificateNonSecretDetails {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  CertificateValidityStartDate: ").Append(CertificateValidityStartDate).Append("\n");
            sb.Append("  CertificateValidityEndDate: ").Append(CertificateValidityEndDate).Append("\n");
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
            return this.Equals(input as AppleCertificateNonSecretDetails);
        }

        /// <summary>
        /// Returns true if AppleCertificateNonSecretDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AppleCertificateNonSecretDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppleCertificateNonSecretDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.CertificateValidityStartDate == input.CertificateValidityStartDate ||
                    (this.CertificateValidityStartDate != null &&
                    this.CertificateValidityStartDate.Equals(input.CertificateValidityStartDate))
                ) && 
                (
                    this.CertificateValidityEndDate == input.CertificateValidityEndDate ||
                    (this.CertificateValidityEndDate != null &&
                    this.CertificateValidityEndDate.Equals(input.CertificateValidityEndDate))
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.CertificateValidityStartDate != null)
                    hashCode = hashCode * 59 + this.CertificateValidityStartDate.GetHashCode();
                if (this.CertificateValidityEndDate != null)
                    hashCode = hashCode * 59 + this.CertificateValidityEndDate.GetHashCode();
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
