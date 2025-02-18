// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The UnknownFormatReadSettings. </summary>
    internal partial class UnknownFormatReadSettings : FormatReadSettings
    {
        /// <summary> Initializes a new instance of UnknownFormatReadSettings. </summary>
        /// <param name="formatReadSettingsType"> The read setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownFormatReadSettings(string formatReadSettingsType, IDictionary<string, BinaryData> additionalProperties) : base(formatReadSettingsType, additionalProperties)
        {
            FormatReadSettingsType = formatReadSettingsType ?? "Unknown";
        }
    }
}
