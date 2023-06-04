using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

/// <summary>
/// 系统管理器
/// </summary>
public class SystemManager : MonoBehaviour
{
    private List<SystemBase<object>> m_AllSystem = new List<SystemBase<object>>();
    private void Awake()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var types = assembly.GetTypes();
        var classesWithAttribute = types.Where(t=>t.GetCustomAttribute<RegisterSystem>() != null);
        foreach (Type type in classesWithAttribute)
        {
            m_AllSystem.Add((SystemBase<object>)Activator.CreateInstance(type));
        }
        OnInit();
    }

    /// <summary>
    /// 初始化(不必在游戏引擎初始化后调用)
    /// </summary>
    public void OnInit()
    {
        foreach (var system in m_AllSystem)
        {
            if (!system.IsAfterGameEngineInit())
            {
                system.OnInit();
            }
        }
    }

    /// <summary>
    /// 游戏引擎完成初始化时
    /// </summary>
    private void OnAfterGameEngineInit()
    {
        foreach (var system in m_AllSystem)
        {
            if (system.IsAfterGameEngineInit())
            {
                system.OnInit();
            }
        }
    }

    /// <summary>
    /// 重置
    /// </summary>
    private void OnReset()
    {
        foreach (var system in m_AllSystem)
        {
            if (system.IsAfterGameEngineInit())
            {
                system.OnReset();
            }
        }
    }
}
