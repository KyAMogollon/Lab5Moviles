using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D _rb;
    public ObjectPoolDinamic poolDinamic;
    // Start is called before the first frame update
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    public ObjectPoolDinamic SetDinamicPool(ObjectPoolDinamic pool)
    {
        return poolDinamic = pool;
    } 
    private void OnEnable()
    {
        _rb.velocity = Vector2.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            poolDinamic.SetObject(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            poolDinamic.SetObject(this.gameObject);
            collision.gameObject.SetActive(false);
        }
    }
}
