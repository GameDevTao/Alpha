using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdsHandler : MonoBehaviour
{
    public void LoadAds()
    {
        AdsManager.Instance.LoadAd("Interstitial_Android");
    }
}
