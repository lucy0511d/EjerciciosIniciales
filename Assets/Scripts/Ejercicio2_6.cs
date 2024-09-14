using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int vida = 3, pocion = 4, armas = 5;
    int resultadoMedia;
    // Start is called before the first frame update
    void Start()
    {
        resultadoMedia = (vida + pocion + armas) / 3;
        Debug.Log(vida + " + " + pocion + " + " + armas + " / 3 = " + resultadoMedia);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
