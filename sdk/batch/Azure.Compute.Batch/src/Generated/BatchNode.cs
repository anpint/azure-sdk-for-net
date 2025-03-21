// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> A Compute Node in the Batch service. </summary>
    public partial class BatchNode
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

        /// <summary> Initializes a new instance of <see cref="BatchNode"/>. </summary>
        internal BatchNode()
        {
            RecentTasks = new ChangeTrackingList<BatchTaskInfo>();
            CertificateReferences = new ChangeTrackingList<BatchCertificateReference>();
            Errors = new ChangeTrackingList<BatchNodeError>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchNode"/>. </summary>
        /// <param name="id"> The ID of the Compute Node. Every Compute Node that is added to a Pool is assigned a unique ID. Whenever a Compute Node is removed from a Pool, all of its local files are deleted, and the ID is reclaimed and could be reused for new Compute Nodes. </param>
        /// <param name="url"> The URL of the Compute Node. </param>
        /// <param name="state"> The current state of the Compute Node. The Spot/Low-priority Compute Node has been preempted. Tasks which were running on the Compute Node when it was preempted will be rescheduled when another Compute Node becomes available. </param>
        /// <param name="schedulingState"> Whether the Compute Node is available for Task scheduling. </param>
        /// <param name="stateTransitionTime"> The time at which the Compute Node entered its current state. </param>
        /// <param name="lastBootTime"> The last time at which the Compute Node was started. This property may not be present if the Compute Node state is unusable. </param>
        /// <param name="allocationTime"> The time at which this Compute Node was allocated to the Pool. This is the time when the Compute Node was initially allocated and doesn't change once set. It is not updated when the Compute Node is service healed or preempted. </param>
        /// <param name="ipAddress"> The IP address that other Nodes can use to communicate with this Compute Node. Every Compute Node that is added to a Pool is assigned a unique IP address. Whenever a Compute Node is removed from a Pool, all of its local files are deleted, and the IP address is reclaimed and could be reused for new Compute Nodes. </param>
        /// <param name="affinityId"> An identifier which can be passed when adding a Task to request that the Task be scheduled on this Compute Node. Note that this is just a soft affinity. If the target Compute Node is busy or unavailable at the time the Task is scheduled, then the Task will be scheduled elsewhere. </param>
        /// <param name="vmSize"> The size of the virtual machine hosting the Compute Node. For information about available sizes of virtual machines in Pools, see Choose a VM size for Compute Nodes in an Azure Batch Pool (https://learn.microsoft.com/azure/batch/batch-pool-vm-sizes). </param>
        /// <param name="totalTasksRun"> The total number of Job Tasks completed on the Compute Node. This includes Job Manager Tasks and normal Tasks, but not Job Preparation, Job Release or Start Tasks. </param>
        /// <param name="runningTasksCount"> The total number of currently running Job Tasks on the Compute Node. This includes Job Manager Tasks and normal Tasks, but not Job Preparation, Job Release or Start Tasks. </param>
        /// <param name="runningTaskSlotsCount"> The total number of scheduling slots used by currently running Job Tasks on the Compute Node. This includes Job Manager Tasks and normal Tasks, but not Job Preparation, Job Release or Start Tasks. </param>
        /// <param name="totalTasksSucceeded"> The total number of Job Tasks which completed successfully (with exitCode 0) on the Compute Node. This includes Job Manager Tasks and normal Tasks, but not Job Preparation, Job Release or Start Tasks. </param>
        /// <param name="recentTasks"> A list of Tasks whose state has recently changed. This property is present only if at least one Task has run on this Compute Node since it was assigned to the Pool. </param>
        /// <param name="startTask"> The Task specified to run on the Compute Node as it joins the Pool. </param>
        /// <param name="startTaskInfo"> Runtime information about the execution of the StartTask on the Compute Node. </param>
        /// <param name="certificateReferences">
        /// For Windows Nodes, the Batch service installs the Certificates to the specified Certificate store and location.
        /// For Linux Compute Nodes, the Certificates are stored in a directory inside the Task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the Task to query for this location.
        /// For Certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and Certificates are placed in that directory.
        /// Warning: This property is deprecated and will be removed after February, 2024. Please use the [Azure KeyVault Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide) instead.
        /// </param>
        /// <param name="errors"> The list of errors that are currently being encountered by the Compute Node. </param>
        /// <param name="isDedicated"> Whether this Compute Node is a dedicated Compute Node. If false, the Compute Node is a Spot/Low-priority Compute Node. </param>
        /// <param name="endpointConfiguration"> The endpoint configuration for the Compute Node. </param>
        /// <param name="nodeAgentInfo"> Information about the Compute Node agent version and the time the Compute Node upgraded to a new version. </param>
        /// <param name="virtualMachineInfo"> Info about the current state of the virtual machine. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchNode(string id, string url, BatchNodeState? state, SchedulingState? schedulingState, DateTimeOffset? stateTransitionTime, DateTimeOffset? lastBootTime, DateTimeOffset? allocationTime, string ipAddress, string affinityId, string vmSize, int? totalTasksRun, int? runningTasksCount, int? runningTaskSlotsCount, int? totalTasksSucceeded, IReadOnlyList<BatchTaskInfo> recentTasks, BatchStartTask startTask, BatchStartTaskInfo startTaskInfo, IReadOnlyList<BatchCertificateReference> certificateReferences, IReadOnlyList<BatchNodeError> errors, bool? isDedicated, BatchNodeEndpointConfiguration endpointConfiguration, BatchNodeAgentInfo nodeAgentInfo, VirtualMachineInfo virtualMachineInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Url = url;
            State = state;
            SchedulingState = schedulingState;
            StateTransitionTime = stateTransitionTime;
            LastBootTime = lastBootTime;
            AllocationTime = allocationTime;
            IpAddress = ipAddress;
            AffinityId = affinityId;
            VmSize = vmSize;
            TotalTasksRun = totalTasksRun;
            RunningTasksCount = runningTasksCount;
            RunningTaskSlotsCount = runningTaskSlotsCount;
            TotalTasksSucceeded = totalTasksSucceeded;
            RecentTasks = recentTasks;
            StartTask = startTask;
            StartTaskInfo = startTaskInfo;
            CertificateReferences = certificateReferences;
            Errors = errors;
            IsDedicated = isDedicated;
            EndpointConfiguration = endpointConfiguration;
            NodeAgentInfo = nodeAgentInfo;
            VirtualMachineInfo = virtualMachineInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ID of the Compute Node. Every Compute Node that is added to a Pool is assigned a unique ID. Whenever a Compute Node is removed from a Pool, all of its local files are deleted, and the ID is reclaimed and could be reused for new Compute Nodes. </summary>
        public string Id { get; }
        /// <summary> The URL of the Compute Node. </summary>
        public string Url { get; }
        /// <summary> The current state of the Compute Node. The Spot/Low-priority Compute Node has been preempted. Tasks which were running on the Compute Node when it was preempted will be rescheduled when another Compute Node becomes available. </summary>
        public BatchNodeState? State { get; }
        /// <summary> Whether the Compute Node is available for Task scheduling. </summary>
        public SchedulingState? SchedulingState { get; }
        /// <summary> The time at which the Compute Node entered its current state. </summary>
        public DateTimeOffset? StateTransitionTime { get; }
        /// <summary> The last time at which the Compute Node was started. This property may not be present if the Compute Node state is unusable. </summary>
        public DateTimeOffset? LastBootTime { get; }
        /// <summary> The time at which this Compute Node was allocated to the Pool. This is the time when the Compute Node was initially allocated and doesn't change once set. It is not updated when the Compute Node is service healed or preempted. </summary>
        public DateTimeOffset? AllocationTime { get; }
        /// <summary> The IP address that other Nodes can use to communicate with this Compute Node. Every Compute Node that is added to a Pool is assigned a unique IP address. Whenever a Compute Node is removed from a Pool, all of its local files are deleted, and the IP address is reclaimed and could be reused for new Compute Nodes. </summary>
        public string IpAddress { get; }
        /// <summary> An identifier which can be passed when adding a Task to request that the Task be scheduled on this Compute Node. Note that this is just a soft affinity. If the target Compute Node is busy or unavailable at the time the Task is scheduled, then the Task will be scheduled elsewhere. </summary>
        public string AffinityId { get; }
        /// <summary> The size of the virtual machine hosting the Compute Node. For information about available sizes of virtual machines in Pools, see Choose a VM size for Compute Nodes in an Azure Batch Pool (https://learn.microsoft.com/azure/batch/batch-pool-vm-sizes). </summary>
        public string VmSize { get; }
        /// <summary> The total number of Job Tasks completed on the Compute Node. This includes Job Manager Tasks and normal Tasks, but not Job Preparation, Job Release or Start Tasks. </summary>
        public int? TotalTasksRun { get; }
        /// <summary> The total number of currently running Job Tasks on the Compute Node. This includes Job Manager Tasks and normal Tasks, but not Job Preparation, Job Release or Start Tasks. </summary>
        public int? RunningTasksCount { get; }
        /// <summary> The total number of scheduling slots used by currently running Job Tasks on the Compute Node. This includes Job Manager Tasks and normal Tasks, but not Job Preparation, Job Release or Start Tasks. </summary>
        public int? RunningTaskSlotsCount { get; }
        /// <summary> The total number of Job Tasks which completed successfully (with exitCode 0) on the Compute Node. This includes Job Manager Tasks and normal Tasks, but not Job Preparation, Job Release or Start Tasks. </summary>
        public int? TotalTasksSucceeded { get; }
        /// <summary> A list of Tasks whose state has recently changed. This property is present only if at least one Task has run on this Compute Node since it was assigned to the Pool. </summary>
        public IReadOnlyList<BatchTaskInfo> RecentTasks { get; }
        /// <summary> The Task specified to run on the Compute Node as it joins the Pool. </summary>
        public BatchStartTask StartTask { get; }
        /// <summary> Runtime information about the execution of the StartTask on the Compute Node. </summary>
        public BatchStartTaskInfo StartTaskInfo { get; }
        /// <summary>
        /// For Windows Nodes, the Batch service installs the Certificates to the specified Certificate store and location.
        /// For Linux Compute Nodes, the Certificates are stored in a directory inside the Task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the Task to query for this location.
        /// For Certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and Certificates are placed in that directory.
        /// Warning: This property is deprecated and will be removed after February, 2024. Please use the [Azure KeyVault Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide) instead.
        /// </summary>
        public IReadOnlyList<BatchCertificateReference> CertificateReferences { get; }
        /// <summary> The list of errors that are currently being encountered by the Compute Node. </summary>
        public IReadOnlyList<BatchNodeError> Errors { get; }
        /// <summary> Whether this Compute Node is a dedicated Compute Node. If false, the Compute Node is a Spot/Low-priority Compute Node. </summary>
        public bool? IsDedicated { get; }
        /// <summary> The endpoint configuration for the Compute Node. </summary>
        public BatchNodeEndpointConfiguration EndpointConfiguration { get; }
        /// <summary> Information about the Compute Node agent version and the time the Compute Node upgraded to a new version. </summary>
        public BatchNodeAgentInfo NodeAgentInfo { get; }
        /// <summary> Info about the current state of the virtual machine. </summary>
        public VirtualMachineInfo VirtualMachineInfo { get; }
    }
}
