using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vidas = 3;

    // Start is called before the first frame update
    void Start()
    {
        vidas += 77;
        Debug.Log("Vidas= " + vidas);
        vidas -= 3;
        Debug.Log("Vidas= " + vidas);
        vidas = vidas * 4;
        Debug.Log("Vidas= " + vidas);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
