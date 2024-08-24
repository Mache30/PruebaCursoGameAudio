using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    public AudioClip sonidoSalto; // El sonido de salto que deseas reproducir.
    public AudioClip sonidolanding;
    public AudioClip Lava;
    public AudioSource audioSource1; // Referencia al componente AudioSource.
    public AudioSource audioSource2;   
    public AudioSource audioSource3;


    private void Start()
    {
        // Obtén la referencia al componente AudioSource en el mismo GameObject.
        audioSource1 = GetComponent<AudioSource>();
        
       
        

        // Asegúrate de que el AudioClip esté asignado al componente AudioSource.
        if (sonidoSalto != null)
        {
            // Asigna el AudioClip al componente AudioSource.
            audioSource1.clip = sonidoSalto;
        }
        else
        {
            Debug.LogError("Falta asignar el sonido de salto en el Inspector.");
        }
       
        
    }

    private void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
            {
                // Reproduce el sonido de salto.
                if (sonidoSalto != null)
                {
                    audioSource1.PlayOneShot(sonidoSalto);
                }
            }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plataforma"))
        {
            // Reproduce el sonido de salto.
            audioSource2 = GetComponent<AudioSource>();
            audioSource2.clip = sonidolanding;
            audioSource2.Play();
            //Debug.Log("plataforma");
        }
        if (collision.gameObject.CompareTag("lava"))
        {
            // Reproduce el sonido de salto.
            audioSource3 = GetComponent<AudioSource>();
            audioSource3.clip = Lava;
            audioSource3.Play();
            //Debug.Log("lava");
        }
        
    }
    
}
