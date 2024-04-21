using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResultManager : MonoBehaviour
{
    public PuntajeSO puntaje;
    public TMP_Text scoreActual;
    public TMP_Text scoreHigh;


    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {

        scoreActual.text = "Puntaje Actual: " + puntaje.GetScoreActual() + " pts";
        scoreHigh.text = "Puntaje mas Alto: " + puntaje.GetScoreHigh() + " pts";
    }
    public void Select()
    {
        SceneGlobalManager.Instance.LoadResults();
    }
    public void Game()
    {
        SceneGlobalManager.Instance.LoadGame();
    }
    public void Menu()
    {
        SceneGlobalManager.Instance.LoadMenu();
    }
}
