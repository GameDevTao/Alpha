using Bright.Serialization;
using SimpleJSON;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

/// <summary>
/// ±Ìπ‹¿Ì∆˜
/// </summary>
[RegisterSystem(Const.EInitPriority.Table)]
public class TableManager : SystemBase<TableManager>
{
    public override void OnInit()
    {
        var tables = new cfg.Tables(LoadByteBuf);

        //UnityEngine.Debug.LogFormat("item[1].name:{0}", tables.TbUI["LogoUI"].Layer);
    }

    private static JSONNode LoadByteBuf(string file)
    {
        return JSON.Parse(File.ReadAllText(Application.dataPath + "/../../GenerateDatas/json/" + file + ".json", System.Text.Encoding.UTF8));
    }


    public override void OnReset()
    {
    }
}
