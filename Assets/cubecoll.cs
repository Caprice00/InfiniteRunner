using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubecoll : MonoBehaviour
{
    public cubemove move;
    //referencing cubemove to cubecoll --we have to stop the cube , we gotta stop its movement script , we disable it when it collides with an obstacle 
    public gmanager gmanager;
    void OnCollisionEnter(Collision colinfo)
    {
        if (colinfo.collider.tag == "obstacle")
        {
            move.enabled = false;
            gmanager.Endgame(); 
        }
    }
}
