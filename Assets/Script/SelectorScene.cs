using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorScene : MonoBehaviour
{
    public void LoadSceneGyroscope()
    {
        SceneGlobalManager.Instance.SelectionGame("GameGyroscope");
    }
    public void LoadSceneAccelerometer()
    {
        SceneGlobalManager.Instance.SelectionGame("GameAccelerometer");
    }
}
