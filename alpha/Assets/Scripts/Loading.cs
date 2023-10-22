using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Services.Analytics;
using Unity.Services.Authentication;
using Unity.Services.Core;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Slider _slider;
    public TMP_Text _text; 

    async void Awake()
    {
        SetProgress(30);
        try
        {
            await UnityServices.InitializeAsync();
            SetProgress(60);
            await AuthenticationService.Instance.SignInAnonymouslyAsync();
        }
        catch (Exception e)
        {
            Debug.LogError("loading fail");
        }
        AnalyticsService.Instance.StartDataCollection();
        SetProgress(100);
        
        SceneManager.LoadScene("MenuScene");
    }

    private void SetProgress(int progress)
    {
        _text.text = string.Format("%{0}", progress);
        _slider.value = progress / 100f;
    }
}
