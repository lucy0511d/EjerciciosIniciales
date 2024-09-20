using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int velplayer1, velplayer2, velplayer3;
    // Start is called before the first frame update
    void Start()
    {
        if (velplayer1 > velplayer2 && velplayer1 > velplayer3)
        {
            Debug.Log("El jugador 1 ataca primero");
        }
        else if (velplayer2 > velplayer1 && velplayer2 > velplayer3)
        {
            Debug.Log("El jugador 2 ataca primero");
        }
        else if (velplayer3 > velplayer1 && velplayer3 > velplayer2)
        {
            Debug.Log("El jugador 3 ataca primero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
