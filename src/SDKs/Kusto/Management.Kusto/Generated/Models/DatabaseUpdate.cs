// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Class representing an update to a Kusto database.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DatabaseUpdate : Resource
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseUpdate class.
        /// </summary>
        public DatabaseUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatabaseUpdate class.
        /// </summary>
        /// <param name="softDeletePeriodInDays">The number of days data should
        /// be kept before it stops being accessible to queries.</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="etag">An ETag of the resource updated.</param>
        /// <param name="provisioningState">The provisioned state of the
        /// resource. Possible values include: 'Running', 'Creating',
        /// 'Deleting', 'Succeeded', 'Failed'</param>
        /// <param name="hotCachePeriodInDays">The number of days of data that
        /// should be kept in cache for fast queries.</param>
        /// <param name="statistics">The statistics of the database.</param>
        public DatabaseUpdate(int softDeletePeriodInDays, string id = default(string), string name = default(string), string type = default(string), string location = default(string), string etag = default(string), string provisioningState = default(string), int? hotCachePeriodInDays = default(int?), DatabaseStatistics statistics = default(DatabaseStatistics))
            : base(id, name, type)
        {
            Location = location;
            Etag = etag;
            ProvisioningState = provisioningState;
            SoftDeletePeriodInDays = softDeletePeriodInDays;
            HotCachePeriodInDays = hotCachePeriodInDays;
            Statistics = statistics;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets an ETag of the resource updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets the provisioned state of the resource. Possible values
        /// include: 'Running', 'Creating', 'Deleting', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the number of days data should be kept before it stops
        /// being accessible to queries.
        /// </summary>
        [JsonProperty(PropertyName = "properties.softDeletePeriodInDays")]
        public int SoftDeletePeriodInDays { get; set; }

        /// <summary>
        /// Gets or sets the number of days of data that should be kept in
        /// cache for fast queries.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hotCachePeriodInDays")]
        public int? HotCachePeriodInDays { get; set; }

        /// <summary>
        /// Gets or sets the statistics of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.statistics")]
        public DatabaseStatistics Statistics { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
