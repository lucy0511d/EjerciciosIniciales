using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{
    [SerializeField] int num;
    // Start is called before the first frame update
    void Start()//preguntar
    {
        if (num % 3 == 0)
        {
            for (int i = num; i < num; i += 2)
            {
                Debug.Log("Tu número es: " + i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
