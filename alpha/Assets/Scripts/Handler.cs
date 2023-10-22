using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Handler : MonoBehaviour
{
    public void OnClickAccept()
    {
        PlayerPrefs.SetInt("IsAccpetPrivacy", 1);
        
        SceneManager.LoadScene("LoadingScene");
    }

    public void OnClickReject()
    {
        Application.Quit();
    }
}
