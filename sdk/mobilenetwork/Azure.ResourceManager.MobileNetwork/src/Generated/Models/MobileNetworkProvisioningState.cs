// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct MobileNetworkProvisioningState : IEquatable<MobileNetworkProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MobileNetworkProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string SucceededValue = "Succeeded";
        private const string AcceptedValue = "Accepted";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string DeletedValue = "Deleted";

        /// <summary> Unknown. </summary>
        public static MobileNetworkProvisioningState Unknown { get; } = new MobileNetworkProvisioningState(UnknownValue);
        /// <summary> Succeeded. </summary>
        public static MobileNetworkProvisioningState Succeeded { get; } = new MobileNetworkProvisioningState(SucceededValue);
        /// <summary> Accepted. </summary>
        public static MobileNetworkProvisioningState Accepted { get; } = new MobileNetworkProvisioningState(AcceptedValue);
        /// <summary> Deleting. </summary>
        public static MobileNetworkProvisioningState Deleting { get; } = new MobileNetworkProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static MobileNetworkProvisioningState Failed { get; } = new MobileNetworkProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static MobileNetworkProvisioningState Canceled { get; } = new MobileNetworkProvisioningState(CanceledValue);
        /// <summary> Deleted. </summary>
        public static MobileNetworkProvisioningState Deleted { get; } = new MobileNetworkProvisioningState(DeletedValue);
        /// <summary> Determines if two <see cref="MobileNetworkProvisioningState"/> values are the same. </summary>
        public static bool operator ==(MobileNetworkProvisioningState left, MobileNetworkProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MobileNetworkProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(MobileNetworkProvisioningState left, MobileNetworkProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MobileNetworkProvisioningState"/>. </summary>
        public static implicit operator MobileNetworkProvisioningState(string value) => new MobileNetworkProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MobileNetworkProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MobileNetworkProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
