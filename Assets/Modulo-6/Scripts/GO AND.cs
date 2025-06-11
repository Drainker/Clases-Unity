using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuintoGO : MonoBehaviour
{
    // Aquí conectamos el tercer y cuarto GameObject para combinar sus resultados
    [SerializeField] private GameObject tercerGO;
    [SerializeField] private GameObject cuartoGO;

    // Esta variable es la que usaremos para el resultado final
    private bool valorBooleano = false;

    // Necesitamos el componente Renderer para cambiar el color del objeto
    private Renderer rendererComponent;

    // Aquí guardamos las referencias a los scripts del tercer y cuarto GameObject
    private Sphere scriptTercero;
    private CuartoGO scriptCuarto;

    void Start()
    {
        // Buscamos el componente Renderer en este objeto
        rendererComponent = GetComponent<Renderer>();

        // Si no lo encontramos, mostramos un mensaje de error
        if (rendererComponent == null)
        {
            Debug.LogError("¡Ojo! No encontré el Renderer en " + gameObject.name + ". ¡Necesito uno para cambiar el color!");
        }

        // Obtenemos las referencias a los scripts del tercer y cuarto GameObject
        if (tercerGO != null)
        {
            scriptTercero = tercerGO.GetComponent<Sphere>();
        }

        if (cuartoGO != null)
        {
            scriptCuarto = cuartoGO.GetComponent<CuartoGO>();
        }
    }

    void FixedUpdate()
    {
        // Obtenemos los valores booleanos del tercer y cuarto GameObject
        bool valorTercero = false;
        bool valorCuarto = false;

        if (scriptTercero != null)
        {
            valorTercero = scriptTercero.GetValorBooleano();
        }

        if (scriptCuarto != null)
        {
            valorCuarto = scriptCuarto.GetValorBooleano();
        }

        // ¡Combinamos los resultados con AND! Solo será verdadero si AMBOS (AND y OR) son verdaderos
        valorBooleano = valorTercero && valorCuarto;

        // Cambiamos el color del objeto según el resultado final
        if (rendererComponent != null)
        {
            rendererComponent.material.color = valorBooleano ? Color.white : Color.black;
        }
        
        // Imprimimos los valores en la consola para ver la lógica completa
        Debug.Log($"Tercer GO (AND): {valorTercero}, Cuarto GO (OR): {valorCuarto}, Quinto GO (AND final): {valorBooleano}");
    }

    // Este método permite que otros scripts pregunten cuál es el valor actual de la variable booleana
    public bool GetValorBooleano()
    {
        return valorBooleano;
    }
}
