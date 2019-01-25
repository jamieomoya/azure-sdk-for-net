// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GlobalUsersOperations.
    /// </summary>
    public static partial class GlobalUsersOperationsExtensions
    {
            /// <summary>
            /// Gets the virtual machine details
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='environmentOperationsPayload'>
            /// Represents payload for any Environment operations like get, start, stop,
            /// connect
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example: 'properties($expand=environment)'
            /// </param>
            public static GetEnvironmentResponse GetEnvironment(this IGlobalUsersOperations operations, string userName, EnvironmentOperationsPayload environmentOperationsPayload, string expand = default(string))
            {
                return operations.GetEnvironmentAsync(userName, environmentOperationsPayload, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the virtual machine details
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='environmentOperationsPayload'>
            /// Represents payload for any Environment operations like get, start, stop,
            /// connect
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example: 'properties($expand=environment)'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetEnvironmentResponse> GetEnvironmentAsync(this IGlobalUsersOperations operations, string userName, EnvironmentOperationsPayload environmentOperationsPayload, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEnvironmentWithHttpMessagesAsync(userName, environmentOperationsPayload, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get batch operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='operationBatchStatusPayload'>
            /// Payload to get the status of an operation
            /// </param>
            public static OperationBatchStatusResponse GetOperationBatchStatus(this IGlobalUsersOperations operations, string userName, OperationBatchStatusPayload operationBatchStatusPayload)
            {
                return operations.GetOperationBatchStatusAsync(userName, operationBatchStatusPayload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get batch operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='operationBatchStatusPayload'>
            /// Payload to get the status of an operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationBatchStatusResponse> GetOperationBatchStatusAsync(this IGlobalUsersOperations operations, string userName, OperationBatchStatusPayload operationBatchStatusPayload, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetOperationBatchStatusWithHttpMessagesAsync(userName, operationBatchStatusPayload, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the status of long running operation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='operationStatusPayload'>
            /// Payload to get the status of an operation
            /// </param>
            public static OperationStatusResponse GetOperationStatus(this IGlobalUsersOperations operations, string userName, OperationStatusPayload operationStatusPayload)
            {
                return operations.GetOperationStatusAsync(userName, operationStatusPayload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the status of long running operation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='operationStatusPayload'>
            /// Payload to get the status of an operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatusResponse> GetOperationStatusAsync(this IGlobalUsersOperations operations, string userName, OperationStatusPayload operationStatusPayload, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetOperationStatusWithHttpMessagesAsync(userName, operationStatusPayload, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get personal preferences for a user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='personalPerferencesOperationsPayload'>
            /// Represents payload for any Environment operations like get, start, stop,
            /// connect
            /// </param>
            public static GetPersonalPreferencesResponse GetPersonalPreferences(this IGlobalUsersOperations operations, string userName, PersonalPerferencesOperationsPayload personalPerferencesOperationsPayload)
            {
                return operations.GetPersonalPreferencesAsync(userName, personalPerferencesOperationsPayload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get personal preferences for a user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='personalPerferencesOperationsPayload'>
            /// Represents payload for any Environment operations like get, start, stop,
            /// connect
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetPersonalPreferencesResponse> GetPersonalPreferencesAsync(this IGlobalUsersOperations operations, string userName, PersonalPerferencesOperationsPayload personalPerferencesOperationsPayload, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPersonalPreferencesWithHttpMessagesAsync(userName, personalPerferencesOperationsPayload, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List Environments for the user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='listEnvironmentsPayload'>
            /// Represents the payload to list environments owned by a user
            /// </param>
            public static ListEnvironmentsResponse ListEnvironments(this IGlobalUsersOperations operations, string userName, ListEnvironmentsPayload listEnvironmentsPayload)
            {
                return operations.ListEnvironmentsAsync(userName, listEnvironmentsPayload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Environments for the user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='listEnvironmentsPayload'>
            /// Represents the payload to list environments owned by a user
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ListEnvironmentsResponse> ListEnvironmentsAsync(this IGlobalUsersOperations operations, string userName, ListEnvironmentsPayload listEnvironmentsPayload, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListEnvironmentsWithHttpMessagesAsync(userName, listEnvironmentsPayload, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List labs for the user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            public static ListLabsResponse ListLabs(this IGlobalUsersOperations operations, string userName)
            {
                return operations.ListLabsAsync(userName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List labs for the user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ListLabsResponse> ListLabsAsync(this IGlobalUsersOperations operations, string userName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListLabsWithHttpMessagesAsync(userName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Register a user to a managed lab
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='registerPayload'>
            /// Represents payload for Register action.
            /// </param>
            public static void Register(this IGlobalUsersOperations operations, string userName, RegisterPayload registerPayload)
            {
                operations.RegisterAsync(userName, registerPayload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Register a user to a managed lab
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='registerPayload'>
            /// Represents payload for Register action.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RegisterAsync(this IGlobalUsersOperations operations, string userName, RegisterPayload registerPayload, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RegisterWithHttpMessagesAsync(userName, registerPayload, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Resets the user password on an environment This operation can take a while
            /// to complete
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='resetPasswordPayload'>
            /// Represents the payload for resetting passwords.
            /// </param>
            public static void ResetPassword(this IGlobalUsersOperations operations, string userName, ResetPasswordPayload resetPasswordPayload)
            {
                operations.ResetPasswordAsync(userName, resetPasswordPayload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resets the user password on an environment This operation can take a while
            /// to complete
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='resetPasswordPayload'>
            /// Represents the payload for resetting passwords.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ResetPasswordAsync(this IGlobalUsersOperations operations, string userName, ResetPasswordPayload resetPasswordPayload, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ResetPasswordWithHttpMessagesAsync(userName, resetPasswordPayload, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Starts an environment by starting all resources inside the environment.
            /// This operation can take a while to complete
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='environmentOperationsPayload'>
            /// Represents payload for any Environment operations like get, start, stop,
            /// connect
            /// </param>
            public static void StartEnvironment(this IGlobalUsersOperations operations, string userName, EnvironmentOperationsPayload environmentOperationsPayload)
            {
                operations.StartEnvironmentAsync(userName, environmentOperationsPayload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Starts an environment by starting all resources inside the environment.
            /// This operation can take a while to complete
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='environmentOperationsPayload'>
            /// Represents payload for any Environment operations like get, start, stop,
            /// connect
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StartEnvironmentAsync(this IGlobalUsersOperations operations, string userName, EnvironmentOperationsPayload environmentOperationsPayload, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.StartEnvironmentWithHttpMessagesAsync(userName, environmentOperationsPayload, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Stops an environment by stopping all resources inside the environment This
            /// operation can take a while to complete
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='environmentOperationsPayload'>
            /// Represents payload for any Environment operations like get, start, stop,
            /// connect
            /// </param>
            public static void StopEnvironment(this IGlobalUsersOperations operations, string userName, EnvironmentOperationsPayload environmentOperationsPayload)
            {
                operations.StopEnvironmentAsync(userName, environmentOperationsPayload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Stops an environment by stopping all resources inside the environment This
            /// operation can take a while to complete
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='environmentOperationsPayload'>
            /// Represents payload for any Environment operations like get, start, stop,
            /// connect
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StopEnvironmentAsync(this IGlobalUsersOperations operations, string userName, EnvironmentOperationsPayload environmentOperationsPayload, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.StopEnvironmentWithHttpMessagesAsync(userName, environmentOperationsPayload, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Resets the user password on an environment This operation can take a while
            /// to complete
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='resetPasswordPayload'>
            /// Represents the payload for resetting passwords.
            /// </param>
            public static void BeginResetPassword(this IGlobalUsersOperations operations, string userName, ResetPasswordPayload resetPasswordPayload)
            {
                operations.BeginResetPasswordAsync(userName, resetPasswordPayload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resets the user password on an environment This operation can take a while
            /// to complete
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='resetPasswordPayload'>
            /// Represents the payload for resetting passwords.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginResetPasswordAsync(this IGlobalUsersOperations operations, string userName, ResetPasswordPayload resetPasswordPayload, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginResetPasswordWithHttpMessagesAsync(userName, resetPasswordPayload, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Starts an environment by starting all resources inside the environment.
            /// This operation can take a while to complete
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='environmentOperationsPayload'>
            /// Represents payload for any Environment operations like get, start, stop,
            /// connect
            /// </param>
            public static void BeginStartEnvironment(this IGlobalUsersOperations operations, string userName, EnvironmentOperationsPayload environmentOperationsPayload)
            {
                operations.BeginStartEnvironmentAsync(userName, environmentOperationsPayload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Starts an environment by starting all resources inside the environment.
            /// This operation can take a while to complete
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='environmentOperationsPayload'>
            /// Represents payload for any Environment operations like get, start, stop,
            /// connect
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStartEnvironmentAsync(this IGlobalUsersOperations operations, string userName, EnvironmentOperationsPayload environmentOperationsPayload, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginStartEnvironmentWithHttpMessagesAsync(userName, environmentOperationsPayload, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Stops an environment by stopping all resources inside the environment This
            /// operation can take a while to complete
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='environmentOperationsPayload'>
            /// Represents payload for any Environment operations like get, start, stop,
            /// connect
            /// </param>
            public static void BeginStopEnvironment(this IGlobalUsersOperations operations, string userName, EnvironmentOperationsPayload environmentOperationsPayload)
            {
                operations.BeginStopEnvironmentAsync(userName, environmentOperationsPayload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Stops an environment by stopping all resources inside the environment This
            /// operation can take a while to complete
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// The name of the user.
            /// </param>
            /// <param name='environmentOperationsPayload'>
            /// Represents payload for any Environment operations like get, start, stop,
            /// connect
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStopEnvironmentAsync(this IGlobalUsersOperations operations, string userName, EnvironmentOperationsPayload environmentOperationsPayload, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginStopEnvironmentWithHttpMessagesAsync(userName, environmentOperationsPayload, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
