using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] int num, num2;
    // Start is called before the first frame update
    void Start()//preguntar
    {
        if (num < num2)
        {
            for (int nume = num; nume < num2; nume++)
            {
                Debug.Log("Tu número es: " + nume);
            }

        }
        else if (num2 < num)
        {
            for (int nume = num2; nume < num; nume++)
            {
                Debug.Log("Tu número es: " + nume);
            }
        }


    } 
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
