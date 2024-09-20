using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_1 : MonoBehaviour
{
    int numero = 0;
    // Start is called before the first frame update
    void Start()
    {
        while (numero >= 1 && numero < 100)
        {
            Debug.Log("Tu número es: " + numero);
            numero++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
