using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    [SerializeField] int temperatura;
    // Start is called before the first frame update
    void Start() //preguntar else if else
    {
        if (temperatura <= 10)
        {
            Debug.Log("Clima frío");
        }
        else if (temperatura > 10 && temperatura <= 20)
        {
            Debug.Log("Clima nublado");
        }
        else if (temperatura > 20 && temperatura <= 30)
        {
            Debug.Log("Clima caluroso");
        }
        else if (temperatura > 30)
        {
            Debug.Log("Clima tropical");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
