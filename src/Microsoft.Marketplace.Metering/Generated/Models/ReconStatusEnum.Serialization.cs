// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.Marketplace.Metering.Models
{
    internal static partial class ReconStatusEnumExtensions
    {
        public static string ToSerialString(this ReconStatusEnum value) => value switch
        {
            ReconStatusEnum.Submitted => "Submitted",
            ReconStatusEnum.Accepted => "Accepted",
            ReconStatusEnum.Rejected => "Rejected",
            ReconStatusEnum.Mismatch => "Mismatch",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ReconStatusEnum value.")
        };

        public static ReconStatusEnum ToReconStatusEnum(this string value)
        {
            if (string.Equals(value, "Submitted", StringComparison.InvariantCultureIgnoreCase)) return ReconStatusEnum.Submitted;
            if (string.Equals(value, "Accepted", StringComparison.InvariantCultureIgnoreCase)) return ReconStatusEnum.Accepted;
            if (string.Equals(value, "Rejected", StringComparison.InvariantCultureIgnoreCase)) return ReconStatusEnum.Rejected;
            if (string.Equals(value, "Mismatch", StringComparison.InvariantCultureIgnoreCase)) return ReconStatusEnum.Mismatch;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ReconStatusEnum value.");
        }
    }
}