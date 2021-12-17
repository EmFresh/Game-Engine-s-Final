using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System;
using util;

public class Lifetime
{
    [StructLayout(LayoutKind.Sequential)]
    public class Lifespan
    {
        public float span { get; } = 5;
    }

#if UNITY_EDITOR
    const string DLL = "/Plugins/EnginesFinalDLL.dll";
#else
    const string DLL = "/Plugins/x86_64/EnginesFinalDLL.dll";
#endif

    static IntPtr _pluginHandle = IntPtr.Zero;

    #region Plugin Handling
    public static void initPlugin()
    {
        if (_pluginHandle != IntPtr.Zero) return;

        if ((_pluginHandle = ManualPluginImporter.OpenLibrary(Application.dataPath + DLL)) == IntPtr.Zero) return; //No DLL found

        //imported delegates 
        //    getlastnetworkerror = ManualPluginImporter.GetDelegate<getLastNetworkErrorDelegate>(_pluginHandle, "getLastNetworkError");

        setLifespan = ManualPluginImporter.GetDelegate<setLifespanDelegate>(_pluginHandle, "setLifespan");
    }

    public static void closePlugin()
    {
        if (_pluginHandle != IntPtr.Zero)
            ManualPluginImporter.CloseLibrary(_pluginHandle);
    }
    #endregion


    public static setLifespanDelegate setLifespan;
    public delegate void setLifespanDelegate(ref Lifespan sp, float size);


}
