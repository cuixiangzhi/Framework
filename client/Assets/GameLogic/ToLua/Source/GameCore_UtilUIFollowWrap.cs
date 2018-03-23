﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class GameCore_UtilUIFollowWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("UtilUIFollow");
		L.RegFunction("Init", Init);
		L.RegFunction("LateLoop", LateLoop);
		L.RegFunction("Exit", Exit);
		L.RegFunction("AddFollow", AddFollow);
		L.RegFunction("RemoveFollow", RemoveFollow);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			GameCore.UtilUIFollow.Init();
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
			GameCore.UtilUIFollow.LateLoop();
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
			GameCore.UtilUIFollow.Exit();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddFollow(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckObject<UnityEngine.Transform>(L, 1);
			UnityEngine.Transform arg1 = (UnityEngine.Transform)ToLua.CheckObject<UnityEngine.Transform>(L, 2);
			UnityEngine.Vector3 arg2 = ToLua.ToVector3(L, 3);
			UnityEngine.Vector3 arg3 = ToLua.ToVector3(L, 4);
			GameCore.UtilUIFollow.AddFollow(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveFollow(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckObject<UnityEngine.Transform>(L, 1);
			GameCore.UtilUIFollow.RemoveFollow(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
