using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objmanager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obsprefab;
    public GameObject player;
   
    public float[] x;
    
    public float[] z;

    


    void Start()
    {
        InvokeRepeating("spawnobs",5.0f,5.0f);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnobs()
    {
        Debug.Log("hiii");
        GameObject obs;
        int i = Random.Range(0, x.Length);
        
        obsprefab.transform.position = new Vector3(player.transform.position.x + x[i], player.transform.position.y +0, player.transform.position.z + z[i]);
        obs = Instantiate(obsprefab, obsprefab.transform.position, obsprefab.transform.rotation) as GameObject;
        




    }
}
