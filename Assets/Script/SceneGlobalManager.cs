using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneGlobalManager : SingletonGenericPersist<SceneGlobalManager>
{
    public void Start()
    {
        base.Awake();
    }

    #region StartScene

    public void ButtonPlay()
    {
        Invoke("UnloadSceneStart", 0.1f);
        SceneManager.LoadSceneAsync("SelecctionCharacter", LoadSceneMode.Additive);
    }
    public void UnloadSceneStart()
    {
        SceneManager.UnloadSceneAsync("Start");
    }
    #endregion

    #region CharacterSelecction

    public void SelectionCharacter()
    {
        Invoke("UnloadCharacterSelecction", 0.1f);
        SceneManager.LoadSceneAsync("SelecctionGame", LoadSceneMode.Additive);
    }
    public void UnloadCharacterSelecction()
    {
        SceneManager.UnloadSceneAsync("SelecctionCharacter");
    }
    #endregion

    #region GameSelecction

    public void SelectionGame(string type)
    {
        Invoke("UnloadSelecctionGame", 0.1f);
        SceneManager.LoadSceneAsync(type, LoadSceneMode.Additive);
    }
    public void UnloadSelecctionGame()
    {
        SceneManager.UnloadSceneAsync("SelecctionGame");
    }
    #endregion

    #region GameScene

    public void SceneNext(string type)
    {
        Invoke(type, 0.1f);
        SceneManager.LoadSceneAsync("Results", LoadSceneMode.Additive);
    }
    public void UnloadSelecctionGyroscope()
    {
        SceneManager.UnloadSceneAsync("GameGyroscope");
    }
    public void UnloadSelecctionAccelerometer()
    {
        SceneManager.UnloadSceneAsync("GameAccelerometer");
    }

    #endregion

    public void LoadResults()
    {
        Invoke("UnloadResults", 0.1f);
        SceneManager.LoadSceneAsync("SelecctionCharacter", LoadSceneMode.Additive);
    }
    public void UnloadResults()
    {
        SceneManager.UnloadSceneAsync("Results");
    }
    public void LoadGame()
    {
        Invoke("UnloadResults", 0.1f);
        SceneManager.LoadSceneAsync("GameGyroscope", LoadSceneMode.Additive);
    }
    public void LoadMenu()
    {
        Invoke("UnloadResults", 0.1f);
        SceneManager.LoadSceneAsync("Start", LoadSceneMode.Additive);
    }
}
