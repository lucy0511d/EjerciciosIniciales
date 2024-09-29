using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeV3 : MonoBehaviour
{
    float ataque;
    float velocidad;
    float vida;
   PersonajeV2 objetivo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RellenarStats(float atq, float vel, float hp)
    {
        ataque = atq;
        velocidad = vel;
        vida = hp;
         
    }
    void MarcarObjetivo(PersonajeV2 objetivo)
    {

    }
    void Atacar()
    {

    }
}
