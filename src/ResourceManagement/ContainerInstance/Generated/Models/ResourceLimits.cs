// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerInstance.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The resource limits.
    /// </summary>
    public partial class ResourceLimits
    {
        /// <summary>
        /// Initializes a new instance of the ResourceLimits class.
        /// </summary>
        public ResourceLimits()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceLimits class.
        /// </summary>
        /// <param name="memoryInGB">The memory limit in GB of this container
        /// instance.</param>
        /// <param name="cpu">The CPU limit of this container instance.</param>
        public ResourceLimits(double? memoryInGB = default(double?), double? cpu = default(double?))
        {
            MemoryInGB = memoryInGB;
            Cpu = cpu;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the memory limit in GB of this container instance.
        /// </summary>
        [JsonProperty(PropertyName = "memoryInGB")]
        public double? MemoryInGB { get; set; }

        /// <summary>
        /// Gets or sets the CPU limit of this container instance.
        /// </summary>
        [JsonProperty(PropertyName = "cpu")]
        public double? Cpu { get; set; }

    }
}
