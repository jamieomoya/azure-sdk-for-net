// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Fabric.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Representation of a drive resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Drive : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Drive class.
        /// </summary>
        public Drive()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Drive class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">The region where the resource is
        /// located.</param>
        /// <param name="tags">List of key-value pairs.</param>
        /// <param name="storageNode">Node that the drive is physically
        /// connected.</param>
        /// <param name="serialNumber">Serial number of the drive.</param>
        /// <param name="healthStatus">Health status of the drive.</param>
        /// <param name="operationalStatus">Operational status of the
        /// drive.</param>
        /// <param name="usage">Intended usage of the drive.</param>
        /// <param name="canPool">Indicate whether the drive can be added to
        /// the pool.</param>
        /// <param name="cannotPoolReason">Specify the reasons why the drive
        /// cannot be added to the pool.</param>
        /// <param name="physicalLocation">Indicate where the hardware is
        /// located.</param>
        /// <param name="model">Model of the drive.</param>
        /// <param name="mediaType">Media type of the drive.</param>
        /// <param name="capacityGB">Total capacity in GB of the drive.</param>
        /// <param name="description">Detailed description for
        /// HealthStatus/OperationalStatus. Empty if
        /// HealthStatus/OperationalStatus is Healthy/Ok.</param>
        /// <param name="action">Detailed recommended action for
        /// HealthStatus/OperationalStatus. Empty if
        /// HealthStatus/OperationalStatus is Healthy/Ok.</param>
        public Drive(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string storageNode = default(string), string serialNumber = default(string), string healthStatus = default(string), string operationalStatus = default(string), string usage = default(string), bool? canPool = default(bool?), string cannotPoolReason = default(string), string physicalLocation = default(string), string model = default(string), string mediaType = default(string), int? capacityGB = default(int?), string description = default(string), string action = default(string))
            : base(id, name, type, location, tags)
        {
            StorageNode = storageNode;
            SerialNumber = serialNumber;
            HealthStatus = healthStatus;
            OperationalStatus = operationalStatus;
            Usage = usage;
            CanPool = canPool;
            CannotPoolReason = cannotPoolReason;
            PhysicalLocation = physicalLocation;
            Model = model;
            MediaType = mediaType;
            CapacityGB = capacityGB;
            Description = description;
            Action = action;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets node that the drive is physically connected.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageNode")]
        public string StorageNode { get; set; }

        /// <summary>
        /// Gets or sets serial number of the drive.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or sets health status of the drive.
        /// </summary>
        [JsonProperty(PropertyName = "properties.healthStatus")]
        public string HealthStatus { get; set; }

        /// <summary>
        /// Gets or sets operational status of the drive.
        /// </summary>
        [JsonProperty(PropertyName = "properties.operationalStatus")]
        public string OperationalStatus { get; set; }

        /// <summary>
        /// Gets or sets intended usage of the drive.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usage")]
        public string Usage { get; set; }

        /// <summary>
        /// Gets or sets indicate whether the drive can be added to the pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.canPool")]
        public bool? CanPool { get; set; }

        /// <summary>
        /// Gets or sets specify the reasons why the drive cannot be added to
        /// the pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cannotPoolReason")]
        public string CannotPoolReason { get; set; }

        /// <summary>
        /// Gets or sets indicate where the hardware is located.
        /// </summary>
        [JsonProperty(PropertyName = "properties.physicalLocation")]
        public string PhysicalLocation { get; set; }

        /// <summary>
        /// Gets or sets model of the drive.
        /// </summary>
        [JsonProperty(PropertyName = "properties.model")]
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets media type of the drive.
        /// </summary>
        [JsonProperty(PropertyName = "properties.mediaType")]
        public string MediaType { get; set; }

        /// <summary>
        /// Gets or sets total capacity in GB of the drive.
        /// </summary>
        [JsonProperty(PropertyName = "properties.capacityGB")]
        public int? CapacityGB { get; set; }

        /// <summary>
        /// Gets or sets detailed description for
        /// HealthStatus/OperationalStatus. Empty if
        /// HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets detailed recommended action for
        /// HealthStatus/OperationalStatus. Empty if
        /// HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        [JsonProperty(PropertyName = "properties.action")]
        public string Action { get; set; }

    }
}
