// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Subscriptions.Models
{
    /// <summary>
    /// Subscription policy information.
    /// </summary>
    public partial class SubscriptionPolicies
    {
        private string _locationPlacementId;
        
        /// <summary>
        /// Optional. Gets or sets the subscription location placement Id.
        /// </summary>
        public string LocationPlacementId
        {
            get { return this._locationPlacementId; }
            set { this._locationPlacementId = value; }
        }
        
        private string _quotaId;
        
        /// <summary>
        /// Optional. Gets or sets the subscription quota Id.
        /// </summary>
        public string QuotaId
        {
            get { return this._quotaId; }
            set { this._quotaId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SubscriptionPolicies class.
        /// </summary>
        public SubscriptionPolicies()
        {
        }
    }
}