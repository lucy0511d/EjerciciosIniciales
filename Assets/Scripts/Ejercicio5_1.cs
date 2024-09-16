using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    [SerializeField] int vida1, vida2;
    // Start is called before the first frame update
    void Start()
    {
        if (vida1 == vida2)
        {
            Debug.Log("Los dos personajes tienen la misma vida");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
