using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private float contador;
    public TMP_Text score;
    public TMP_Text live;
    public PuntajeSO puntaje;
    [SerializeField] PlayerControler player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contador += 1 * (Time.deltaTime*player.velocityHorizontal);
        puntaje.UpdateScore((int)contador);
        score.text = "Puntaje: " + (int)contador;
    }
    public void LifeText(int vida)
    {
        live.text = "Live: " + vida;
    }
}
