using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] deathItems;

    public float secondsBetweenSpawn = 6f;
    public float elapsedTime = 0.0f;

    public void Start()
    {
        SpawnItem();
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > secondsBetweenSpawn)
        {
            elapsedTime = 0;
            SpawnItem();
        }
    }

    public void SpawnItem()
    {
        DestroyerItem di = new DestroyerItem();
        NullItem ni = new NullItem();

        Vector3 spwnLoc = new Vector3(Random.Range(-4,4), 17f, 0);

        // *** NULLOBJECT PATTERN ***
        // Invokation use for the pattern
        Instantiate(di.CreateItem(), spwnLoc, Quaternion.identity);

        if (deathItems.Length <= 0)
        {
            Instantiate(ni.CreateItem(), spwnLoc, Quaternion.identity);
        }
    }
}
