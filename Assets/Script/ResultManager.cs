using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    public Text scoreActual;
    public Text scoreHigh;
    public PuntajeSO puntaje;

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
        SceneManager.LoadScene("SelecctionCharacter");
    }
}
