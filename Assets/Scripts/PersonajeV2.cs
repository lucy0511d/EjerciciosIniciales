using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeV2 : MonoBehaviour
{
    string nombre;
    int vida;
    int experiencia;
    float nivel;
    bool miTurno = false;
    [SerializeField] Personaje enemigo;
    [SerializeField] SistemaDeVida miSistemaDeVidas;
    [SerializeField] Arma miArma;
    
    #region Getters and Setters
    public string Nombre { get => nombre; set => nombre = value; }
    public int Vida { get => vida; set => vida = value; }
    public float Nivel { get => nivel; set => nivel = value; }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
      nivel = CalcularNivel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float CalcularNivel()
    {
        float resultadoNivel = experiencia / 1000;
        return resultadoNivel;
    }
}
