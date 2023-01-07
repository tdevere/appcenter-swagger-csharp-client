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
    /// DistributionGroupUserPostResponse
    /// </summary>
    [DataContract]
        public partial class DistributionGroupUserPostResponse :  IEquatable<DistributionGroupUserPostResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionGroupUserPostResponse" /> class.
        /// </summary>
        /// <param name="code">The code of the result.</param>
        /// <param name="invitePending">Whether the has accepted the invite. Available when an invite is pending, and the value will be \&quot;true\&quot;..</param>
        /// <param name="message">The message of the result.</param>
        /// <param name="status">The status code of the result (required).</param>
        /// <param name="userEmail">The email of the user.</param>
        public DistributionGroupUserPostResponse(string code = default(string), bool? invitePending = default(bool?), string message = default(string), int? status = default(int?), string userEmail = default(string))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for DistributionGroupUserPostResponse and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.Code = code;
            this.InvitePending = invitePending;
            this.Message = message;
            this.UserEmail = userEmail;
        }
        
        /// <summary>
        /// The code of the result
        /// </summary>
        /// <value>The code of the result</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Whether the has accepted the invite. Available when an invite is pending, and the value will be \&quot;true\&quot;.
        /// </summary>
        /// <value>Whether the has accepted the invite. Available when an invite is pending, and the value will be \&quot;true\&quot;.</value>
        [DataMember(Name="invite_pending", EmitDefaultValue=false)]
        public bool? InvitePending { get; set; }

        /// <summary>
        /// The message of the result
        /// </summary>
        /// <value>The message of the result</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// The status code of the result
        /// </summary>
        /// <value>The status code of the result</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The email of the user
        /// </summary>
        /// <value>The email of the user</value>
        [DataMember(Name="user_email", EmitDefaultValue=false)]
        public string UserEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DistributionGroupUserPostResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  InvitePending: ").Append(InvitePending).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
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
            return this.Equals(input as DistributionGroupUserPostResponse);
        }

        /// <summary>
        /// Returns true if DistributionGroupUserPostResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DistributionGroupUserPostResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistributionGroupUserPostResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.InvitePending == input.InvitePending ||
                    (this.InvitePending != null &&
                    this.InvitePending.Equals(input.InvitePending))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UserEmail == input.UserEmail ||
                    (this.UserEmail != null &&
                    this.UserEmail.Equals(input.UserEmail))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.InvitePending != null)
                    hashCode = hashCode * 59 + this.InvitePending.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UserEmail != null)
                    hashCode = hashCode * 59 + this.UserEmail.GetHashCode();
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
