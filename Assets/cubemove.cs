using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemove : MonoBehaviour
{
   
    public Rigidbody rb;
    public float thrust = 2000f;
    public float sidfor = 50f;

    void FixedUpdate()

    {
        rb.AddForce(0, 0, thrust * Time.deltaTime);//used to keep shit equal in high end and low end systems

       
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidfor * Time.deltaTime, 0, 0, ForceMode.VelocityChange);//velo change ignores momentum and mass
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidfor * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y< -1f)
        {
            FindObjectOfType<gmanager>().Endgame();
        }
    }
}
