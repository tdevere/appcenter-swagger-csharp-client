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
    /// ApiTokensPostRequest
    /// </summary>
    [DataContract]
        public partial class ApiTokensPostRequest :  IEquatable<ApiTokensPostRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines Scope
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ScopeEnum
        {
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 1,
            /// <summary>
            /// Enum Inappupdate for value: in_app_update
            /// </summary>
            [EnumMember(Value = "in_app_update")]
            Inappupdate = 2,
            /// <summary>
            /// Enum Viewer for value: viewer
            /// </summary>
            [EnumMember(Value = "viewer")]
            Viewer = 3        }
        /// <summary>
        /// The scope for this token. An array of supported roles.
        /// </summary>
        /// <value>The scope for this token. An array of supported roles.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public List<ScopeEnum> Scope { get; set; }
        /// <summary>
        /// The token&#x27;s type. public:managed by the user; in_app_update:special token for in-app update scenario; buid:dedicated for CI usage for now; session:for CLI session management; tester_app: used for tester mobile app; default is \&quot;public\&quot;.&#x27;
        /// </summary>
        /// <value>The token&#x27;s type. public:managed by the user; in_app_update:special token for in-app update scenario; buid:dedicated for CI usage for now; session:for CLI session management; tester_app: used for tester mobile app; default is \&quot;public\&quot;.&#x27;</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TokenTypeEnum
        {
            /// <summary>
            /// Enum Public for value: public
            /// </summary>
            [EnumMember(Value = "public")]
            Public = 1,
            /// <summary>
            /// Enum Inappupdate for value: in_app_update
            /// </summary>
            [EnumMember(Value = "in_app_update")]
            Inappupdate = 2,
            /// <summary>
            /// Enum Build for value: build
            /// </summary>
            [EnumMember(Value = "build")]
            Build = 3,
            /// <summary>
            /// Enum Session for value: session
            /// </summary>
            [EnumMember(Value = "session")]
            Session = 4,
            /// <summary>
            /// Enum Testerapp for value: tester_app
            /// </summary>
            [EnumMember(Value = "tester_app")]
            Testerapp = 5        }
        /// <summary>
        /// The token&#x27;s type. public:managed by the user; in_app_update:special token for in-app update scenario; buid:dedicated for CI usage for now; session:for CLI session management; tester_app: used for tester mobile app; default is \&quot;public\&quot;.&#x27;
        /// </summary>
        /// <value>The token&#x27;s type. public:managed by the user; in_app_update:special token for in-app update scenario; buid:dedicated for CI usage for now; session:for CLI session management; tester_app: used for tester mobile app; default is \&quot;public\&quot;.&#x27;</value>
        [DataMember(Name="token_type", EmitDefaultValue=false)]
        public TokenTypeEnum? TokenType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTokensPostRequest" /> class.
        /// </summary>
        /// <param name="description">The description of the token.</param>
        /// <param name="encryptedToken">An encrypted value of the token..</param>
        /// <param name="scope">The scope for this token. An array of supported roles..</param>
        /// <param name="tokenHash">The hashed value of api token.</param>
        /// <param name="tokenType">The token&#x27;s type. public:managed by the user; in_app_update:special token for in-app update scenario; buid:dedicated for CI usage for now; session:for CLI session management; tester_app: used for tester mobile app; default is \&quot;public\&quot;.&#x27;.</param>
        public ApiTokensPostRequest(string description = default(string), string encryptedToken = default(string), List<ScopeEnum> scope = default(List<ScopeEnum>), string tokenHash = default(string), TokenTypeEnum? tokenType = default(TokenTypeEnum?))
        {
            this.Description = description;
            this.EncryptedToken = encryptedToken;
            this.Scope = scope;
            this.TokenHash = tokenHash;
            this.TokenType = tokenType;
        }
        
        /// <summary>
        /// The description of the token
        /// </summary>
        /// <value>The description of the token</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// An encrypted value of the token.
        /// </summary>
        /// <value>An encrypted value of the token.</value>
        [DataMember(Name="encrypted_token", EmitDefaultValue=false)]
        public string EncryptedToken { get; set; }


        /// <summary>
        /// The hashed value of api token
        /// </summary>
        /// <value>The hashed value of api token</value>
        [DataMember(Name="token_hash", EmitDefaultValue=false)]
        public string TokenHash { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiTokensPostRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EncryptedToken: ").Append(EncryptedToken).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  TokenHash: ").Append(TokenHash).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
            return this.Equals(input as ApiTokensPostRequest);
        }

        /// <summary>
        /// Returns true if ApiTokensPostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiTokensPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiTokensPostRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EncryptedToken == input.EncryptedToken ||
                    (this.EncryptedToken != null &&
                    this.EncryptedToken.Equals(input.EncryptedToken))
                ) && 
                (
                    this.Scope == input.Scope ||
                    this.Scope != null &&
                    input.Scope != null &&
                    this.Scope.SequenceEqual(input.Scope)
                ) && 
                (
                    this.TokenHash == input.TokenHash ||
                    (this.TokenHash != null &&
                    this.TokenHash.Equals(input.TokenHash))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EncryptedToken != null)
                    hashCode = hashCode * 59 + this.EncryptedToken.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.TokenHash != null)
                    hashCode = hashCode * 59 + this.TokenHash.GetHashCode();
                if (this.TokenType != null)
                    hashCode = hashCode * 59 + this.TokenType.GetHashCode();
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
