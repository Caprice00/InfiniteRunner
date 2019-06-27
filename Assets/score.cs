using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour
{
    public GameObject cube;
    public GameObject empcube;
    public float distance;
    public Text scoretext;
    void Update()
    {
        distance = Vector3.Distance(cube.transform.position, empcube.transform.position);
        scoretext.text = distance.ToString("0");
    }
}
