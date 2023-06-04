using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

/// <summary>
/// ϵͳ������
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
    /// ��ʼ��(��������Ϸ�����ʼ�������)
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
    /// ��Ϸ������ɳ�ʼ��ʱ
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
    /// ����
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
