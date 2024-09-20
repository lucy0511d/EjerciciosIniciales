using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1 = 3 , vidasPlayer2 = 2, vidasPlayer3 = 4, vidasPlayer4 = 1;
    // Start is called before the first frame update
    void Start()
    {
        vidasPlayer2 = vidasPlayer3;
        Debug.Log("vidasPlayer2 = " + vidasPlayer2);
        vidasPlayer3 = vidasPlayer1;
        Debug.Log("vidasPlayer3 = " + vidasPlayer3);
        vidasPlayer1 = vidasPlayer4;
        Debug.Log("vidasPlayer1 = " + vidasPlayer1);
        vidasPlayer4 = vidasPlayer2;
        Debug.Log("vidasPlayer4 = " + vidasPlayer4);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
