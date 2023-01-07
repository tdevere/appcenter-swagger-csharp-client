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
    /// The source repository
    /// </summary>
    [DataContract]
        public partial class SourceRepository :  IEquatable<SourceRepository>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceRepository" /> class.
        /// </summary>
        /// <param name="name">The repository name.</param>
        /// <param name="cloneUrl">URL used to clone the repository.</param>
        public SourceRepository(string name = default(string), string cloneUrl = default(string))
        {
            this.Name = name;
            this.CloneUrl = cloneUrl;
        }
        
        /// <summary>
        /// The repository name
        /// </summary>
        /// <value>The repository name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// URL used to clone the repository
        /// </summary>
        /// <value>URL used to clone the repository</value>
        [DataMember(Name="clone_url", EmitDefaultValue=false)]
        public string CloneUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SourceRepository {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CloneUrl: ").Append(CloneUrl).Append("\n");
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
            return this.Equals(input as SourceRepository);
        }

        /// <summary>
        /// Returns true if SourceRepository instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceRepository to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceRepository input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CloneUrl == input.CloneUrl ||
                    (this.CloneUrl != null &&
                    this.CloneUrl.Equals(input.CloneUrl))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CloneUrl != null)
                    hashCode = hashCode * 59 + this.CloneUrl.GetHashCode();
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