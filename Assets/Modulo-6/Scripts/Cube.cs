using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Esta variable es la que vamos a estar cambiando entre verdadero y falso
    private bool valorBooleano = false;

    // Necesitamos el componente Renderer para cambiar el color del objeto
    private Renderer rendererComponent;

    void Start()
    {
        // Aquí buscamos el componente Renderer en el objeto
        rendererComponent = GetComponent<Renderer>();

        // Si no lo encontramos, mostramos un mensaje de error para que sepamos qué está pasando
        if (rendererComponent == null)
        {
            Debug.LogError("¡Ojo! No encontré el Renderer en " + gameObject.name + ". ¡Necesito uno para cambiar el color!");
        }
    }

    void FixedUpdate()
    {
        // ¡Aquí está la magia! Cambiamos el valor de la variable booleana a lo opuesto de lo que era antes
        valorBooleano = !valorBooleano;

        // Ahora, cambiamos el color del objeto según el valor de la variable
        if (rendererComponent != null)
        {
            rendererComponent.sharedMaterial.color = valorBooleano ? Color.white : Color.black;
        }
    }

    // Este método permite que otros scripts pregunten cuál es el valor actual de la variable booleana
    public bool GetValorBooleano()
    {
        return valorBooleano;
    }
}















