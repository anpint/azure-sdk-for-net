// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> The status of the packet capture session. </summary>
    public readonly partial struct MobileNetworkPacketCaptureStatus : IEquatable<MobileNetworkPacketCaptureStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkPacketCaptureStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MobileNetworkPacketCaptureStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string RunningValue = "Running";
        private const string StoppedValue = "Stopped";
        private const string ErrorValue = "Error";

        /// <summary> NotStarted. </summary>
        public static MobileNetworkPacketCaptureStatus NotStarted { get; } = new MobileNetworkPacketCaptureStatus(NotStartedValue);
        /// <summary> Running. </summary>
        public static MobileNetworkPacketCaptureStatus Running { get; } = new MobileNetworkPacketCaptureStatus(RunningValue);
        /// <summary> Stopped. </summary>
        public static MobileNetworkPacketCaptureStatus Stopped { get; } = new MobileNetworkPacketCaptureStatus(StoppedValue);
        /// <summary> Error. </summary>
        public static MobileNetworkPacketCaptureStatus Error { get; } = new MobileNetworkPacketCaptureStatus(ErrorValue);
        /// <summary> Determines if two <see cref="MobileNetworkPacketCaptureStatus"/> values are the same. </summary>
        public static bool operator ==(MobileNetworkPacketCaptureStatus left, MobileNetworkPacketCaptureStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MobileNetworkPacketCaptureStatus"/> values are not the same. </summary>
        public static bool operator !=(MobileNetworkPacketCaptureStatus left, MobileNetworkPacketCaptureStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MobileNetworkPacketCaptureStatus"/>. </summary>
        public static implicit operator MobileNetworkPacketCaptureStatus(string value) => new MobileNetworkPacketCaptureStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MobileNetworkPacketCaptureStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MobileNetworkPacketCaptureStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
