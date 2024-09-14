using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] float radio;
    float longitud, area;
    float PI = 3.1416f;


    // Start is called before the first frame update
    void Start()
    {
        longitud = 2 * PI * radio;
        area = PI * radio / 2;
        Debug.Log("longitud= " + longitud + " area= " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
