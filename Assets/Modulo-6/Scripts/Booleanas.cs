using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booleanas : MonoBehaviour
{

    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;
        variable3 = false;
        if ((variable1 || variable2) && variable3)
        
        {
            Debug.Log("la operacion 1 es verdadera");


        }
        if ((variable1 || variable2) || variable3)
        {
            if (variable1)
            {
                Debug.Log("la variable 1 es verdadera");


            }
            Debug.Log("la operacion 2 es verdadera");
        }
        if ((variable3 && variable2) || variable1) {

            Debug.Log("la opcion 3 es la verdadera");


        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
