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
    /// The information for a single distribution group member and their ios device
    /// </summary>
    [DataContract]
        public partial class MemberDevicesInfoResponse :  IEquatable<MemberDevicesInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberDevicesInfoResponse" /> class.
        /// </summary>
        /// <param name="id">The unique id (UUID) of the user (required).</param>
        /// <param name="avatarUrl">The avatar URL of the user.</param>
        /// <param name="canChangePassword">User is required to send an old password in order to change the password..</param>
        /// <param name="displayName">The full name of the user. Might for example be first and last name.</param>
        /// <param name="email">The email address of the user (required).</param>
        /// <param name="invitePending">Whether the has accepted the invite. Available when an invite is pending, and the value will be \&quot;true\&quot;..</param>
        /// <param name="name">The unique name that is used to identify the user..</param>
        /// <param name="udid">The Unique Device IDentifier of the device (required).</param>
        /// <param name="model">The model identifier of the device, in the format iDeviceM,N (required).</param>
        /// <param name="deviceName">The device description, in the format \&quot;iPhone 7 Plus (A1784)\&quot; (required).</param>
        /// <param name="fullDeviceName">A combination of the device model name and the owner name..</param>
        /// <param name="osBuild">The last known OS version running on the device (required).</param>
        /// <param name="osVersion">The last known OS version running on the device (required).</param>
        /// <param name="serial">The device&#x27;s serial number. Always empty or undefined at present..</param>
        /// <param name="imei">The device&#x27;s International Mobile Equipment Identity number. Always empty or undefined at present..</param>
        /// <param name="ownerId">The user ID of the device owner..</param>
        /// <param name="status">The provisioning status of the device. (required).</param>
        /// <param name="registeredAt">Timestamp of when the device was registered in ISO format..</param>
        public MemberDevicesInfoResponse(Guid? id = default(Guid?), string avatarUrl = default(string), bool? canChangePassword = default(bool?), string displayName = default(string), string email = default(string), bool? invitePending = default(bool?), string name = default(string), string udid = default(string), string model = default(string), string deviceName = default(string), string fullDeviceName = default(string), string osBuild = default(string), string osVersion = default(string), string serial = default(string), string imei = default(string), string ownerId = default(string), string status = default(string), string registeredAt = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for MemberDevicesInfoResponse and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for MemberDevicesInfoResponse and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "udid" is required (not null)
            if (udid == null)
            {
                throw new InvalidDataException("udid is a required property for MemberDevicesInfoResponse and cannot be null");
            }
            else
            {
                this.Udid = udid;
            }
            // to ensure "model" is required (not null)
            if (model == null)
            {
                throw new InvalidDataException("model is a required property for MemberDevicesInfoResponse and cannot be null");
            }
            else
            {
                this.Model = model;
            }
            // to ensure "deviceName" is required (not null)
            if (deviceName == null)
            {
                throw new InvalidDataException("deviceName is a required property for MemberDevicesInfoResponse and cannot be null");
            }
            else
            {
                this.DeviceName = deviceName;
            }
            // to ensure "osBuild" is required (not null)
            if (osBuild == null)
            {
                throw new InvalidDataException("osBuild is a required property for MemberDevicesInfoResponse and cannot be null");
            }
            else
            {
                this.OsBuild = osBuild;
            }
            // to ensure "osVersion" is required (not null)
            if (osVersion == null)
            {
                throw new InvalidDataException("osVersion is a required property for MemberDevicesInfoResponse and cannot be null");
            }
            else
            {
                this.OsVersion = osVersion;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for MemberDevicesInfoResponse and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.AvatarUrl = avatarUrl;
            this.CanChangePassword = canChangePassword;
            this.DisplayName = displayName;
            this.InvitePending = invitePending;
            this.Name = name;
            this.FullDeviceName = fullDeviceName;
            this.Serial = serial;
            this.Imei = imei;
            this.OwnerId = ownerId;
            this.RegisteredAt = registeredAt;
        }
        
        /// <summary>
        /// The unique id (UUID) of the user
        /// </summary>
        /// <value>The unique id (UUID) of the user</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// The avatar URL of the user
        /// </summary>
        /// <value>The avatar URL of the user</value>
        [DataMember(Name="avatar_url", EmitDefaultValue=false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// User is required to send an old password in order to change the password.
        /// </summary>
        /// <value>User is required to send an old password in order to change the password.</value>
        [DataMember(Name="can_change_password", EmitDefaultValue=false)]
        public bool? CanChangePassword { get; set; }

        /// <summary>
        /// The full name of the user. Might for example be first and last name
        /// </summary>
        /// <value>The full name of the user. Might for example be first and last name</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The email address of the user
        /// </summary>
        /// <value>The email address of the user</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Whether the has accepted the invite. Available when an invite is pending, and the value will be \&quot;true\&quot;.
        /// </summary>
        /// <value>Whether the has accepted the invite. Available when an invite is pending, and the value will be \&quot;true\&quot;.</value>
        [DataMember(Name="invite_pending", EmitDefaultValue=false)]
        public bool? InvitePending { get; set; }

        /// <summary>
        /// The unique name that is used to identify the user.
        /// </summary>
        /// <value>The unique name that is used to identify the user.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The Unique Device IDentifier of the device
        /// </summary>
        /// <value>The Unique Device IDentifier of the device</value>
        [DataMember(Name="udid", EmitDefaultValue=false)]
        public string Udid { get; set; }

        /// <summary>
        /// The model identifier of the device, in the format iDeviceM,N
        /// </summary>
        /// <value>The model identifier of the device, in the format iDeviceM,N</value>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public string Model { get; set; }

        /// <summary>
        /// The device description, in the format \&quot;iPhone 7 Plus (A1784)\&quot;
        /// </summary>
        /// <value>The device description, in the format \&quot;iPhone 7 Plus (A1784)\&quot;</value>
        [DataMember(Name="device_name", EmitDefaultValue=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// A combination of the device model name and the owner name.
        /// </summary>
        /// <value>A combination of the device model name and the owner name.</value>
        [DataMember(Name="full_device_name", EmitDefaultValue=false)]
        public string FullDeviceName { get; set; }

        /// <summary>
        /// The last known OS version running on the device
        /// </summary>
        /// <value>The last known OS version running on the device</value>
        [DataMember(Name="os_build", EmitDefaultValue=false)]
        public string OsBuild { get; set; }

        /// <summary>
        /// The last known OS version running on the device
        /// </summary>
        /// <value>The last known OS version running on the device</value>
        [DataMember(Name="os_version", EmitDefaultValue=false)]
        public string OsVersion { get; set; }

        /// <summary>
        /// The device&#x27;s serial number. Always empty or undefined at present.
        /// </summary>
        /// <value>The device&#x27;s serial number. Always empty or undefined at present.</value>
        [DataMember(Name="serial", EmitDefaultValue=false)]
        public string Serial { get; set; }

        /// <summary>
        /// The device&#x27;s International Mobile Equipment Identity number. Always empty or undefined at present.
        /// </summary>
        /// <value>The device&#x27;s International Mobile Equipment Identity number. Always empty or undefined at present.</value>
        [DataMember(Name="imei", EmitDefaultValue=false)]
        public string Imei { get; set; }

        /// <summary>
        /// The user ID of the device owner.
        /// </summary>
        /// <value>The user ID of the device owner.</value>
        [DataMember(Name="owner_id", EmitDefaultValue=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The provisioning status of the device.
        /// </summary>
        /// <value>The provisioning status of the device.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Timestamp of when the device was registered in ISO format.
        /// </summary>
        /// <value>Timestamp of when the device was registered in ISO format.</value>
        [DataMember(Name="registered_at", EmitDefaultValue=false)]
        public string RegisteredAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberDevicesInfoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  CanChangePassword: ").Append(CanChangePassword).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  InvitePending: ").Append(InvitePending).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Udid: ").Append(Udid).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  FullDeviceName: ").Append(FullDeviceName).Append("\n");
            sb.Append("  OsBuild: ").Append(OsBuild).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  Serial: ").Append(Serial).Append("\n");
            sb.Append("  Imei: ").Append(Imei).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  RegisteredAt: ").Append(RegisteredAt).Append("\n");
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
            return this.Equals(input as MemberDevicesInfoResponse);
        }

        /// <summary>
        /// Returns true if MemberDevicesInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MemberDevicesInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemberDevicesInfoResponse input)
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
                    this.AvatarUrl == input.AvatarUrl ||
                    (this.AvatarUrl != null &&
                    this.AvatarUrl.Equals(input.AvatarUrl))
                ) && 
                (
                    this.CanChangePassword == input.CanChangePassword ||
                    (this.CanChangePassword != null &&
                    this.CanChangePassword.Equals(input.CanChangePassword))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.InvitePending == input.InvitePending ||
                    (this.InvitePending != null &&
                    this.InvitePending.Equals(input.InvitePending))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Udid == input.Udid ||
                    (this.Udid != null &&
                    this.Udid.Equals(input.Udid))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.DeviceName == input.DeviceName ||
                    (this.DeviceName != null &&
                    this.DeviceName.Equals(input.DeviceName))
                ) && 
                (
                    this.FullDeviceName == input.FullDeviceName ||
                    (this.FullDeviceName != null &&
                    this.FullDeviceName.Equals(input.FullDeviceName))
                ) && 
                (
                    this.OsBuild == input.OsBuild ||
                    (this.OsBuild != null &&
                    this.OsBuild.Equals(input.OsBuild))
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    this.Serial == input.Serial ||
                    (this.Serial != null &&
                    this.Serial.Equals(input.Serial))
                ) && 
                (
                    this.Imei == input.Imei ||
                    (this.Imei != null &&
                    this.Imei.Equals(input.Imei))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.RegisteredAt == input.RegisteredAt ||
                    (this.RegisteredAt != null &&
                    this.RegisteredAt.Equals(input.RegisteredAt))
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
                if (this.AvatarUrl != null)
                    hashCode = hashCode * 59 + this.AvatarUrl.GetHashCode();
                if (this.CanChangePassword != null)
                    hashCode = hashCode * 59 + this.CanChangePassword.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.InvitePending != null)
                    hashCode = hashCode * 59 + this.InvitePending.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Udid != null)
                    hashCode = hashCode * 59 + this.Udid.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.DeviceName != null)
                    hashCode = hashCode * 59 + this.DeviceName.GetHashCode();
                if (this.FullDeviceName != null)
                    hashCode = hashCode * 59 + this.FullDeviceName.GetHashCode();
                if (this.OsBuild != null)
                    hashCode = hashCode * 59 + this.OsBuild.GetHashCode();
                if (this.OsVersion != null)
                    hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.Serial != null)
                    hashCode = hashCode * 59 + this.Serial.GetHashCode();
                if (this.Imei != null)
                    hashCode = hashCode * 59 + this.Imei.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RegisteredAt != null)
                    hashCode = hashCode * 59 + this.RegisteredAt.GetHashCode();
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