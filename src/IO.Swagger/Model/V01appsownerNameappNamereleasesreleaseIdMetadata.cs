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
    /// An object containing all the release metadata.
    /// </summary>
    [DataContract]
        public partial class V01appsownerNameappNamereleasesreleaseIdMetadata :  IEquatable<V01appsownerNameappNamereleasesreleaseIdMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V01appsownerNameappNamereleasesreleaseIdMetadata" /> class.
        /// </summary>
        /// <param name="dsaSignature">dsa signature of the release for the sparkle feed..</param>
        /// <param name="edSignature">edDSA signature of the release for the sparkle feed..</param>
        public V01appsownerNameappNamereleasesreleaseIdMetadata(string dsaSignature = default(string), string edSignature = default(string))
        {
            this.DsaSignature = dsaSignature;
            this.EdSignature = edSignature;
        }
        
        /// <summary>
        /// dsa signature of the release for the sparkle feed.
        /// </summary>
        /// <value>dsa signature of the release for the sparkle feed.</value>
        [DataMember(Name="dsa_signature", EmitDefaultValue=false)]
        public string DsaSignature { get; set; }

        /// <summary>
        /// edDSA signature of the release for the sparkle feed.
        /// </summary>
        /// <value>edDSA signature of the release for the sparkle feed.</value>
        [DataMember(Name="ed_signature", EmitDefaultValue=false)]
        public string EdSignature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V01appsownerNameappNamereleasesreleaseIdMetadata {\n");
            sb.Append("  DsaSignature: ").Append(DsaSignature).Append("\n");
            sb.Append("  EdSignature: ").Append(EdSignature).Append("\n");
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
            return this.Equals(input as V01appsownerNameappNamereleasesreleaseIdMetadata);
        }

        /// <summary>
        /// Returns true if V01appsownerNameappNamereleasesreleaseIdMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of V01appsownerNameappNamereleasesreleaseIdMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V01appsownerNameappNamereleasesreleaseIdMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DsaSignature == input.DsaSignature ||
                    (this.DsaSignature != null &&
                    this.DsaSignature.Equals(input.DsaSignature))
                ) && 
                (
                    this.EdSignature == input.EdSignature ||
                    (this.EdSignature != null &&
                    this.EdSignature.Equals(input.EdSignature))
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
                if (this.DsaSignature != null)
                    hashCode = hashCode * 59 + this.DsaSignature.GetHashCode();
                if (this.EdSignature != null)
                    hashCode = hashCode * 59 + this.EdSignature.GetHashCode();
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
