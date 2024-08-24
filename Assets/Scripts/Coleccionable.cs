using SUPERCharacter;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    public ControlColeccionable jugador; // Referencia al script del jugador.
    public AudioSource sonidoRecogida; // Opcional: sonido al recoger el coleccionable.
    CambiarSnapshot snapshot;
    public GameObject portal;
    private ControlVictoria victoria;

    private void Start()
    {
        snapshot = GetComponent<CambiarSnapshot>();
        
        victoria = portal.GetComponent<ControlVictoria>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Llama a la función de recoger coleccionable en el script del jugador.
            jugador.RecogerColeccionable();
            snapshot.CambiarASnapshot2ConFade();
            victoria.ControlRecogidos();

            // Reproduce un sonido si está configurado.
            if (sonidoRecogida != null)
            {
                sonidoRecogida.Play();
            }

            Destroy(gameObject);
        }
    }
}