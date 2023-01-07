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
    /// AndroidModule
    /// </summary>
    [DataContract]
        public partial class AndroidModule :  IEquatable<AndroidModule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidModule" /> class.
        /// </summary>
        /// <param name="name">Name of the Android module (required).</param>
        /// <param name="hasBundle">Module contains bundle settings.</param>
        /// <param name="productFlavors">The product flavors of the Android module.</param>
        /// <param name="buildVariants">The detected build variants of the Android module (matrix of product flavor + build type (debug|release)).</param>
        /// <param name="buildTypes">The detected build types of the Android module.</param>
        /// <param name="buildConfigurations">The detected build configurations of the Android module.</param>
        /// <param name="isRoot">Whether the module is at the root level of the project.</param>
        public AndroidModule(string name = default(string), bool? hasBundle = default(bool?), List<string> productFlavors = default(List<string>), List<string> buildVariants = default(List<string>), List<string> buildTypes = default(List<string>), List<AndroidProjectBuildConfigurations> buildConfigurations = default(List<AndroidProjectBuildConfigurations>), bool? isRoot = default(bool?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for AndroidModule and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.HasBundle = hasBundle;
            this.ProductFlavors = productFlavors;
            this.BuildVariants = buildVariants;
            this.BuildTypes = buildTypes;
            this.BuildConfigurations = buildConfigurations;
            this.IsRoot = isRoot;
        }
        
        /// <summary>
        /// Name of the Android module
        /// </summary>
        /// <value>Name of the Android module</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Module contains bundle settings
        /// </summary>
        /// <value>Module contains bundle settings</value>
        [DataMember(Name="hasBundle", EmitDefaultValue=false)]
        public bool? HasBundle { get; set; }

        /// <summary>
        /// The product flavors of the Android module
        /// </summary>
        /// <value>The product flavors of the Android module</value>
        [DataMember(Name="productFlavors", EmitDefaultValue=false)]
        public List<string> ProductFlavors { get; set; }

        /// <summary>
        /// The detected build variants of the Android module (matrix of product flavor + build type (debug|release))
        /// </summary>
        /// <value>The detected build variants of the Android module (matrix of product flavor + build type (debug|release))</value>
        [DataMember(Name="buildVariants", EmitDefaultValue=false)]
        public List<string> BuildVariants { get; set; }

        /// <summary>
        /// The detected build types of the Android module
        /// </summary>
        /// <value>The detected build types of the Android module</value>
        [DataMember(Name="buildTypes", EmitDefaultValue=false)]
        public List<string> BuildTypes { get; set; }

        /// <summary>
        /// The detected build configurations of the Android module
        /// </summary>
        /// <value>The detected build configurations of the Android module</value>
        [DataMember(Name="buildConfigurations", EmitDefaultValue=false)]
        public List<AndroidProjectBuildConfigurations> BuildConfigurations { get; set; }

        /// <summary>
        /// Whether the module is at the root level of the project
        /// </summary>
        /// <value>Whether the module is at the root level of the project</value>
        [DataMember(Name="isRoot", EmitDefaultValue=false)]
        public bool? IsRoot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AndroidModule {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HasBundle: ").Append(HasBundle).Append("\n");
            sb.Append("  ProductFlavors: ").Append(ProductFlavors).Append("\n");
            sb.Append("  BuildVariants: ").Append(BuildVariants).Append("\n");
            sb.Append("  BuildTypes: ").Append(BuildTypes).Append("\n");
            sb.Append("  BuildConfigurations: ").Append(BuildConfigurations).Append("\n");
            sb.Append("  IsRoot: ").Append(IsRoot).Append("\n");
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
            return this.Equals(input as AndroidModule);
        }

        /// <summary>
        /// Returns true if AndroidModule instances are equal
        /// </summary>
        /// <param name="input">Instance of AndroidModule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AndroidModule input)
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
                    this.HasBundle == input.HasBundle ||
                    (this.HasBundle != null &&
                    this.HasBundle.Equals(input.HasBundle))
                ) && 
                (
                    this.ProductFlavors == input.ProductFlavors ||
                    this.ProductFlavors != null &&
                    input.ProductFlavors != null &&
                    this.ProductFlavors.SequenceEqual(input.ProductFlavors)
                ) && 
                (
                    this.BuildVariants == input.BuildVariants ||
                    this.BuildVariants != null &&
                    input.BuildVariants != null &&
                    this.BuildVariants.SequenceEqual(input.BuildVariants)
                ) && 
                (
                    this.BuildTypes == input.BuildTypes ||
                    this.BuildTypes != null &&
                    input.BuildTypes != null &&
                    this.BuildTypes.SequenceEqual(input.BuildTypes)
                ) && 
                (
                    this.BuildConfigurations == input.BuildConfigurations ||
                    this.BuildConfigurations != null &&
                    input.BuildConfigurations != null &&
                    this.BuildConfigurations.SequenceEqual(input.BuildConfigurations)
                ) && 
                (
                    this.IsRoot == input.IsRoot ||
                    (this.IsRoot != null &&
                    this.IsRoot.Equals(input.IsRoot))
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
                if (this.HasBundle != null)
                    hashCode = hashCode * 59 + this.HasBundle.GetHashCode();
                if (this.ProductFlavors != null)
                    hashCode = hashCode * 59 + this.ProductFlavors.GetHashCode();
                if (this.BuildVariants != null)
                    hashCode = hashCode * 59 + this.BuildVariants.GetHashCode();
                if (this.BuildTypes != null)
                    hashCode = hashCode * 59 + this.BuildTypes.GetHashCode();
                if (this.BuildConfigurations != null)
                    hashCode = hashCode * 59 + this.BuildConfigurations.GetHashCode();
                if (this.IsRoot != null)
                    hashCode = hashCode * 59 + this.IsRoot.GetHashCode();
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
