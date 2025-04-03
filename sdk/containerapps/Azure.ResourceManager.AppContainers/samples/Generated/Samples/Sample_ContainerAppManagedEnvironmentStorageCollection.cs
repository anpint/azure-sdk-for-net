// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppContainers.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppManagedEnvironmentStorageCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateEnvironmentsStorage()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/ManagedEnvironmentsStorages_CreateOrUpdate.json
            // this example is just showing the usage of "ManagedEnvironmentsStorages_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "managedEnv";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this ContainerAppManagedEnvironmentStorageResource
            ContainerAppManagedEnvironmentStorageCollection collection = containerAppManagedEnvironment.GetContainerAppManagedEnvironmentStorages();

            // invoke the operation
            string storageName = "jlaw-demo1";
            ContainerAppManagedEnvironmentStorageData data = new ContainerAppManagedEnvironmentStorageData
            {
                Properties = new ManagedEnvironmentStorageProperties
                {
                    AzureFile = new ContainerAppAzureFileProperties
                    {
                        AccountName = "account1",
                        AccountKey = "key",
                        AccessMode = ContainerAppAccessMode.ReadOnly,
                        ShareName = "share1",
                    },
                },
            };
            ArmOperation<ContainerAppManagedEnvironmentStorageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, storageName, data);
            ContainerAppManagedEnvironmentStorageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppManagedEnvironmentStorageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateEnvironmentsStorageForNFSAzureFile()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/ManagedEnvironmentsStorages_CreateOrUpdate_NfsAzureFile.json
            // this example is just showing the usage of "ManagedEnvironmentsStorages_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "managedEnv";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this ContainerAppManagedEnvironmentStorageResource
            ContainerAppManagedEnvironmentStorageCollection collection = containerAppManagedEnvironment.GetContainerAppManagedEnvironmentStorages();

            // invoke the operation
            string storageName = "jlaw-demo1";
            ContainerAppManagedEnvironmentStorageData data = new ContainerAppManagedEnvironmentStorageData
            {
                Properties = new ManagedEnvironmentStorageProperties
                {
                    NfsAzureFile = new ContainerAppNfsAzureFileProperties
                    {
                        Server = "server1",
                        AccessMode = ContainerAppAccessMode.ReadOnly,
                        ShareName = "share1",
                    },
                },
            };
            ArmOperation<ContainerAppManagedEnvironmentStorageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, storageName, data);
            ContainerAppManagedEnvironmentStorageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppManagedEnvironmentStorageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAEnvironmentsStorage()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/ManagedEnvironmentsStorages_Get.json
            // this example is just showing the usage of "ManagedEnvironmentsStorages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "managedEnv";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this ContainerAppManagedEnvironmentStorageResource
            ContainerAppManagedEnvironmentStorageCollection collection = containerAppManagedEnvironment.GetContainerAppManagedEnvironmentStorages();

            // invoke the operation
            string storageName = "jlaw-demo1";
            ContainerAppManagedEnvironmentStorageResource result = await collection.GetAsync(storageName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppManagedEnvironmentStorageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAEnvironmentsStorageForNFSAzureFile()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/ManagedEnvironmentsStorages_Get_NfsAzureFile.json
            // this example is just showing the usage of "ManagedEnvironmentsStorages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "managedEnv";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this ContainerAppManagedEnvironmentStorageResource
            ContainerAppManagedEnvironmentStorageCollection collection = containerAppManagedEnvironment.GetContainerAppManagedEnvironmentStorages();

            // invoke the operation
            string storageName = "jlaw-demo1";
            ContainerAppManagedEnvironmentStorageResource result = await collection.GetAsync(storageName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppManagedEnvironmentStorageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListEnvironmentsStoragesBySubscription()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/ManagedEnvironmentsStorages_List.json
            // this example is just showing the usage of "ManagedEnvironmentsStorages_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "managedEnv";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this ContainerAppManagedEnvironmentStorageResource
            ContainerAppManagedEnvironmentStorageCollection collection = containerAppManagedEnvironment.GetContainerAppManagedEnvironmentStorages();

            // invoke the operation and iterate over the result
            await foreach (ContainerAppManagedEnvironmentStorageResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppManagedEnvironmentStorageData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAEnvironmentsStorage()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/ManagedEnvironmentsStorages_Get.json
            // this example is just showing the usage of "ManagedEnvironmentsStorages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "managedEnv";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this ContainerAppManagedEnvironmentStorageResource
            ContainerAppManagedEnvironmentStorageCollection collection = containerAppManagedEnvironment.GetContainerAppManagedEnvironmentStorages();

            // invoke the operation
            string storageName = "jlaw-demo1";
            bool result = await collection.ExistsAsync(storageName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAEnvironmentsStorageForNFSAzureFile()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/ManagedEnvironmentsStorages_Get_NfsAzureFile.json
            // this example is just showing the usage of "ManagedEnvironmentsStorages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "managedEnv";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this ContainerAppManagedEnvironmentStorageResource
            ContainerAppManagedEnvironmentStorageCollection collection = containerAppManagedEnvironment.GetContainerAppManagedEnvironmentStorages();

            // invoke the operation
            string storageName = "jlaw-demo1";
            bool result = await collection.ExistsAsync(storageName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAEnvironmentsStorage()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/ManagedEnvironmentsStorages_Get.json
            // this example is just showing the usage of "ManagedEnvironmentsStorages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "managedEnv";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this ContainerAppManagedEnvironmentStorageResource
            ContainerAppManagedEnvironmentStorageCollection collection = containerAppManagedEnvironment.GetContainerAppManagedEnvironmentStorages();

            // invoke the operation
            string storageName = "jlaw-demo1";
            NullableResponse<ContainerAppManagedEnvironmentStorageResource> response = await collection.GetIfExistsAsync(storageName);
            ContainerAppManagedEnvironmentStorageResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppManagedEnvironmentStorageData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAEnvironmentsStorageForNFSAzureFile()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/ManagedEnvironmentsStorages_Get_NfsAzureFile.json
            // this example is just showing the usage of "ManagedEnvironmentsStorages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentResource, please refer to the document of ContainerAppManagedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "managedEnv";
            ResourceIdentifier containerAppManagedEnvironmentResourceId = ContainerAppManagedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName);
            ContainerAppManagedEnvironmentResource containerAppManagedEnvironment = client.GetContainerAppManagedEnvironmentResource(containerAppManagedEnvironmentResourceId);

            // get the collection of this ContainerAppManagedEnvironmentStorageResource
            ContainerAppManagedEnvironmentStorageCollection collection = containerAppManagedEnvironment.GetContainerAppManagedEnvironmentStorages();

            // invoke the operation
            string storageName = "jlaw-demo1";
            NullableResponse<ContainerAppManagedEnvironmentStorageResource> response = await collection.GetIfExistsAsync(storageName);
            ContainerAppManagedEnvironmentStorageResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppManagedEnvironmentStorageData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
