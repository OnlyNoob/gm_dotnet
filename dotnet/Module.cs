﻿using GSharp.GLuaNET;
using GSharp.Native;
using GSharp.Native.Classes;
using GSharp.Native.Classes.VCR;
using RGiesecke.DllExport;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace dotnet
{
    /*static class cpp_sandbox
    {
        [DllImport("cpp_sandbox")]
        public static extern void cpp_test();
    }*/

    public unsafe static class Module
    {
        
        [DllExport("gmod13_open", CallingConvention = CallingConvention.Cdecl)]
        public static int Open(lua_state L)
        {
            var glua = new GLua(L);

            lua_CFunction d = SomeCFunction;
            GCHandle.Alloc(d);
            glua.PushCFunction(d);
            glua.SetField(GLua.LUA_GLOBALSINDEX, "somecfunction");

            Console.WriteLine("DotNet loaded");
            return 0;
        }

        public static int SomeCFunction(lua_state L)
        {
            Debug.WriteLine("ran cfunction!!");
            return 0;
        }

        static Hook_Cmd_Exec new_Hook_Cmd_Exec;
        static Hook_Cmd_Exec old_Hook_Cmd_Exec;
        public static void Hook_Cmd_Exec(string[] Args)
        {
            old_Hook_Cmd_Exec(Args);
        }

        [DllExport("gmod13_close", CallingConvention = CallingConvention.Cdecl)]
        public static int Close(IntPtr L)
        {
            return 0;
        }
    }


    
}
