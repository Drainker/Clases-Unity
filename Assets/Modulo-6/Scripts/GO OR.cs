using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuartoGO : MonoBehaviour
{
    // Aquí conectamos los otros dos GameObjects para poder acceder a sus scripts
    [SerializeField] private GameObject Cube;
    [SerializeField] private GameObject Capsule;

    // Esta variable es la que usaremos para el resultado del "OR"
    private bool valorBooleano = false;

    // Necesitamos el componente Renderer para cambiar el color del objeto
    private Renderer rendererComponent;

    // Aquí guardamos las referencias a los scripts de los otros GameObjects
    private Cube scriptPrimero;
    private Capsule scriptSegundo;

    void Start()
    {
        // Buscamos el componente Renderer en este objeto
        rendererComponent = GetComponent<Renderer>();

        // Si no lo encontramos, mostramos un mensaje de error
        if (rendererComponent == null)
        {
            Debug.LogError("¡Ojo! No encontré el Renderer en " + gameObject.name + ". ¡Necesito uno para cambiar el color!");
        }

        // Obtenemos las referencias a los scripts de los otros GameObjects
        if (Cube != null)
        {
            scriptPrimero = Cube.GetComponent<Cube>();
        }

        if (Capsule != null)
        {
            scriptSegundo = Capsule.GetComponent<Capsule>();
        }
    }

    void FixedUpdate()
    {
        // Obtenemos los valores booleanos de los otros dos GameObjects
        bool cubePrimero = false;
        bool capsuleSegundo = false;

        if (scriptPrimero != null)
        {
            cubePrimero = scriptPrimero.GetValorBooleano();
        }

        if (scriptSegundo != null)
        {
            capsuleSegundo = scriptSegundo.GetValorBooleano();
        }

        // ¡Aquí aplicamos la operación "OR"! La variable será verdadera si AL MENOS UNA es verdadera
        valorBooleano = cubePrimero || capsuleSegundo;

        // Cambiamos el color del objeto según el resultado del "OR"
        if (rendererComponent != null)
        {
            rendererComponent.sharedMaterial.color = valorBooleano ? Color.white : Color.black;
        }

        // Imprimimos los valores en la consola para ver qué está pasando (opcional)
        Debug.Log($"Primer GO: {cubePrimero}, Segundo GO: {capsuleSegundo}, Cuarto GO (OR): {valorBooleano}");
    }

    // Este método permite que otros scripts pregunten cuál es el valor actual de la variable booleana
    public bool GetValorBooleano()
    {
        return valorBooleano;
    }
}
