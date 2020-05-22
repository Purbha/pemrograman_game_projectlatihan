using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan7 : MonoBehaviour
{
    //Constant Variable
    const string CONST_VAR = "1234";

    //Static Variable
    public static string staticVar = "5678"; //Static Variable

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Panggil Constant: " + CONST_VAR);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
