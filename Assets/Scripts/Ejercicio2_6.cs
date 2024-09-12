using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int vida = 3, pocion = 4, armas = 5;
    int resultadoSuma;
    // Start is called before the first frame update
    void Start()
    {
        resultadoSuma = vida + pocion + armas;
        Debug.Log(vida + " + " + pocion + " + " + armas + " = " + resultadoSuma);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
