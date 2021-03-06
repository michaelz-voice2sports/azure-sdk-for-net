// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Intune.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Application entity for Intune MAM.
    /// </summary>
    public partial class Application : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Application class.
        /// </summary>
        public Application() { }

        /// <summary>
        /// Initializes a new instance of the Application class.
        /// </summary>
        public Application(string friendlyName, string platform, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string location = default(string), string appId = default(string))
            : base(id, name, type, tags, location)
        {
            FriendlyName = friendlyName;
            Platform = platform;
            AppId = appId;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Possible values for this property include: 'ios', 'android',
        /// 'windows'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.platform")]
        public string Platform { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (FriendlyName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FriendlyName");
            }
            if (Platform == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Platform");
            }
        }
    }
}
