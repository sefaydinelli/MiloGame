using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{

    public GameObject item;
    float randX, randY;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-10f, 10f);
            randY = Random.Range(-6f, 6f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(item, whereToSpawn, Quaternion.identity);
        }
    }
}
