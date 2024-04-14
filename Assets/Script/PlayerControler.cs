using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    public SpriteRenderer _sp;
    public int live;
    public int velocityVertical;
    public int velocityHorizontal;
    public TypePath name;
    private Gyroscope gyroscope;

    public PuntajeSO puntaje;

    public bool Giroscopio;
    public bool Acelerometro;
    [SerializeField] ObjectPoolDinamic poolDinamic;
    [SerializeField] GameManager _gm;
    // Start is called before the first frame update
    void Start()
    {
        _sp = GetComponent<SpriteRenderer>();
        _sp.sprite = SelectionCharacter.Instance.sprite;
        live = SelectionCharacter.Instance.live;
        velocityVertical = SelectionCharacter.Instance.velocityVertical;
        velocityHorizontal=SelectionCharacter.Instance.velocityHorizontal;
        name = SelectionCharacter.Instance.name;
        _sp.color = SelectionCharacter.Instance.colornNavE;
        transform.Rotate(0,0,-90);
        _gm.LifeText(live);

        if (SystemInfo.supportsGyroscope)
        {
            gyroscope = Input.gyro;
            gyroscope.enabled = true;

            Debug.Log("Gyroscope enable");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {

                InvokeRepeating("Shoot", 0, 0.5f);
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                CancelInvoke("Shoot");
            }
        }
        if (Giroscopio==true)
        {
            float x = gyroscope.rotationRateUnbiased.x;
            float inputY = x;

            transform.Translate(-inputY * velocityVertical * Time.deltaTime, 0, 0);
        }

        if (Acelerometro == true)
        {
            float inputY = Input.acceleration.y;

            transform.Translate(-inputY * velocityVertical * Time.deltaTime, 0, 0);
        }


    }
    public void Shoot()
    {
        Debug.Log("Estoy invocando");
        poolDinamic.GetObject(transform.position);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy"|| collision.gameObject.tag=="Alienigena")
        {
            live--;
            _gm.LifeText(live);
            collision.gameObject.SetActive(false);
            if (live <= 0)
            {
                puntaje.ResetCurrentScore();
                SceneManager.LoadScene("Results");
            }
        }
    }
}
