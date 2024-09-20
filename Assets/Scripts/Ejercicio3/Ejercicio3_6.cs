using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float velocidadkm;
    float velocidadms;
    // Start is called before the first frame update
    void Start()
    {
        velocidadms = velocidadkm / 3.6f;
        Debug.Log("velocidad en m/s= " + velocidadms);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
