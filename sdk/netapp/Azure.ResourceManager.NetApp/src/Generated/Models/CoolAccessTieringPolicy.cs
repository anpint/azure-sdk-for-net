// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> coolAccessTieringPolicy determines which cold data blocks are moved to cool tier. The possible values for this field are: Auto - Moves cold user data blocks in both the Snapshot copies and the active file system to the cool tier tier. This policy is the default. SnapshotOnly - Moves user data blocks of the Volume Snapshot copies that are not associated with the active file system to the cool tier. </summary>
    public readonly partial struct CoolAccessTieringPolicy : IEquatable<CoolAccessTieringPolicy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CoolAccessTieringPolicy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CoolAccessTieringPolicy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "Auto";
        private const string SnapshotOnlyValue = "SnapshotOnly";

        /// <summary> Auto. </summary>
        public static CoolAccessTieringPolicy Auto { get; } = new CoolAccessTieringPolicy(AutoValue);
        /// <summary> SnapshotOnly. </summary>
        public static CoolAccessTieringPolicy SnapshotOnly { get; } = new CoolAccessTieringPolicy(SnapshotOnlyValue);
        /// <summary> Determines if two <see cref="CoolAccessTieringPolicy"/> values are the same. </summary>
        public static bool operator ==(CoolAccessTieringPolicy left, CoolAccessTieringPolicy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CoolAccessTieringPolicy"/> values are not the same. </summary>
        public static bool operator !=(CoolAccessTieringPolicy left, CoolAccessTieringPolicy right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CoolAccessTieringPolicy"/>. </summary>
        public static implicit operator CoolAccessTieringPolicy(string value) => new CoolAccessTieringPolicy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CoolAccessTieringPolicy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CoolAccessTieringPolicy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
