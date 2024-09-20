using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int H, M, S;
    // Start is called before the first frame update
    void Start() //preguntar al profe
    {
        if (H < 24 && M < 59 && S < 59)
        {
            Debug.Log(H + ":" + M + ":" +  S);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
