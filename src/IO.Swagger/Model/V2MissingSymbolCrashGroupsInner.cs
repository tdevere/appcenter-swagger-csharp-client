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
    /// missing symbol crash group object
    /// </summary>
    [DataContract]
        public partial class V2MissingSymbolCrashGroupsInner :  IEquatable<V2MissingSymbolCrashGroupsInner>, IValidatableObject
    {
        /// <summary>
        /// group status
        /// </summary>
        /// <value>group status</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 2,
            /// <summary>
            /// Enum Closed for value: closed
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed = 3        }
        /// <summary>
        /// group status
        /// </summary>
        /// <value>group status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2MissingSymbolCrashGroupsInner" /> class.
        /// </summary>
        /// <param name="symbolGroupId">id of the symbol group (required).</param>
        /// <param name="crashCount">number of crashes that belong to this group.</param>
        /// <param name="errorCount">number of errors that belong to this group.</param>
        /// <param name="appId">application id (required).</param>
        /// <param name="appVer">application version (required).</param>
        /// <param name="appBuild">application build (required).</param>
        /// <param name="lastModified">last update date for the group (required).</param>
        /// <param name="missingSymbols">list of missing symbols (required).</param>
        /// <param name="status">group status (required).</param>
        public V2MissingSymbolCrashGroupsInner(string symbolGroupId = default(string), int? crashCount = default(int?), int? errorCount = default(int?), string appId = default(string), string appVer = default(string), string appBuild = default(string), DateTime? lastModified = default(DateTime?), List<Object> missingSymbols = default(List<Object>), StatusEnum status = default(StatusEnum))
        {
            // to ensure "symbolGroupId" is required (not null)
            if (symbolGroupId == null)
            {
                throw new InvalidDataException("symbolGroupId is a required property for V2MissingSymbolCrashGroupsInner and cannot be null");
            }
            else
            {
                this.SymbolGroupId = symbolGroupId;
            }
            // to ensure "appId" is required (not null)
            if (appId == null)
            {
                throw new InvalidDataException("appId is a required property for V2MissingSymbolCrashGroupsInner and cannot be null");
            }
            else
            {
                this.AppId = appId;
            }
            // to ensure "appVer" is required (not null)
            if (appVer == null)
            {
                throw new InvalidDataException("appVer is a required property for V2MissingSymbolCrashGroupsInner and cannot be null");
            }
            else
            {
                this.AppVer = appVer;
            }
            // to ensure "appBuild" is required (not null)
            if (appBuild == null)
            {
                throw new InvalidDataException("appBuild is a required property for V2MissingSymbolCrashGroupsInner and cannot be null");
            }
            else
            {
                this.AppBuild = appBuild;
            }
            // to ensure "lastModified" is required (not null)
            if (lastModified == null)
            {
                throw new InvalidDataException("lastModified is a required property for V2MissingSymbolCrashGroupsInner and cannot be null");
            }
            else
            {
                this.LastModified = lastModified;
            }
            // to ensure "missingSymbols" is required (not null)
            if (missingSymbols == null)
            {
                throw new InvalidDataException("missingSymbols is a required property for V2MissingSymbolCrashGroupsInner and cannot be null");
            }
            else
            {
                this.MissingSymbols = missingSymbols;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for V2MissingSymbolCrashGroupsInner and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.CrashCount = crashCount;
            this.ErrorCount = errorCount;
        }
        
        /// <summary>
        /// id of the symbol group
        /// </summary>
        /// <value>id of the symbol group</value>
        [DataMember(Name="symbol_group_id", EmitDefaultValue=false)]
        public string SymbolGroupId { get; set; }

        /// <summary>
        /// number of crashes that belong to this group
        /// </summary>
        /// <value>number of crashes that belong to this group</value>
        [DataMember(Name="crash_count", EmitDefaultValue=false)]
        public int? CrashCount { get; set; }

        /// <summary>
        /// number of errors that belong to this group
        /// </summary>
        /// <value>number of errors that belong to this group</value>
        [DataMember(Name="error_count", EmitDefaultValue=false)]
        public int? ErrorCount { get; set; }

        /// <summary>
        /// application id
        /// </summary>
        /// <value>application id</value>
        [DataMember(Name="app_id", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// application version
        /// </summary>
        /// <value>application version</value>
        [DataMember(Name="app_ver", EmitDefaultValue=false)]
        public string AppVer { get; set; }

        /// <summary>
        /// application build
        /// </summary>
        /// <value>application build</value>
        [DataMember(Name="app_build", EmitDefaultValue=false)]
        public string AppBuild { get; set; }

        /// <summary>
        /// last update date for the group
        /// </summary>
        /// <value>last update date for the group</value>
        [DataMember(Name="last_modified", EmitDefaultValue=false)]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// list of missing symbols
        /// </summary>
        /// <value>list of missing symbols</value>
        [DataMember(Name="missing_symbols", EmitDefaultValue=false)]
        public List<Object> MissingSymbols { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2MissingSymbolCrashGroupsInner {\n");
            sb.Append("  SymbolGroupId: ").Append(SymbolGroupId).Append("\n");
            sb.Append("  CrashCount: ").Append(CrashCount).Append("\n");
            sb.Append("  ErrorCount: ").Append(ErrorCount).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  AppVer: ").Append(AppVer).Append("\n");
            sb.Append("  AppBuild: ").Append(AppBuild).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  MissingSymbols: ").Append(MissingSymbols).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as V2MissingSymbolCrashGroupsInner);
        }

        /// <summary>
        /// Returns true if V2MissingSymbolCrashGroupsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of V2MissingSymbolCrashGroupsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2MissingSymbolCrashGroupsInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SymbolGroupId == input.SymbolGroupId ||
                    (this.SymbolGroupId != null &&
                    this.SymbolGroupId.Equals(input.SymbolGroupId))
                ) && 
                (
                    this.CrashCount == input.CrashCount ||
                    (this.CrashCount != null &&
                    this.CrashCount.Equals(input.CrashCount))
                ) && 
                (
                    this.ErrorCount == input.ErrorCount ||
                    (this.ErrorCount != null &&
                    this.ErrorCount.Equals(input.ErrorCount))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.AppVer == input.AppVer ||
                    (this.AppVer != null &&
                    this.AppVer.Equals(input.AppVer))
                ) && 
                (
                    this.AppBuild == input.AppBuild ||
                    (this.AppBuild != null &&
                    this.AppBuild.Equals(input.AppBuild))
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.MissingSymbols == input.MissingSymbols ||
                    this.MissingSymbols != null &&
                    input.MissingSymbols != null &&
                    this.MissingSymbols.SequenceEqual(input.MissingSymbols)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.SymbolGroupId != null)
                    hashCode = hashCode * 59 + this.SymbolGroupId.GetHashCode();
                if (this.CrashCount != null)
                    hashCode = hashCode * 59 + this.CrashCount.GetHashCode();
                if (this.ErrorCount != null)
                    hashCode = hashCode * 59 + this.ErrorCount.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.AppVer != null)
                    hashCode = hashCode * 59 + this.AppVer.GetHashCode();
                if (this.AppBuild != null)
                    hashCode = hashCode * 59 + this.AppBuild.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.MissingSymbols != null)
                    hashCode = hashCode * 59 + this.MissingSymbols.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
