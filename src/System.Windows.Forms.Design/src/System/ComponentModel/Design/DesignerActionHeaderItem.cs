﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace System.ComponentModel.Design
{
    public sealed class DesignerActionHeaderItem : DesignerActionTextItem
    {
        public DesignerActionHeaderItem(string displayName) : base(displayName, displayName)
        {
        }

        public DesignerActionHeaderItem(string displayName, string category) : base(displayName, category)
        {
        }
    }
}
