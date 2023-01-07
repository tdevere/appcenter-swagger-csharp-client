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
    /// ApiTokensPrivateCreateRequest
    /// </summary>
    [DataContract]
        public partial class ApiTokensPrivateCreateRequest :  IEquatable<ApiTokensPrivateCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// The principal type assigned to the API token
        /// </summary>
        /// <value>The principal type assigned to the API token</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PrincipalTypeEnum
        {
            /// <summary>
            /// Enum App for value: app
            /// </summary>
            [EnumMember(Value = "app")]
            App = 1,
            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 2        }
        /// <summary>
        /// The principal type assigned to the API token
        /// </summary>
        /// <value>The principal type assigned to the API token</value>
        [DataMember(Name="principal_type", EmitDefaultValue=false)]
        public PrincipalTypeEnum PrincipalType { get; set; }
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
        /// The scope for this token (default \&quot;all\&quot;).
        /// </summary>
        /// <value>The scope for this token (default \&quot;all\&quot;).</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public List<ScopeEnum> Scope { get; set; }
        /// <summary>
        /// The token&#x27;s type (default \&quot;public\&quot;)   public: managed by the user   in_app_update: special token for in-app update scenario   buid: dedicated for CI usage for now   session: for CLI session management   tester_app: used for tester mobile app
        /// </summary>
        /// <value>The token&#x27;s type (default \&quot;public\&quot;)   public: managed by the user   in_app_update: special token for in-app update scenario   buid: dedicated for CI usage for now   session: for CLI session management   tester_app: used for tester mobile app</value>
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
        /// The token&#x27;s type (default \&quot;public\&quot;)   public: managed by the user   in_app_update: special token for in-app update scenario   buid: dedicated for CI usage for now   session: for CLI session management   tester_app: used for tester mobile app
        /// </summary>
        /// <value>The token&#x27;s type (default \&quot;public\&quot;)   public: managed by the user   in_app_update: special token for in-app update scenario   buid: dedicated for CI usage for now   session: for CLI session management   tester_app: used for tester mobile app</value>
        [DataMember(Name="token_type", EmitDefaultValue=false)]
        public TokenTypeEnum? TokenType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTokensPrivateCreateRequest" /> class.
        /// </summary>
        /// <param name="principalId">The principal ID assigned to the API token (required).</param>
        /// <param name="principalType">The principal type assigned to the API token (required).</param>
        /// <param name="description">The description of the token.</param>
        /// <param name="scope">The scope for this token (default \&quot;all\&quot;)..</param>
        /// <param name="tokenType">The token&#x27;s type (default \&quot;public\&quot;)   public: managed by the user   in_app_update: special token for in-app update scenario   buid: dedicated for CI usage for now   session: for CLI session management   tester_app: used for tester mobile app.</param>
        public ApiTokensPrivateCreateRequest(Guid? principalId = default(Guid?), PrincipalTypeEnum principalType = default(PrincipalTypeEnum), string description = default(string), List<ScopeEnum> scope = default(List<ScopeEnum>), TokenTypeEnum? tokenType = default(TokenTypeEnum?))
        {
            // to ensure "principalId" is required (not null)
            if (principalId == null)
            {
                throw new InvalidDataException("principalId is a required property for ApiTokensPrivateCreateRequest and cannot be null");
            }
            else
            {
                this.PrincipalId = principalId;
            }
            // to ensure "principalType" is required (not null)
            if (principalType == null)
            {
                throw new InvalidDataException("principalType is a required property for ApiTokensPrivateCreateRequest and cannot be null");
            }
            else
            {
                this.PrincipalType = principalType;
            }
            this.Description = description;
            this.Scope = scope;
            this.TokenType = tokenType;
        }
        
        /// <summary>
        /// The principal ID assigned to the API token
        /// </summary>
        /// <value>The principal ID assigned to the API token</value>
        [DataMember(Name="principal_id", EmitDefaultValue=false)]
        public Guid? PrincipalId { get; set; }


        /// <summary>
        /// The description of the token
        /// </summary>
        /// <value>The description of the token</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiTokensPrivateCreateRequest {\n");
            sb.Append("  PrincipalId: ").Append(PrincipalId).Append("\n");
            sb.Append("  PrincipalType: ").Append(PrincipalType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
            return this.Equals(input as ApiTokensPrivateCreateRequest);
        }

        /// <summary>
        /// Returns true if ApiTokensPrivateCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiTokensPrivateCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiTokensPrivateCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrincipalId == input.PrincipalId ||
                    (this.PrincipalId != null &&
                    this.PrincipalId.Equals(input.PrincipalId))
                ) && 
                (
                    this.PrincipalType == input.PrincipalType ||
                    (this.PrincipalType != null &&
                    this.PrincipalType.Equals(input.PrincipalType))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Scope == input.Scope ||
                    this.Scope != null &&
                    input.Scope != null &&
                    this.Scope.SequenceEqual(input.Scope)
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
                if (this.PrincipalId != null)
                    hashCode = hashCode * 59 + this.PrincipalId.GetHashCode();
                if (this.PrincipalType != null)
                    hashCode = hashCode * 59 + this.PrincipalType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
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
