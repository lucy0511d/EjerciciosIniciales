using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]PersonajeV2 capsulin;
    [SerializeField]PersonajeV2 enemigo;
    bool yaEjecutado = false; 
    
    
    // Start is called before the first frame update
    void Start()
    {
       if (Input.GetKeyDown(KeyCode.Space)&& yaEjecutado == false)
        {
            PrepararPersonajes();
            
            yaEjecutado=true;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    void PrepararPersonajes()
    {
        //Capsulin
        capsulin.Vida = 50;
        capsulin.Nombre = "Capsulin";
        capsulin.CalcularNivel();
        //Enemigo
        enemigo.Vida = 70;
        enemigo.Nombre = "Capsulan";
        enemigo.CalcularNivel();
       
    }
    void FinDeTurno(PersonajeV2 capsulin)
    {
       // if (PersonajeV2 capsulin)
       // {
       //     capsulin.miTurno(); = false;
       // }
        Debug.Log("Se acabó el turno de: ");
    }
}
