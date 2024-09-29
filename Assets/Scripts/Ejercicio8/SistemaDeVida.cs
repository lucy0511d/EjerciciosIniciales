using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeVida : MonoBehaviour
{
    [SerializeField] float vidaInicial;
    float vidaActual;
    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaInicial;
        float curitas = RecibirCura(3);
        float danhito = RecibirDanho(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float RecibirCura(float cantidad)
    { 
        if (cantidad > 0)
        {
            vidaActual = vidaInicial + cantidad;
            Debug.Log("La vida actual es:" + vidaActual);
        }
        else 
        {
            Debug.Log("-1");
        }
        return cantidad; 
    }
    public float RecibirDanho(float danho)
    {
        vidaActual += danho;
        if (vidaActual > 0)
        {
            Debug.Log("La vida actual es:" + vidaActual);
        }
        else if (vidaActual == 0)
        {
            Debug.Log("0");
        }
        if (danho < 0)
        {
            Debug.Log("-1");
        }
        return danho; 
    }
}
