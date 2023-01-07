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
    /// Apple credentials needed to log into the Apple Developer Portal
    /// </summary>
    [DataContract]
        public partial class AppleLoginRequest :  IEquatable<AppleLoginRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppleLoginRequest" /> class.
        /// </summary>
        /// <param name="username">The username for the Apple Developer account. (required).</param>
        /// <param name="password">The password for the Apple Developer account. (required).</param>
        /// <param name="teamIdentifier">Identifier of the team to use when logged in..</param>
        /// <param name="cookie">The 30-day session cookie for multi-factor authentication backed accounts..</param>
        public AppleLoginRequest(string username = default(string), string password = default(string), string teamIdentifier = default(string), string cookie = default(string))
        {
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for AppleLoginRequest and cannot be null");
            }
            else
            {
                this.Username = username;
            }
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for AppleLoginRequest and cannot be null");
            }
            else
            {
                this.Password = password;
            }
            this.TeamIdentifier = teamIdentifier;
            this.Cookie = cookie;
        }
        
        /// <summary>
        /// The username for the Apple Developer account.
        /// </summary>
        /// <value>The username for the Apple Developer account.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// The password for the Apple Developer account.
        /// </summary>
        /// <value>The password for the Apple Developer account.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Identifier of the team to use when logged in.
        /// </summary>
        /// <value>Identifier of the team to use when logged in.</value>
        [DataMember(Name="team_identifier", EmitDefaultValue=false)]
        public string TeamIdentifier { get; set; }

        /// <summary>
        /// The 30-day session cookie for multi-factor authentication backed accounts.
        /// </summary>
        /// <value>The 30-day session cookie for multi-factor authentication backed accounts.</value>
        [DataMember(Name="cookie", EmitDefaultValue=false)]
        public string Cookie { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppleLoginRequest {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  TeamIdentifier: ").Append(TeamIdentifier).Append("\n");
            sb.Append("  Cookie: ").Append(Cookie).Append("\n");
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
            return this.Equals(input as AppleLoginRequest);
        }

        /// <summary>
        /// Returns true if AppleLoginRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AppleLoginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppleLoginRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.TeamIdentifier == input.TeamIdentifier ||
                    (this.TeamIdentifier != null &&
                    this.TeamIdentifier.Equals(input.TeamIdentifier))
                ) && 
                (
                    this.Cookie == input.Cookie ||
                    (this.Cookie != null &&
                    this.Cookie.Equals(input.Cookie))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.TeamIdentifier != null)
                    hashCode = hashCode * 59 + this.TeamIdentifier.GetHashCode();
                if (this.Cookie != null)
                    hashCode = hashCode * 59 + this.Cookie.GetHashCode();
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
