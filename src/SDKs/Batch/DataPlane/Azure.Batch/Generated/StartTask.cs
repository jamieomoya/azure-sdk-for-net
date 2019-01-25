// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A task which is run when a compute node joins a pool in the Azure Batch service, or when the compute node is rebooted 
    /// or reimaged.
    /// </summary>
    /// <remarks>
    /// Batch will retry tasks when a recovery operation is triggered on a compute node. Examples of recovery operations 
    /// include (but are not limited to) when an unhealthy compute node is rebooted or a compute node disappeared due to 
    /// host failure. Retries due to recovery operations are independent of and are not counted against the <see cref="TaskConstraints.MaxTaskRetryCount" 
    /// />. Even if the <see cref="TaskConstraints.MaxTaskRetryCount" /> is 0, an internal retry due to a recovery operation 
    /// may occur. Because of this, all tasks should be idempotent. This means tasks need to tolerate being interrupted and 
    /// restarted without causing any corruption or duplicate data. The best practice for long running tasks is to use some 
    /// form of checkpointing.
    /// </remarks>
    public partial class StartTask : ITransportObjectProvider<Models.StartTask>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<string> CommandLineProperty;
            public readonly PropertyAccessor<TaskContainerSettings> ContainerSettingsProperty;
            public readonly PropertyAccessor<IList<EnvironmentSetting>> EnvironmentSettingsProperty;
            public readonly PropertyAccessor<int?> MaxTaskRetryCountProperty;
            public readonly PropertyAccessor<IList<ResourceFile>> ResourceFilesProperty;
            public readonly PropertyAccessor<UserIdentity> UserIdentityProperty;
            public readonly PropertyAccessor<bool?> WaitForSuccessProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.CommandLineProperty = this.CreatePropertyAccessor<string>(nameof(CommandLine), BindingAccess.Read | BindingAccess.Write);
                this.ContainerSettingsProperty = this.CreatePropertyAccessor<TaskContainerSettings>(nameof(ContainerSettings), BindingAccess.Read | BindingAccess.Write);
                this.EnvironmentSettingsProperty = this.CreatePropertyAccessor<IList<EnvironmentSetting>>(nameof(EnvironmentSettings), BindingAccess.Read | BindingAccess.Write);
                this.MaxTaskRetryCountProperty = this.CreatePropertyAccessor<int?>(nameof(MaxTaskRetryCount), BindingAccess.Read | BindingAccess.Write);
                this.ResourceFilesProperty = this.CreatePropertyAccessor<IList<ResourceFile>>(nameof(ResourceFiles), BindingAccess.Read | BindingAccess.Write);
                this.UserIdentityProperty = this.CreatePropertyAccessor<UserIdentity>(nameof(UserIdentity), BindingAccess.Read | BindingAccess.Write);
                this.WaitForSuccessProperty = this.CreatePropertyAccessor<bool?>(nameof(WaitForSuccess), BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.StartTask protocolObject) : base(BindingState.Bound)
            {
                this.CommandLineProperty = this.CreatePropertyAccessor(
                    protocolObject.CommandLine,
                    nameof(CommandLine),
                    BindingAccess.Read | BindingAccess.Write);
                this.ContainerSettingsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.ContainerSettings, o => new TaskContainerSettings(o).Freeze()),
                    nameof(ContainerSettings),
                    BindingAccess.Read);
                this.EnvironmentSettingsProperty = this.CreatePropertyAccessor(
                    EnvironmentSetting.ConvertFromProtocolCollection(protocolObject.EnvironmentSettings),
                    nameof(EnvironmentSettings),
                    BindingAccess.Read | BindingAccess.Write);
                this.MaxTaskRetryCountProperty = this.CreatePropertyAccessor(
                    protocolObject.MaxTaskRetryCount,
                    nameof(MaxTaskRetryCount),
                    BindingAccess.Read | BindingAccess.Write);
                this.ResourceFilesProperty = this.CreatePropertyAccessor(
                    ResourceFile.ConvertFromProtocolCollection(protocolObject.ResourceFiles),
                    nameof(ResourceFiles),
                    BindingAccess.Read | BindingAccess.Write);
                this.UserIdentityProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.UserIdentity, o => new UserIdentity(o)),
                    nameof(UserIdentity),
                    BindingAccess.Read | BindingAccess.Write);
                this.WaitForSuccessProperty = this.CreatePropertyAccessor(
                    protocolObject.WaitForSuccess,
                    nameof(WaitForSuccess),
                    BindingAccess.Read | BindingAccess.Write);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="StartTask"/> class.
        /// </summary>
        /// <param name='commandLine'>The command line of the task.</param>
        public StartTask(
            string commandLine)
        {
            this.propertyContainer = new PropertyContainer();
            this.CommandLine = commandLine;
        }

        internal StartTask(Models.StartTask protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region StartTask

        /// <summary>
        /// Gets or sets the command line of the task.
        /// </summary>
        /// <remarks>
        /// The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment 
        /// variable expansion. If you want to take advantage of such features, you should invoke the shell in the command 
        /// line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux. If the command line 
        /// refers to file paths, it should use a relative path (relative to the task working directory), or use the Batch 
        /// provided environment variables (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables).
        /// </remarks>
        public string CommandLine
        {
            get { return this.propertyContainer.CommandLineProperty.Value; }
            set { this.propertyContainer.CommandLineProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the settings for the container under which the task runs.
        /// </summary>
        /// <remarks>
        /// When this is specified, all directories recursively below the AZ_BATCH_NODE_ROOT_DIR (the root of Azure Batch 
        /// directories on the node) are mapped into the container, all task environment variables are mapped into the container, 
        /// and the task command line is executed in the container.
        /// </remarks>
        public TaskContainerSettings ContainerSettings
        {
            get { return this.propertyContainer.ContainerSettingsProperty.Value; }
            set { this.propertyContainer.ContainerSettingsProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a set of environment settings for the start task.
        /// </summary>
        public IList<EnvironmentSetting> EnvironmentSettings
        {
            get { return this.propertyContainer.EnvironmentSettingsProperty.Value; }
            set
            {
                this.propertyContainer.EnvironmentSettingsProperty.Value = ConcurrentChangeTrackedModifiableList<EnvironmentSetting>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the maximum number of retries for the task.
        /// </summary>
        public int? MaxTaskRetryCount
        {
            get { return this.propertyContainer.MaxTaskRetryCountProperty.Value; }
            set { this.propertyContainer.MaxTaskRetryCountProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download to the compute node before running the command 
        /// line.
        /// </summary>
        /// <remarks>
        /// There is a maximum size for the list of resource files. When the max size is exceeded, the request will fail 
        /// and the response error code will be RequestEntityTooLarge. If this occurs, the collection of resource files must 
        /// be reduced in size. This can be achieved using .zip files, Application Packages, or Docker Containers.
        /// </remarks>
        public IList<ResourceFile> ResourceFiles
        {
            get { return this.propertyContainer.ResourceFilesProperty.Value; }
            set
            {
                this.propertyContainer.ResourceFilesProperty.Value = ConcurrentChangeTrackedModifiableList<ResourceFile>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the user identity under which the task runs.
        /// </summary>
        /// <remarks>
        /// If omitted, the task runs as a non-administrative user unique to the task.
        /// </remarks>
        public UserIdentity UserIdentity
        {
            get { return this.propertyContainer.UserIdentityProperty.Value; }
            set { this.propertyContainer.UserIdentityProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the Batch service should wait for the start task to complete before scheduling 
        /// any tasks on the compute node.
        /// </summary>
        /// <remarks>
        /// If this is not specified, the default is false.
        /// </remarks>
        public bool? WaitForSuccess
        {
            get { return this.propertyContainer.WaitForSuccessProperty.Value; }
            set { this.propertyContainer.WaitForSuccessProperty.Value = value; }
        }

        #endregion // StartTask

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.StartTask ITransportObjectProvider<Models.StartTask>.GetTransportObject()
        {
            Models.StartTask result = new Models.StartTask()
            {
                CommandLine = this.CommandLine,
                ContainerSettings = UtilitiesInternal.CreateObjectWithNullCheck(this.ContainerSettings, (o) => o.GetTransportObject()),
                EnvironmentSettings = UtilitiesInternal.ConvertToProtocolCollection(this.EnvironmentSettings),
                MaxTaskRetryCount = this.MaxTaskRetryCount,
                ResourceFiles = UtilitiesInternal.ConvertToProtocolCollection(this.ResourceFiles),
                UserIdentity = UtilitiesInternal.CreateObjectWithNullCheck(this.UserIdentity, (o) => o.GetTransportObject()),
                WaitForSuccess = this.WaitForSuccess,
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}