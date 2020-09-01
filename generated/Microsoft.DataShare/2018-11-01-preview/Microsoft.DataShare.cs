// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_DataShare_2018_11_01_preview
    {
        private const string ProviderNamespace = "Microsoft.DataShare";
        private const string ApiVersion = "2018-11-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_accounts = new ResourceTypeReference(ProviderNamespace, new[]{"accounts"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_accounts_shares = new ResourceTypeReference(ProviderNamespace, new[]{"accounts", "shares"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_accounts_shareSubscriptions = new ResourceTypeReference(ProviderNamespace, new[]{"accounts", "shareSubscriptions"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_accounts_shares_dataSets = new ResourceTypeReference(ProviderNamespace, new[]{"accounts", "shares", "dataSets"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_accounts_shareSubscriptions_dataSetMappings = new ResourceTypeReference(ProviderNamespace, new[]{"accounts", "shareSubscriptions", "dataSetMappings"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_accounts_shares_invitations = new ResourceTypeReference(ProviderNamespace, new[]{"accounts", "shares", "invitations"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_accounts_shares_synchronizationSettings = new ResourceTypeReference(ProviderNamespace, new[]{"accounts", "shares", "synchronizationSettings"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_accounts_shareSubscriptions_triggers = new ResourceTypeReference(ProviderNamespace, new[]{"accounts", "shareSubscriptions", "triggers"}, ApiVersion);
        private static Lazy<Microsoft_DataShare_2018_11_01_preview> InstanceLazy = new Lazy<Microsoft_DataShare_2018_11_01_preview>(() => new Microsoft_DataShare_2018_11_01_preview());
        private Microsoft_DataShare_2018_11_01_preview()
        {
            Identity = new NamedObjectType("Identity", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AccountProperties = new NamedObjectType("AccountProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            ADLSGen1FileDataSet = new NamedObjectType("ADLSGen1FileDataSet", new ITypeProperty[]{new LazyTypeProperty("properties", () => ADLSGen1FileProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ADLSGen1FileProperties = new NamedObjectType("ADLSGen1FileProperties", new ITypeProperty[]{new TypeProperty("accountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("fileName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("folderPath", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("resourceGroup", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("subscriptionId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ADLSGen1FolderDataSet = new NamedObjectType("ADLSGen1FolderDataSet", new ITypeProperty[]{new LazyTypeProperty("properties", () => ADLSGen1FolderProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ADLSGen1FolderProperties = new NamedObjectType("ADLSGen1FolderProperties", new ITypeProperty[]{new TypeProperty("accountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("folderPath", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("resourceGroup", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("subscriptionId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ADLSGen2FileDataSet = new NamedObjectType("ADLSGen2FileDataSet", new ITypeProperty[]{new LazyTypeProperty("properties", () => ADLSGen2FileProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ADLSGen2FileProperties = new NamedObjectType("ADLSGen2FileProperties", new ITypeProperty[]{new TypeProperty("filePath", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("fileSystem", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("resourceGroup", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("storageAccountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("subscriptionId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ADLSGen2FileSystemDataSet = new NamedObjectType("ADLSGen2FileSystemDataSet", new ITypeProperty[]{new LazyTypeProperty("properties", () => ADLSGen2FileSystemProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ADLSGen2FileSystemProperties = new NamedObjectType("ADLSGen2FileSystemProperties", new ITypeProperty[]{new TypeProperty("fileSystem", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("resourceGroup", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("storageAccountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("subscriptionId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ADLSGen2FolderDataSet = new NamedObjectType("ADLSGen2FolderDataSet", new ITypeProperty[]{new LazyTypeProperty("properties", () => ADLSGen2FolderProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ADLSGen2FolderProperties = new NamedObjectType("ADLSGen2FolderProperties", new ITypeProperty[]{new TypeProperty("fileSystem", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("folderPath", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("resourceGroup", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("storageAccountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("subscriptionId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            BlobContainerDataSet = new NamedObjectType("BlobContainerDataSet", new ITypeProperty[]{new LazyTypeProperty("properties", () => BlobContainerProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            BlobContainerProperties = new NamedObjectType("BlobContainerProperties", new ITypeProperty[]{new TypeProperty("containerName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("resourceGroup", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("storageAccountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("subscriptionId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            BlobDataSet = new NamedObjectType("BlobDataSet", new ITypeProperty[]{new LazyTypeProperty("properties", () => BlobProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            BlobProperties = new NamedObjectType("BlobProperties", new ITypeProperty[]{new TypeProperty("containerName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("filePath", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("resourceGroup", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("storageAccountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("subscriptionId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            BlobFolderDataSet = new NamedObjectType("BlobFolderDataSet", new ITypeProperty[]{new LazyTypeProperty("properties", () => BlobFolderProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            BlobFolderProperties = new NamedObjectType("BlobFolderProperties", new ITypeProperty[]{new TypeProperty("containerName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("prefix", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("resourceGroup", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("storageAccountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("subscriptionId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            KustoClusterDataSet = new NamedObjectType("KustoClusterDataSet", new ITypeProperty[]{new LazyTypeProperty("properties", () => KustoClusterDataSetProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            KustoClusterDataSetProperties = new NamedObjectType("KustoClusterDataSetProperties", new ITypeProperty[]{new TypeProperty("kustoClusterResourceId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            KustoDatabaseDataSet = new NamedObjectType("KustoDatabaseDataSet", new ITypeProperty[]{new LazyTypeProperty("properties", () => KustoDatabaseDataSetProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            KustoDatabaseDataSetProperties = new NamedObjectType("KustoDatabaseDataSetProperties", new ITypeProperty[]{new TypeProperty("kustoDatabaseResourceId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SqlDBTableDataSet = new NamedObjectType("SqlDBTableDataSet", new ITypeProperty[]{new LazyTypeProperty("properties", () => SqlDBTableProperties, TypePropertyFlags.None), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SqlDBTableProperties = new NamedObjectType("SqlDBTableProperties", new ITypeProperty[]{new TypeProperty("databaseName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("schemaName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("sqlServerResourceId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tableName", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SqlDWTableDataSet = new NamedObjectType("SqlDWTableDataSet", new ITypeProperty[]{new LazyTypeProperty("properties", () => SqlDWTableProperties, TypePropertyFlags.None), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SqlDWTableProperties = new NamedObjectType("SqlDWTableProperties", new ITypeProperty[]{new TypeProperty("dataWarehouseName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("schemaName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("sqlServerResourceId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tableName", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ADLSGen2FileDataSetMapping = new NamedObjectType("ADLSGen2FileDataSetMapping", new ITypeProperty[]{new LazyTypeProperty("properties", () => ADLSGen2FileDataSetMappingProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ADLSGen2FileDataSetMappingProperties = new NamedObjectType("ADLSGen2FileDataSetMappingProperties", new ITypeProperty[]{new TypeProperty("dataSetId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("filePath", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("fileSystem", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("outputType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("resourceGroup", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("storageAccountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("subscriptionId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ADLSGen2FileSystemDataSetMapping = new NamedObjectType("ADLSGen2FileSystemDataSetMapping", new ITypeProperty[]{new LazyTypeProperty("properties", () => ADLSGen2FileSystemDataSetMappingProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ADLSGen2FileSystemDataSetMappingProperties = new NamedObjectType("ADLSGen2FileSystemDataSetMappingProperties", new ITypeProperty[]{new TypeProperty("dataSetId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("fileSystem", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("resourceGroup", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("storageAccountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("subscriptionId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ADLSGen2FolderDataSetMapping = new NamedObjectType("ADLSGen2FolderDataSetMapping", new ITypeProperty[]{new LazyTypeProperty("properties", () => ADLSGen2FolderDataSetMappingProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ADLSGen2FolderDataSetMappingProperties = new NamedObjectType("ADLSGen2FolderDataSetMappingProperties", new ITypeProperty[]{new TypeProperty("dataSetId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("fileSystem", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("folderPath", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("resourceGroup", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("storageAccountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("subscriptionId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            BlobContainerDataSetMapping = new NamedObjectType("BlobContainerDataSetMapping", new ITypeProperty[]{new LazyTypeProperty("properties", () => BlobContainerMappingProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            BlobContainerMappingProperties = new NamedObjectType("BlobContainerMappingProperties", new ITypeProperty[]{new TypeProperty("containerName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("dataSetId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("resourceGroup", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("storageAccountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("subscriptionId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            BlobDataSetMapping = new NamedObjectType("BlobDataSetMapping", new ITypeProperty[]{new LazyTypeProperty("properties", () => BlobMappingProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            BlobMappingProperties = new NamedObjectType("BlobMappingProperties", new ITypeProperty[]{new TypeProperty("containerName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("dataSetId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("filePath", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("outputType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("resourceGroup", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("storageAccountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("subscriptionId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            BlobFolderDataSetMapping = new NamedObjectType("BlobFolderDataSetMapping", new ITypeProperty[]{new LazyTypeProperty("properties", () => BlobFolderMappingProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            BlobFolderMappingProperties = new NamedObjectType("BlobFolderMappingProperties", new ITypeProperty[]{new TypeProperty("containerName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("dataSetId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("prefix", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("resourceGroup", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("storageAccountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("subscriptionId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            KustoClusterDataSetMapping = new NamedObjectType("KustoClusterDataSetMapping", new ITypeProperty[]{new LazyTypeProperty("properties", () => KustoClusterDataSetMappingProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            KustoClusterDataSetMappingProperties = new NamedObjectType("KustoClusterDataSetMappingProperties", new ITypeProperty[]{new TypeProperty("dataSetId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("kustoClusterResourceId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            KustoDatabaseDataSetMapping = new NamedObjectType("KustoDatabaseDataSetMapping", new ITypeProperty[]{new LazyTypeProperty("properties", () => KustoDatabaseDataSetMappingProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            KustoDatabaseDataSetMappingProperties = new NamedObjectType("KustoDatabaseDataSetMappingProperties", new ITypeProperty[]{new TypeProperty("dataSetId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("kustoClusterResourceId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SqlDBTableDataSetMapping = new NamedObjectType("SqlDBTableDataSetMapping", new ITypeProperty[]{new LazyTypeProperty("properties", () => SqlDBTableDataSetMappingProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SqlDBTableDataSetMappingProperties = new NamedObjectType("SqlDBTableDataSetMappingProperties", new ITypeProperty[]{new TypeProperty("databaseName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("dataSetId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("schemaName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("sqlServerResourceId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tableName", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SqlDWTableDataSetMapping = new NamedObjectType("SqlDWTableDataSetMapping", new ITypeProperty[]{new LazyTypeProperty("properties", () => SqlDWTableDataSetMappingProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SqlDWTableDataSetMappingProperties = new NamedObjectType("SqlDWTableDataSetMappingProperties", new ITypeProperty[]{new TypeProperty("dataSetId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("dataWarehouseName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("schemaName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("sqlServerResourceId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tableName", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            InvitationProperties = new NamedObjectType("InvitationProperties", new ITypeProperty[]{new TypeProperty("targetActiveDirectoryId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("targetEmail", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("targetObjectId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ShareProperties = new NamedObjectType("ShareProperties", new ITypeProperty[]{new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("shareKind", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("terms", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ShareSubscriptionProperties = new NamedObjectType("ShareSubscriptionProperties", new ITypeProperty[]{new TypeProperty("invitationId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ScheduledSynchronizationSetting = new NamedObjectType("ScheduledSynchronizationSetting", new ITypeProperty[]{new LazyTypeProperty("properties", () => ScheduledSynchronizationSettingProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ScheduledSynchronizationSettingProperties = new NamedObjectType("ScheduledSynchronizationSettingProperties", new ITypeProperty[]{new TypeProperty("recurrenceInterval", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("synchronizationTime", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ScheduledTrigger = new NamedObjectType("ScheduledTrigger", new ITypeProperty[]{new LazyTypeProperty("properties", () => ScheduledTriggerProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ScheduledTriggerProperties = new NamedObjectType("ScheduledTriggerProperties", new ITypeProperty[]{new TypeProperty("recurrenceInterval", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("synchronizationMode", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("synchronizationTime", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceType_accounts = new ResourceType("Microsoft.DataShare/accounts", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("identity", () => Identity, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => AccountProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_accounts);
            ResourceType_accounts_shares = new ResourceType("Microsoft.DataShare/accounts/shares", new ITypeProperty[]{new LazyTypeProperty("properties", () => ShareProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_accounts_shares);
            ResourceType_accounts_shareSubscriptions = new ResourceType("Microsoft.DataShare/accounts/shareSubscriptions", new ITypeProperty[]{new LazyTypeProperty("properties", () => ShareSubscriptionProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_accounts_shareSubscriptions);
            ResourceType_accounts_shares_dataSets = new ResourceType("Microsoft.DataShare/accounts/shares/dataSets", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_accounts_shares_dataSets);
            ResourceType_accounts_shareSubscriptions_dataSetMappings = new ResourceType("Microsoft.DataShare/accounts/shareSubscriptions/dataSetMappings", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_accounts_shareSubscriptions_dataSetMappings);
            ResourceType_accounts_shares_invitations = new ResourceType("Microsoft.DataShare/accounts/shares/invitations", new ITypeProperty[]{new LazyTypeProperty("properties", () => InvitationProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_accounts_shares_invitations);
            ResourceType_accounts_shares_synchronizationSettings = new ResourceType("Microsoft.DataShare/accounts/shares/synchronizationSettings", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_accounts_shares_synchronizationSettings);
            ResourceType_accounts_shareSubscriptions_triggers = new ResourceType("Microsoft.DataShare/accounts/shareSubscriptions/triggers", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_accounts_shareSubscriptions_triggers);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_accounts, () => InstanceLazy.Value.ResourceType_accounts);
            registrar.RegisterType(ResourceTypeReference_accounts_shares, () => InstanceLazy.Value.ResourceType_accounts_shares);
            registrar.RegisterType(ResourceTypeReference_accounts_shareSubscriptions, () => InstanceLazy.Value.ResourceType_accounts_shareSubscriptions);
            registrar.RegisterType(ResourceTypeReference_accounts_shares_dataSets, () => InstanceLazy.Value.ResourceType_accounts_shares_dataSets);
            registrar.RegisterType(ResourceTypeReference_accounts_shareSubscriptions_dataSetMappings, () => InstanceLazy.Value.ResourceType_accounts_shareSubscriptions_dataSetMappings);
            registrar.RegisterType(ResourceTypeReference_accounts_shares_invitations, () => InstanceLazy.Value.ResourceType_accounts_shares_invitations);
            registrar.RegisterType(ResourceTypeReference_accounts_shares_synchronizationSettings, () => InstanceLazy.Value.ResourceType_accounts_shares_synchronizationSettings);
            registrar.RegisterType(ResourceTypeReference_accounts_shareSubscriptions_triggers, () => InstanceLazy.Value.ResourceType_accounts_shareSubscriptions_triggers);
        }
        private readonly ResourceType ResourceType_accounts;
        private readonly ResourceType ResourceType_accounts_shares;
        private readonly ResourceType ResourceType_accounts_shareSubscriptions;
        private readonly ResourceType ResourceType_accounts_shares_dataSets;
        private readonly ResourceType ResourceType_accounts_shareSubscriptions_dataSetMappings;
        private readonly ResourceType ResourceType_accounts_shares_invitations;
        private readonly ResourceType ResourceType_accounts_shares_synchronizationSettings;
        private readonly ResourceType ResourceType_accounts_shareSubscriptions_triggers;
        private readonly TypeSymbol Identity;
        private readonly TypeSymbol AccountProperties;
        private readonly TypeSymbol ADLSGen1FileDataSet;
        private readonly TypeSymbol ADLSGen1FileProperties;
        private readonly TypeSymbol ADLSGen1FolderDataSet;
        private readonly TypeSymbol ADLSGen1FolderProperties;
        private readonly TypeSymbol ADLSGen2FileDataSet;
        private readonly TypeSymbol ADLSGen2FileProperties;
        private readonly TypeSymbol ADLSGen2FileSystemDataSet;
        private readonly TypeSymbol ADLSGen2FileSystemProperties;
        private readonly TypeSymbol ADLSGen2FolderDataSet;
        private readonly TypeSymbol ADLSGen2FolderProperties;
        private readonly TypeSymbol BlobContainerDataSet;
        private readonly TypeSymbol BlobContainerProperties;
        private readonly TypeSymbol BlobDataSet;
        private readonly TypeSymbol BlobProperties;
        private readonly TypeSymbol BlobFolderDataSet;
        private readonly TypeSymbol BlobFolderProperties;
        private readonly TypeSymbol KustoClusterDataSet;
        private readonly TypeSymbol KustoClusterDataSetProperties;
        private readonly TypeSymbol KustoDatabaseDataSet;
        private readonly TypeSymbol KustoDatabaseDataSetProperties;
        private readonly TypeSymbol SqlDBTableDataSet;
        private readonly TypeSymbol SqlDBTableProperties;
        private readonly TypeSymbol SqlDWTableDataSet;
        private readonly TypeSymbol SqlDWTableProperties;
        private readonly TypeSymbol ADLSGen2FileDataSetMapping;
        private readonly TypeSymbol ADLSGen2FileDataSetMappingProperties;
        private readonly TypeSymbol ADLSGen2FileSystemDataSetMapping;
        private readonly TypeSymbol ADLSGen2FileSystemDataSetMappingProperties;
        private readonly TypeSymbol ADLSGen2FolderDataSetMapping;
        private readonly TypeSymbol ADLSGen2FolderDataSetMappingProperties;
        private readonly TypeSymbol BlobContainerDataSetMapping;
        private readonly TypeSymbol BlobContainerMappingProperties;
        private readonly TypeSymbol BlobDataSetMapping;
        private readonly TypeSymbol BlobMappingProperties;
        private readonly TypeSymbol BlobFolderDataSetMapping;
        private readonly TypeSymbol BlobFolderMappingProperties;
        private readonly TypeSymbol KustoClusterDataSetMapping;
        private readonly TypeSymbol KustoClusterDataSetMappingProperties;
        private readonly TypeSymbol KustoDatabaseDataSetMapping;
        private readonly TypeSymbol KustoDatabaseDataSetMappingProperties;
        private readonly TypeSymbol SqlDBTableDataSetMapping;
        private readonly TypeSymbol SqlDBTableDataSetMappingProperties;
        private readonly TypeSymbol SqlDWTableDataSetMapping;
        private readonly TypeSymbol SqlDWTableDataSetMappingProperties;
        private readonly TypeSymbol InvitationProperties;
        private readonly TypeSymbol ShareProperties;
        private readonly TypeSymbol ShareSubscriptionProperties;
        private readonly TypeSymbol ScheduledSynchronizationSetting;
        private readonly TypeSymbol ScheduledSynchronizationSettingProperties;
        private readonly TypeSymbol ScheduledTrigger;
        private readonly TypeSymbol ScheduledTriggerProperties;
    }
}
