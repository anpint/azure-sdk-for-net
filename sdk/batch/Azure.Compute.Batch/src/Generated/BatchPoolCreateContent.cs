// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> Parameters for creating an Azure Batch Pool. </summary>
    public partial class BatchPoolCreateContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BatchPoolCreateContent"/>. </summary>
        /// <param name="id"> A string that uniquely identifies the Pool within the Account. The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. The ID is case-preserving and case-insensitive (that is, you may not have two Pool IDs within an Account that differ only by case). </param>
        /// <param name="vmSize"> The size of virtual machines in the Pool. All virtual machines in a Pool are the same size. For information about available VM sizes for Pools using Images from the Virtual Machines Marketplace (pools created with virtualMachineConfiguration), see Sizes for Virtual Machines in Azure (https://learn.microsoft.com/azure/virtual-machines/sizes/overview). Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2 series). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="vmSize"/> is null. </exception>
        public BatchPoolCreateContent(string id, string vmSize)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(vmSize, nameof(vmSize));

            Id = id;
            VmSize = vmSize;
            ResourceTags = new ChangeTrackingDictionary<string, string>();
            CertificateReferences = new ChangeTrackingList<BatchCertificateReference>();
            ApplicationPackageReferences = new ChangeTrackingList<BatchApplicationPackageReference>();
            UserAccounts = new ChangeTrackingList<UserAccount>();
            Metadata = new ChangeTrackingList<MetadataItem>();
            MountConfiguration = new ChangeTrackingList<MountConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchPoolCreateContent"/>. </summary>
        /// <param name="id"> A string that uniquely identifies the Pool within the Account. The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. The ID is case-preserving and case-insensitive (that is, you may not have two Pool IDs within an Account that differ only by case). </param>
        /// <param name="displayName"> The display name for the Pool. The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024. </param>
        /// <param name="vmSize"> The size of virtual machines in the Pool. All virtual machines in a Pool are the same size. For information about available VM sizes for Pools using Images from the Virtual Machines Marketplace (pools created with virtualMachineConfiguration), see Sizes for Virtual Machines in Azure (https://learn.microsoft.com/azure/virtual-machines/sizes/overview). Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2 series). </param>
        /// <param name="virtualMachineConfiguration"> The virtual machine configuration for the Pool. This property must be specified. </param>
        /// <param name="resizeTimeout"> The timeout for allocation of Compute Nodes to the Pool. This timeout applies only to manual scaling; it has no effect when enableAutoScale is set to true. The default value is 15 minutes. The minimum value is 5 minutes. If you specify a value less than 5 minutes, the Batch service returns an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </param>
        /// <param name="resourceTags"> The user-specified tags associated with the pool. The user-defined tags to be associated with the Azure Batch Pool. When specified, these tags are propagated to the backing Azure resources associated with the pool. This property can only be specified when the Batch account was created with the poolAllocationMode property set to 'UserSubscription'. </param>
        /// <param name="targetDedicatedNodes"> The desired number of dedicated Compute Nodes in the Pool. This property must not be specified if enableAutoScale is set to true. If enableAutoScale is set to false, then you must set either targetDedicatedNodes, targetLowPriorityNodes, or both. </param>
        /// <param name="targetLowPriorityNodes"> The desired number of Spot/Low-priority Compute Nodes in the Pool. This property must not be specified if enableAutoScale is set to true. If enableAutoScale is set to false, then you must set either targetDedicatedNodes, targetLowPriorityNodes, or both. </param>
        /// <param name="enableAutoScale"> Whether the Pool size should automatically adjust over time. If false, at least one of targetDedicatedNodes and targetLowPriorityNodes must be specified. If true, the autoScaleFormula property is required and the Pool automatically resizes according to the formula. The default value is false. </param>
        /// <param name="autoScaleFormula"> A formula for the desired number of Compute Nodes in the Pool. This property must not be specified if enableAutoScale is set to false. It is required if enableAutoScale is set to true. The formula is checked for validity before the Pool is created. If the formula is not valid, the Batch service rejects the request with detailed error information. For more information about specifying this formula, see 'Automatically scale Compute Nodes in an Azure Batch Pool' (https://learn.microsoft.com/azure/batch/batch-automatic-scaling). </param>
        /// <param name="autoScaleEvaluationInterval"> The time interval at which to automatically adjust the Pool size according to the autoscale formula. The default value is 15 minutes. The minimum and maximum value are 5 minutes and 168 hours respectively. If you specify a value less than 5 minutes or greater than 168 hours, the Batch service returns an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </param>
        /// <param name="enableInterNodeCommunication"> Whether the Pool permits direct communication between Compute Nodes. Enabling inter-node communication limits the maximum size of the Pool due to deployment restrictions on the Compute Nodes of the Pool. This may result in the Pool not reaching its desired size. The default value is false. </param>
        /// <param name="networkConfiguration"> The network configuration for the Pool. </param>
        /// <param name="startTask"> A Task specified to run on each Compute Node as it joins the Pool. The Task runs when the Compute Node is added to the Pool or when the Compute Node is restarted. </param>
        /// <param name="certificateReferences">
        /// For Windows Nodes, the Batch service installs the Certificates to the specified Certificate store and location.
        /// For Linux Compute Nodes, the Certificates are stored in a directory inside the Task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the Task to query for this location.
        /// For Certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and Certificates are placed in that directory.
        /// Warning: This property is deprecated and will be removed after February, 2024. Please use the [Azure KeyVault Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide) instead.
        /// </param>
        /// <param name="applicationPackageReferences"> The list of Packages to be installed on each Compute Node in the Pool. When creating a pool, the package's application ID must be fully qualified (/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}). Changes to Package references affect all new Nodes joining the Pool, but do not affect Compute Nodes that are already in the Pool until they are rebooted or reimaged. There is a maximum of 10 Package references on any given Pool. </param>
        /// <param name="taskSlotsPerNode"> The number of task slots that can be used to run concurrent tasks on a single compute node in the pool. The default value is 1. The maximum value is the smaller of 4 times the number of cores of the vmSize of the pool or 256. </param>
        /// <param name="taskSchedulingPolicy"> How Tasks are distributed across Compute Nodes in a Pool. If not specified, the default is spread. </param>
        /// <param name="userAccounts"> The list of user Accounts to be created on each Compute Node in the Pool. </param>
        /// <param name="metadata"> A list of name-value pairs associated with the Pool as metadata. The Batch service does not assign any meaning to metadata; it is solely for the use of user code. </param>
        /// <param name="mountConfiguration"> Mount storage using specified file system for the entire lifetime of the pool. Mount the storage using Azure fileshare, NFS, CIFS or Blobfuse based file system. </param>
        /// <param name="targetNodeCommunicationMode"> The desired node communication mode for the pool. If omitted, the default value is Default. </param>
        /// <param name="upgradePolicy"> The upgrade policy for the Pool. Describes an upgrade policy - automatic, manual, or rolling. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchPoolCreateContent(string id, string displayName, string vmSize, VirtualMachineConfiguration virtualMachineConfiguration, TimeSpan? resizeTimeout, IDictionary<string, string> resourceTags, int? targetDedicatedNodes, int? targetLowPriorityNodes, bool? enableAutoScale, string autoScaleFormula, TimeSpan? autoScaleEvaluationInterval, bool? enableInterNodeCommunication, NetworkConfiguration networkConfiguration, BatchStartTask startTask, IList<BatchCertificateReference> certificateReferences, IList<BatchApplicationPackageReference> applicationPackageReferences, int? taskSlotsPerNode, BatchTaskSchedulingPolicy taskSchedulingPolicy, IList<UserAccount> userAccounts, IList<MetadataItem> metadata, IList<MountConfiguration> mountConfiguration, BatchNodeCommunicationMode? targetNodeCommunicationMode, UpgradePolicy upgradePolicy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            DisplayName = displayName;
            VmSize = vmSize;
            VirtualMachineConfiguration = virtualMachineConfiguration;
            ResizeTimeout = resizeTimeout;
            ResourceTags = resourceTags;
            TargetDedicatedNodes = targetDedicatedNodes;
            TargetLowPriorityNodes = targetLowPriorityNodes;
            EnableAutoScale = enableAutoScale;
            AutoScaleFormula = autoScaleFormula;
            AutoScaleEvaluationInterval = autoScaleEvaluationInterval;
            EnableInterNodeCommunication = enableInterNodeCommunication;
            NetworkConfiguration = networkConfiguration;
            StartTask = startTask;
            CertificateReferences = certificateReferences;
            ApplicationPackageReferences = applicationPackageReferences;
            TaskSlotsPerNode = taskSlotsPerNode;
            TaskSchedulingPolicy = taskSchedulingPolicy;
            UserAccounts = userAccounts;
            Metadata = metadata;
            MountConfiguration = mountConfiguration;
            TargetNodeCommunicationMode = targetNodeCommunicationMode;
            UpgradePolicy = upgradePolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchPoolCreateContent"/> for deserialization. </summary>
        internal BatchPoolCreateContent()
        {
        }

        /// <summary> A string that uniquely identifies the Pool within the Account. The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. The ID is case-preserving and case-insensitive (that is, you may not have two Pool IDs within an Account that differ only by case). </summary>
        public string Id { get; }
        /// <summary> The display name for the Pool. The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024. </summary>
        public string DisplayName { get; set; }
        /// <summary> The size of virtual machines in the Pool. All virtual machines in a Pool are the same size. For information about available VM sizes for Pools using Images from the Virtual Machines Marketplace (pools created with virtualMachineConfiguration), see Sizes for Virtual Machines in Azure (https://learn.microsoft.com/azure/virtual-machines/sizes/overview). Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2 series). </summary>
        public string VmSize { get; }
        /// <summary> The virtual machine configuration for the Pool. This property must be specified. </summary>
        public VirtualMachineConfiguration VirtualMachineConfiguration { get; set; }
        /// <summary> The timeout for allocation of Compute Nodes to the Pool. This timeout applies only to manual scaling; it has no effect when enableAutoScale is set to true. The default value is 15 minutes. The minimum value is 5 minutes. If you specify a value less than 5 minutes, the Batch service returns an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </summary>
        public TimeSpan? ResizeTimeout { get; set; }
        /// <summary> The user-specified tags associated with the pool. The user-defined tags to be associated with the Azure Batch Pool. When specified, these tags are propagated to the backing Azure resources associated with the pool. This property can only be specified when the Batch account was created with the poolAllocationMode property set to 'UserSubscription'. </summary>
        public IDictionary<string, string> ResourceTags { get; }
        /// <summary> The desired number of dedicated Compute Nodes in the Pool. This property must not be specified if enableAutoScale is set to true. If enableAutoScale is set to false, then you must set either targetDedicatedNodes, targetLowPriorityNodes, or both. </summary>
        public int? TargetDedicatedNodes { get; set; }
        /// <summary> The desired number of Spot/Low-priority Compute Nodes in the Pool. This property must not be specified if enableAutoScale is set to true. If enableAutoScale is set to false, then you must set either targetDedicatedNodes, targetLowPriorityNodes, or both. </summary>
        public int? TargetLowPriorityNodes { get; set; }
        /// <summary> Whether the Pool size should automatically adjust over time. If false, at least one of targetDedicatedNodes and targetLowPriorityNodes must be specified. If true, the autoScaleFormula property is required and the Pool automatically resizes according to the formula. The default value is false. </summary>
        public bool? EnableAutoScale { get; set; }
        /// <summary> A formula for the desired number of Compute Nodes in the Pool. This property must not be specified if enableAutoScale is set to false. It is required if enableAutoScale is set to true. The formula is checked for validity before the Pool is created. If the formula is not valid, the Batch service rejects the request with detailed error information. For more information about specifying this formula, see 'Automatically scale Compute Nodes in an Azure Batch Pool' (https://learn.microsoft.com/azure/batch/batch-automatic-scaling). </summary>
        public string AutoScaleFormula { get; set; }
        /// <summary> The time interval at which to automatically adjust the Pool size according to the autoscale formula. The default value is 15 minutes. The minimum and maximum value are 5 minutes and 168 hours respectively. If you specify a value less than 5 minutes or greater than 168 hours, the Batch service returns an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </summary>
        public TimeSpan? AutoScaleEvaluationInterval { get; set; }
        /// <summary> Whether the Pool permits direct communication between Compute Nodes. Enabling inter-node communication limits the maximum size of the Pool due to deployment restrictions on the Compute Nodes of the Pool. This may result in the Pool not reaching its desired size. The default value is false. </summary>
        public bool? EnableInterNodeCommunication { get; set; }
        /// <summary> The network configuration for the Pool. </summary>
        public NetworkConfiguration NetworkConfiguration { get; set; }
        /// <summary> A Task specified to run on each Compute Node as it joins the Pool. The Task runs when the Compute Node is added to the Pool or when the Compute Node is restarted. </summary>
        public BatchStartTask StartTask { get; set; }
        /// <summary>
        /// For Windows Nodes, the Batch service installs the Certificates to the specified Certificate store and location.
        /// For Linux Compute Nodes, the Certificates are stored in a directory inside the Task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the Task to query for this location.
        /// For Certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and Certificates are placed in that directory.
        /// Warning: This property is deprecated and will be removed after February, 2024. Please use the [Azure KeyVault Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide) instead.
        /// </summary>
        public IList<BatchCertificateReference> CertificateReferences { get; }
        /// <summary> The list of Packages to be installed on each Compute Node in the Pool. When creating a pool, the package's application ID must be fully qualified (/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}). Changes to Package references affect all new Nodes joining the Pool, but do not affect Compute Nodes that are already in the Pool until they are rebooted or reimaged. There is a maximum of 10 Package references on any given Pool. </summary>
        public IList<BatchApplicationPackageReference> ApplicationPackageReferences { get; }
        /// <summary> The number of task slots that can be used to run concurrent tasks on a single compute node in the pool. The default value is 1. The maximum value is the smaller of 4 times the number of cores of the vmSize of the pool or 256. </summary>
        public int? TaskSlotsPerNode { get; set; }
        /// <summary> How Tasks are distributed across Compute Nodes in a Pool. If not specified, the default is spread. </summary>
        public BatchTaskSchedulingPolicy TaskSchedulingPolicy { get; set; }
        /// <summary> The list of user Accounts to be created on each Compute Node in the Pool. </summary>
        public IList<UserAccount> UserAccounts { get; }
        /// <summary> A list of name-value pairs associated with the Pool as metadata. The Batch service does not assign any meaning to metadata; it is solely for the use of user code. </summary>
        public IList<MetadataItem> Metadata { get; }
        /// <summary> Mount storage using specified file system for the entire lifetime of the pool. Mount the storage using Azure fileshare, NFS, CIFS or Blobfuse based file system. </summary>
        public IList<MountConfiguration> MountConfiguration { get; }
        /// <summary> The desired node communication mode for the pool. If omitted, the default value is Default. </summary>
        public BatchNodeCommunicationMode? TargetNodeCommunicationMode { get; set; }
        /// <summary> The upgrade policy for the Pool. Describes an upgrade policy - automatic, manual, or rolling. </summary>
        public UpgradePolicy UpgradePolicy { get; set; }
    }
}
