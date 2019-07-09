// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

internal static partial class Interop
{
    internal static partial class Sys
    {
        [DllImport(Libraries.SystemNative, EntryPoint = "SystemNative_GetFatAttr", SetLastError = true)]
        internal static extern int GetFatAttr(SafeFileHandle fd);

        [DllImport(Libraries.SystemNative, EntryPoint = "SystemNative_SetFatAttr", SetLastError = true)]
        internal static extern int SetFatAttr(SafeFileHandle fd, FileAttributes attributes);
    }
}
