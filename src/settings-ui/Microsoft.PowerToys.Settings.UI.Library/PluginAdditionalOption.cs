// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace Microsoft.PowerToys.Settings.UI.Library
{
    public class PluginAdditionalOption : IEquatable<PluginAdditionalOption>
    {
        public string Key { get; set; }

        public string DisplayLabel { get; set; }

        public bool Value { get; set; }

        public bool Equals(PluginAdditionalOption other)
        {
            return Key == other?.Key;
        }

        public override int GetHashCode()
        {
            return 990326508 + EqualityComparer<string>.Default.GetHashCode(Key);
        }

        public override bool Equals(object obj) => Equals(obj as PluginAdditionalOption);
    }
}
