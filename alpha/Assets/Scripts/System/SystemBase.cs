using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ϵͳ����
/// </summary>
public abstract class SystemBase<T> : SingletonBase<T> where T : new()
{
    private bool m_IsInit;
    public bool IsInit { get { return m_IsInit; } }

    /// <summary>
    //  ��ʼ��
    /// </summary>
    public void Init()
    {
        m_IsInit = true;

        OnInit();
    }
    /// <summary>
    /// ��ʼ���ص�
    /// </summary>
    public abstract void OnInit();

    /// <summary>
    /// ����
    /// </summary>
    public abstract void OnReset();
}
