using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Waktu untuk Update: " + Time.deltaTime);
    }

    void FixedUpdate()
    {
        Debug.Log("Waktu untuk FixedUpdate: " + Time.deltaTime);
    }

    void LateUpdate()
    {
        Debug.Log("Waktu untuk LateUpdate: " + Time.deltaTime);
    }

}
