using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 6;
    PlayerControler player;
    Rigidbody2D _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player").GetComponent<PlayerControler>();
    }
    private void OnEnable()
    {
        //transform.position = new Vector3(transform.position.x - speed * (Time.deltaTime * player.velocityHorizontal), transform.position.y, transform.position.z);
        _rb.velocity = Vector2.left*speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Wall"))
        {
            gameObject.SetActive(false);

        }
    }
}
