using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int num, num2;
    // Start is called before the first frame update
    void Start()//meter else
    {
        for (int i = num; i < num2; i += 2)
        {
            if (i % 2 == 0)
            {
                Debug.Log("Número par: " + i);
            }
        }
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
