using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlColeccionable : MonoBehaviour
{
    public int maximoColeccionables = 3; // El máximo de coleccionables que el jugador puede recoger.
    private int coleccionablesRecogidos = 0; // Cantidad de coleccionables recogidos.
    public Text textoColeccionables; // Texto en el Canvas que muestra la cantidad de coleccionables.

    void Start()
    {
        // Asegúrate de que el Canvas esté configurado correctamente en el Inspector.
        if (textoColeccionables == null)
        {
            Debug.LogError("Asigna un objeto de tipo Text en el campo 'Texto Coleccionables' en el Inspector.");
        }

        // Actualiza el texto del Canvas al inicio.
        ActualizarTextoColeccionables();
    }

    // Se llama cuando el jugador recoge un coleccionable.
    public void RecogerColeccionable()
    {
        if (coleccionablesRecogidos < maximoColeccionables)
        {
            coleccionablesRecogidos++;

            // Actualiza el texto del Canvas
            ActualizarTextoColeccionables();

            // Realiza cualquier otra acción relacionada con la recolección de coleccionables.
        }
    }

    // Actualiza el texto del Canvas para mostrar la cantidad de coleccionables recogidos.
    public void ActualizarTextoColeccionables()
    {
        textoColeccionables.text = "Coleccionables: " + coleccionablesRecogidos + "/" + maximoColeccionables;

        // Verifica si se han recogido todos los coleccionables.
        if (coleccionablesRecogidos >= maximoColeccionables)
        {
            // Realiza acciones adicionales cuando el jugador ha recogido todos los coleccionables.
            Debug.Log("¡Has recogido todos los coleccionables!");
        }
    }
}