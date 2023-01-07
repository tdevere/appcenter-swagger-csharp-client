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
    /// EventsEvents
    /// </summary>
    [DataContract]
        public partial class EventsEvents :  IEquatable<EventsEvents>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventsEvents" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="deviceCount">deviceCount.</param>
        /// <param name="previousDeviceCount">The device count of previous time range of the event..</param>
        /// <param name="count">count.</param>
        /// <param name="previousCount">The event count of previous time range of the event..</param>
        /// <param name="countPerDevice">countPerDevice.</param>
        /// <param name="countPerSession">countPerSession.</param>
        public EventsEvents(string id = default(string), string name = default(string), long? deviceCount = default(long?), long? previousDeviceCount = default(long?), long? count = default(long?), long? previousCount = default(long?), double? countPerDevice = default(double?), double? countPerSession = default(double?))
        {
            this.Id = id;
            this.Name = name;
            this.DeviceCount = deviceCount;
            this.PreviousDeviceCount = previousDeviceCount;
            this.Count = count;
            this.PreviousCount = previousCount;
            this.CountPerDevice = countPerDevice;
            this.CountPerSession = countPerSession;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DeviceCount
        /// </summary>
        [DataMember(Name="device_count", EmitDefaultValue=false)]
        public long? DeviceCount { get; set; }

        /// <summary>
        /// The device count of previous time range of the event.
        /// </summary>
        /// <value>The device count of previous time range of the event.</value>
        [DataMember(Name="previous_device_count", EmitDefaultValue=false)]
        public long? PreviousDeviceCount { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// The event count of previous time range of the event.
        /// </summary>
        /// <value>The event count of previous time range of the event.</value>
        [DataMember(Name="previous_count", EmitDefaultValue=false)]
        public long? PreviousCount { get; set; }

        /// <summary>
        /// Gets or Sets CountPerDevice
        /// </summary>
        [DataMember(Name="count_per_device", EmitDefaultValue=false)]
        public double? CountPerDevice { get; set; }

        /// <summary>
        /// Gets or Sets CountPerSession
        /// </summary>
        [DataMember(Name="count_per_session", EmitDefaultValue=false)]
        public double? CountPerSession { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventsEvents {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DeviceCount: ").Append(DeviceCount).Append("\n");
            sb.Append("  PreviousDeviceCount: ").Append(PreviousDeviceCount).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  PreviousCount: ").Append(PreviousCount).Append("\n");
            sb.Append("  CountPerDevice: ").Append(CountPerDevice).Append("\n");
            sb.Append("  CountPerSession: ").Append(CountPerSession).Append("\n");
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
            return this.Equals(input as EventsEvents);
        }

        /// <summary>
        /// Returns true if EventsEvents instances are equal
        /// </summary>
        /// <param name="input">Instance of EventsEvents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventsEvents input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DeviceCount == input.DeviceCount ||
                    (this.DeviceCount != null &&
                    this.DeviceCount.Equals(input.DeviceCount))
                ) && 
                (
                    this.PreviousDeviceCount == input.PreviousDeviceCount ||
                    (this.PreviousDeviceCount != null &&
                    this.PreviousDeviceCount.Equals(input.PreviousDeviceCount))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.PreviousCount == input.PreviousCount ||
                    (this.PreviousCount != null &&
                    this.PreviousCount.Equals(input.PreviousCount))
                ) && 
                (
                    this.CountPerDevice == input.CountPerDevice ||
                    (this.CountPerDevice != null &&
                    this.CountPerDevice.Equals(input.CountPerDevice))
                ) && 
                (
                    this.CountPerSession == input.CountPerSession ||
                    (this.CountPerSession != null &&
                    this.CountPerSession.Equals(input.CountPerSession))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DeviceCount != null)
                    hashCode = hashCode * 59 + this.DeviceCount.GetHashCode();
                if (this.PreviousDeviceCount != null)
                    hashCode = hashCode * 59 + this.PreviousDeviceCount.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.PreviousCount != null)
                    hashCode = hashCode * 59 + this.PreviousCount.GetHashCode();
                if (this.CountPerDevice != null)
                    hashCode = hashCode * 59 + this.CountPerDevice.GetHashCode();
                if (this.CountPerSession != null)
                    hashCode = hashCode * 59 + this.CountPerSession.GetHashCode();
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
