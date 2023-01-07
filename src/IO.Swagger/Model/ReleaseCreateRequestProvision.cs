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
    /// An object containing information about an iOS provisioning profile.
    /// </summary>
    [DataContract]
        public partial class ReleaseCreateRequestProvision :  IEquatable<ReleaseCreateRequestProvision>, IValidatableObject
    {
        /// <summary>
        /// Defines ProfileType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ProfileTypeEnum
        {
            /// <summary>
            /// Enum Adhoc for value: adhoc
            /// </summary>
            [EnumMember(Value = "adhoc")]
            Adhoc = 1,
            /// <summary>
            /// Enum Enterprise for value: enterprise
            /// </summary>
            [EnumMember(Value = "enterprise")]
            Enterprise = 2,
            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 3        }
        /// <summary>
        /// Gets or Sets ProfileType
        /// </summary>
        [DataMember(Name="profile_type", EmitDefaultValue=false)]
        public ProfileTypeEnum ProfileType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseCreateRequestProvision" /> class.
        /// </summary>
        /// <param name="name">The name of the provisioning profile. (required).</param>
        /// <param name="applicationIdentifier">The application identifier. (required).</param>
        /// <param name="teamIdentifier">The team identifier. (required).</param>
        /// <param name="profileType">profileType (required).</param>
        /// <param name="expiredAt">The profile&#x27;s expiration date in RFC 3339 format, i.e. 2017-07-21T17:32:28Z (required).</param>
        /// <param name="udids">udids.</param>
        public ReleaseCreateRequestProvision(string name = default(string), string applicationIdentifier = default(string), string teamIdentifier = default(string), ProfileTypeEnum profileType = default(ProfileTypeEnum), string expiredAt = default(string), List<string> udids = default(List<string>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ReleaseCreateRequestProvision and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "applicationIdentifier" is required (not null)
            if (applicationIdentifier == null)
            {
                throw new InvalidDataException("applicationIdentifier is a required property for ReleaseCreateRequestProvision and cannot be null");
            }
            else
            {
                this.ApplicationIdentifier = applicationIdentifier;
            }
            // to ensure "teamIdentifier" is required (not null)
            if (teamIdentifier == null)
            {
                throw new InvalidDataException("teamIdentifier is a required property for ReleaseCreateRequestProvision and cannot be null");
            }
            else
            {
                this.TeamIdentifier = teamIdentifier;
            }
            // to ensure "profileType" is required (not null)
            if (profileType == null)
            {
                throw new InvalidDataException("profileType is a required property for ReleaseCreateRequestProvision and cannot be null");
            }
            else
            {
                this.ProfileType = profileType;
            }
            // to ensure "expiredAt" is required (not null)
            if (expiredAt == null)
            {
                throw new InvalidDataException("expiredAt is a required property for ReleaseCreateRequestProvision and cannot be null");
            }
            else
            {
                this.ExpiredAt = expiredAt;
            }
            this.Udids = udids;
        }
        
        /// <summary>
        /// The name of the provisioning profile.
        /// </summary>
        /// <value>The name of the provisioning profile.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The application identifier.
        /// </summary>
        /// <value>The application identifier.</value>
        [DataMember(Name="application_identifier", EmitDefaultValue=false)]
        public string ApplicationIdentifier { get; set; }

        /// <summary>
        /// The team identifier.
        /// </summary>
        /// <value>The team identifier.</value>
        [DataMember(Name="team_identifier", EmitDefaultValue=false)]
        public string TeamIdentifier { get; set; }


        /// <summary>
        /// The profile&#x27;s expiration date in RFC 3339 format, i.e. 2017-07-21T17:32:28Z
        /// </summary>
        /// <value>The profile&#x27;s expiration date in RFC 3339 format, i.e. 2017-07-21T17:32:28Z</value>
        [DataMember(Name="expired_at", EmitDefaultValue=false)]
        public string ExpiredAt { get; set; }

        /// <summary>
        /// Gets or Sets Udids
        /// </summary>
        [DataMember(Name="udids", EmitDefaultValue=false)]
        public List<string> Udids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReleaseCreateRequestProvision {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ApplicationIdentifier: ").Append(ApplicationIdentifier).Append("\n");
            sb.Append("  TeamIdentifier: ").Append(TeamIdentifier).Append("\n");
            sb.Append("  ProfileType: ").Append(ProfileType).Append("\n");
            sb.Append("  ExpiredAt: ").Append(ExpiredAt).Append("\n");
            sb.Append("  Udids: ").Append(Udids).Append("\n");
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
            return this.Equals(input as ReleaseCreateRequestProvision);
        }

        /// <summary>
        /// Returns true if ReleaseCreateRequestProvision instances are equal
        /// </summary>
        /// <param name="input">Instance of ReleaseCreateRequestProvision to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReleaseCreateRequestProvision input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ApplicationIdentifier == input.ApplicationIdentifier ||
                    (this.ApplicationIdentifier != null &&
                    this.ApplicationIdentifier.Equals(input.ApplicationIdentifier))
                ) && 
                (
                    this.TeamIdentifier == input.TeamIdentifier ||
                    (this.TeamIdentifier != null &&
                    this.TeamIdentifier.Equals(input.TeamIdentifier))
                ) && 
                (
                    this.ProfileType == input.ProfileType ||
                    (this.ProfileType != null &&
                    this.ProfileType.Equals(input.ProfileType))
                ) && 
                (
                    this.ExpiredAt == input.ExpiredAt ||
                    (this.ExpiredAt != null &&
                    this.ExpiredAt.Equals(input.ExpiredAt))
                ) && 
                (
                    this.Udids == input.Udids ||
                    this.Udids != null &&
                    input.Udids != null &&
                    this.Udids.SequenceEqual(input.Udids)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ApplicationIdentifier != null)
                    hashCode = hashCode * 59 + this.ApplicationIdentifier.GetHashCode();
                if (this.TeamIdentifier != null)
                    hashCode = hashCode * 59 + this.TeamIdentifier.GetHashCode();
                if (this.ProfileType != null)
                    hashCode = hashCode * 59 + this.ProfileType.GetHashCode();
                if (this.ExpiredAt != null)
                    hashCode = hashCode * 59 + this.ExpiredAt.GetHashCode();
                if (this.Udids != null)
                    hashCode = hashCode * 59 + this.Udids.GetHashCode();
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