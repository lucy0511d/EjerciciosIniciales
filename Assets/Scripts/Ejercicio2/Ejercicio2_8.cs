using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float vida = 120, veneno = 0.3f, vidaActualizada;
    

    // Start is called before the first frame update
    void Start()
    {
        vidaActualizada = vida * (0.3f + veneno);
        Debug.Log("Vida actualizada= " + vidaActualizada);
        vidaActualizada = vida * (0.6f + veneno);
        Debug.Log("Vida actualizada= " + vidaActualizada);
        vidaActualizada = vida * (0.9f + veneno);
        Debug.Log("Vida actualizada= " + vidaActualizada);
        vidaActualizada = vida * (1.2f + veneno);
        Debug.Log("Vida actualizada= " + vidaActualizada);
        vidaActualizada = vida * (1.5f + veneno);
        Debug.Log("Vida actualizada= " + vidaActualizada);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
