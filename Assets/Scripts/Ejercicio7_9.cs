using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{
    [SerializeField] int num;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < num; i++)
        {
            if (i % 3 == 0)
            {
                Debug.Log("El numero: " + i + " es múltiplo de 3");
            }
            else
            {
                Debug.Log("El numero: " + i + " no es múltiplo de 3");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
