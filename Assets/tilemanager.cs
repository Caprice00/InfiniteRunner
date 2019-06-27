using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilemanager : MonoBehaviour
{
    public GameObject[] tileprefab ;
    public GameObject[] obstacle;
    public Transform transform;
    public Transform[] spawnpoints;
    private float spawnz = 0.0f;
    
    public int tilelength = 10;
    private int tilesonscreen = 7;
    public Vector3 v;
    private List<GameObject> activetiles;
    public Vector3 v1;

    
    void Start()
    {
        activetiles = new List<GameObject>();
        for (int i = 0; i <= tilesonscreen; i++)
        {
            spawntile(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > (spawnz - tilesonscreen * tilelength))
        {
           // StartCoroutine(delayspawntile());
           spawntile(0);
        }

    }

    /*IEnumerator delayspawntile()
    {
        print(Time.time);
        yield return new WaitForSeconds(0.5f);
        print(Time.time);
        spawntile(0);
    }*/

    void spawntile(int index)
    {
        
        GameObject go,obs1,obs2,obs3,obs4,obs5;
       // int i = Random.Range(0, tileprefab.Count);
        go = Instantiate(tileprefab[index]) as GameObject;
       // go.transform.SetParent(transform);
        go.transform.position = v * spawnz;
        spawnz = spawnz + tilelength;
        int i = Random.Range(0, obstacle.Length);
        int j = Random.Range(0, spawnpoints.Length);
        //obs1 = Instantiate(obstacle[i],spawnpoints[j]) as GameObject;
       // obs1.transform.position = v * spawnz;



        /*v1 = new Vector3(go.transform.position.x + v1.x, go.transform.position.y + v1.y, go.transform.position.z + v1.z );
        obs1 = Instantiate(obstacle[i], go.transform.position + v1);*/
        Destroy(go, 5.0f);
        //Destroy(obs1, 5.0f);
        //activetiles.Add(go);







    }
   /* void Deletetile()
    {
        Destroy(activetiles[0]);
        activetiles.RemoveAt(0);
    }*/
}


