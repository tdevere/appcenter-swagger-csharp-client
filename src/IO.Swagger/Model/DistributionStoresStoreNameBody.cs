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
    /// DistributionStoresStoreNameBody
    /// </summary>
    [DataContract]
        public partial class DistributionStoresStoreNameBody :  IEquatable<DistributionStoresStoreNameBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionStoresStoreNameBody" /> class.
        /// </summary>
        /// <param name="serviceConnectionId">Service connection id to updated. (required).</param>
        public DistributionStoresStoreNameBody(string serviceConnectionId = default(string))
        {
            // to ensure "serviceConnectionId" is required (not null)
            if (serviceConnectionId == null)
            {
                throw new InvalidDataException("serviceConnectionId is a required property for DistributionStoresStoreNameBody and cannot be null");
            }
            else
            {
                this.ServiceConnectionId = serviceConnectionId;
            }
        }
        
        /// <summary>
        /// Service connection id to updated.
        /// </summary>
        /// <value>Service connection id to updated.</value>
        [DataMember(Name="service_connection_id", EmitDefaultValue=false)]
        public string ServiceConnectionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DistributionStoresStoreNameBody {\n");
            sb.Append("  ServiceConnectionId: ").Append(ServiceConnectionId).Append("\n");
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
            return this.Equals(input as DistributionStoresStoreNameBody);
        }

        /// <summary>
        /// Returns true if DistributionStoresStoreNameBody instances are equal
        /// </summary>
        /// <param name="input">Instance of DistributionStoresStoreNameBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistributionStoresStoreNameBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceConnectionId == input.ServiceConnectionId ||
                    (this.ServiceConnectionId != null &&
                    this.ServiceConnectionId.Equals(input.ServiceConnectionId))
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
                if (this.ServiceConnectionId != null)
                    hashCode = hashCode * 59 + this.ServiceConnectionId.GetHashCode();
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
