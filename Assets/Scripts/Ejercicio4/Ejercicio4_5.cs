using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float areaCirculo = Circulo(4, 3);
        float areaTriangulo = Triangulo(5, 6);
        float areaCuadrado = Cuadrado(4); // cantidad
        Debug.Log("area circulo= " + areaCirculo + " area triangulo= " + areaTriangulo + "area cuadrado= " + areaCuadrado);
        float conversion = convertirCuadrado(areaCuadrado, "euro");
        Debug.Log("Conversion del area de cuadrado a una cantidad de monedas= " + conversion + "euros");
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
    float Cuadrado(float lado)
    {
        float resultadoCuadrado = (lado * lado);
        return resultadoCuadrado;
    }
    float convertirCuadrado (float areaCuadrado, string moneda)
    {
        
        float valoreuro = 0.90f, valordolar = 1.11f;
        float conversion = 0;
        if (moneda == "euro")
        {
            conversion = areaCuadrado * valordolar;
        }
        else if (moneda == "dolar")
        {
            conversion =  areaCuadrado * valoreuro;
        }

        return conversion;
    }
}
