﻿using Aimp4.Api;
using RGiesecke.DllExport;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AimpLyrics
{
    public static class EntryPoint
    {
        [DllExport("AIMPPluginGetHeader", CallingConvention.StdCall)]
        public static IntPtr AIMPPluginGetHeader([MarshalAs(UnmanagedType.Interface)] out IAIMPPlugin header)
        {
            Debug.WriteLine("AIMPPluginGetHeader");
            try
            {
                header = new AimpLyricsPlugin();
                return IntPtr.Zero;
            }
            catch (Exception exception)
            {
                header = null;
                return (IntPtr)exception.HResult;
            }
        }
    }
}