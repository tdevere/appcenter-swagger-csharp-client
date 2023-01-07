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
    /// TesterAppWithReleaseResponse
    /// </summary>
    [DataContract]
        public partial class TesterAppWithReleaseResponse :  IEquatable<TesterAppWithReleaseResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TesterAppWithReleaseResponse" /> class.
        /// </summary>
        /// <param name="id">The unique ID (UUID) of the app.</param>
        /// <param name="release">release.</param>
        /// <param name="name">The app&#x27;s name..</param>
        /// <param name="displayName">The app&#x27;s display name..</param>
        /// <param name="description">The description of the app.</param>
        /// <param name="iconUrl">A URL to the app&#x27;s icon..</param>
        /// <param name="os">The app&#x27;s os..</param>
        /// <param name="owner">owner.</param>
        public TesterAppWithReleaseResponse(string id = default(string), AllOfTesterAppWithReleaseResponseRelease release = default(AllOfTesterAppWithReleaseResponseRelease), string name = default(string), string displayName = default(string), string description = default(string), string iconUrl = default(string), string os = default(string), TesterAppWithReleaseResponseOwner owner = default(TesterAppWithReleaseResponseOwner))
        {
            this.Id = id;
            this.Release = release;
            this.Name = name;
            this.DisplayName = displayName;
            this.Description = description;
            this.IconUrl = iconUrl;
            this.Os = os;
            this.Owner = owner;
        }
        
        /// <summary>
        /// The unique ID (UUID) of the app
        /// </summary>
        /// <value>The unique ID (UUID) of the app</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Release
        /// </summary>
        [DataMember(Name="release", EmitDefaultValue=false)]
        public AllOfTesterAppWithReleaseResponseRelease Release { get; set; }

        /// <summary>
        /// The app&#x27;s name.
        /// </summary>
        /// <value>The app&#x27;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The app&#x27;s display name.
        /// </summary>
        /// <value>The app&#x27;s display name.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The description of the app
        /// </summary>
        /// <value>The description of the app</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A URL to the app&#x27;s icon.
        /// </summary>
        /// <value>A URL to the app&#x27;s icon.</value>
        [DataMember(Name="icon_url", EmitDefaultValue=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// The app&#x27;s os.
        /// </summary>
        /// <value>The app&#x27;s os.</value>
        [DataMember(Name="os", EmitDefaultValue=false)]
        public string Os { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public TesterAppWithReleaseResponseOwner Owner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TesterAppWithReleaseResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Release: ").Append(Release).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
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
            return this.Equals(input as TesterAppWithReleaseResponse);
        }

        /// <summary>
        /// Returns true if TesterAppWithReleaseResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TesterAppWithReleaseResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TesterAppWithReleaseResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Release == input.Release ||
                    (this.Release != null &&
                    this.Release.Equals(input.Release))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
                ) && 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Release != null)
                    hashCode = hashCode * 59 + this.Release.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IconUrl != null)
                    hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
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
