using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int H, M, S;
    // Start is called before the first frame update
    void Start() //preguntar al profe
    {
        if (M < 60 && S < 60)
        {
            Debug.Log(H + ":" + M + ":" +  S);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
