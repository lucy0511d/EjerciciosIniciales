using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeV2 : MonoBehaviour
{
    string nombre;
    int vida;
    int experiencia;
    bool miTurno = false;
    [SerializeField] Personaje enemigo;
    [SerializeField] SistemaDeVida miSistemaDeVidas;
    [SerializeField] Arma miArma;
    [SerializeField] KeyCode miTecla1;
    [SerializeField] KeyCode miTecla2;

    #region Getters and Setters
    public string Nombre { get => nombre; set => nombre = value; }
    public int Vida { get => vida; set => vida = value; }
  
    #endregion

    // Start is called before the first frame update
    void Start()
    {
      float nivel = CalcularNivel();
        //if (Input.GetKeyDown(KeyCode.miTecla1))
        //{
        //   
        //}
        //if (Input.GetKeyDown(KeyCode.miTecla2))
        //{
        //
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float CalcularNivel()
    {
        float resultadoNivel = experiencia / 1000;
        return resultadoNivel;
    }
}
