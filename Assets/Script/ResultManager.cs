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
    [SerializeField] NotificationSimple notification;
    [SerializeField] NotificationDataSO[] dataSO;
    private void OnEnable()
    {
        if (puntaje.GetScoreActual() == puntaje.GetScoreHigh())
        {
            dataSO[1].score = puntaje.GetScoreHigh();
            notification.SendNotificationHightScore(dataSO[1]);
        }
        else
        {
            dataSO[0].score = puntaje.GetScoreActual();
            notification.SendNotificationCurrentScore(dataSO[0]);
        }
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
