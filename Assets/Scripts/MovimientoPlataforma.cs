using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlataforma : MonoBehaviour


{
    public Vector3 puntoA; // Punto inicial
    public Vector3 puntoB; // Punto final
    public float velocidad = 2.0f;

    private bool moviendoHaciaB = true;

    // Variable para el jugador
    private Transform jugador;

    private void Start()
    {
        // Encuentra el objeto del jugador por etiqueta (aseg�rate de que el jugador tenga la etiqueta adecuada)
        jugador = GameObject.FindGameObjectWithTag("Player").transform;

        StartCoroutine(MoverObjeto());
    }

    private IEnumerator MoverObjeto()
    {
        while (true)
        {
            float tiempoInicio = Time.time;
            float distanciaRecorrida = 0.0f;

            while (distanciaRecorrida < 1.0f)
            {
                float tiempoPasado = Time.time - tiempoInicio;
                distanciaRecorrida = tiempoPasado * velocidad;

                // Calcula la posici�n actual interpolando entre los puntos A y B
                Vector3 posicionActual = Vector3.Lerp(puntoA, puntoB, distanciaRecorrida);

                // Establece la posici�n del objeto
                transform.position = posicionActual;

                yield return null;
            }

            // Cambia la direcci�n del movimiento
            moviendoHaciaB = !moviendoHaciaB;

            // Intercambia los puntos A y B para invertir la direcci�n
            Vector3 temp = puntoA;
            puntoA = puntoB;
            puntoB = temp;
        }
    }

    // Detecta la colisi�n con el jugador
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Establece la plataforma como el padre del jugador
            jugador.parent = transform;
        }
    }

    // Detecta cuando el jugador sale de la colisi�n
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Restablece el padre del jugador para que ya no est� unido a la plataforma
            jugador.parent = null;
        }
    }
}


