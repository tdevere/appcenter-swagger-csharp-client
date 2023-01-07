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
    /// URL that can be used to check the status of the update devices operation and the updated profiles.
    /// </summary>
    [DataContract]
        public partial class ResignAttemptResponse :  IEquatable<ResignAttemptResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResignAttemptResponse" /> class.
        /// </summary>
        /// <param name="status">The status of the resigning operation. (required).</param>
        /// <param name="userId">ID of the user performing the resign operaiton. (required).</param>
        /// <param name="appId">App ID that the resign operation is being performed against. (required).</param>
        /// <param name="originalReleaseId">ID of the release which is being resigned. (required).</param>
        /// <param name="resignId">ID of the resign operation. (required).</param>
        /// <param name="contextId">Context ID for the resigning operation. (required).</param>
        /// <param name="startTime">The time that the resign operation was started. (required).</param>
        /// <param name="destinations">List of destinations that the resign operation is being performed against..</param>
        /// <param name="errorCode">Error code associated with the exception..</param>
        /// <param name="errorMessage">Error message associated with the exception..</param>
        public ResignAttemptResponse(string status = default(string), string userId = default(string), string appId = default(string), decimal? originalReleaseId = default(decimal?), string resignId = default(string), string contextId = default(string), decimal? startTime = default(decimal?), List<Object> destinations = default(List<Object>), string errorCode = default(string), string errorMessage = default(string))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for ResignAttemptResponse and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for ResignAttemptResponse and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }
            // to ensure "appId" is required (not null)
            if (appId == null)
            {
                throw new InvalidDataException("appId is a required property for ResignAttemptResponse and cannot be null");
            }
            else
            {
                this.AppId = appId;
            }
            // to ensure "originalReleaseId" is required (not null)
            if (originalReleaseId == null)
            {
                throw new InvalidDataException("originalReleaseId is a required property for ResignAttemptResponse and cannot be null");
            }
            else
            {
                this.OriginalReleaseId = originalReleaseId;
            }
            // to ensure "resignId" is required (not null)
            if (resignId == null)
            {
                throw new InvalidDataException("resignId is a required property for ResignAttemptResponse and cannot be null");
            }
            else
            {
                this.ResignId = resignId;
            }
            // to ensure "contextId" is required (not null)
            if (contextId == null)
            {
                throw new InvalidDataException("contextId is a required property for ResignAttemptResponse and cannot be null");
            }
            else
            {
                this.ContextId = contextId;
            }
            // to ensure "startTime" is required (not null)
            if (startTime == null)
            {
                throw new InvalidDataException("startTime is a required property for ResignAttemptResponse and cannot be null");
            }
            else
            {
                this.StartTime = startTime;
            }
            this.Destinations = destinations;
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
        }
        
        /// <summary>
        /// The status of the resigning operation.
        /// </summary>
        /// <value>The status of the resigning operation.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// ID of the user performing the resign operaiton.
        /// </summary>
        /// <value>ID of the user performing the resign operaiton.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// App ID that the resign operation is being performed against.
        /// </summary>
        /// <value>App ID that the resign operation is being performed against.</value>
        [DataMember(Name="appId", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// ID of the release which is being resigned.
        /// </summary>
        /// <value>ID of the release which is being resigned.</value>
        [DataMember(Name="originalReleaseId", EmitDefaultValue=false)]
        public decimal? OriginalReleaseId { get; set; }

        /// <summary>
        /// ID of the resign operation.
        /// </summary>
        /// <value>ID of the resign operation.</value>
        [DataMember(Name="resignId", EmitDefaultValue=false)]
        public string ResignId { get; set; }

        /// <summary>
        /// Context ID for the resigning operation.
        /// </summary>
        /// <value>Context ID for the resigning operation.</value>
        [DataMember(Name="contextId", EmitDefaultValue=false)]
        public string ContextId { get; set; }

        /// <summary>
        /// The time that the resign operation was started.
        /// </summary>
        /// <value>The time that the resign operation was started.</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public decimal? StartTime { get; set; }

        /// <summary>
        /// List of destinations that the resign operation is being performed against.
        /// </summary>
        /// <value>List of destinations that the resign operation is being performed against.</value>
        [DataMember(Name="destinations", EmitDefaultValue=false)]
        public List<Object> Destinations { get; set; }

        /// <summary>
        /// Error code associated with the exception.
        /// </summary>
        /// <value>Error code associated with the exception.</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Error message associated with the exception.
        /// </summary>
        /// <value>Error message associated with the exception.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResignAttemptResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  OriginalReleaseId: ").Append(OriginalReleaseId).Append("\n");
            sb.Append("  ResignId: ").Append(ResignId).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Destinations: ").Append(Destinations).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            return this.Equals(input as ResignAttemptResponse);
        }

        /// <summary>
        /// Returns true if ResignAttemptResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ResignAttemptResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResignAttemptResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.OriginalReleaseId == input.OriginalReleaseId ||
                    (this.OriginalReleaseId != null &&
                    this.OriginalReleaseId.Equals(input.OriginalReleaseId))
                ) && 
                (
                    this.ResignId == input.ResignId ||
                    (this.ResignId != null &&
                    this.ResignId.Equals(input.ResignId))
                ) && 
                (
                    this.ContextId == input.ContextId ||
                    (this.ContextId != null &&
                    this.ContextId.Equals(input.ContextId))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Destinations == input.Destinations ||
                    this.Destinations != null &&
                    input.Destinations != null &&
                    this.Destinations.SequenceEqual(input.Destinations)
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.OriginalReleaseId != null)
                    hashCode = hashCode * 59 + this.OriginalReleaseId.GetHashCode();
                if (this.ResignId != null)
                    hashCode = hashCode * 59 + this.ResignId.GetHashCode();
                if (this.ContextId != null)
                    hashCode = hashCode * 59 + this.ContextId.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Destinations != null)
                    hashCode = hashCode * 59 + this.Destinations.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
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