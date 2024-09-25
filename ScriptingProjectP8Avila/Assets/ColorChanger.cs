using System.Collections;
using System.Collections.Generic;
using Unity.Android.Types;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            GetComponent<Renderer>().material.color = Color.cyan;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            GetComponent<Renderer>().material.color = Color.grey;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            GetComponent<Renderer>().material.color = Color.magenta;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}