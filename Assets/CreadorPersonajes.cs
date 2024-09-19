using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorPersonajes : MonoBehaviour
{
    int numero = 4;
    string texto = "Hola";
    float deci = 3.14f;
    Personaje link;
    Personaje mario;

    // Start is called before the first frame update
    void Start()
    {
        //link's life
        link.nombre = "Link";
        link.vida = 100;
        link.velocidad = 100;

        link.Mover(3, 1, 0);
        link.Saltar();
        link.Atacar();

        transform.Rotate();
    }

}


