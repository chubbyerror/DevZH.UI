﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DevZH.UI.Interop
{
    internal partial class NativeMethods
    {
        [DllImport(LibUI, CallingConvention = CallingConvention.Cdecl, EntryPoint = "uiSpinboxValue")]
        public static extern int SpinBoxValue(ControlHandle spinBox);

        [DllImport(LibUI, CallingConvention = CallingConvention.Cdecl, EntryPoint = "uiSpinboxSetValue")]
        public static extern void SpinBoxSetValue(ControlHandle spinBox, int value);

        [DllImport(LibUI, CallingConvention = CallingConvention.Cdecl, EntryPoint = "uiSpinboxOnChanged")]
        public static extern void SpinBoxOnChanged(ControlHandle spinBox, SpinBoxOnChangedDelegate spinBoxOnChanged, IntPtr data);

        [DllImport(LibUI, CallingConvention = CallingConvention.Cdecl, EntryPoint = "uiNewSpinbox")]
        public static extern ControlHandle NewSpinBox(int min, int max);
    }
}
