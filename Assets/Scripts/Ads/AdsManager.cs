﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
    public static string gameIdAndroid = "4350991";
    public static string idAndroidReward = "Rewarded_Android";
    public static string idAndroidInters = "Interstitial_Android";
    public static bool testMode = false;
    public static bool ready;
    public static int maxTriesTimeOut = 30;
    public static int timeToShowReward = 15;
    public static int deathsToShowReward = 5;
}

