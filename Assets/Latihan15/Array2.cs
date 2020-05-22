using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array2 : MonoBehaviour
{
    int[,] intArray2; //Deklarasi Array

    // Start is called before the first frame update
    void Start()
    {
        intArray2 = new int[2, 2]; //Inisialisasi Array
        intArray2[0,0] = 10;
        intArray2[0,1] = 20;
        intArray2[1,0] = 30;
        intArray2[1,1] = 40;
        Debug.Log("Menampilkan Seluruh Array");
        for (int a=0;a<2;a++)
        {
            for(int b=0;b<2;b++)
            {
                Debug.Log(intArray2[a,b]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
