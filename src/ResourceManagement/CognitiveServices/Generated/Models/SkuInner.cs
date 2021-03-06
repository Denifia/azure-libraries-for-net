// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CognitiveServices;
    using Microsoft.Azure.Management.CognitiveServices.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The SKU of the cognitive services account.
    /// </summary>
    public partial class SkuInner
    {
        /// <summary>
        /// Initializes a new instance of the SkuInner class.
        /// </summary>
        public SkuInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SkuInner class.
        /// </summary>
        /// <param name="name">Gets or sets the sku name. Required for account
        /// creation, optional for update. Possible values include: 'F0', 'P0',
        /// 'P1', 'P2', 'S0', 'S1', 'S2', 'S3', 'S4', 'S5', 'S6'</param>
        /// <param name="tier">Gets the sku tier. This is based on the SKU
        /// name. Possible values include: 'Free', 'Standard',
        /// 'Premium'</param>
        public SkuInner(string name, SkuTier? tier = default(SkuTier?))
        {
            Name = name;
            Tier = tier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the sku name. Required for account creation, optional
        /// for update. Possible values include: 'F0', 'P0', 'P1', 'P2', 'S0',
        /// 'S1', 'S2', 'S3', 'S4', 'S5', 'S6'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the sku tier. This is based on the SKU name. Possible values
        /// include: 'Free', 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public SkuTier? Tier { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
