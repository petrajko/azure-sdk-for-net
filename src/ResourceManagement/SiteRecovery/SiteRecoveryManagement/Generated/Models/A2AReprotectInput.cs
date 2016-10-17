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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The Azure reprotect input.
    /// </summary>
    public partial class A2AReprotectInput : ReverseReplicationProviderSpecificInput
    {
        private string _policyId;
        
        /// <summary>
        /// Optional. ARM Id of the policy.
        /// </summary>
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }
        
        private string _recoveryAvailabilitySetId;
        
        /// <summary>
        /// Optional. Recovery availability set ARM Id.
        /// </summary>
        public string RecoveryAvailabilitySetId
        {
            get { return this._recoveryAvailabilitySetId; }
            set { this._recoveryAvailabilitySetId = value; }
        }
        
        private string _recoveryCloudServiceId;
        
        /// <summary>
        /// Optional. Recovery cloud service ARM Id.
        /// </summary>
        public string RecoveryCloudServiceId
        {
            get { return this._recoveryCloudServiceId; }
            set { this._recoveryCloudServiceId = value; }
        }
        
        private string _recoveryContainerId;
        
        /// <summary>
        /// Optional. Recovery container ARM Id.
        /// </summary>
        public string RecoveryContainerId
        {
            get { return this._recoveryContainerId; }
            set { this._recoveryContainerId = value; }
        }
        
        private string _recoveryResourceGroupId;
        
        /// <summary>
        /// Optional. Recovery resource group ARM Id.
        /// </summary>
        public string RecoveryResourceGroupId
        {
            get { return this._recoveryResourceGroupId; }
            set { this._recoveryResourceGroupId = value; }
        }
        
        private IList<A2AVmDiskInputDetails> _vmDisks;
        
        /// <summary>
        /// Optional. List of disk specific details.
        /// </summary>
        public IList<A2AVmDiskInputDetails> VmDisks
        {
            get { return this._vmDisks; }
            set { this._vmDisks = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the A2AReprotectInput class.
        /// </summary>
        public A2AReprotectInput()
        {
            this.VmDisks = new LazyList<A2AVmDiskInputDetails>();
        }
    }
}