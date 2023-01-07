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
    /// LegacyCodePushApp
    /// </summary>
    [DataContract]
        public partial class LegacyCodePushApp :  IEquatable<LegacyCodePushApp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyCodePushApp" /> class.
        /// </summary>
        /// <param name="name">The app name. (required).</param>
        /// <param name="os">The app os..</param>
        /// <param name="platform">The app platform..</param>
        /// <param name="manuallyProvisionDeployments">Whether the user provided their own deployments. Not currently in use..</param>
        public LegacyCodePushApp(string name = default(string), string os = default(string), string platform = default(string), bool? manuallyProvisionDeployments = default(bool?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for LegacyCodePushApp and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Os = os;
            this.Platform = platform;
            this.ManuallyProvisionDeployments = manuallyProvisionDeployments;
        }
        
        /// <summary>
        /// The app name.
        /// </summary>
        /// <value>The app name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The app os.
        /// </summary>
        /// <value>The app os.</value>
        [DataMember(Name="os", EmitDefaultValue=false)]
        public string Os { get; set; }

        /// <summary>
        /// The app platform.
        /// </summary>
        /// <value>The app platform.</value>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public string Platform { get; set; }

        /// <summary>
        /// Whether the user provided their own deployments. Not currently in use.
        /// </summary>
        /// <value>Whether the user provided their own deployments. Not currently in use.</value>
        [DataMember(Name="manuallyProvisionDeployments", EmitDefaultValue=false)]
        public bool? ManuallyProvisionDeployments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LegacyCodePushApp {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  ManuallyProvisionDeployments: ").Append(ManuallyProvisionDeployments).Append("\n");
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
            return this.Equals(input as LegacyCodePushApp);
        }

        /// <summary>
        /// Returns true if LegacyCodePushApp instances are equal
        /// </summary>
        /// <param name="input">Instance of LegacyCodePushApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegacyCodePushApp input)
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
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.ManuallyProvisionDeployments == input.ManuallyProvisionDeployments ||
                    (this.ManuallyProvisionDeployments != null &&
                    this.ManuallyProvisionDeployments.Equals(input.ManuallyProvisionDeployments))
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
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.ManuallyProvisionDeployments != null)
                    hashCode = hashCode * 59 + this.ManuallyProvisionDeployments.GetHashCode();
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
