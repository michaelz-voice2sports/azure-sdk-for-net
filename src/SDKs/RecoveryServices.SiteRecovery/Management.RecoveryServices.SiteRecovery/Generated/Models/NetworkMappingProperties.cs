// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Network Mapping Properties.
    /// </summary>
    public partial class NetworkMappingProperties
    {
        /// <summary>
        /// Initializes a new instance of the NetworkMappingProperties class.
        /// </summary>
        public NetworkMappingProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkMappingProperties class.
        /// </summary>
        /// <param name="state">The pairing state for network mapping.</param>
        /// <param name="primaryNetworkFriendlyName">The primary network
        /// friendly name.</param>
        /// <param name="primaryNetworkId">The primary network id for network
        /// mapping.</param>
        /// <param name="primaryFabricFriendlyName">The primary fabric friendly
        /// name.</param>
        /// <param name="recoveryNetworkFriendlyName">The recovery network
        /// friendly name.</param>
        /// <param name="recoveryNetworkId">The recovery network id for network
        /// mapping.</param>
        /// <param name="recoveryFabricArmId">The recovery fabric ARM
        /// id.</param>
        /// <param name="recoveryFabricFriendlyName">The recovery fabric
        /// friendly name.</param>
        /// <param name="fabricSpecificSettings">The fabric specific
        /// settings.</param>
        public NetworkMappingProperties(string state = default(string), string primaryNetworkFriendlyName = default(string), string primaryNetworkId = default(string), string primaryFabricFriendlyName = default(string), string recoveryNetworkFriendlyName = default(string), string recoveryNetworkId = default(string), string recoveryFabricArmId = default(string), string recoveryFabricFriendlyName = default(string), NetworkMappingFabricSpecificSettings fabricSpecificSettings = default(NetworkMappingFabricSpecificSettings))
        {
            State = state;
            PrimaryNetworkFriendlyName = primaryNetworkFriendlyName;
            PrimaryNetworkId = primaryNetworkId;
            PrimaryFabricFriendlyName = primaryFabricFriendlyName;
            RecoveryNetworkFriendlyName = recoveryNetworkFriendlyName;
            RecoveryNetworkId = recoveryNetworkId;
            RecoveryFabricArmId = recoveryFabricArmId;
            RecoveryFabricFriendlyName = recoveryFabricFriendlyName;
            FabricSpecificSettings = fabricSpecificSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the pairing state for network mapping.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the primary network friendly name.
        /// </summary>
        [JsonProperty(PropertyName = "primaryNetworkFriendlyName")]
        public string PrimaryNetworkFriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the primary network id for network mapping.
        /// </summary>
        [JsonProperty(PropertyName = "primaryNetworkId")]
        public string PrimaryNetworkId { get; set; }

        /// <summary>
        /// Gets or sets the primary fabric friendly name.
        /// </summary>
        [JsonProperty(PropertyName = "primaryFabricFriendlyName")]
        public string PrimaryFabricFriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the recovery network friendly name.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryNetworkFriendlyName")]
        public string RecoveryNetworkFriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the recovery network id for network mapping.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryNetworkId")]
        public string RecoveryNetworkId { get; set; }

        /// <summary>
        /// Gets or sets the recovery fabric ARM id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryFabricArmId")]
        public string RecoveryFabricArmId { get; set; }

        /// <summary>
        /// Gets or sets the recovery fabric friendly name.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryFabricFriendlyName")]
        public string RecoveryFabricFriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the fabric specific settings.
        /// </summary>
        [JsonProperty(PropertyName = "fabricSpecificSettings")]
        public NetworkMappingFabricSpecificSettings FabricSpecificSettings { get; set; }

    }
}
