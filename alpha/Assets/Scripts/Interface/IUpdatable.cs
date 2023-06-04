using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 每帧更新接口IUpdate
/// </summary>
public interface IUpdatable
{
    public void OnUpdate();
}