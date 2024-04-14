using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolStatic : MonoBehaviour
{
    public List<GameObject> objectPool;
    public GameObject objPref;
    public int maxQuantity;
    // Start is called before the first frame update
    void Start()
    {
        InstantiateObjects();
    }
    public void InstantiateObjects()
    {
        GameObject tmp;
        for (int i = 0; i < maxQuantity; i++)
        {
            tmp = Instantiate(objPref, transform.position, transform.rotation);
            objectPool.Add(tmp);
            tmp.transform.SetParent(this.transform);
            tmp.SetActive(false);
        }
    } 
    public GameObject RequestBullet()
    {
        for(int i = 0;i<objectPool.Count;i++)
        {
            if (!objectPool[i].activeSelf)
            {
                objectPool[i].SetActive(true);
                return objectPool[i];
            }
        }
        return null;
    }
}
