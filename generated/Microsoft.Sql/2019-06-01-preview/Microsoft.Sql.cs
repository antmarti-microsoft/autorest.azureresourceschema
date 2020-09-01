// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Sql_2019_06_01_preview
    {
        private const string ProviderNamespace = "Microsoft.Sql";
        private const string ApiVersion = "2019-06-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_servers = new ResourceTypeReference(ProviderNamespace, new[]{"servers"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_servers_administrators = new ResourceTypeReference(ProviderNamespace, new[]{"servers", "administrators"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_servers_databases_workloadGroups = new ResourceTypeReference(ProviderNamespace, new[]{"servers", "databases", "workloadGroups"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_servers_databases_syncGroups = new ResourceTypeReference(ProviderNamespace, new[]{"servers", "databases", "syncGroups"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_servers_databases_workloadGroups_workloadClassifiers = new ResourceTypeReference(ProviderNamespace, new[]{"servers", "databases", "workloadGroups", "workloadClassifiers"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_servers_databases_syncGroups_syncMembers = new ResourceTypeReference(ProviderNamespace, new[]{"servers", "databases", "syncGroups", "syncMembers"}, ApiVersion);
        private static Lazy<Microsoft_Sql_2019_06_01_preview> InstanceLazy = new Lazy<Microsoft_Sql_2019_06_01_preview>(() => new Microsoft_Sql_2019_06_01_preview());
        private Microsoft_Sql_2019_06_01_preview()
        {
            ResourceIdentity = new NamedObjectType("ResourceIdentity", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ServerProperties = new NamedObjectType("ServerProperties", new ITypeProperty[]{new TypeProperty("administratorLogin", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("administratorLoginPassword", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("version", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("minimalTlsVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("publicNetworkAccess", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            WorkloadGroupProperties = new NamedObjectType("WorkloadGroupProperties", new ITypeProperty[]{new TypeProperty("minResourcePercent", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("maxResourcePercent", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("minResourcePercentPerRequest", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("maxResourcePercentPerRequest", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("importance", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("queryExecutionTimeout", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            WorkloadClassifierProperties = new NamedObjectType("WorkloadClassifierProperties", new ITypeProperty[]{new TypeProperty("memberName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("label", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("context", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("startTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("endTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("importance", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AdministratorProperties = new NamedObjectType("AdministratorProperties", new ITypeProperty[]{new TypeProperty("administratorType", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("login", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("sid", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tenantId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SyncGroupProperties = new NamedObjectType("SyncGroupProperties", new ITypeProperty[]{new TypeProperty("interval", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("conflictResolutionPolicy", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("syncDatabaseId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("hubDatabaseUserName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("hubDatabasePassword", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("schema", () => SyncGroupSchema, TypePropertyFlags.None), new TypeProperty("usePrivateLinkConnection", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SyncGroupSchema = new NamedObjectType("SyncGroupSchema", new ITypeProperty[]{new TypeProperty("tables", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("masterSyncMemberName", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SyncGroupSchemaTable = new NamedObjectType("SyncGroupSchemaTable", new ITypeProperty[]{new TypeProperty("columns", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("quotedName", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SyncGroupSchemaTableColumn = new NamedObjectType("SyncGroupSchemaTableColumn", new ITypeProperty[]{new TypeProperty("quotedName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("dataSize", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("dataType", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SyncMemberProperties = new NamedObjectType("SyncMemberProperties", new ITypeProperty[]{new TypeProperty("databaseType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("syncAgentId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sqlServerDatabaseId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("syncMemberAzureDatabaseResourceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("usePrivateLinkConnection", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("serverName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("databaseName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("userName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("password", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("syncDirection", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_servers = new ResourceType("Microsoft.Sql/servers", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("identity", () => ResourceIdentity, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ServerProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_servers);
            ResourceType_servers_administrators = new ResourceType("Microsoft.Sql/servers/administrators", new ITypeProperty[]{new LazyTypeProperty("properties", () => AdministratorProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_servers_administrators);
            ResourceType_servers_databases_workloadGroups = new ResourceType("Microsoft.Sql/servers/databases/workloadGroups", new ITypeProperty[]{new LazyTypeProperty("properties", () => WorkloadGroupProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_servers_databases_workloadGroups);
            ResourceType_servers_databases_syncGroups = new ResourceType("Microsoft.Sql/servers/databases/syncGroups", new ITypeProperty[]{new LazyTypeProperty("properties", () => SyncGroupProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_servers_databases_syncGroups);
            ResourceType_servers_databases_workloadGroups_workloadClassifiers = new ResourceType("Microsoft.Sql/servers/databases/workloadGroups/workloadClassifiers", new ITypeProperty[]{new LazyTypeProperty("properties", () => WorkloadClassifierProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_servers_databases_workloadGroups_workloadClassifiers);
            ResourceType_servers_databases_syncGroups_syncMembers = new ResourceType("Microsoft.Sql/servers/databases/syncGroups/syncMembers", new ITypeProperty[]{new LazyTypeProperty("properties", () => SyncMemberProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_servers_databases_syncGroups_syncMembers);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_servers, () => InstanceLazy.Value.ResourceType_servers);
            registrar.RegisterType(ResourceTypeReference_servers_administrators, () => InstanceLazy.Value.ResourceType_servers_administrators);
            registrar.RegisterType(ResourceTypeReference_servers_databases_workloadGroups, () => InstanceLazy.Value.ResourceType_servers_databases_workloadGroups);
            registrar.RegisterType(ResourceTypeReference_servers_databases_syncGroups, () => InstanceLazy.Value.ResourceType_servers_databases_syncGroups);
            registrar.RegisterType(ResourceTypeReference_servers_databases_workloadGroups_workloadClassifiers, () => InstanceLazy.Value.ResourceType_servers_databases_workloadGroups_workloadClassifiers);
            registrar.RegisterType(ResourceTypeReference_servers_databases_syncGroups_syncMembers, () => InstanceLazy.Value.ResourceType_servers_databases_syncGroups_syncMembers);
        }
        private readonly ResourceType ResourceType_servers;
        private readonly ResourceType ResourceType_servers_administrators;
        private readonly ResourceType ResourceType_servers_databases_workloadGroups;
        private readonly ResourceType ResourceType_servers_databases_syncGroups;
        private readonly ResourceType ResourceType_servers_databases_workloadGroups_workloadClassifiers;
        private readonly ResourceType ResourceType_servers_databases_syncGroups_syncMembers;
        private readonly TypeSymbol ResourceIdentity;
        private readonly TypeSymbol ServerProperties;
        private readonly TypeSymbol WorkloadGroupProperties;
        private readonly TypeSymbol WorkloadClassifierProperties;
        private readonly TypeSymbol AdministratorProperties;
        private readonly TypeSymbol SyncGroupProperties;
        private readonly TypeSymbol SyncGroupSchema;
        private readonly TypeSymbol SyncGroupSchemaTable;
        private readonly TypeSymbol SyncGroupSchemaTableColumn;
        private readonly TypeSymbol SyncMemberProperties;
    }
}
