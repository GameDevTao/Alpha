using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ״̬������
/// </summary>
public abstract class State
{
    /// <summary>
    /// ״̬��
    /// </summary>
    public abstract string StateName { get; set; }

    /// <summary>
    /// ״̬���
    /// </summary>
    public abstract void OnEnter();

    /// <summary>
    /// ״̬����
    /// </summary>
    public abstract void OnExit();
}