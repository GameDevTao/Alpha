using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class Utility
{
    [MenuItem("Custom/ClearPlayerPrefs")]
    public static void ClearPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
    }
}
