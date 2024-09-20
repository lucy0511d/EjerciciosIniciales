using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float conversion = ConversorKmH(20.3f);
        Debug.Log("Conversion a metros/s " + conversion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float ConversorKmH(float velocidad) 
    {
        float velocidadms = velocidad / 3.6f;
        return velocidadms;
    }
}
