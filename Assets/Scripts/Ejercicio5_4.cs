using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] int dividendo, divisor;
    int resultadoDivision;
    // Start is called before the first frame update
    void Start()
    {
        if (divisor != 0)
        {
            resultadoDivision = dividendo / divisor;
            Debug.Log("resultado divison= " + resultadoDivision);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
