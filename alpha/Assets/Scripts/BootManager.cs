using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BootManager : MonoBehaviour
{
    private void Awake()
    {
        var isAccpetPrivacy = PlayerPrefs.GetInt("IsAccpetPrivacy", 0);
        if (isAccpetPrivacy == 1)
        {
            SceneManager.LoadScene("LoadingScene");
        }
        else
        {
            SceneManager.LoadScene("PrivacyScene");
        }
    }
}
