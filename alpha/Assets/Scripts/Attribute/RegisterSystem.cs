using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ϵͳ����
/// </summary>
public class RegisterSystem : Attribute
{
    /// <summary>
    /// ϵͳ��ʼ�����ȼ�
    /// </summary>
    public Const.EInitPriority Priority { get; set; }
    public RegisterSystem(Const.EInitPriority priority)
    {
        Priority = priority;
    }
}
