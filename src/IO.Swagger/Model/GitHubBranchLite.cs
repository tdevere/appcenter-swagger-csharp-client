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
    /// The lite version of GitHub branch
    /// </summary>
    [DataContract]
        public partial class GitHubBranchLite :  IEquatable<GitHubBranchLite>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GitHubBranchLite" /> class.
        /// </summary>
        /// <param name="_ref">The repository name.</param>
        /// <param name="sha">The discription of repository.</param>
        /// <param name="repo">repo.</param>
        public GitHubBranchLite(string _ref = default(string), string sha = default(string), GitHubPullRequestLiteHeadRepo repo = default(GitHubPullRequestLiteHeadRepo))
        {
            this._Ref = _ref;
            this.Sha = sha;
            this.Repo = repo;
        }
        
        /// <summary>
        /// The repository name
        /// </summary>
        /// <value>The repository name</value>
        [DataMember(Name="ref", EmitDefaultValue=false)]
        public string _Ref { get; set; }

        /// <summary>
        /// The discription of repository
        /// </summary>
        /// <value>The discription of repository</value>
        [DataMember(Name="sha", EmitDefaultValue=false)]
        public string Sha { get; set; }

        /// <summary>
        /// Gets or Sets Repo
        /// </summary>
        [DataMember(Name="repo", EmitDefaultValue=false)]
        public GitHubPullRequestLiteHeadRepo Repo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GitHubBranchLite {\n");
            sb.Append("  _Ref: ").Append(_Ref).Append("\n");
            sb.Append("  Sha: ").Append(Sha).Append("\n");
            sb.Append("  Repo: ").Append(Repo).Append("\n");
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
            return this.Equals(input as GitHubBranchLite);
        }

        /// <summary>
        /// Returns true if GitHubBranchLite instances are equal
        /// </summary>
        /// <param name="input">Instance of GitHubBranchLite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GitHubBranchLite input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Ref == input._Ref ||
                    (this._Ref != null &&
                    this._Ref.Equals(input._Ref))
                ) && 
                (
                    this.Sha == input.Sha ||
                    (this.Sha != null &&
                    this.Sha.Equals(input.Sha))
                ) && 
                (
                    this.Repo == input.Repo ||
                    (this.Repo != null &&
                    this.Repo.Equals(input.Repo))
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
                if (this._Ref != null)
                    hashCode = hashCode * 59 + this._Ref.GetHashCode();
                if (this.Sha != null)
                    hashCode = hashCode * 59 + this.Sha.GetHashCode();
                if (this.Repo != null)
                    hashCode = hashCode * 59 + this.Repo.GetHashCode();
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
