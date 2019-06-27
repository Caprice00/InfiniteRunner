using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update

    void Start()
    {
        //Debug.Log("hello1");
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("hello1");
            anim.SetBool("isopen", true);
        }
        
    }

    
}
