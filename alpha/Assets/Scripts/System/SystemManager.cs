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

    private List<IUpdatable> m_UpdatableSystem = new List<IUpdatable>();
    private List<ILateUpdatable> m_LateUpdatableSystem = new List<ILateUpdatable>();
    private List<IFixedUpdatable> m_FixedUpdatableSystem = new List<IFixedUpdatable>();

    private void Awake()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var types = assembly.GetTypes();
        var classesWithAttribute = types.Where(t=>t.GetCustomAttribute<RegisterSystem>() != null);
        foreach (Type type in classesWithAttribute)
        {
            var instance = (SystemBase<object>)Activator.CreateInstance(type);
            m_AllSystem.Add(instance);
            if (type is IUpdatable)
            {
                m_UpdatableSystem.Add((IUpdatable)instance);
            }
            if (type is ILateUpdatable)
            {
                m_LateUpdatableSystem.Add((ILateUpdatable)instance);
            }
            if (type is IFixedUpdatable)
            {
                m_FixedUpdatableSystem.Add((IFixedUpdatable)instance);
            }
        }
        OnInit();
    }

    /// <summary>
    /// FixedUpdate
    /// </summary>
    private void FixedUpdate()
    {
        foreach (var sys in m_FixedUpdatableSystem)
        {
            sys.OnFixedUpdate();
        }
    }

    /// <summary>
    /// Update
    /// </summary>
    public void Update()
    {
        foreach (var sys in m_UpdatableSystem)
        {
            sys.OnUpdate();
        }
    }

    /// <summary>
    /// LateUpdate
    /// </summary>
    private void LateUpdate()
    {
        foreach (var sys in m_LateUpdatableSystem)
        {
            sys.OnLateUpdate();
        }
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
