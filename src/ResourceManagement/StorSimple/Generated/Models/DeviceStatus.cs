// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DeviceStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeviceStatus
    {
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "Online")]
        Online,
        [EnumMember(Value = "Offline")]
        Offline,
        [EnumMember(Value = "Deactivated")]
        Deactivated,
        [EnumMember(Value = "RequiresAttention")]
        RequiresAttention,
        [EnumMember(Value = "MaintenanceMode")]
        MaintenanceMode,
        [EnumMember(Value = "Creating")]
        Creating,
        [EnumMember(Value = "Provisioning")]
        Provisioning,
        [EnumMember(Value = "Deactivating")]
        Deactivating,
        [EnumMember(Value = "Deleted")]
        Deleted,
        [EnumMember(Value = "ReadyToSetup")]
        ReadyToSetup
    }
    internal static class DeviceStatusEnumExtension
    {
        internal static string ToSerializedValue(this DeviceStatus? value)
        {
            return value == null ? null : ((DeviceStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DeviceStatus value)
        {
            switch( value )
            {
                case DeviceStatus.Unknown:
                    return "Unknown";
                case DeviceStatus.Online:
                    return "Online";
                case DeviceStatus.Offline:
                    return "Offline";
                case DeviceStatus.Deactivated:
                    return "Deactivated";
                case DeviceStatus.RequiresAttention:
                    return "RequiresAttention";
                case DeviceStatus.MaintenanceMode:
                    return "MaintenanceMode";
                case DeviceStatus.Creating:
                    return "Creating";
                case DeviceStatus.Provisioning:
                    return "Provisioning";
                case DeviceStatus.Deactivating:
                    return "Deactivating";
                case DeviceStatus.Deleted:
                    return "Deleted";
                case DeviceStatus.ReadyToSetup:
                    return "ReadyToSetup";
            }
            return null;
        }

        internal static DeviceStatus? ParseDeviceStatus(this string value)
        {
            switch( value )
            {
                case "Unknown":
                    return DeviceStatus.Unknown;
                case "Online":
                    return DeviceStatus.Online;
                case "Offline":
                    return DeviceStatus.Offline;
                case "Deactivated":
                    return DeviceStatus.Deactivated;
                case "RequiresAttention":
                    return DeviceStatus.RequiresAttention;
                case "MaintenanceMode":
                    return DeviceStatus.MaintenanceMode;
                case "Creating":
                    return DeviceStatus.Creating;
                case "Provisioning":
                    return DeviceStatus.Provisioning;
                case "Deactivating":
                    return DeviceStatus.Deactivating;
                case "Deleted":
                    return DeviceStatus.Deleted;
                case "ReadyToSetup":
                    return DeviceStatus.ReadyToSetup;
            }
            return null;
        }
    }
}
