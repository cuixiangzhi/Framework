﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class GF_ResManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("ResManager");
		L.RegFunction("Init", Init);
		L.RegFunction("LateLoop", LateLoop);
		L.RegFunction("Exit", Exit);
		L.RegFunction("Destroy", Destroy);
		L.RegFunction("LoadBytes", LoadBytes);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			GF.ResManager.Init();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LateLoop(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			GF.ResManager.LateLoop();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Exit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			GF.ResManager.Exit();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Destroy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
			GF.ResManager.Destroy(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadBytes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			LuaInterface.LuaByteBuffer o = GF.ResManager.LoadBytes(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

