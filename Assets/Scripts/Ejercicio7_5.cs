using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numero;
    int numero1 = 1;
    // Start is called before the first frame update
    void Start()
    {
      
        while (numero1 >= 1 && numero1 <= numero)
        {
            Debug.Log("Tu número es: " + numero1);
            numero1++;
        }
        for (int numero2 = 1; numero2 < numero; numero2++)
        {
            Debug.Log("Tu numero es: " + numero2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
