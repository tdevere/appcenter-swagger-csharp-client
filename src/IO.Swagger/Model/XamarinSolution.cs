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
    /// XamarinSolution
    /// </summary>
    [DataContract]
        public partial class XamarinSolution :  IEquatable<XamarinSolution>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XamarinSolution" /> class.
        /// </summary>
        /// <param name="path">Path to solution (required).</param>
        /// <param name="configurations">Solution configurations (required).</param>
        /// <param name="defaultConfiguration">Solution default configuration.</param>
        public XamarinSolution(string path = default(string), List<string> configurations = default(List<string>), string defaultConfiguration = default(string))
        {
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new InvalidDataException("path is a required property for XamarinSolution and cannot be null");
            }
            else
            {
                this.Path = path;
            }
            // to ensure "configurations" is required (not null)
            if (configurations == null)
            {
                throw new InvalidDataException("configurations is a required property for XamarinSolution and cannot be null");
            }
            else
            {
                this.Configurations = configurations;
            }
            this.DefaultConfiguration = defaultConfiguration;
        }
        
        /// <summary>
        /// Path to solution
        /// </summary>
        /// <value>Path to solution</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Solution configurations
        /// </summary>
        /// <value>Solution configurations</value>
        [DataMember(Name="configurations", EmitDefaultValue=false)]
        public List<string> Configurations { get; set; }

        /// <summary>
        /// Solution default configuration
        /// </summary>
        /// <value>Solution default configuration</value>
        [DataMember(Name="defaultConfiguration", EmitDefaultValue=false)]
        public string DefaultConfiguration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XamarinSolution {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Configurations: ").Append(Configurations).Append("\n");
            sb.Append("  DefaultConfiguration: ").Append(DefaultConfiguration).Append("\n");
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
            return this.Equals(input as XamarinSolution);
        }

        /// <summary>
        /// Returns true if XamarinSolution instances are equal
        /// </summary>
        /// <param name="input">Instance of XamarinSolution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XamarinSolution input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Configurations == input.Configurations ||
                    this.Configurations != null &&
                    input.Configurations != null &&
                    this.Configurations.SequenceEqual(input.Configurations)
                ) && 
                (
                    this.DefaultConfiguration == input.DefaultConfiguration ||
                    (this.DefaultConfiguration != null &&
                    this.DefaultConfiguration.Equals(input.DefaultConfiguration))
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Configurations != null)
                    hashCode = hashCode * 59 + this.Configurations.GetHashCode();
                if (this.DefaultConfiguration != null)
                    hashCode = hashCode * 59 + this.DefaultConfiguration.GetHashCode();
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
