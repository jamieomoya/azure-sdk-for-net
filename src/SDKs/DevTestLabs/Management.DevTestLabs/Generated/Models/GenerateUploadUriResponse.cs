// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Reponse body for generating an upload URI.
    /// </summary>
    public partial class GenerateUploadUriResponse
    {
        /// <summary>
        /// Initializes a new instance of the GenerateUploadUriResponse class.
        /// </summary>
        public GenerateUploadUriResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GenerateUploadUriResponse class.
        /// </summary>
        /// <param name="uploadUri">The upload URI for the VHD.</param>
        public GenerateUploadUriResponse(string uploadUri = default(string))
        {
            UploadUri = uploadUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the upload URI for the VHD.
        /// </summary>
        [JsonProperty(PropertyName = "uploadUri")]
        public string UploadUri { get; set; }

    }
}
