// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ServiceFabric_2016_09_01
    {
        private const string ProviderNamespace = "Microsoft.ServiceFabric";
        private const string ApiVersion = "2016-09-01";
        private static readonly ResourceTypeReference ResourceTypeReference_clusters = new ResourceTypeReference(ProviderNamespace, new[]{"clusters"}, ApiVersion);
        private static Lazy<Microsoft_ServiceFabric_2016_09_01> InstanceLazy = new Lazy<Microsoft_ServiceFabric_2016_09_01>(() => new Microsoft_ServiceFabric_2016_09_01());
        private Microsoft_ServiceFabric_2016_09_01()
        {
            ClusterProperties = new NamedObjectType("ClusterProperties", new ITypeProperty[]{new TypeProperty("clusterCodeVersion", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("certificate", () => CertificateDescription, TypePropertyFlags.None), new TypeProperty("reliabilityLevel", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("upgradeMode", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("clientCertificateThumbprints", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("clientCertificateCommonNames", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("fabricSettings", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("reverseProxyCertificate", () => CertificateDescription, TypePropertyFlags.None), new TypeProperty("managementEndpoint", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("nodeTypes", LanguageConstants.Array, TypePropertyFlags.Required), new LazyTypeProperty("azureActiveDirectory", () => AzureActiveDirectory, TypePropertyFlags.None), new TypeProperty("vmImage", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("diagnosticsStorageAccountConfig", () => DiagnosticsStorageAccountConfig, TypePropertyFlags.None), new LazyTypeProperty("upgradeDescription", () => ClusterUpgradePolicy, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            CertificateDescription = new NamedObjectType("CertificateDescription", new ITypeProperty[]{new TypeProperty("thumbprint", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("thumbprintSecondary", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("x509StoreName", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ClientCertificateThumbprint = new NamedObjectType("ClientCertificateThumbprint", new ITypeProperty[]{new TypeProperty("isAdmin", LanguageConstants.Bool, TypePropertyFlags.Required), new TypeProperty("certificateThumbprint", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ClientCertificateCommonName = new NamedObjectType("ClientCertificateCommonName", new ITypeProperty[]{new TypeProperty("isAdmin", LanguageConstants.Bool, TypePropertyFlags.Required), new TypeProperty("certificateCommonName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("certificateIssuerThumbprint", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SettingsSectionDescription = new NamedObjectType("SettingsSectionDescription", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("parameters", LanguageConstants.Array, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SettingsParameterDescription = new NamedObjectType("SettingsParameterDescription", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            NodeTypeDescription = new NamedObjectType("NodeTypeDescription", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("placementProperties", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("capacities", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("clientConnectionEndpointPort", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("httpGatewayEndpointPort", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("durabilityLevel", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("applicationPorts", () => EndpointRangeDescription, TypePropertyFlags.None), new LazyTypeProperty("ephemeralPorts", () => EndpointRangeDescription, TypePropertyFlags.None), new TypeProperty("isPrimary", LanguageConstants.Bool, TypePropertyFlags.Required), new TypeProperty("vmInstanceCount", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("reverseProxyEndpointPort", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            EndpointRangeDescription = new NamedObjectType("EndpointRangeDescription", new ITypeProperty[]{new TypeProperty("startPort", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("endPort", LanguageConstants.Int, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            AzureActiveDirectory = new NamedObjectType("AzureActiveDirectory", new ITypeProperty[]{new TypeProperty("tenantId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("clusterApplication", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("clientApplication", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DiagnosticsStorageAccountConfig = new NamedObjectType("DiagnosticsStorageAccountConfig", new ITypeProperty[]{new TypeProperty("storageAccountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("protectedAccountKeyName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("blobEndpoint", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("queueEndpoint", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tableEndpoint", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ClusterUpgradePolicy = new NamedObjectType("ClusterUpgradePolicy", new ITypeProperty[]{new TypeProperty("overrideUserUpgradePolicy", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("forceRestart", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("upgradeReplicaSetCheckTimeout", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("healthCheckWaitDuration", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("healthCheckStableDuration", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("healthCheckRetryTimeout", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("upgradeTimeout", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("upgradeDomainTimeout", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("healthPolicy", () => ClusterHealthPolicy, TypePropertyFlags.Required), new LazyTypeProperty("deltaHealthPolicy", () => ClusterUpgradeDeltaHealthPolicy, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ClusterHealthPolicy = new NamedObjectType("ClusterHealthPolicy", new ITypeProperty[]{new TypeProperty("maxPercentUnhealthyNodes", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("maxPercentUnhealthyApplications", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ClusterUpgradeDeltaHealthPolicy = new NamedObjectType("ClusterUpgradeDeltaHealthPolicy", new ITypeProperty[]{new TypeProperty("maxPercentDeltaUnhealthyNodes", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("maxPercentUpgradeDomainDeltaUnhealthyNodes", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("maxPercentDeltaUnhealthyApplications", LanguageConstants.Int, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceType_clusters = new ResourceType("Microsoft.ServiceFabric/clusters", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ClusterProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_clusters);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_clusters, () => InstanceLazy.Value.ResourceType_clusters);
        }
        private readonly ResourceType ResourceType_clusters;
        private readonly TypeSymbol ClusterProperties;
        private readonly TypeSymbol CertificateDescription;
        private readonly TypeSymbol ClientCertificateThumbprint;
        private readonly TypeSymbol ClientCertificateCommonName;
        private readonly TypeSymbol SettingsSectionDescription;
        private readonly TypeSymbol SettingsParameterDescription;
        private readonly TypeSymbol NodeTypeDescription;
        private readonly TypeSymbol EndpointRangeDescription;
        private readonly TypeSymbol AzureActiveDirectory;
        private readonly TypeSymbol DiagnosticsStorageAccountConfig;
        private readonly TypeSymbol ClusterUpgradePolicy;
        private readonly TypeSymbol ClusterHealthPolicy;
        private readonly TypeSymbol ClusterUpgradeDeltaHealthPolicy;
    }
}
