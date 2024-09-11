using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 3;
    float exp = 5;
    char carac = 'r';
    float resultadoSuma;
    float resultadoResta;




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Vidas= " + vidas + " ,Exp= " + exp + " .");
        resultadoSuma = vidas + exp;
        resultadoResta = vidas - exp;
        Debug.Log("Resultado suma= " + resultadoSuma + " ,resultado resta = " + resultadoResta + " .");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
