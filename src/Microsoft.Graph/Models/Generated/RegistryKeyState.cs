// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type RegistryKeyState.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class RegistryKeyState
    {

        /// <summary>
        /// Gets or sets hive.
        /// A Windows registry hive : HKEY_CURRENT_CONFIG HKEY_CURRENT_USER HKEY_LOCAL_MACHINE/SAM HKEY_LOCAL_MACHINE/Security HKEY_LOCAL_MACHINE/Software HKEY_LOCAL_MACHINE/System HKEY_USERS/.Default. Possible values are: unknown, currentConfig, currentUser, localMachineSam, localMachineSecurity, localMachineSoftware, localMachineSystem, usersDefault.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hive", Required = Newtonsoft.Json.Required.Default)]
        public RegistryHive? Hive { get; set; }
    
        /// <summary>
        /// Gets or sets key.
        /// Current (i.e. changed) registry key (excludes HIVE).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "key", Required = Newtonsoft.Json.Required.Default)]
        public string Key { get; set; }
    
        /// <summary>
        /// Gets or sets oldKey.
        /// Previous (i.e. before changed) registry key (excludes HIVE).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "oldKey", Required = Newtonsoft.Json.Required.Default)]
        public string OldKey { get; set; }
    
        /// <summary>
        /// Gets or sets oldValueData.
        /// Previous (i.e. before changed) registry key value data (contents).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "oldValueData", Required = Newtonsoft.Json.Required.Default)]
        public string OldValueData { get; set; }
    
        /// <summary>
        /// Gets or sets oldValueName.
        /// Previous (i.e. before changed) registry key value name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "oldValueName", Required = Newtonsoft.Json.Required.Default)]
        public string OldValueName { get; set; }
    
        /// <summary>
        /// Gets or sets operation.
        /// Operation that changed the registry key name and/or value. Possible values are: unknown, create, modify, delete.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operation", Required = Newtonsoft.Json.Required.Default)]
        public RegistryOperation? Operation { get; set; }
    
        /// <summary>
        /// Gets or sets processId.
        /// Process ID (PID) of the process that modified the registry key (process details will appear in the alert 'processes' collection).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processId", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ProcessId { get; set; }
    
        /// <summary>
        /// Gets or sets valueData.
        /// Current (i.e. changed) registry key value data (contents).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "valueData", Required = Newtonsoft.Json.Required.Default)]
        public string ValueData { get; set; }
    
        /// <summary>
        /// Gets or sets valueName.
        /// Current (i.e. changed) registry key value name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "valueName", Required = Newtonsoft.Json.Required.Default)]
        public string ValueName { get; set; }
    
        /// <summary>
        /// Gets or sets valueType.
        /// Registry key value type REG_BINARY REG_DWORD REG_DWORD_LITTLE_ENDIAN REG_DWORD_BIG_ENDIANREG_EXPAND_SZ REG_LINK REG_MULTI_SZ REG_NONE REG_QWORD REG_QWORD_LITTLE_ENDIAN REG_SZ Possible values are: unknown, binary, dword, dwordLittleEndian, dwordBigEndian, expandSz, link, multiSz, none, qword, qwordlittleEndian, sz.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "valueType", Required = Newtonsoft.Json.Required.Default)]
        public RegistryValueType? ValueType { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
