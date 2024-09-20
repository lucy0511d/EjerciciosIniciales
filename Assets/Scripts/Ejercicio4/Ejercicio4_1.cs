using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float areaCirculo = Circulo(4, 3.1416f);
        float areaTriangulo = Triangulo(5, 6);
        float areaCuadrado = Cuadrado(4);
        Debug.Log("area circulo= " + areaCirculo + " area triangulo= " + areaTriangulo + "area cuadrado= " + areaCuadrado);
    }

    // Update is called once per frame
    void Update()
    {

    }
    float Circulo(float radio, float PI) 
    { 
      float resultadoCirculo = (radio / 2) * PI;
        return resultadoCirculo;
    }
    float Triangulo(float baset, float altura)
    {
        float resultadoTriangulo = (baset * altura) / 2;
        return resultadoTriangulo;
    }
    float Cuadrado (float lado)
    {
        float resultadoCuadrado = (lado * lado);
        return resultadoCuadrado;
    }

}
