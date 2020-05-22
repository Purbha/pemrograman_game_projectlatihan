using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan5 : MonoBehaviour
{
    // Global Variable
    string kalimat = "Ini adalah Global Variable"; 
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("1: " + kalimat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Debug.Log("2: " + kalimat);
    }
}
