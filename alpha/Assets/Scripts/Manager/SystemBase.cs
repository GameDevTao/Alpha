using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ϵͳ����
/// </summary>
public class SystemBase<T> : SingletonBase<T> where T : new()
{
    /// <summary>
    /// �Ƿ�����Ϸ�����ʼ�����ٳ�ʼ��
    /// </summary>
    /// <returns></returns>
    public virtual bool IsAfterGameEngineInit()
    {
        return true;
    }

    /// <summary>
    /// ��ʼ��
    /// </summary>
    public virtual void OnInit()
    {
    }

    /// <summary>
    /// ����
    /// </summary>
    public virtual void OnReset()
    {
    }
}
