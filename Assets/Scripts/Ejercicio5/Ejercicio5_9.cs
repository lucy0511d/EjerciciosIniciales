using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    int tipo, danio, vida;
    // Start is called before the first frame update
    void Start()
    {
        if (tipo == 1)
        {
            danio = 350; vida = 650;
            Debug.Log("Daño:" + danio + " Vida:" + vida);
        }
        else if (tipo == 2)
        {
            danio = 300; vida = 550;
            Debug.Log("Daño:" + danio + " Vida:" + vida);
        }
        else if (tipo == 3)
        {
            danio = 300; vida = 500;
            Debug.Log("Daño:" + danio + " Vida:" + vida);
        }
        else if (tipo == 4)
        {
            danio = 310; vida = 460;
            Debug.Log("Daño:" + danio + " Vida:" + vida);
        }
        else if (tipo == 5)
        {
            danio = 280; vida = 490;
            Debug.Log("Daño:" + danio + " Vida:" + vida);
        }
        else
        {
            danio = 360; vida = 520;
            Debug.Log("Daño:" + danio + " Vida:" + vida);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
