using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numero1;
    int numero2, numero3;
    // Start is called before the first frame update
    void Start()
    {
        numero2 = numero1 * 2;
        numero3 = numero2 * 3;
        Debug.Log("numero2= " + numero2 + ", numero3= " + numero3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
