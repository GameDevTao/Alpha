using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 每帧更新接口LateUpdate
/// </summary>
public interface ILateUpdatable
{
    public void OnLateUpdate();
}