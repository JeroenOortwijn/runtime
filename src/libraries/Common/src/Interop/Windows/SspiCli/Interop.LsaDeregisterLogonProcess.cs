// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class SspiCli
    {
        [DllImport(Interop.Libraries.SspiCli)]
        internal static extern int LsaDeregisterLogonProcess(IntPtr LsaHandle);
    }
}
