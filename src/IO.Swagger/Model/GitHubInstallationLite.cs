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
    /// The GitHub Installation
    /// </summary>
    [DataContract]
        public partial class GitHubInstallationLite :  IEquatable<GitHubInstallationLite>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GitHubInstallationLite" /> class.
        /// </summary>
        /// <param name="id">GitHub Installation Id.</param>
        /// <param name="account">account.</param>
        /// <param name="appId">GitHub Installation App Id.</param>
        public GitHubInstallationLite(decimal? id = default(decimal?), GitHubInstallationLiteAccount account = default(GitHubInstallationLiteAccount), decimal? appId = default(decimal?))
        {
            this.Id = id;
            this.Account = account;
            this.AppId = appId;
        }
        
        /// <summary>
        /// GitHub Installation Id
        /// </summary>
        /// <value>GitHub Installation Id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public decimal? Id { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public GitHubInstallationLiteAccount Account { get; set; }

        /// <summary>
        /// GitHub Installation App Id
        /// </summary>
        /// <value>GitHub Installation App Id</value>
        [DataMember(Name="app_id", EmitDefaultValue=false)]
        public decimal? AppId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GitHubInstallationLite {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
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
            return this.Equals(input as GitHubInstallationLite);
        }

        /// <summary>
        /// Returns true if GitHubInstallationLite instances are equal
        /// </summary>
        /// <param name="input">Instance of GitHubInstallationLite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GitHubInstallationLite input)
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
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
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
