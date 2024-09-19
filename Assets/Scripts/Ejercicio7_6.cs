using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int num;
    int num2;
    // Start is called before the first frame update
    void Start() // -num version negativa num
    {
        while (num >= 1 && num <= num2)
        {
            Debug.Log("Tu número es: " + num);
            num++;
        }
        for (int num2 = 1; num < num2; num++)
        {
            Debug.Log("Tu número es: " + num);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
