using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    
    int oroPorSeg = 7, oroRecogidoEn4H;
    // Start is called before the first frame update
    void Start()
    {
        oroRecogidoEn4H += ((oroPorSeg * 60) * 60) * 4;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
