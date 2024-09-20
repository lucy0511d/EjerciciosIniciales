using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int numpos,numneg;
    
    // Start is called before the first frame update
    void Start() // -num version negativa num
    {
        while (numpos >= numneg)
        {
            Debug.Log("Tu número es: " + numpos);
            numpos--;
        }
        for (int i = numneg; numpos > 1; numpos--)
        {
            Debug.Log("Tu número es: " + numpos);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
