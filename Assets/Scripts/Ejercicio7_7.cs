using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] int num, num2;
    // Start is called before the first frame update
    void Start()//lo he hecho de menor a mayor y de mayor a menor
    {
        if (num < num2)
        {
            for (int nume = num; nume < num2; nume++)
            {
                Debug.Log("Tu n�mero es: " + nume);
            }

        }
        else if (num2 < num)
        {
            for (int nume = num2; nume < num; nume++)
            {
                Debug.Log("Tu n�mero es: " + nume);
            }
        }


    } 
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
