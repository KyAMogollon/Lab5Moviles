using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class MapController : MonoBehaviour
{
    [SerializeField] GameObject bg1;
    [SerializeField] GameObject bg2;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bg1.transform.position = new UnityEngine.Vector2(bg1.transform.position.x - speed * Time.deltaTime, bg1.transform.position.y);
        bg2.transform.position = new UnityEngine.Vector2(bg2.transform.position.x - speed * Time.deltaTime, bg2.transform.position.y);
        if (bg1.transform.position.x <= -23.2)
        {
            bg1.transform.position = new UnityEngine.Vector2(24.83f, bg1.transform.position.y);
        }
        if (bg2.transform.position.x <= -23.2)
        {
            bg2.transform.position = new UnityEngine.Vector2(24.83f, bg2.transform.position.y);
        }
    }
}
