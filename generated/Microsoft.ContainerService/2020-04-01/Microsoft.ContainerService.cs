// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerService_2020_04_01
    {
        private const string ProviderNamespace = "Microsoft.ContainerService";
        private const string ApiVersion = "2020-04-01";
        private static readonly ResourceTypeReference ResourceTypeReference_managedClusters = new ResourceTypeReference(ProviderNamespace, new[]{"managedClusters"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_managedClusters_agentPools = new ResourceTypeReference(ProviderNamespace, new[]{"managedClusters", "agentPools"}, ApiVersion);
        private static Lazy<Microsoft_ContainerService_2020_04_01> InstanceLazy = new Lazy<Microsoft_ContainerService_2020_04_01>(() => new Microsoft_ContainerService_2020_04_01());
        private Microsoft_ContainerService_2020_04_01()
        {
            ManagedClusterProperties = new NamedObjectType("ManagedClusterProperties", new ITypeProperty[]{new TypeProperty("kubernetesVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("dnsPrefix", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("agentPoolProfiles", new TypedArrayType(new NamedObjectType("agentPoolProfiles", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("linuxProfile", () => ContainerServiceLinuxProfile, TypePropertyFlags.None), new LazyTypeProperty("windowsProfile", () => ManagedClusterWindowsProfile, TypePropertyFlags.None), new LazyTypeProperty("servicePrincipalProfile", () => ManagedClusterServicePrincipalProfile, TypePropertyFlags.None), new TypeProperty("addonProfiles", new NamedObjectType("addonProfiles", new ITypeProperty[]{}, new NamedObjectType("additionalProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None), TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("nodeResourceGroup", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("enableRBAC", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enablePodSecurityPolicy", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("networkProfile", () => ContainerServiceNetworkProfile, TypePropertyFlags.None), new LazyTypeProperty("aadProfile", () => ManagedClusterAADProfile, TypePropertyFlags.None), new LazyTypeProperty("autoScalerProfile", () => ManagedClusterPropertiesAutoScalerProfile, TypePropertyFlags.None), new LazyTypeProperty("apiServerAccessProfile", () => ManagedClusterAPIServerAccessProfile, TypePropertyFlags.None), new TypeProperty("diskEncryptionSetID", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("identityProfile", new NamedObjectType("identityProfile", new ITypeProperty[]{}, new NamedObjectType("additionalProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None), TypePropertyFlags.None), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ManagedClusterAgentPoolProfile = new NamedObjectType("ManagedClusterAgentPoolProfile", new ITypeProperty[]{new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("vmSize", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("osDiskSizeGB", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("vnetSubnetID", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("maxPods", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("osType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("maxCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("minCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("enableAutoScaling", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("mode", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("orchestratorVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("nodeImageVersion", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("upgradeSettings", () => AgentPoolUpgradeSettings, TypePropertyFlags.None), new TypeProperty("availabilityZones", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("enableNodePublicIP", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("scaleSetPriority", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scaleSetEvictionPolicy", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("spotMaxPrice", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("nodeLabels", new NamedObjectType("nodeLabels", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("nodeTaints", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            AgentPoolUpgradeSettings = new NamedObjectType("AgentPoolUpgradeSettings", new ITypeProperty[]{new TypeProperty("maxSurge", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerServiceLinuxProfile = new NamedObjectType("ContainerServiceLinuxProfile", new ITypeProperty[]{new TypeProperty("adminUsername", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("ssh", () => ContainerServiceSshConfiguration, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ContainerServiceSshConfiguration = new NamedObjectType("ContainerServiceSshConfiguration", new ITypeProperty[]{new TypeProperty("publicKeys", new TypedArrayType(new NamedObjectType("publicKeys", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ContainerServiceSshPublicKey = new NamedObjectType("ContainerServiceSshPublicKey", new ITypeProperty[]{new TypeProperty("keyData", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ManagedClusterWindowsProfile = new NamedObjectType("ManagedClusterWindowsProfile", new ITypeProperty[]{new TypeProperty("adminUsername", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("adminPassword", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ManagedClusterServicePrincipalProfile = new NamedObjectType("ManagedClusterServicePrincipalProfile", new ITypeProperty[]{new TypeProperty("clientId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("secret", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ManagedClusterAddonProfile = new NamedObjectType("ManagedClusterAddonProfile", new ITypeProperty[]{new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.Required), new TypeProperty("config", new NamedObjectType("config", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerServiceNetworkProfile = new NamedObjectType("ContainerServiceNetworkProfile", new ITypeProperty[]{new TypeProperty("networkPlugin", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("networkPolicy", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("networkMode", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("podCidr", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serviceCidr", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("dnsServiceIP", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("dockerBridgeCidr", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("outboundType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("loadBalancerSku", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("loadBalancerProfile", () => ManagedClusterLoadBalancerProfile, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ManagedClusterLoadBalancerProfile = new NamedObjectType("ManagedClusterLoadBalancerProfile", new ITypeProperty[]{new LazyTypeProperty("managedOutboundIPs", () => ManagedClusterLoadBalancerProfileManagedOutboundIPs, TypePropertyFlags.None), new LazyTypeProperty("outboundIPPrefixes", () => ManagedClusterLoadBalancerProfileOutboundIPPrefixes, TypePropertyFlags.None), new LazyTypeProperty("outboundIPs", () => ManagedClusterLoadBalancerProfileOutboundIPs, TypePropertyFlags.None), new TypeProperty("effectiveOutboundIPs", new TypedArrayType(new NamedObjectType("effectiveOutboundIPs", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("allocatedOutboundPorts", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("idleTimeoutInMinutes", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ManagedClusterLoadBalancerProfileManagedOutboundIPs = new NamedObjectType("ManagedClusterLoadBalancerProfileManagedOutboundIPs", new ITypeProperty[]{new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ManagedClusterLoadBalancerProfileOutboundIPPrefixes = new NamedObjectType("ManagedClusterLoadBalancerProfileOutboundIPPrefixes", new ITypeProperty[]{new TypeProperty("publicIPPrefixes", new TypedArrayType(new NamedObjectType("publicIPPrefixes", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceReference = new NamedObjectType("ResourceReference", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ManagedClusterLoadBalancerProfileOutboundIPs = new NamedObjectType("ManagedClusterLoadBalancerProfileOutboundIPs", new ITypeProperty[]{new TypeProperty("publicIPs", new TypedArrayType(new NamedObjectType("publicIPs", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ManagedClusterAADProfile = new NamedObjectType("ManagedClusterAADProfile", new ITypeProperty[]{new TypeProperty("managed", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("adminGroupObjectIDs", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("clientAppID", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serverAppID", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serverAppSecret", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tenantID", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ManagedClusterPropertiesAutoScalerProfile = new NamedObjectType("ManagedClusterPropertiesAutoScalerProfile", new ITypeProperty[]{new TypeProperty("balance-similar-node-groups", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scan-interval", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scale-down-delay-after-add", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scale-down-delay-after-delete", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scale-down-delay-after-failure", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scale-down-unneeded-time", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scale-down-unready-time", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scale-down-utilization-threshold", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("max-graceful-termination-sec", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ManagedClusterAPIServerAccessProfile = new NamedObjectType("ManagedClusterAPIServerAccessProfile", new ITypeProperty[]{new TypeProperty("authorizedIPRanges", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("enablePrivateCluster", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Componentsqit0etschemasmanagedclusterpropertiespropertiesidentityprofileadditionalproperties = new NamedObjectType("Componentsqit0etschemasmanagedclusterpropertiespropertiesidentityprofileadditionalproperties", new ITypeProperty[]{new TypeProperty("resourceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("clientId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("objectId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ManagedClusterIdentity = new NamedObjectType("ManagedClusterIdentity", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ManagedClusterSKU = new NamedObjectType("ManagedClusterSKU", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tier", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ManagedClusterAgentPoolProfileProperties = new NamedObjectType("ManagedClusterAgentPoolProfileProperties", new ITypeProperty[]{new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("vmSize", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("osDiskSizeGB", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("vnetSubnetID", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("maxPods", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("osType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("maxCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("minCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("enableAutoScaling", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("mode", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("orchestratorVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("nodeImageVersion", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("upgradeSettings", () => AgentPoolUpgradeSettings, TypePropertyFlags.None), new TypeProperty("availabilityZones", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("enableNodePublicIP", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("scaleSetPriority", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scaleSetEvictionPolicy", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("spotMaxPrice", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("nodeLabels", new NamedObjectType("nodeLabels", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("nodeTaints", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_managedClusters = new ResourceType("Microsoft.ContainerService/managedClusters", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("properties", () => ManagedClusterProperties, TypePropertyFlags.Required), new LazyTypeProperty("identity", () => ManagedClusterIdentity, TypePropertyFlags.None), new LazyTypeProperty("sku", () => ManagedClusterSKU, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_managedClusters);
            ResourceType_managedClusters_agentPools = new ResourceType("Microsoft.ContainerService/managedClusters/agentPools", new ITypeProperty[]{new LazyTypeProperty("properties", () => ManagedClusterAgentPoolProfileProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_managedClusters_agentPools);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_managedClusters, () => InstanceLazy.Value.ResourceType_managedClusters);
            registrar.RegisterType(ResourceTypeReference_managedClusters_agentPools, () => InstanceLazy.Value.ResourceType_managedClusters_agentPools);
        }
        private readonly ResourceType ResourceType_managedClusters;
        private readonly ResourceType ResourceType_managedClusters_agentPools;
        private readonly TypeSymbol ManagedClusterProperties;
        private readonly TypeSymbol ManagedClusterAgentPoolProfile;
        private readonly TypeSymbol AgentPoolUpgradeSettings;
        private readonly TypeSymbol ContainerServiceLinuxProfile;
        private readonly TypeSymbol ContainerServiceSshConfiguration;
        private readonly TypeSymbol ContainerServiceSshPublicKey;
        private readonly TypeSymbol ManagedClusterWindowsProfile;
        private readonly TypeSymbol ManagedClusterServicePrincipalProfile;
        private readonly TypeSymbol ManagedClusterAddonProfile;
        private readonly TypeSymbol ContainerServiceNetworkProfile;
        private readonly TypeSymbol ManagedClusterLoadBalancerProfile;
        private readonly TypeSymbol ManagedClusterLoadBalancerProfileManagedOutboundIPs;
        private readonly TypeSymbol ManagedClusterLoadBalancerProfileOutboundIPPrefixes;
        private readonly TypeSymbol ResourceReference;
        private readonly TypeSymbol ManagedClusterLoadBalancerProfileOutboundIPs;
        private readonly TypeSymbol ManagedClusterAADProfile;
        private readonly TypeSymbol ManagedClusterPropertiesAutoScalerProfile;
        private readonly TypeSymbol ManagedClusterAPIServerAccessProfile;
        private readonly TypeSymbol Componentsqit0etschemasmanagedclusterpropertiespropertiesidentityprofileadditionalproperties;
        private readonly TypeSymbol ManagedClusterIdentity;
        private readonly TypeSymbol ManagedClusterSKU;
        private readonly TypeSymbol ManagedClusterAgentPoolProfileProperties;
    }
}
