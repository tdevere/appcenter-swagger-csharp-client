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
    /// AppRepoPatchRequest
    /// </summary>
    [DataContract]
        public partial class AppRepoPatchRequest :  IEquatable<AppRepoPatchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppRepoPatchRequest" /> class.
        /// </summary>
        /// <param name="repoUrl">The absolute URL of the repository.</param>
        /// <param name="userId">The unique id (UUID) of the user.</param>
        /// <param name="externalUserId">The external user id from the provider.</param>
        /// <param name="serviceConnectionId">The id of the service connection stored in customer credential store.</param>
        public AppRepoPatchRequest(string repoUrl = default(string), Guid? userId = default(Guid?), string externalUserId = default(string), Guid? serviceConnectionId = default(Guid?))
        {
            this.RepoUrl = repoUrl;
            this.UserId = userId;
            this.ExternalUserId = externalUserId;
            this.ServiceConnectionId = serviceConnectionId;
        }
        
        /// <summary>
        /// The absolute URL of the repository
        /// </summary>
        /// <value>The absolute URL of the repository</value>
        [DataMember(Name="repo_url", EmitDefaultValue=false)]
        public string RepoUrl { get; set; }

        /// <summary>
        /// The unique id (UUID) of the user
        /// </summary>
        /// <value>The unique id (UUID) of the user</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// The external user id from the provider
        /// </summary>
        /// <value>The external user id from the provider</value>
        [DataMember(Name="external_user_id", EmitDefaultValue=false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// The id of the service connection stored in customer credential store
        /// </summary>
        /// <value>The id of the service connection stored in customer credential store</value>
        [DataMember(Name="service_connection_id", EmitDefaultValue=false)]
        public Guid? ServiceConnectionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppRepoPatchRequest {\n");
            sb.Append("  RepoUrl: ").Append(RepoUrl).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ExternalUserId: ").Append(ExternalUserId).Append("\n");
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
            return this.Equals(input as AppRepoPatchRequest);
        }

        /// <summary>
        /// Returns true if AppRepoPatchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRepoPatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRepoPatchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RepoUrl == input.RepoUrl ||
                    (this.RepoUrl != null &&
                    this.RepoUrl.Equals(input.RepoUrl))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.ExternalUserId == input.ExternalUserId ||
                    (this.ExternalUserId != null &&
                    this.ExternalUserId.Equals(input.ExternalUserId))
                ) && 
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
                if (this.RepoUrl != null)
                    hashCode = hashCode * 59 + this.RepoUrl.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.ExternalUserId != null)
                    hashCode = hashCode * 59 + this.ExternalUserId.GetHashCode();
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