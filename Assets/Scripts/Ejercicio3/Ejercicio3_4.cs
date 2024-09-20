using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    [SerializeField] int EXP;
    int LVL;
    // Start is called before the first frame update
    void Start()
    {
        LVL = 32 + (9 * EXP / 5);
        Debug.Log( "Nivel= " + LVL );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
