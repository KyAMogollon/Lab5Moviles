using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerControllerAccelometer : MonoBehaviour
{
    public SpriteRenderer _sp;
    public int live;
    public int velocityVertical;
    public int velocityHorizontal;
    public TypePath name;
    public PuntajeSO puntaje;

    void Start()
    {
        _sp = GetComponent<SpriteRenderer>();
        _sp.sprite = SelectionCharacter.Instance.sprite;
        live = SelectionCharacter.Instance.live;
        velocityVertical = SelectionCharacter.Instance.velocityVertical;
        velocityHorizontal = SelectionCharacter.Instance.velocityHorizontal;
        name = SelectionCharacter.Instance.name;
        _sp.color = SelectionCharacter.Instance.colornNavE;
        transform.Rotate(0, 0, -90);
    }

    void Update()
    {
        float inputY = Input.acceleration.y;

        transform.Translate(-inputY * velocityVertical * Time.deltaTime,0 ,0);
        if(live<=0)
        {
            puntaje.ResetCurrentScore();
            SceneManager.LoadScene("Results");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            live--;
            if (live <= 0)
            {
                puntaje.ResetCurrentScore();
                SceneManager.LoadScene("Results");
            }
        }
    }
}
