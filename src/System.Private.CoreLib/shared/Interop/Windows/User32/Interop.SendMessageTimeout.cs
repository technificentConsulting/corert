// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class User32
    {
        [DllImport(Libraries.User32, EntryPoint = "SendMessageTimeoutW", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessageTimeout(IntPtr hWnd, int msg, IntPtr wParam, string lParam, int flags, int timeout, IntPtr pdwResult);
    }
}
