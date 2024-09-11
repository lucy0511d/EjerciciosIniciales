using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 5;
    float exp = 3.3f;
    float Producto;
    float Cociente;
    float Doble;
    float Triple;

    // Start is called before the first frame update
    void Start()
    {
        Producto = vidas * exp;
        Cociente = vidas / exp;
        Doble = vidas * 2;
        Triple = vidas * 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
