// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayFrontend.UpdateDefinition
{
    using Microsoft.Azure.Management.Network.Fluent;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.HasSubnet.UpdateDefinition;
    using Microsoft.Azure.Management.Network.Fluent.HasPrivateIPAddress.UpdateDefinition;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResourceActions;
    using Microsoft.Azure.Management.Network.Fluent.HasPublicIPAddress.UpdateDefinition;

    /// <summary>
    /// The entirety of an application gateway frontend definition as part of an application gateway update.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the parent application gateway definition to return to after attaching this definition.</typeparam>
    public interface IUpdateDefinition<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayFrontend.UpdateDefinition.IBlank<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayFrontend.UpdateDefinition.IWithAttach<ParentT>
    {
    }

    /// <summary>
    /// The stage of an application gateway frontend definition allowing to specify a subnet from the selected network to make this
    /// application gateway visible to.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the parent application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithSubnet<ParentT> :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.HasSubnet.UpdateDefinition.IWithSubnet<Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayFrontend.UpdateDefinition.IWithAttach<ParentT>>
    {
        /// <summary>
        /// Assigns the specified subnet to this private frontend.
        /// </summary>
        /// <param name="network">The virtual network the subnet exists in.</param>
        /// <param name="subnetName">The name of a subnet.</param>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayFrontend.UpdateDefinition.IWithAttach<ParentT> WithExistingSubnet(INetwork network, string subnetName);
    }

    /// <summary>
    /// The first stage of an application gateway frontend definition.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the parent application gateway definition to return to after attaching this definition.</typeparam>
    public interface IBlank<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayFrontend.UpdateDefinition.IWithSubnet<ParentT>
    {
    }

    /// <summary>
    /// The stage of an application gateway frontend definition allowing to specify the private IP address this application gateway
    /// should be available at within the selected virtual network.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the parent application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithPrivateIP<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.HasPrivateIPAddress.UpdateDefinition.IWithPrivateIPAddress<Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayFrontend.UpdateDefinition.IWithAttach<ParentT>>
    {
    }

    /// <summary>
    /// The final stage of an application gateway frontend definition.
    /// At this stage, any remaining optional settings can be specified, or the frontend definition
    /// can be attached to the parent application gateway definition.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the parent application gateway definition to return to after attaching this definition.</typeparam>
    public interface IWithAttach<ParentT> :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResourceActions.IInUpdateAlt<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayFrontend.UpdateDefinition.IWithPublicIPAddress<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayFrontend.UpdateDefinition.IWithSubnet<ParentT>,
        Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayFrontend.UpdateDefinition.IWithPrivateIP<ParentT>
    {
    }

    /// <summary>
    /// The stage of an application gateway frontend definition allowing to specify an existing public IP address to make
    /// the application gateway available at as Internet-facing.
    /// </summary>
    /// <typeparam name="ParentT">The stage of the parent definition to return to after attaching this definition.</typeparam>
    public interface IWithPublicIPAddress<ParentT> :
        Microsoft.Azure.Management.Network.Fluent.HasPublicIPAddress.UpdateDefinition.IWithExistingPublicIPAddress<Microsoft.Azure.Management.Network.Fluent.ApplicationGatewayFrontend.UpdateDefinition.IWithAttach<ParentT>>
    {
    }
}