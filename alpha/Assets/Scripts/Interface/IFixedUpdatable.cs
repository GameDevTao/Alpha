using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 每帧更新接口FixedUpdate
/// </summary>
public interface IFixedUpdatable
{
    public void OnFixedUpdate();
}