using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 系统基类
/// </summary>
public class SystemBase<T> : SingletonBase<T> where T : new()
{
    /// <summary>
    /// 是否再游戏引擎初始化后再初始化
    /// </summary>
    /// <returns></returns>
    public virtual bool IsAfterGameEngineInit()
    {
        return true;
    }

    /// <summary>
    /// 初始化
    /// </summary>
    public virtual void OnInit()
    {
    }

    /// <summary>
    /// 重置
    /// </summary>
    public virtual void OnReset()
    {
    }
}
