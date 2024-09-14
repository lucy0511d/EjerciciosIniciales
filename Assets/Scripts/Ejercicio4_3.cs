using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float conversor = Convertir(1.5f, "euro");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Convertir(float cantidad, string moneda)
    {
        float valoreuro = 0.90f, valordolar = 1.11f;
        float conversion = 0;
        if (moneda == "euro")
        {
            conversion = cantidad * valordolar;
        }
        else if (moneda == "dolar") 
        {
            conversion = cantidad * valoreuro;
        }

        return conversion;


    }
}
