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
    /// CrashDetails
    /// </summary>
    [DataContract]
        public partial class CrashDetails :  IEquatable<CrashDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrashDetails" /> class.
        /// </summary>
        /// <param name="carrierCountry">Carrier country code (for mobile devices). .</param>
        /// <param name="carrierName">Carrier name (for mobile devices). .</param>
        /// <param name="locale">Language code (example: en_US).  (required).</param>
        /// <param name="osBuild">OS build code (example: LMY47X). .</param>
        /// <param name="rooted">Whether the device where the crash occurred is rooted or jailbroken  (required).</param>
        /// <param name="screenSize">Screen size of the device in pixels (example: 640x480).  (required).</param>
        /// <param name="appStartTimestamp">Application launch timestamp (example: 1985-04-12T23:20:50.52Z). .</param>
        public CrashDetails(string carrierCountry = default(string), string carrierName = default(string), string locale = default(string), string osBuild = default(string), bool? rooted = default(bool?), string screenSize = default(string), DateTime? appStartTimestamp = default(DateTime?))
        {
            // to ensure "locale" is required (not null)
            if (locale == null)
            {
                throw new InvalidDataException("locale is a required property for CrashDetails and cannot be null");
            }
            else
            {
                this.Locale = locale;
            }
            // to ensure "rooted" is required (not null)
            if (rooted == null)
            {
                throw new InvalidDataException("rooted is a required property for CrashDetails and cannot be null");
            }
            else
            {
                this.Rooted = rooted;
            }
            // to ensure "screenSize" is required (not null)
            if (screenSize == null)
            {
                throw new InvalidDataException("screenSize is a required property for CrashDetails and cannot be null");
            }
            else
            {
                this.ScreenSize = screenSize;
            }
            this.CarrierCountry = carrierCountry;
            this.CarrierName = carrierName;
            this.OsBuild = osBuild;
            this.AppStartTimestamp = appStartTimestamp;
        }
        
        /// <summary>
        /// Carrier country code (for mobile devices). 
        /// </summary>
        /// <value>Carrier country code (for mobile devices). </value>
        [DataMember(Name="carrier_country", EmitDefaultValue=false)]
        public string CarrierCountry { get; set; }

        /// <summary>
        /// Carrier name (for mobile devices). 
        /// </summary>
        /// <value>Carrier name (for mobile devices). </value>
        [DataMember(Name="carrier_name", EmitDefaultValue=false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// Language code (example: en_US). 
        /// </summary>
        /// <value>Language code (example: en_US). </value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// OS build code (example: LMY47X). 
        /// </summary>
        /// <value>OS build code (example: LMY47X). </value>
        [DataMember(Name="os_build", EmitDefaultValue=false)]
        public string OsBuild { get; set; }

        /// <summary>
        /// Whether the device where the crash occurred is rooted or jailbroken 
        /// </summary>
        /// <value>Whether the device where the crash occurred is rooted or jailbroken </value>
        [DataMember(Name="rooted", EmitDefaultValue=false)]
        public bool? Rooted { get; set; }

        /// <summary>
        /// Screen size of the device in pixels (example: 640x480). 
        /// </summary>
        /// <value>Screen size of the device in pixels (example: 640x480). </value>
        [DataMember(Name="screen_size", EmitDefaultValue=false)]
        public string ScreenSize { get; set; }

        /// <summary>
        /// Application launch timestamp (example: 1985-04-12T23:20:50.52Z). 
        /// </summary>
        /// <value>Application launch timestamp (example: 1985-04-12T23:20:50.52Z). </value>
        [DataMember(Name="app_start_timestamp", EmitDefaultValue=false)]
        public DateTime? AppStartTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrashDetails {\n");
            sb.Append("  CarrierCountry: ").Append(CarrierCountry).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  OsBuild: ").Append(OsBuild).Append("\n");
            sb.Append("  Rooted: ").Append(Rooted).Append("\n");
            sb.Append("  ScreenSize: ").Append(ScreenSize).Append("\n");
            sb.Append("  AppStartTimestamp: ").Append(AppStartTimestamp).Append("\n");
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
            return this.Equals(input as CrashDetails);
        }

        /// <summary>
        /// Returns true if CrashDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CrashDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrashDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CarrierCountry == input.CarrierCountry ||
                    (this.CarrierCountry != null &&
                    this.CarrierCountry.Equals(input.CarrierCountry))
                ) && 
                (
                    this.CarrierName == input.CarrierName ||
                    (this.CarrierName != null &&
                    this.CarrierName.Equals(input.CarrierName))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.OsBuild == input.OsBuild ||
                    (this.OsBuild != null &&
                    this.OsBuild.Equals(input.OsBuild))
                ) && 
                (
                    this.Rooted == input.Rooted ||
                    (this.Rooted != null &&
                    this.Rooted.Equals(input.Rooted))
                ) && 
                (
                    this.ScreenSize == input.ScreenSize ||
                    (this.ScreenSize != null &&
                    this.ScreenSize.Equals(input.ScreenSize))
                ) && 
                (
                    this.AppStartTimestamp == input.AppStartTimestamp ||
                    (this.AppStartTimestamp != null &&
                    this.AppStartTimestamp.Equals(input.AppStartTimestamp))
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
                if (this.CarrierCountry != null)
                    hashCode = hashCode * 59 + this.CarrierCountry.GetHashCode();
                if (this.CarrierName != null)
                    hashCode = hashCode * 59 + this.CarrierName.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.OsBuild != null)
                    hashCode = hashCode * 59 + this.OsBuild.GetHashCode();
                if (this.Rooted != null)
                    hashCode = hashCode * 59 + this.Rooted.GetHashCode();
                if (this.ScreenSize != null)
                    hashCode = hashCode * 59 + this.ScreenSize.GetHashCode();
                if (this.AppStartTimestamp != null)
                    hashCode = hashCode * 59 + this.AppStartTimestamp.GetHashCode();
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
