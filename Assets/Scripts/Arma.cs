using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] int danhoMinimo;
    [SerializeField] int danhoMaximo;
    [SerializeField] int capacidadTotal;
    [SerializeField] bool automatica;
    int municionActual;
    // Start is called before the first frame update
    void Start() //PREGUNTARR
    {
        capacidadTotal = municionActual;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void UtilizarArma()
    {
        if (municionActual > 0)
        {
            municionActual--;
        }
        else if (municionActual == 0) 
        {
            Debug.Log("0");
        }
        
    }
    void RecargarArma()
    { 
       if (municionActual != capacidadTotal) 
       {
            municionActual = capacidadTotal;
            Debug.Log("0");
       }
       else
       {
            Debug.Log("-1");
       }
    }
}
