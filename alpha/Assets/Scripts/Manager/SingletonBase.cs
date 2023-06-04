using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 单例模板类
/// </summary>
public class SingletonBase<T> where T:new()
{
    /// <summary>
    /// 添加单例引用
    /// </summary>
    public static T Instance
    {
        get
        {
            if (null == m_Instance)
            {
                m_Instance = new T();
            }
            return m_Instance;
        }
    }

    private static T m_Instance;
}
