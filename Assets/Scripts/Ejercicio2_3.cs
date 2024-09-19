using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 5;
    float exp = 3.3f;
    float producto;
    float cociente;
    float doble;
    float triple;

    // Start is called before the first frame update
    void Start()
    {
        producto = vidas * exp;
        Debug.Log("Producto= " + producto);
        cociente = vidas / exp;
        Debug.Log("Cociente= " + cociente);
        doble = vidas * 2;
        Debug.Log("Doble= " + doble);
        triple = vidas * 3;
        Debug.Log("Triple= " + triple);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
