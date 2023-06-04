using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// uiπ‹¿Ì∆˜
/// </summary>
[RegisterSystem(Const.EInitPriority.First)]
public class UIManager : SystemBase<UIManager>, IUpdatable
{
    public override void OnInit()
    {
        //test
        Logger.Error("error");
        //test
    }

    public override void OnReset()
    {
    }

    public void OnUpdate()
    {
    }
}
