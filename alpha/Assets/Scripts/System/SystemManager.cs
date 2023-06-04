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
            var sys = (SystemBase<object>)Activator.CreateInstance(type);
            m_AllSystem.Add(sys);

            var attr = type.GetCustomAttribute<RegisterSystem>();
            if (attr.Priority == Const.EInitPriority.First)
            {
                sys.Init();

                RegisterUpdateSystem(sys);
            }
        }
    }

    private void RegisterUpdateSystem(SystemBase<object> sys)
    {
        if (sys is IFixedUpdatable)
        {
            m_FixedUpdatableSystem.Add((IFixedUpdatable)sys);
        }
        if (sys is IUpdatable)
        {
            m_UpdatableSystem.Add((IUpdatable)sys);
        }
        if (sys is ILateUpdatable)
        {
            m_LateUpdatableSystem.Add((ILateUpdatable)sys);
        }
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
    /// 重置
    /// </summary>
    private void OnReset()
    {
        foreach (var system in m_AllSystem)
        {
            system.OnReset();
        }
    }
}
