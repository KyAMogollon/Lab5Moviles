using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Puntaje", order = 2)]
public class PuntajeSO : ScriptableObject
{
    public int highScore=0;
    public int currentScore=0;

    public void UpdateScore(int score)
    {
        currentScore = score;
        if (currentScore > highScore)
        {
            highScore = currentScore;

        }
    }
    public void ResetCurrentScore()
    {
        currentScore = 0;
    }
    public int GetScoreHigh()
    {
        return highScore;
    }
    public int GetScoreActual()
    {
        return currentScore;
    }
}
