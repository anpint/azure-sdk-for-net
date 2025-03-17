// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> The certificate's provisioning state. </summary>
    public readonly partial struct CertificateProvisioningState : IEquatable<CertificateProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CertificateProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CertificateProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotProvisionedValue = "NotProvisioned";
        private const string ProvisionedValue = "Provisioned";
        private const string FailedValue = "Failed";

        /// <summary> The certificate has not been provisioned. </summary>
        public static CertificateProvisioningState NotProvisioned { get; } = new CertificateProvisioningState(NotProvisionedValue);
        /// <summary> The certificate has been provisioned. </summary>
        public static CertificateProvisioningState Provisioned { get; } = new CertificateProvisioningState(ProvisionedValue);
        /// <summary> The certificate failed to be provisioned. The "reason" property explains why. </summary>
        public static CertificateProvisioningState Failed { get; } = new CertificateProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="CertificateProvisioningState"/> values are the same. </summary>
        public static bool operator ==(CertificateProvisioningState left, CertificateProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CertificateProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(CertificateProvisioningState left, CertificateProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CertificateProvisioningState"/>. </summary>
        public static implicit operator CertificateProvisioningState(string value) => new CertificateProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CertificateProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CertificateProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
