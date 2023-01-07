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
    /// InlineResponse20021
    /// </summary>
    [DataContract]
        public partial class InlineResponse20021 :  IEquatable<InlineResponse20021>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20021" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="appHashFileId">appHashFileId.</param>
        /// <param name="locale">locale.</param>
        /// <param name="dsymHashFileId">dsymHashFileId.</param>
        /// <param name="appHashFileUrl">appHashFileUrl.</param>
        /// <param name="dsymHashFileUrl">dsymHashFileUrl.</param>
        /// <param name="appIconUrl">appIconUrl.</param>
        public InlineResponse20021(Guid? id = default(Guid?), Guid? appHashFileId = default(Guid?), string locale = default(string), Guid? dsymHashFileId = default(Guid?), string appHashFileUrl = default(string), string dsymHashFileUrl = default(string), string appIconUrl = default(string))
        {
            this.Id = id;
            this.AppHashFileId = appHashFileId;
            this.Locale = locale;
            this.DsymHashFileId = dsymHashFileId;
            this.AppHashFileUrl = appHashFileUrl;
            this.DsymHashFileUrl = dsymHashFileUrl;
            this.AppIconUrl = appIconUrl;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets AppHashFileId
        /// </summary>
        [DataMember(Name="app_hash_file_id", EmitDefaultValue=false)]
        public Guid? AppHashFileId { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets DsymHashFileId
        /// </summary>
        [DataMember(Name="dsym_hash_file_id", EmitDefaultValue=false)]
        public Guid? DsymHashFileId { get; set; }

        /// <summary>
        /// Gets or Sets AppHashFileUrl
        /// </summary>
        [DataMember(Name="app_hash_file_url", EmitDefaultValue=false)]
        public string AppHashFileUrl { get; set; }

        /// <summary>
        /// Gets or Sets DsymHashFileUrl
        /// </summary>
        [DataMember(Name="dsym_hash_file_url", EmitDefaultValue=false)]
        public string DsymHashFileUrl { get; set; }

        /// <summary>
        /// Gets or Sets AppIconUrl
        /// </summary>
        [DataMember(Name="app_icon_url", EmitDefaultValue=false)]
        public string AppIconUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20021 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AppHashFileId: ").Append(AppHashFileId).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  DsymHashFileId: ").Append(DsymHashFileId).Append("\n");
            sb.Append("  AppHashFileUrl: ").Append(AppHashFileUrl).Append("\n");
            sb.Append("  DsymHashFileUrl: ").Append(DsymHashFileUrl).Append("\n");
            sb.Append("  AppIconUrl: ").Append(AppIconUrl).Append("\n");
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
            return this.Equals(input as InlineResponse20021);
        }

        /// <summary>
        /// Returns true if InlineResponse20021 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20021 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20021 input)
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
                    this.AppHashFileId == input.AppHashFileId ||
                    (this.AppHashFileId != null &&
                    this.AppHashFileId.Equals(input.AppHashFileId))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.DsymHashFileId == input.DsymHashFileId ||
                    (this.DsymHashFileId != null &&
                    this.DsymHashFileId.Equals(input.DsymHashFileId))
                ) && 
                (
                    this.AppHashFileUrl == input.AppHashFileUrl ||
                    (this.AppHashFileUrl != null &&
                    this.AppHashFileUrl.Equals(input.AppHashFileUrl))
                ) && 
                (
                    this.DsymHashFileUrl == input.DsymHashFileUrl ||
                    (this.DsymHashFileUrl != null &&
                    this.DsymHashFileUrl.Equals(input.DsymHashFileUrl))
                ) && 
                (
                    this.AppIconUrl == input.AppIconUrl ||
                    (this.AppIconUrl != null &&
                    this.AppIconUrl.Equals(input.AppIconUrl))
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
                if (this.AppHashFileId != null)
                    hashCode = hashCode * 59 + this.AppHashFileId.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.DsymHashFileId != null)
                    hashCode = hashCode * 59 + this.DsymHashFileId.GetHashCode();
                if (this.AppHashFileUrl != null)
                    hashCode = hashCode * 59 + this.AppHashFileUrl.GetHashCode();
                if (this.DsymHashFileUrl != null)
                    hashCode = hashCode * 59 + this.DsymHashFileUrl.GetHashCode();
                if (this.AppIconUrl != null)
                    hashCode = hashCode * 59 + this.AppIconUrl.GetHashCode();
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
