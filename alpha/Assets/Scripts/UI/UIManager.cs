using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// uiπ‹¿Ì∆˜
/// </summary>
[RegisterSystem(Const.EInitPriority.UI)]
public class UIManager : SystemBase<UIManager>, IUpdatable
{
    private GameObject m_UIRoot;
    public override void OnInit()
    {
        var asset = Resources.Load<GameObject>("UIRoot");
        m_UIRoot = GameObject.Instantiate(asset);
        GameObject.DontDestroyOnLoad(m_UIRoot);
    }

    public void OpenUI(string ui)
    {
    }

    public void CloseUI(string ui)
    {
    }

    public override void OnReset()
    {
    }

    public void OnUpdate()
    {
    }
}
