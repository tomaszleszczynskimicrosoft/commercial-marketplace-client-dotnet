// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Marketplace.SaaS.Models
{
    public partial class AadIdentifier
    {
        internal static AadIdentifier DeserializeAadIdentifier(JsonElement element)
        {
            Optional<string> emailId = default;
            Optional<Guid> objectId = default;
            Optional<Guid> tenantId = default;
            Optional<string> puid = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("emailId"))
                {
                    emailId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    objectId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("puid"))
                {
                    puid = property.Value.GetString();
                    continue;
                }
            }
            return new AadIdentifier(emailId.Value, Optional.ToNullable(objectId), Optional.ToNullable(tenantId), puid.Value);
        }
    }
}