using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 状态抽象类
/// </summary>
public abstract class State
{
    /// <summary>
    /// 状态名
    /// </summary>
    public abstract string StateName { get; set; }

    /// <summary>
    /// 状态入口
    /// </summary>
    public abstract void OnEnter();

    /// <summary>
    /// 状态出口
    /// </summary>
    public abstract void OnExit();
}