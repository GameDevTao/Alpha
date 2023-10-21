using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Analytics;

public class AnalysticsManager : MonoBehaviour
{
    async void Start()
    {
        await UnityServices.InitializeAsync();
		
        AskForConsent();

        ConsentGiven();
        
        //await AuthenticationService.Instance.SignInAnonymouslyAsync();
    }
	
    void AskForConsent()
    {
        // ... show the player a UI element that asks for consent.
    }
	
    void ConsentGiven()
    {
        AnalyticsService.Instance.StartDataCollection();
    }

    public void OnClickMainButton()
    {
        AnalyticsService.Instance.CustomData("clickMainButton");
    }
}
