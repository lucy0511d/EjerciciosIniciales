using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] float baset, altura;
    float area;
    // Start is called before the first frame update
    void Start()
    {
        area = (baset * altura) / 2;
        Debug.Log("area= " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
