using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]PersonajeV2 capsulin;
    [SerializeField]PersonajeV2 capsulan;
    bool yaEjecutado = false; 
    // capsulan = enemigo
    
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
        
        //Capsulan
        capsulan.Vida = 70;
        capsulan.Nombre = "Capsulan";
        Debug.Log("Funcijdeow");
    }
    void FinDeTurno(Personaje capsulan)
    {
        Debug.Log("Se acab� el turno de: ");
    }
}
