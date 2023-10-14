using Bright.Serialization;
using SimpleJSON;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

/// <summary>
/// �������
/// </summary>
[RegisterSystem(Const.EInitPriority.Table)]
public class TableManager : SystemBase<TableManager>
{
    public cfg.Tables Tables;

    public override void OnInit()
    {
        Tables = new cfg.Tables(LoadByteBuf);

        //UnityEngine.Debug.LogFormat("item[1].name:{0}", tables.TbUI["LogoUI"].Layer);
    }

    private static JSONNode LoadByteBuf(string file)
    {
#if UNITY_EDITOR
        return JSON.Parse(File.ReadAllText(Application.dataPath + "/Table/json/" + file + ".json", System.Text.Encoding.UTF8));
#else
        return null;
#endif
    }


    public override void OnReset()
    {
    }
}
