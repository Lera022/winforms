﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable

using Windows.Win32.System.Com;
using System.Diagnostics;

namespace System.Windows.Forms.Tests;

/// <summary>
///  Custom <see cref="AxHost"/> that directly uses a <see cref="ComClassFactory"/>.
/// </summary>
public unsafe class DynamicAxHost : AxHost
{
    private readonly ComClassFactory _factory;

    internal DynamicAxHost(ComClassFactory factory) : base(factory.ClassId.ToString("D"), 0)
    {
        _factory = factory;
    }

    protected override object CreateInstanceCore(Guid clsid)
    {
        Debug.Assert(clsid == _factory.ClassId);
        _factory.CreateInstance(out object unknown).ThrowOnFailure();
        return unknown;
    }
}
