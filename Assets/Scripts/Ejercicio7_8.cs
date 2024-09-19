using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int num, num2;
    // Start is called before the first frame update
    void Start()//meter else
    {
        if (num % 2 == 0)
        {
            for (int i = num; i < num2; i+=2)
            {
                Debug.Log("Tu número es: " + i);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
