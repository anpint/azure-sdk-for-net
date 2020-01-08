// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GalleryApplicationVersionsOperations.
    /// </summary>
    public static partial class GalleryApplicationVersionsOperationsExtensions
    {
            /// <summary>
            /// Create or update a gallery Application Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition resides.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition in which the Application
            /// Version is to be created.
            /// </param>
            /// <param name='galleryApplicationVersionName'>
            /// The name of the gallery Application Version to be created. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryApplicationVersion'>
            /// Parameters supplied to the create or update gallery Application Version
            /// operation.
            /// </param>
            public static GalleryApplicationVersion CreateOrUpdate(this IGalleryApplicationVersionsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, GalleryApplicationVersion galleryApplicationVersion)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a gallery Application Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition resides.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition in which the Application
            /// Version is to be created.
            /// </param>
            /// <param name='galleryApplicationVersionName'>
            /// The name of the gallery Application Version to be created. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryApplicationVersion'>
            /// Parameters supplied to the create or update gallery Application Version
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryApplicationVersion> CreateOrUpdateAsync(this IGalleryApplicationVersionsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, GalleryApplicationVersion galleryApplicationVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a gallery Application Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition resides.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition in which the Application
            /// Version is to be updated.
            /// </param>
            /// <param name='galleryApplicationVersionName'>
            /// The name of the gallery Application Version to be updated. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryApplicationVersion'>
            /// Parameters supplied to the update gallery Application Version operation.
            /// </param>
            public static GalleryApplicationVersion Update(this IGalleryApplicationVersionsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, GalleryApplicationVersionUpdate galleryApplicationVersion)
            {
                return operations.UpdateAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a gallery Application Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition resides.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition in which the Application
            /// Version is to be updated.
            /// </param>
            /// <param name='galleryApplicationVersionName'>
            /// The name of the gallery Application Version to be updated. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryApplicationVersion'>
            /// Parameters supplied to the update gallery Application Version operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryApplicationVersion> UpdateAsync(this IGalleryApplicationVersionsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, GalleryApplicationVersionUpdate galleryApplicationVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves information about a gallery Application Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition resides.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition in which the Application
            /// Version resides.
            /// </param>
            /// <param name='galleryApplicationVersionName'>
            /// The name of the gallery Application Version to be retrieved.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation. Possible values include:
            /// 'ReplicationStatus'
            /// </param>
            public static GalleryApplicationVersion Get(this IGalleryApplicationVersionsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves information about a gallery Application Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition resides.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition in which the Application
            /// Version resides.
            /// </param>
            /// <param name='galleryApplicationVersionName'>
            /// The name of the gallery Application Version to be retrieved.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation. Possible values include:
            /// 'ReplicationStatus'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryApplicationVersion> GetAsync(this IGalleryApplicationVersionsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a gallery Application Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition resides.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition in which the Application
            /// Version resides.
            /// </param>
            /// <param name='galleryApplicationVersionName'>
            /// The name of the gallery Application Version to be deleted.
            /// </param>
            public static void Delete(this IGalleryApplicationVersionsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName)
            {
                operations.DeleteAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a gallery Application Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition resides.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition in which the Application
            /// Version resides.
            /// </param>
            /// <param name='galleryApplicationVersionName'>
            /// The name of the gallery Application Version to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IGalleryApplicationVersionsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List gallery Application Versions in a gallery Application Definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition resides.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the Shared Application Gallery Application Definition from
            /// which the Application Versions are to be listed.
            /// </param>
            public static IPage<GalleryApplicationVersion> ListByGalleryApplication(this IGalleryApplicationVersionsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName)
            {
                return operations.ListByGalleryApplicationAsync(resourceGroupName, galleryName, galleryApplicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List gallery Application Versions in a gallery Application Definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition resides.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the Shared Application Gallery Application Definition from
            /// which the Application Versions are to be listed.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<GalleryApplicationVersion>> ListByGalleryApplicationAsync(this IGalleryApplicationVersionsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByGalleryApplicationWithHttpMessagesAsync(resourceGroupName, galleryName, galleryApplicationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a gallery Application Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition resides.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition in which the Application
            /// Version is to be created.
            /// </param>
            /// <param name='galleryApplicationVersionName'>
            /// The name of the gallery Application Version to be created. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryApplicationVersion'>
            /// Parameters supplied to the create or update gallery Application Version
            /// operation.
            /// </param>
            public static GalleryApplicationVersion BeginCreateOrUpdate(this IGalleryApplicationVersionsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, GalleryApplicationVersion galleryApplicationVersion)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a gallery Application Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition resides.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition in which the Application
            /// Version is to be created.
            /// </param>
            /// <param name='galleryApplicationVersionName'>
            /// The name of the gallery Application Version to be created. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryApplicationVersion'>
            /// Parameters supplied to the create or update gallery Application Version
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryApplicationVersion> BeginCreateOrUpdateAsync(this IGalleryApplicationVersionsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, GalleryApplicationVersion galleryApplicationVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a gallery Application Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition resides.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition in which the Application
            /// Version is to be updated.
            /// </param>
            /// <param name='galleryApplicationVersionName'>
            /// The name of the gallery Application Version to be updated. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryApplicationVersion'>
            /// Parameters supplied to the update gallery Application Version operation.
            /// </param>
            public static GalleryApplicationVersion BeginUpdate(this IGalleryApplicationVersionsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, GalleryApplicationVersionUpdate galleryApplicationVersion)
            {
                return operations.BeginUpdateAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a gallery Application Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition resides.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition in which the Application
            /// Version is to be updated.
            /// </param>
            /// <param name='galleryApplicationVersionName'>
            /// The name of the gallery Application Version to be updated. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryApplicationVersion'>
            /// Parameters supplied to the update gallery Application Version operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryApplicationVersion> BeginUpdateAsync(this IGalleryApplicationVersionsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, GalleryApplicationVersionUpdate galleryApplicationVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a gallery Application Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition resides.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition in which the Application
            /// Version resides.
            /// </param>
            /// <param name='galleryApplicationVersionName'>
            /// The name of the gallery Application Version to be deleted.
            /// </param>
            public static void BeginDelete(this IGalleryApplicationVersionsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName)
            {
                operations.BeginDeleteAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a gallery Application Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Application Gallery in which the Application
            /// Definition resides.
            /// </param>
            /// <param name='galleryApplicationName'>
            /// The name of the gallery Application Definition in which the Application
            /// Version resides.
            /// </param>
            /// <param name='galleryApplicationVersionName'>
            /// The name of the gallery Application Version to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IGalleryApplicationVersionsOperations operations, string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List gallery Application Versions in a gallery Application Definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<GalleryApplicationVersion> ListByGalleryApplicationNext(this IGalleryApplicationVersionsOperations operations, string nextPageLink)
            {
                return operations.ListByGalleryApplicationNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List gallery Application Versions in a gallery Application Definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<GalleryApplicationVersion>> ListByGalleryApplicationNextAsync(this IGalleryApplicationVersionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByGalleryApplicationNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
