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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
