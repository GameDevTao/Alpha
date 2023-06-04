using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ����ģ����
/// </summary>
public class SingletonBase<T> where T:new()
{
    /// <summary>
    /// ��ӵ�������
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
