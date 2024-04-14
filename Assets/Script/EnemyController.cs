using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject[] target;
    public float TimeToWait = 1;
    private float currentTime;
    //public GameObject enemy;
    public ObjectPoolStatic pool;
    public ObjectPoolStatic poolStatic;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > TimeToWait)
        {
            SpawnEnemy();
            currentTime = 0;
        }
        
    }
    public void SpawnEnemy()
    {
        int rnd = Random.Range(0, target.Length);
        int rnd2 = Random.Range(0, target.Length);
        GameObject obj = pool.RequestBullet();
        GameObject obj2 = poolStatic.RequestBullet();
        obj2.transform.position = target[rnd2].transform.position;
        obj.transform.position = target[rnd].transform.position;
    }
}
