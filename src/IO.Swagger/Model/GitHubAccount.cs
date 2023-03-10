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
    /// GitHub account information
    /// </summary>
    [DataContract]
        public partial class GitHubAccount :  IEquatable<GitHubAccount>, IValidatableObject
    {
        /// <summary>
        /// Type of GitHub account
        /// </summary>
        /// <value>Type of GitHub account</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum AccountTypeEnum
        {
            /// <summary>
            /// Enum User for value: User
            /// </summary>
            [EnumMember(Value = "User")]
            User = 1,
            /// <summary>
            /// Enum Organization for value: Organization
            /// </summary>
            [EnumMember(Value = "Organization")]
            Organization = 2        }
        /// <summary>
        /// Type of GitHub account
        /// </summary>
        /// <value>Type of GitHub account</value>
        [DataMember(Name="accountType", EmitDefaultValue=false)]
        public AccountTypeEnum? AccountType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GitHubAccount" /> class.
        /// </summary>
        /// <param name="id">Id of GitHub account.</param>
        /// <param name="accountType">Type of GitHub account.</param>
        public GitHubAccount(int? id = default(int?), AccountTypeEnum? accountType = default(AccountTypeEnum?))
        {
            this.Id = id;
            this.AccountType = accountType;
        }
        
        /// <summary>
        /// Id of GitHub account
        /// </summary>
        /// <value>Id of GitHub account</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GitHubAccount {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
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
            return this.Equals(input as GitHubAccount);
        }

        /// <summary>
        /// Returns true if GitHubAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of GitHubAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GitHubAccount input)
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
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
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
                if (this.AccountType != null)
                    hashCode = hashCode * 59 + this.AccountType.GetHashCode();
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
