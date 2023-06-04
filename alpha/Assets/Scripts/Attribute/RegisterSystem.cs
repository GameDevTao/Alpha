using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 系统属性
/// </summary>
public class RegisterSystem : Attribute
{
    /// <summary>
    /// 系统初始化优先级
    /// </summary>
    public Const.EInitPriority Priority { get; set; }
    public RegisterSystem(Const.EInitPriority priority)
    {
        Priority = priority;
    }
}
