using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SonidoBoton : MonoBehaviour


{
    public AudioSource sonidoAlPasar;
    public AudioSource sonidoAlHacerClick;

    private void OnMouseEnter()
    {
        // Reproducir el sonido al pasar el mouse.
        sonidoAlPasar.Play();
    }

    private void OnMouseDown()
    {
        // Reproducir el sonido al hacer clic.
        sonidoAlHacerClick.Play();
    }
}


   



