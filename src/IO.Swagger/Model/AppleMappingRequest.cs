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
    /// Apple Mapping Request Type
    /// </summary>
    [DataContract]
        public partial class AppleMappingRequest :  IEquatable<AppleMappingRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppleMappingRequest" /> class.
        /// </summary>
        /// <param name="serviceConnectionId">Id for the shared service connection. In case of Apple AppStore, this connection will be used to create and connect to the Apple AppStore in Mobile Center. (required).</param>
        /// <param name="appleId">ID of the apple application in apple store, takes precedence over bundle_identifier when both are provided.</param>
        /// <param name="bundleIdentifier">Bundle Identifier of the apple package.</param>
        /// <param name="teamIdentifier">ID of the Team associated with the app in apple store (required).</param>
        public AppleMappingRequest(string serviceConnectionId = default(string), string appleId = default(string), string bundleIdentifier = default(string), string teamIdentifier = default(string))
        {
            // to ensure "serviceConnectionId" is required (not null)
            if (serviceConnectionId == null)
            {
                throw new InvalidDataException("serviceConnectionId is a required property for AppleMappingRequest and cannot be null");
            }
            else
            {
                this.ServiceConnectionId = serviceConnectionId;
            }
            // to ensure "teamIdentifier" is required (not null)
            if (teamIdentifier == null)
            {
                throw new InvalidDataException("teamIdentifier is a required property for AppleMappingRequest and cannot be null");
            }
            else
            {
                this.TeamIdentifier = teamIdentifier;
            }
            this.AppleId = appleId;
            this.BundleIdentifier = bundleIdentifier;
        }
        
        /// <summary>
        /// Id for the shared service connection. In case of Apple AppStore, this connection will be used to create and connect to the Apple AppStore in Mobile Center.
        /// </summary>
        /// <value>Id for the shared service connection. In case of Apple AppStore, this connection will be used to create and connect to the Apple AppStore in Mobile Center.</value>
        [DataMember(Name="service_connection_id", EmitDefaultValue=false)]
        public string ServiceConnectionId { get; set; }

        /// <summary>
        /// ID of the apple application in apple store, takes precedence over bundle_identifier when both are provided
        /// </summary>
        /// <value>ID of the apple application in apple store, takes precedence over bundle_identifier when both are provided</value>
        [DataMember(Name="apple_id", EmitDefaultValue=false)]
        public string AppleId { get; set; }

        /// <summary>
        /// Bundle Identifier of the apple package
        /// </summary>
        /// <value>Bundle Identifier of the apple package</value>
        [DataMember(Name="bundle_identifier", EmitDefaultValue=false)]
        public string BundleIdentifier { get; set; }

        /// <summary>
        /// ID of the Team associated with the app in apple store
        /// </summary>
        /// <value>ID of the Team associated with the app in apple store</value>
        [DataMember(Name="team_identifier", EmitDefaultValue=false)]
        public string TeamIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppleMappingRequest {\n");
            sb.Append("  ServiceConnectionId: ").Append(ServiceConnectionId).Append("\n");
            sb.Append("  AppleId: ").Append(AppleId).Append("\n");
            sb.Append("  BundleIdentifier: ").Append(BundleIdentifier).Append("\n");
            sb.Append("  TeamIdentifier: ").Append(TeamIdentifier).Append("\n");
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
            return this.Equals(input as AppleMappingRequest);
        }

        /// <summary>
        /// Returns true if AppleMappingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AppleMappingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppleMappingRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceConnectionId == input.ServiceConnectionId ||
                    (this.ServiceConnectionId != null &&
                    this.ServiceConnectionId.Equals(input.ServiceConnectionId))
                ) && 
                (
                    this.AppleId == input.AppleId ||
                    (this.AppleId != null &&
                    this.AppleId.Equals(input.AppleId))
                ) && 
                (
                    this.BundleIdentifier == input.BundleIdentifier ||
                    (this.BundleIdentifier != null &&
                    this.BundleIdentifier.Equals(input.BundleIdentifier))
                ) && 
                (
                    this.TeamIdentifier == input.TeamIdentifier ||
                    (this.TeamIdentifier != null &&
                    this.TeamIdentifier.Equals(input.TeamIdentifier))
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
                if (this.AppleId != null)
                    hashCode = hashCode * 59 + this.AppleId.GetHashCode();
                if (this.BundleIdentifier != null)
                    hashCode = hashCode * 59 + this.BundleIdentifier.GetHashCode();
                if (this.TeamIdentifier != null)
                    hashCode = hashCode * 59 + this.TeamIdentifier.GetHashCode();
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
