using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_10 : MonoBehaviour
{
    [SerializeField] int num, num2;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = num; i < num2; i++)
        {
            if (i < 0 && i % 2 == 0)
            {
                Debug.Log("Tu número es: " + i + ", negativo y par");
            }
            if (i < 0 && i % 2 == 1)
            {
                Debug.Log("Tu número es: " + i + ", negativo e impar");
            }
            if (i >= 0 && i % 2 == 0)
            {
                Debug.Log("Tu número es: " + i + ", positivo y par");
            }
            if (i >= 0 && i % 2 == 1)
            {
                Debug.Log("Tu número es: " + i + ", positivo e impar");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
