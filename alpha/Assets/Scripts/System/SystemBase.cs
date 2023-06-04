using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 系统基类
/// </summary>
public abstract class SystemBase<T> : SingletonBase<T> where T : new()
{
    private bool m_IsInit;
    public bool IsInit { get { return m_IsInit; } }

    /// <summary>
    //  初始化
    /// </summary>
    public void Init()
    {
        m_IsInit = true;

        OnInit();
    }
    /// <summary>
    /// 初始化回调
    /// </summary>
    public abstract void OnInit();

    /// <summary>
    /// 重置
    /// </summary>
    public abstract void OnReset();
}
