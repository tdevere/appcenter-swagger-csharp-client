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
    /// DataSubjectRightOperation
    /// </summary>
    [DataContract]
        public partial class DataSubjectRightOperation :  IEquatable<DataSubjectRightOperation>, IValidatableObject
    {
        /// <summary>
        /// Request type
        /// </summary>
        /// <value>Request type</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RequestTypeEnum
        {
            /// <summary>
            /// Enum Unsupported for value: Unsupported
            /// </summary>
            [EnumMember(Value = "Unsupported")]
            Unsupported = 1,
            /// <summary>
            /// Enum Delete for value: Delete
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete = 2,
            /// <summary>
            /// Enum Purge for value: Purge
            /// </summary>
            [EnumMember(Value = "Purge")]
            Purge = 3,
            /// <summary>
            /// Enum UndoDelete for value: UndoDelete
            /// </summary>
            [EnumMember(Value = "UndoDelete")]
            UndoDelete = 4,
            /// <summary>
            /// Enum Scheduled for value: Scheduled
            /// </summary>
            [EnumMember(Value = "Scheduled")]
            Scheduled = 5,
            /// <summary>
            /// Enum AppDelete for value: AppDelete
            /// </summary>
            [EnumMember(Value = "AppDelete")]
            AppDelete = 6,
            /// <summary>
            /// Enum AppPurge for value: AppPurge
            /// </summary>
            [EnumMember(Value = "AppPurge")]
            AppPurge = 7,
            /// <summary>
            /// Enum AppUndoDelete for value: AppUndoDelete
            /// </summary>
            [EnumMember(Value = "AppUndoDelete")]
            AppUndoDelete = 8,
            /// <summary>
            /// Enum Export for value: Export
            /// </summary>
            [EnumMember(Value = "Export")]
            Export = 9,
            /// <summary>
            /// Enum CustomerAccountDelete for value: CustomerAccountDelete
            /// </summary>
            [EnumMember(Value = "CustomerAccountDelete")]
            CustomerAccountDelete = 10,
            /// <summary>
            /// Enum CustomerAccountExport for value: CustomerAccountExport
            /// </summary>
            [EnumMember(Value = "CustomerAccountExport")]
            CustomerAccountExport = 11,
            /// <summary>
            /// Enum CustomerUserDelete for value: CustomerUserDelete
            /// </summary>
            [EnumMember(Value = "CustomerUserDelete")]
            CustomerUserDelete = 12,
            /// <summary>
            /// Enum CustomerUserExport for value: CustomerUserExport
            /// </summary>
            [EnumMember(Value = "CustomerUserExport")]
            CustomerUserExport = 13        }
        /// <summary>
        /// Request type
        /// </summary>
        /// <value>Request type</value>
        [DataMember(Name="requestType", EmitDefaultValue=false)]
        public RequestTypeEnum RequestType { get; set; }
        /// <summary>
        /// Operation status
        /// </summary>
        /// <value>Operation status</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            /// <summary>
            /// Enum Created for value: Created
            /// </summary>
            [EnumMember(Value = "Created")]
            Created = 2,
            /// <summary>
            /// Enum Queued for value: Queued
            /// </summary>
            [EnumMember(Value = "Queued")]
            Queued = 3,
            /// <summary>
            /// Enum InProgress for value: InProgress
            /// </summary>
            [EnumMember(Value = "InProgress")]
            InProgress = 4,
            /// <summary>
            /// Enum Completed for value: Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed = 5,
            /// <summary>
            /// Enum Failed for value: Failed
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed = 6        }
        /// <summary>
        /// Operation status
        /// </summary>
        /// <value>Operation status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSubjectRightOperation" /> class.
        /// </summary>
        /// <param name="requestId">Unique request identifier (required).</param>
        /// <param name="operationId">Unique operation identifier (required).</param>
        /// <param name="requestType">Request type (required).</param>
        /// <param name="status">Operation status (required).</param>
        /// <param name="participant">Participant to execute the response (required).</param>
        /// <param name="context">JSON object decribing what to delete (TODO - make separate definition?) (required).</param>
        /// <param name="appId">Application identifier if applicable.</param>
        /// <param name="participantData">String field to be used by participant for any intermediate statuses or data they need to save.</param>
        public DataSubjectRightOperation(Guid? requestId = default(Guid?), Guid? operationId = default(Guid?), RequestTypeEnum requestType = default(RequestTypeEnum), StatusEnum status = default(StatusEnum), string participant = default(string), string context = default(string), string appId = default(string), string participantData = default(string))
        {
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new InvalidDataException("requestId is a required property for DataSubjectRightOperation and cannot be null");
            }
            else
            {
                this.RequestId = requestId;
            }
            // to ensure "operationId" is required (not null)
            if (operationId == null)
            {
                throw new InvalidDataException("operationId is a required property for DataSubjectRightOperation and cannot be null");
            }
            else
            {
                this.OperationId = operationId;
            }
            // to ensure "requestType" is required (not null)
            if (requestType == null)
            {
                throw new InvalidDataException("requestType is a required property for DataSubjectRightOperation and cannot be null");
            }
            else
            {
                this.RequestType = requestType;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for DataSubjectRightOperation and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "participant" is required (not null)
            if (participant == null)
            {
                throw new InvalidDataException("participant is a required property for DataSubjectRightOperation and cannot be null");
            }
            else
            {
                this.Participant = participant;
            }
            // to ensure "context" is required (not null)
            if (context == null)
            {
                throw new InvalidDataException("context is a required property for DataSubjectRightOperation and cannot be null");
            }
            else
            {
                this.Context = context;
            }
            this.AppId = appId;
            this.ParticipantData = participantData;
        }
        
        /// <summary>
        /// Unique request identifier
        /// </summary>
        /// <value>Unique request identifier</value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public Guid? RequestId { get; set; }

        /// <summary>
        /// Unique operation identifier
        /// </summary>
        /// <value>Unique operation identifier</value>
        [DataMember(Name="operationId", EmitDefaultValue=false)]
        public Guid? OperationId { get; set; }



        /// <summary>
        /// Participant to execute the response
        /// </summary>
        /// <value>Participant to execute the response</value>
        [DataMember(Name="participant", EmitDefaultValue=false)]
        public string Participant { get; set; }

        /// <summary>
        /// JSON object decribing what to delete (TODO - make separate definition?)
        /// </summary>
        /// <value>JSON object decribing what to delete (TODO - make separate definition?)</value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public string Context { get; set; }

        /// <summary>
        /// Application identifier if applicable
        /// </summary>
        /// <value>Application identifier if applicable</value>
        [DataMember(Name="appId", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// String field to be used by participant for any intermediate statuses or data they need to save
        /// </summary>
        /// <value>String field to be used by participant for any intermediate statuses or data they need to save</value>
        [DataMember(Name="participantData", EmitDefaultValue=false)]
        public string ParticipantData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataSubjectRightOperation {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Participant: ").Append(Participant).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  ParticipantData: ").Append(ParticipantData).Append("\n");
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
            return this.Equals(input as DataSubjectRightOperation);
        }

        /// <summary>
        /// Returns true if DataSubjectRightOperation instances are equal
        /// </summary>
        /// <param name="input">Instance of DataSubjectRightOperation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSubjectRightOperation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.OperationId == input.OperationId ||
                    (this.OperationId != null &&
                    this.OperationId.Equals(input.OperationId))
                ) && 
                (
                    this.RequestType == input.RequestType ||
                    (this.RequestType != null &&
                    this.RequestType.Equals(input.RequestType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Participant == input.Participant ||
                    (this.Participant != null &&
                    this.Participant.Equals(input.Participant))
                ) && 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.ParticipantData == input.ParticipantData ||
                    (this.ParticipantData != null &&
                    this.ParticipantData.Equals(input.ParticipantData))
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.OperationId != null)
                    hashCode = hashCode * 59 + this.OperationId.GetHashCode();
                if (this.RequestType != null)
                    hashCode = hashCode * 59 + this.RequestType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Participant != null)
                    hashCode = hashCode * 59 + this.Participant.GetHashCode();
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.ParticipantData != null)
                    hashCode = hashCode * 59 + this.ParticipantData.GetHashCode();
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
