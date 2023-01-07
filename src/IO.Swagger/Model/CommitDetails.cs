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
    /// CommitDetails
    /// </summary>
    [DataContract]
        public partial class CommitDetails :  IEquatable<CommitDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommitDetails" /> class.
        /// </summary>
        /// <param name="commit">commit.</param>
        public CommitDetails(CommitDetailsCommit commit = default(CommitDetailsCommit))
        {
            this.Commit = commit;
        }
        
        /// <summary>
        /// Gets or Sets Commit
        /// </summary>
        [DataMember(Name="commit", EmitDefaultValue=false)]
        public CommitDetailsCommit Commit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommitDetails {\n");
            sb.Append("  Commit: ").Append(Commit).Append("\n");
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
            return this.Equals(input as CommitDetails);
        }

        /// <summary>
        /// Returns true if CommitDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CommitDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommitDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Commit == input.Commit ||
                    (this.Commit != null &&
                    this.Commit.Equals(input.Commit))
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
                if (this.Commit != null)
                    hashCode = hashCode * 59 + this.Commit.GetHashCode();
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
