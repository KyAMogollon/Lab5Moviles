using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorScene : MonoBehaviour
{
    public void LoadSceneGyroscope()
    {
        SceneManager.LoadScene("GameGyroscope");
    }
    public void LoadSceneAccelerometer()
    {
        SceneManager.LoadScene("GameAccelerometer");
    }
}
