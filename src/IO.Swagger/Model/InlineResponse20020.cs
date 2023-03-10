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
    /// Set of toolsets available for app
    /// </summary>
    [DataContract]
        public partial class InlineResponse20020 :  IEquatable<InlineResponse20020>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20020" /> class.
        /// </summary>
        /// <param name="xamarin">A list of Xamarin SDK bundles.</param>
        /// <param name="xcode">A list of Xcode versions.</param>
        /// <param name="node">A list of Node versions.</param>
        public InlineResponse20020(List<InlineResponse20017> xamarin = default(List<InlineResponse20017>), List<InlineResponse20016> xcode = default(List<InlineResponse20016>), List<ToolsetsNode> node = default(List<ToolsetsNode>))
        {
            this.Xamarin = xamarin;
            this.Xcode = xcode;
            this.Node = node;
        }
        
        /// <summary>
        /// A list of Xamarin SDK bundles
        /// </summary>
        /// <value>A list of Xamarin SDK bundles</value>
        [DataMember(Name="xamarin", EmitDefaultValue=false)]
        public List<InlineResponse20017> Xamarin { get; set; }

        /// <summary>
        /// A list of Xcode versions
        /// </summary>
        /// <value>A list of Xcode versions</value>
        [DataMember(Name="xcode", EmitDefaultValue=false)]
        public List<InlineResponse20016> Xcode { get; set; }

        /// <summary>
        /// A list of Node versions
        /// </summary>
        /// <value>A list of Node versions</value>
        [DataMember(Name="node", EmitDefaultValue=false)]
        public List<ToolsetsNode> Node { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20020 {\n");
            sb.Append("  Xamarin: ").Append(Xamarin).Append("\n");
            sb.Append("  Xcode: ").Append(Xcode).Append("\n");
            sb.Append("  Node: ").Append(Node).Append("\n");
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
            return this.Equals(input as InlineResponse20020);
        }

        /// <summary>
        /// Returns true if InlineResponse20020 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20020 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20020 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Xamarin == input.Xamarin ||
                    this.Xamarin != null &&
                    input.Xamarin != null &&
                    this.Xamarin.SequenceEqual(input.Xamarin)
                ) && 
                (
                    this.Xcode == input.Xcode ||
                    this.Xcode != null &&
                    input.Xcode != null &&
                    this.Xcode.SequenceEqual(input.Xcode)
                ) && 
                (
                    this.Node == input.Node ||
                    this.Node != null &&
                    input.Node != null &&
                    this.Node.SequenceEqual(input.Node)
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
                if (this.Xamarin != null)
                    hashCode = hashCode * 59 + this.Xamarin.GetHashCode();
                if (this.Xcode != null)
                    hashCode = hashCode * 59 + this.Xcode.GetHashCode();
                if (this.Node != null)
                    hashCode = hashCode * 59 + this.Node.GetHashCode();
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
