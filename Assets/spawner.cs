using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] obstacle;
    public float spawndelay = .3f;
    public Transform[] spawnpoints;
    // Start is called before the first frame update

    float nextTimeToSpawn = 0f;
    void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnObs();
            nextTimeToSpawn = Time.time + spawndelay;
        }
    }

    void SpawnObs()
    {
    }
}
