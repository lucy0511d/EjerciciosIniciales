using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeV2 : MonoBehaviour
{
    string nombre;
    int vida;
    int experiencia;
    bool miTurno = false;
    [SerializeField] PersonajeV2 enemigo;
    [SerializeField] SistemaDeVida miSistemaDeVidas;
    [SerializeField] Arma miArma;
    [SerializeField] KeyCode teclaCura;
    [SerializeField] KeyCode teclaAtacar;
    [SerializeField] KeyCode teclaRecargar;

    #region Getters and Setters
    public string Nombre { get => nombre; set => nombre = value; }
    public int Vida { get => vida; set => vida = value; }
    public bool MiTurno { get => miTurno; set => miTurno = value; }

    #endregion

    // Start is called before the first frame update
    void Start()
    {
      float nivel = CalcularNivel();
        if (Input.GetKeyDown(teclaCura))
        {
           //RecibirCura();
        }
        if (Input.GetKeyDown(teclaAtacar))
        {
          //UtilizarArma();
        }
        if (Input.GetKeyDown(teclaRecargar))
        {
           //RecargarArma();
        }

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
